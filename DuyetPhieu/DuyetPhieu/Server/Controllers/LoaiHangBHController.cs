using DuyetPhieu.Server.Data;
using DuyetPhieu.Shared.Model.Details;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DuyetPhieu.Server.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class LoaiHangBHController:ControllerBase
	{
		private readonly DeleiveryDBContext _deleiveryDBContext;
		public LoaiHangBHController(DeleiveryDBContext deleiveryDBContext)
		{
			_deleiveryDBContext = deleiveryDBContext;
		}
		[HttpGet]
		public async Task<IActionResult> ListLoaiBaoHanh()
		{
			var list = await (from bh in _deleiveryDBContext.MnLoaiHangBhs
						where bh.Active == true
						select new MnLoaiHangBhModel { 
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
	}
}
