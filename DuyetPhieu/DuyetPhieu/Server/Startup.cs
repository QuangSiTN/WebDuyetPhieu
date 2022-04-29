using DuyetPhieu.Server.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DuyetPhieu.Server
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<DeleiveryDBContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));
			services.AddDatabaseDeveloperPageExceptionFilter();
			services.Configure<IdentityOptions>(option =>
			{
				option.Password.RequireUppercase = false;
				option.Password.RequireLowercase = false;
				option.Password.RequiredLength = 6;
				option.Password.RequireNonAlphanumeric = false;
				option.ClaimsIdentity.UserNameClaimType = ClaimTypes.NameIdentifier;
				// Lockout settings
				option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
				option.Lockout.MaxFailedAccessAttempts = 3;
			});
			services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

			}).AddJwtBearer(options =>
			{
				options.SaveToken = true;
				options.RequireHttpsMetadata = false;
				options.MapInboundClaims = false;
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = Configuration["JwtIssuer"],
					ValidAudience = Configuration["JwtAudience"],
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecurityKey"]))
				};
				options.Events = new JwtBearerEvents
				{
					OnMessageReceived = context =>
					{
						var accessToken = context.Request.Query["access_token"];
						if (!string.IsNullOrEmpty(accessToken))
						{
							context.Token = accessToken;
						}
						return Task.CompletedTask;
					}
				};
			});
			services.AddAuthorization(options =>
			{
				options.AddPolicy(JwtBearerDefaults.AuthenticationScheme, policy =>
				{
					policy.AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme);
					policy.RequireClaim(ClaimTypes.NameIdentifier);
					policy.RequireClaim(ClaimTypes.Name);
				});
			});
			services.Configure<IdentityOptions>(options => {
				options.ClaimsIdentity.UserNameClaimType = ClaimTypes.NameIdentifier;
				options.ClaimsIdentity.UserIdClaimType = ClaimTypes.Name;
			});
			services.AddResponseCompression(opts =>
			{
				opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
					new[] { "application/octet-stream" });
			});
			services.AddMvc().AddNewtonsoftJson();
			services.AddControllersWithViews();
			services.AddRazorPages();
			services.AddHttpContextAccessor();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseMigrationsEndPoint();
				app.UseWebAssemblyDebugging();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseBlazorFrameworkFiles();
			app.UseStaticFiles();
			app.UseCertificateForwarding();
			app.UseCookiePolicy();
			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
				endpoints.MapControllers();
				endpoints.MapFallbackToFile("index.html");
			});
		}
	}
}
