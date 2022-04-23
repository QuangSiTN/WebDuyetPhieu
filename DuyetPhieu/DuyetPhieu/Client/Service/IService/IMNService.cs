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
		//chung tu
		Task<IEnumerable<LoaiChungTuModel>> ListChungTu();
		//Loai hang bao hanh
		Task<IEnumerable<MnLoaiHangBhModel>> ListLoaiBaoHanh();
		Task<IEnumerable<MnNguonGocLoiBaoHanhModel>> ListNguonGocBaoHanh();
		Task<IEnumerable<MnLoaiDichVuBhModel>> ListLoaiDichVu();
		Task<IEnumerable<MnTinhTrangBhModel>> ListTinhTrangBaoHanh();
	}
}
