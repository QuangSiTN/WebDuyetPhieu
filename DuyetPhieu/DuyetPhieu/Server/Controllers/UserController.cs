﻿using DuyetPhieu.Server.CodeMD5;
using DuyetPhieu.Server.Data;
using DuyetPhieu.Shared;
using Microsoft.AspNetCore.Mvc;
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
		public IActionResult Login(LoginModel model)
		{
			if(model == null) return Ok(new ResultModel { Successful = false, Errors = "Khong co du lieu truyen vao ",Token = null});
			CryptMD5 cryptMD5 = new CryptMD5();
			string passencr = cryptMD5.Encrypt(model.Password, "cf", true);
			var user = _deleiveryDBContext.TblUsers.Where(x => x.TenDangNhap == model.UserName && x.Pass == passencr).FirstOrDefault();
			if (user == null) return Ok(new ResultModel { Successful = false, Errors = "Vui long kiem tra lai tai khoan",Token = null });
			var claims = new List<Claim>();
			claims.Add(new Claim(ClaimTypes.NameIdentifier, user.TenDangNhap));
			claims.Add(new Claim(ClaimTypes.Name, user.TenDangNhap));
			var identity = new ClaimsIdentity(claims);
			var claimsPrincipal = new ClaimsPrincipal(identity);
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
			return Ok(new ResultModel { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
		}
		[HttpGet]
		public IActionResult GiaiNen(string password)
		{
			CryptMD5 cryptMD5 = new CryptMD5();
			string passa = cryptMD5.Decrypt(password, "cf", true);
			return Ok(passa);
		}
	}
	
}