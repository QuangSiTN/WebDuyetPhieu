﻿using DuyetPhieu.Server.Data;
using DuyetPhieu.Server.Models;
using DuyetPhieu.Shared;
using DuyetPhieu.Shared.ChinhSuaDuLieu.In;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DuyetPhieu.Server.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class DeNghiChinhSuaDuLieuController:ControllerBase
	{
		private readonly DeleiveryDBContext _deliveryDBContext;
		private readonly IWebHostEnvironment _environment;
		public DeNghiChinhSuaDuLieuController(DeleiveryDBContext deleiveryDBContext, IWebHostEnvironment environment)
		{
			_deliveryDBContext = deleiveryDBContext;
			_environment = environment;
		}
		[HttpPost]
		public async Task<IActionResult> InsertPhieuDeNghiChinhSua(EmsDeNghiChinhSuaDuLieuInModel model)
		{
			if (model == null) return Ok(new ResultModel { Successful = false, Errors = "Du lieu truyen vao null",Token = null });
			var checkSoChungTu = _deliveryDBContext.EmsDeNghiChinhSuaDuLieus.Where(x => x.SoChungTu == model.SoChungTu && x.Status == 1).FirstOrDefault();
			if (checkSoChungTu != null) return Ok(new ResultModel { Successful = false ,Errors ="So phieu bien nhan da ton tai ",Token= null});
			//save image
			string linkimg = "";
			var wwwpath = $"{_environment.WebRootPath}";
			string pathfolder = Path.Combine($"{_environment.WebRootPath}", "ImageChungTu");
			if(!Directory.Exists(pathfolder))
			{
				Directory.CreateDirectory(pathfolder);
			}
			foreach (var file in model.UrlAnh)
			{
				var path = $"{pathfolder}\\{file.FileName}";
				linkimg = path.ToString();
				await using var fs = new FileStream(path, FileMode.Create);
				fs.Write(file.FileContent, 0, file.FileContent.Length);
			}
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
				UrlAnh = linkimg
			};
			await _deliveryDBContext.EmsDeNghiChinhSuaDuLieus.AddAsync(phieuDeNghiChinhSuaModel);
			await _deliveryDBContext.SaveChangesAsync();
			return Ok(new ResultModel { Successful = true, Errors = null, Token = null }) ;
		}
		[HttpGet]
		public IActionResult ListPhieuDeNghiChinhSua()
		{
			var list = _deliveryDBContext.EmsDeNghiChinhSuaDuLieus.Where(x => x.Status == 1).ToList();
			return Ok(list);
		}
		
		[HttpPost]
		
		public async Task<IActionResult> FileUpload(List<UploadedFile> files)
		{
			foreach (var file in files)
			{
				var path = $"{_environment.WebRootPath}\\{file.FileName}";
				await using var fs = new FileStream(path, FileMode.Create);
				fs.Write(file.FileContent, 0, file.FileContent.Length);
			}
			return Ok(new ResultModel { Successful = true });
		}
		[HttpGet]
		public IActionResult getFile()
		{
			var list = (from i in _deliveryDBContext.EmsDeNghiChinhSuaDuLieus
						where i.Status == 1
						select new UploadedFile
						{
							FileContent = System.IO.File.ReadAllBytes(i.UrlAnh),
							FileName = i.SoChungTu
						}).ToList();
			return Ok(list);
		}
	}
}
