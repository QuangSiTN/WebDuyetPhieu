using DuyetPhieu.Server.Data;
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
	public class ChiNhanhController : ControllerBase
	{
		private readonly DeleiveryDBContext _deleiveryDBContext;
		public ChiNhanhController(DeleiveryDBContext deleiveryDBContext)
		{
			_deleiveryDBContext = deleiveryDBContext;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllChiNhanh()
		{
			var list = await (from cn in _deleiveryDBContext.ChiNhanhs
						where cn.Active == false
						select new InformationChiNhanhModel
						{
							MaChiNhanh = cn.MaChiNhanh,
							SiteIdSap = cn.SiteIdSap,
							TenChiNhanh = cn.TenChiNhanh,
							Active =Convert.ToInt32(cn.Active),
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
			return Ok(new ListInformationChiNhanh { Error = 0, Message ="Lay du lieu thanh cong ",Data = list});
		}
		
	}
}
