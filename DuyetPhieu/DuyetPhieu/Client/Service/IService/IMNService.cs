using DuyetPhieu.Shared.Model;
using DuyetPhieu.Shared.Model.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service.IService
{
	public interface IMNService
	{
		//chi nhanh
		Task<ListInformationChiNhanh> GetAllChiNhanh();
		Task<ListInformationChiNhanh> ListTramBaoHanh();
		Task<ChiNhanhLoginModel> GetNameSiteByUserName(string username);
		//chung tu
		Task<IEnumerable<LoaiChungTuModel>> ListChungTu();
		//chung tu xet duyet
		Task<IEnumerable<LCTXETDUYETModel>> ListLCTXETDUYET();
		//Loai hang bao hanh
		Task<IEnumerable<MnLoaiHangBhModel>> ListLoaiBaoHanh();
		Task<IEnumerable<MnNguonGocLoiModel>> ListNguonGocLoi();
		Task<IEnumerable<MnLoaiDichVuBhModel>> ListLoaiDichVu();
		Task<IEnumerable<MnTinhTrangBhModel>> ListTinhTrangBaoHanh();
	}
}
