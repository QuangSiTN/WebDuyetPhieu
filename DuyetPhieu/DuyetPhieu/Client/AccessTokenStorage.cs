using Blazored.LocalStorage;
using System.Threading.Tasks;

namespace DuyetPhieu.Client
{
	public class AccessTokenStorage
	{
		//
		private readonly ILocalStorageService _localStorage;
		public AccessTokenStorage(ILocalStorageService localStorage)
		{
			_localStorage = localStorage;
		}
		public async Task<string> GetTokenAsync()
		{
			var saveToken = await _localStorage.GetItemAsync<string>("authToken");
			return saveToken;
		}
	}
}
