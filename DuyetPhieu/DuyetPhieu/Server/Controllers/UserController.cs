using DuyetPhieu.Server.CodeMD5;
using DuyetPhieu.Server.Data;
using DuyetPhieu.Shared;
using DuyetPhieu.Shared.Model;
using DuyetPhieu.Shared.Model.Details;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DuyetPhieu.Server.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class UserController:ControllerBase
	{
		private readonly DeleiveryDBContext _deleiveryDBContext;
		private readonly IConfiguration _configuration;
		public UserController(DeleiveryDBContext deleiveryDBContext, IConfiguration configuration)
		{
			_deleiveryDBContext = deleiveryDBContext;
			_configuration = configuration;
		}
		[HttpPost]
		public IActionResult LoginAsync(LoginModel model)
		{
			if(model == null) return Ok(new ResultModel { Successful = false, Errors = "Khong co du lieu truyen vao ",Token = null});
			CryptMD5 cryptMD5 = new CryptMD5();
			string passencr = cryptMD5.Encrypt(model.Password, "a,b,c", true);
			var user = _deleiveryDBContext.TblUsers.Where(x => x.TenDangNhap == model.UserName && x.Pass == passencr && x.MaChiNhanh == model.MaChiNhanh).FirstOrDefault();
			if (user == null) return Ok(new ResultModel { Successful = false, Errors = "Vui long kiem tra lai tai khoan",Token = null });
			var role = _deleiveryDBContext.TblUserGroups.Where(x => x.UserId == user.TenDangNhap).ToList();
			if (role.Count == 0) return Ok(new ResultModel { Successful = false, Errors = "User khong  co quyen nao", Token = null });
			var claims = new List<Claim>();
			claims.Add(new Claim(ClaimTypes.NameIdentifier, user.TenDangNhap));
			claims.Add(new Claim(ClaimTypes.Name, user.TenDangNhap));
			foreach (var i in role)
			{
				claims.Add(new Claim(ClaimTypes.Role, i.GroupId));
			}
			var identity = new ClaimsIdentity(claims);
			var claimsPrincipal = new ClaimsPrincipal(identity);
			
			HttpContext.User = claimsPrincipal;
			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
			var expiry = DateTime.Now.AddHours(1);
			var token = new JwtSecurityToken(
				_configuration["JwtIssuer"],
				_configuration["JwtAudience"],
				claims,
				expires: expiry,
				signingCredentials: creds
			);
			return Ok(new ResultModel { Successful = true, Errors = HttpContext.User.Claims.FirstOrDefault().ToString()  ,Token = new JwtSecurityTokenHandler().WriteToken(token) }); ;
		}
		[HttpPost]
		public IActionResult LogOut(LoginModel model)
		{
			var user = _deleiveryDBContext.TblUsers.Where(x => x.TenDangNhap == model.UserName).FirstOrDefault();
			if (user == null) return Ok(new ResultModel { Successful = false, Errors = "Tai khoan khong ton tai", Token = null });
			var u = (ClaimsIdentity)User.Identity;
			var claims = u.Claims;
			var r = u.RoleClaimType;
			var userdelete = claims.Where(x => x.Type == ClaimTypes.Name).ToList();
			var list = userdelete.Where(x => x.Value == user.TenDangNhap).FirstOrDefault();
			
			return Ok();
		}
		[HttpGet]
		public async Task<IActionResult> ListThongTinNhanVien()
		{
			var list = await (from nv in _deleiveryDBContext.NhanViens
							  where nv.Active == true && nv.DepartMentId != null && nv.StatusDichVu == 0
							  select new ThongTinNhanVienModel
							  {
								  MaNhanVien = nv.MaNhanVien,
								  TenNhanVien = nv.TenNhanVien,
								  MaChiNhanh = nv.MaChiNhanh,
								  DienThoai = nv.DienThoai,
								  DepartMentId = nv.DepartMentId,
								  DepartMentName = nv.DepartMentName,
								  DiaChi = nv.DiaChi,
								  MaBaCodeId = nv.MaBaCodeId
							  }).ToListAsync();
			if (list.Count() == 0) return Ok(new ListThongTinNhanVien { Error = 0, Message = "Khong co du lieu ", Data = null });
			return Ok(new ListThongTinNhanVien { Error = 1, Message = "Lay du lieu thanh cong", Data = list });
		}
		[HttpGet]
		public IActionResult GetDecrypt()
		{
			CryptMD5 cryptMD5 = new CryptMD5();
			string passencr = cryptMD5.Decrypt("ZJlDefzTkPWX7TnFzdYmBA==", "a,b,c", true);
			return Ok(passencr);
		}
	}
	
}
