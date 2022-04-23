using DuyetPhieu.Client.Service.IService;
using DuyetPhieu.Shared.Model;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service
{
	public class ChiNhanhService:IChiNhanhService
	{
		private readonly HttpClient _httpClient;
		public ChiNhanhService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<ListInformationChiNhanh> GetAllChiNhanh()
		{
			return await _httpClient.GetFromJsonAsync<ListInformationChiNhanh>($"api/chinhanh/getallchinhanh");
		}
	}
}
