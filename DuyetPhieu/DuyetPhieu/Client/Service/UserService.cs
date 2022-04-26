using Blazored.LocalStorage;
using DuyetPhieu.Client.Service.IService;
using DuyetPhieu.Shared;
using DuyetPhieu.Shared.Model;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace DuyetPhieu.Client.Service
{
	public class UserService : IUserService
	{
		private readonly HttpClient _httpClient;
		private readonly AuthenticationStateProvider _authenticationStateProvider;
		private readonly ILocalStorageService _localStorage;
		public UserService(HttpClient httpClient, AuthenticationStateProvider authenticationStateProvider, ILocalStorageService localStorage)
		{
			_httpClient = httpClient;
			_authenticationStateProvider = authenticationStateProvider;
			_localStorage = localStorage;
		}

		

		public async Task<ResultModel> Login(LoginModel model)
		{
			var response = await _httpClient.PostAsJsonAsync($"api/user/login", model);
			var loginResult = JsonSerializer.Deserialize<ResultModel>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
			if (!response.IsSuccessStatusCode) return loginResult;
			if(loginResult.Token == null) return loginResult;
			await _localStorage.SetItemAsync("authToken", loginResult.Token);
			((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(model.UserName);
			_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", loginResult.Token);
			return loginResult;
		}

		public async Task<ResultModel> Logout(string username)
		{
			await _localStorage.RemoveItemAsync("authToken");
			((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
			_httpClient.DefaultRequestHeaders.Authorization = null;
			return new ResultModel { Successful = true,Token=null };
		}
		public async Task<ListThongTinNhanVien> ListThongTinNhanVien()
		{
			return await _httpClient.GetFromJsonAsync<ListThongTinNhanVien>($"api/user/listthongtinnhanvien");
		}

		public  async Task<string> GetDecrypt()
		{
			return await _httpClient.GetFromJsonAsync<string>($"api/user/getdecrypt");
		}
	}
}
