using Blazored.LocalStorage;
using DuyetPhieu.Client.Service;
using DuyetPhieu.Client.Service.IService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DuyetPhieu.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");
			builder.Services.AddBlazoredLocalStorage();
			builder.Services.AddScoped<AccessTokenStorage>();
			builder.Services.AddOptions();
			builder.Services.AddHttpContextAccessor();
			builder.Services.AddAuthorizationCore();
			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
			builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
			builder.Services.AddScoped<IUserService,UserService>();
			builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			builder.Services.AddMudServices();
			await builder.Build().RunAsync();
		}
	}
}
