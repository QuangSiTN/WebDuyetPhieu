using DuyetPhieu.Client.Service.IService;
using DuyetPhieu.Shared.Model;
using DuyetPhieu.Shared.Model.Details;
using System;
using System.Collections.Generic;
using System.Linq;
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

		public async Task<IEnumerable<MnNguonGocLoiBaoHanhModel>> ListNguonGocBaoHanh()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<MnNguonGocLoiBaoHanhModel>>($"api/mn/listnguongocbaohanh");
		}

		public async Task<IEnumerable<MnLoaiDichVuBhModel>> ListLoaiDichVu()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<MnLoaiDichVuBhModel>>($"api/mn/listloaidichvu");
		}
	}
}
