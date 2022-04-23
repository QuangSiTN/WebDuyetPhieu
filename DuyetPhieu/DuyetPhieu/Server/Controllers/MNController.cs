﻿using DuyetPhieu.Server.Data;
using DuyetPhieu.Shared.Model;
using DuyetPhieu.Shared.Model.Details;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuyetPhieu.Server.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class MNController : ControllerBase
	{
		private readonly DeleiveryDBContext _deleiveryDBContext;
		public MNController(DeleiveryDBContext deleiveryDBContext)
		{
			_deleiveryDBContext = deleiveryDBContext;
		}
		///lay loai chung tu
		[HttpGet]
		public async Task<IActionResult> ListChungTu()
		{
			var list = await (from ct in _deleiveryDBContext.EmsLctxetduyets
							  where ct.Levels == 3
							  select new LoaiChungTuModel
							  {
								  MaXetDuyet = ct.MaXetDuyet,
								  LoaiChungTu = ct.LoaiChungTu,
								  Levels = Convert.ToInt32(ct.Levels),
								  MoTa = ct.MoTa,
								  NgayTao = Convert.ToString(ct.NgayTao),
								  NguoiTao = ct.NguoiTao
							  }).ToListAsync();
			return Ok(list);
		}
		//Chi Nhanh
		[HttpGet]
		public async Task<IActionResult> GetAllChiNhanh()
		{
			var list = await (from cn in _deleiveryDBContext.ChiNhanhs
							  where cn.Active == true && cn.AddressSite != null && cn.Sto == "STO"
							  select new InformationChiNhanhModel
							  {
								  MaChiNhanh = cn.MaChiNhanh,
								  SiteIdSap = cn.SiteIdSap,
								  TenChiNhanh = cn.TenChiNhanh,
								  Active = Convert.ToInt32(cn.Active),
								  MaTinhThanh = cn.MaTinhThanh,
								  MaQuanHuyen = cn.MaQuanHuyen,
								  WardId = cn.WardId,
								  ConvertSo = Convert.ToInt32(cn.ConvertSo),
								  MobiphoneSmstai = cn.MobiphoneSmstai,
								  MobiphoneSmshonDa = cn.MobiphoneSmshonDa,
								  SitePhone = cn.SitePhone,
								  AddressSite = cn.AddressSite
							  }).ToListAsync();
			if (list.Count() == 0) return Ok(new ListInformationChiNhanh { Error = 1, Message = "Khong co du lieu", Data = null });
			return Ok(new ListInformationChiNhanh { Error = 0, Message = "Lay du lieu thanh cong ", Data = list });
		}
		[HttpGet]
		public async Task<IActionResult> ListTramBaoHanh()
		{
			var list = await (from cn in _deleiveryDBContext.ChiNhanhs
							  where cn.Active == true && cn.AddressSite != null && cn.ActiveNhanBaoHanh == false && cn.Sto == "STO"
							  select new InformationChiNhanhModel
							  {
								  MaChiNhanh = cn.MaChiNhanh,
								  SiteIdSap = cn.SiteIdSap,
								  TenChiNhanh = cn.TenChiNhanh,
								  Active = Convert.ToInt32(cn.Active),
								  MaTinhThanh = cn.MaTinhThanh,
								  MaQuanHuyen = cn.MaQuanHuyen,
								  WardId = cn.WardId,
								  ConvertSo = Convert.ToInt32(cn.ConvertSo),
								  MobiphoneSmstai = cn.MobiphoneSmstai,
								  MobiphoneSmshonDa = cn.MobiphoneSmshonDa,
								  SitePhone = cn.SitePhone,
								  AddressSite = cn.AddressSite
							  }).ToListAsync();
			if (list.Count() == 0) return Ok(new ListInformationChiNhanh { Error = 1, Message = "Khong co du lieu", Data = null });
			return Ok(new ListInformationChiNhanh { Error = 0, Message = "Lay du lieu thanh cong ", Data = list });
		}
		//Bao Hanh 
		[HttpGet]
		public async Task<IActionResult> ListLoaiBaoHanh()
		{
			var list = await (from bh in _deleiveryDBContext.MnLoaiHangBhs
							  where bh.Active == true
							  select new MnLoaiHangBhModel
							  {
								  LoaiHangId = bh.LoaiHangId,
								  TenLoaiHang = bh.TenLoaiHang,
								  Active = Convert.ToInt32(bh.Active),
								  GhiChu = bh.GhiChu,
								  KeyUpSerial = bh.KeyUpSerial,
								  Mch = bh.Mch,
								  Samsung = bh.Samsung
							  }).ToListAsync();
			return Ok(list);
		}
		//MN_NguonGocLoiBaoHanh
		[HttpGet]
		public async Task<IActionResult> ListNguonGocBaoHanh()
		{
			var list = await (from bh in _deleiveryDBContext.MnNguonGocLoiBaoHanhs
							  where bh.Active == true
							  select new MnNguonGocLoiBaoHanhModel
							  {
								  NguonGocLoiId = bh.NguonGocLoiId,
								  DienGiai = bh.DienGiai,
								  Active = Convert.ToInt32(bh.Active)
							  }).ToListAsync();
			return Ok(list);
		}
		//[MN_LoaiDichVuBH]
		[HttpGet]
		public async Task<IActionResult> ListLoaiDichVu()
		{
			var list = await (from ldv in _deleiveryDBContext.MnLoaiDichVuBhs
							  where ldv.Active == true
							  select new MnLoaiDichVuBhModel
							  {
								  MaLoaiDichVu = ldv.MaLoaiDichVu,
								  TenLoaiDichVu = ldv.TenLoaiDichVu,
								  Active = Convert.ToInt32(ldv.Active),
								  GhiChu = ldv.GhiChu
							  }).ToListAsync();
			return Ok(list);
		}
		//MnTinhTrangBhModel
		[HttpGet]
		public async Task<IActionResult> ListTinhTrangBaoHanh()
		{
			var list = await (from bh in _deleiveryDBContext.MnTinhTrangBhs
							  where bh.Active == true
							  select new MnTinhTrangBhModel
							  {
								  TinhTrangId = bh.TinhTrangId,
								  TinhTrang = bh.TinhTrang,
								  Active = Convert.ToInt32(bh.Active)
							  }).ToListAsync();
			return Ok(list);
		}
	}
}
