using DuyetPhieu.Client.Service.IService;
using DuyetPhieu.Shared.Model.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service
{
	public class LoaiHangBHService : ILoaiHangBHService
	{
		private readonly HttpClient _httpClient;
		public LoaiHangBHService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<IEnumerable<MnLoaiHangBhModel>> ListLoaiBaoHanh()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<MnLoaiHangBhModel>>($"api/loaihangbh/listloaibaohanh");
		}
	}
}
