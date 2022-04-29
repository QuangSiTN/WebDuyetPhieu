using DuyetPhieu.Server.Data;
using DuyetPhieu.Server.Models;
using DuyetPhieu.Shared;
using DuyetPhieu.Shared.ChinhSuaDuLieu.In;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DuyetPhieu.Server.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class DeNghiChinhSuaDuLieuController:ControllerBase
	{
		private readonly DeleiveryDBContext _deleiveryDBContext;
		private readonly IWebHostEnvironment _environment;
		public DeNghiChinhSuaDuLieuController(DeleiveryDBContext deleiveryDBContext, IWebHostEnvironment environment)
		{
			_deleiveryDBContext = deleiveryDBContext;
			_environment = environment;
		}
		[HttpPost]
		public async Task<IActionResult> InsertPhieuDeNghiChinhSua(EmsDeNghiChinhSuaDuLieuInModel model)
		{
			if (model == null) return Ok(new ResultModel { Successful = false, Errors = "Du lieu truyen vao null",Token = null });
			var checkSoChungTu =  _deleiveryDBContext.EmsDeNghiChinhSuaDuLieus.Where(x => x.SoChungTu == model.SoChungTu && x.Status == 1).FirstOrDefault();
			if (checkSoChungTu != null) return Ok(new ResultModel { Successful = false ,Errors ="So phieu bien nhan da ton tai ",Token= null});
			var phieuDeNghiChinhSuaModel = new EmsDeNghiChinhSuaDuLieu
			{
				ChungTuLq = model.ChungTuLq,
				HinhThucChinhSua = model.HinhThucChinhSua,
				CreatedBy = model.CreatedBy,
				CreationDate = DateTime.Now,
				LoaiChungTu = model.LoaiChungTu,
				NguyeNhanLoi = model.NguyeNhanLoi,
				NoiDung = model.NoiDung,
				SoChungTu = model.SoChungTu,
				Status = 1,
				UrlAnh = "Linktest"
			};
			await _deleiveryDBContext.EmsDeNghiChinhSuaDuLieus.AddAsync(phieuDeNghiChinhSuaModel);
			await _deleiveryDBContext.SaveChangesAsync();
			return Ok(new ResultModel { Successful = true, Errors = null, Token = null }) ;
		}
		[HttpGet]
		public IActionResult ListPhieuDeNghiChinhSua()
		{
			var list = _deleiveryDBContext.EmsDeNghiChinhSuaDuLieus.Where(x => x.Status == 1).ToList();
			return Ok(list);
		}
		/*[HttpPost]
		[Route("FileUploadAsync")]
		public async Task<IActionResult> FileUploadAsync(UploadedFile uploadedFile)
		{
			try
			{
				await System.IO.File.WriteAllBytesAsync(_environment.ContentRootPath + "\\" + uploadedFile.FileName, uploadedFile.FileContent);
				return Ok(new ResultModel { Successful = true });
			}
			catch(Exception ex)
			{
				return Ok(new ResultModel { Successful = false,Errors =ex.ToString(),Token = null });
			}
			
		}*/
		[HttpPost]
		[Route("FileUploadAsync")]
		public async Task<IActionResult> FileUploadAsync(UploadedFile[] files)
		{
			/*try
			{
				await System.IO.File.WriteAllBytesAsync(_environment.ContentRootPath + "\\" + uploadedFile.FileName, uploadedFile.FileContent);
				return Ok(new ResultModel { Successful = true });
			}
			catch(Exception ex)
			{
				return Ok(new ResultModel { Successful = false,Errors =ex.ToString(),Token = null });
			}*/
			try
			{
				foreach (var file in files)
				{
					var buf = Convert.FromBase64String(file.base64data);
					await System.IO.File.WriteAllBytesAsync(_environment.ContentRootPath + "\\" + Guid.NewGuid().ToString("N") + "-" + file.fileName, buf);
				}
				return Ok(new ResultModel { Successful = true });
			}
			catch(Exception ex)
			{
				return Ok(new ResultModel { Successful = false,Errors = ex.Message.ToString(),Token = null });
			}
			

		}

		[HttpPost]
		public async Task Post()
		{
			if (HttpContext.Request.Form.Files.Any())
			{
				foreach (var file in HttpContext.Request.Form.Files)
				{
					var path = Path.Combine(_environment.ContentRootPath, "images", file.FileName);
					using (var stream = new FileStream(path, FileMode.Create))
					{
						await file.CopyToAsync(stream);
					}
				}
			}
		}
	}
}
