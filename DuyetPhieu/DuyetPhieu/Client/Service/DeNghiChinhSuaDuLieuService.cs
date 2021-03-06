using DuyetPhieu.Client.Service.IService;
using DuyetPhieu.Shared;
using DuyetPhieu.Shared.ChinhSuaDuLieu.Details;
using DuyetPhieu.Shared.ChinhSuaDuLieu.In;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service
{
	public class DeNghiChinhSuaDuLieuService: IDeNghiChinhSuaDuLieuService
	{
		public HttpClient _httpClient;
		public DeNghiChinhSuaDuLieuService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<ResultModel> InsertPhieuDeNghiChinhSua(EmsDeNghiChinhSuaDuLieuInModel model)
		{
			var res = await _httpClient.PostAsJsonAsync($"api/denghichinhsuadulieu/insertphieudenghichinhsua", model);
			return await res.Content.ReadFromJsonAsync<ResultModel>();
		}

		public async Task<IEnumerable<EmsDeNghiChinhSuaDuLieuModel>> ListPhieuDeNghiChinhSua()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<EmsDeNghiChinhSuaDuLieuModel>>($"api/denghichinhsuadulieu/listphieudenghichinhsua");
		}

		public async Task<IEnumerable<UploadedFile>> getFile()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<UploadedFile>>($"/api/denghichinhsuadulieu/getfile");
		}
	}
}
