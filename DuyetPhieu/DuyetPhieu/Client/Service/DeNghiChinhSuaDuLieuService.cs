using BlazorInputFile;
using DuyetPhieu.Client.Service.IService;
using DuyetPhieu.Shared;
using DuyetPhieu.Shared.ChinhSuaDuLieu.Details;
using DuyetPhieu.Shared.ChinhSuaDuLieu.In;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
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
		public async Task<ResultModel> FileUpload(List<UploadedFile> filesBase64)
		{
			var res = await _httpClient.PostAsJsonAsync($"/api/denghichinhsuadulieu/fileupload", filesBase64);
			return await res.Content.ReadFromJsonAsync<ResultModel>();

		}
	}
}
