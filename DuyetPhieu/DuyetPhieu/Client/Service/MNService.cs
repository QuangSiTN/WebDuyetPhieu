using DuyetPhieu.Client.Service.IService;
using DuyetPhieu.Shared.Model;
using DuyetPhieu.Shared.Model.Details;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service
{
	public class MNService : IMNService
	{
		private readonly HttpClient _httpClient;
		public MNService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<ListInformationChiNhanh> GetAllChiNhanh()
		{
			return await _httpClient.GetFromJsonAsync<ListInformationChiNhanh>($"api/mn/getallchinhanh");
		}

		public async Task<ListInformationChiNhanh> ListTramBaoHanh()
		{
			return await _httpClient.GetFromJsonAsync<ListInformationChiNhanh>($"api/mn/listtrambaohanh");
		}
		public async Task<IEnumerable<LoaiChungTuModel>> ListChungTu()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<LoaiChungTuModel>>($"api/mn/listchungtu");
		}
		public async Task<IEnumerable<MnLoaiHangBhModel>> ListLoaiBaoHanh()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<MnLoaiHangBhModel>>($"api/mn/listloaibaohanh");
		}

		public async Task<IEnumerable<MnNguonGocLoiModel>> ListNguonGocLoi()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<MnNguonGocLoiModel>>($"api/mn/listnguongocloi");
		}

		public async Task<IEnumerable<MnLoaiDichVuBhModel>> ListLoaiDichVu()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<MnLoaiDichVuBhModel>>($"api/mn/listloaidichvu");
		}

		public async Task<IEnumerable<MnTinhTrangBhModel>> ListTinhTrangBaoHanh()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<MnTinhTrangBhModel>>($"api/mn/listtinhtrangbaohanh");
		}

		public async Task<ChiNhanhLoginModel> GetNameSiteByUserName(string username)
		{
			return await _httpClient.GetFromJsonAsync<ChiNhanhLoginModel>($"api/mn/getnamesitebyusername?username="+username);
		}

		public async Task<IEnumerable<LCTXETDUYETModel>> ListLCTXETDUYET()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<LCTXETDUYETModel>>($"api/mn/listlctxetduyet");
		}
	}
}
