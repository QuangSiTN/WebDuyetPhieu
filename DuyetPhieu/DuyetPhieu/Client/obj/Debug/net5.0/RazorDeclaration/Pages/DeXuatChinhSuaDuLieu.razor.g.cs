// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DuyetPhieu.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Client.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Client.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Shared.ThongTinTiepNhan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Shared.ThongTinTiepNhan.Details;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Shared.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Shared.Model.Details;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Shared.ChinhSuaDuLieu.In;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using DuyetPhieu.Shared.ChinhSuaDuLieu.Details;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dexuatchinhsuadulieu")]
    public partial class DeXuatChinhSuaDuLieu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\DeXuatChinhSuaDuLieu.razor"
       

	//button
	//disable button
	private bool disableAdd = false;
	private bool disableUpdate = false;
	private bool disableDelete = false;
	private bool disableSave = true;
	private bool disableUndo = true;
	private bool disableFind = false;
	//xu ly button
	private void UpdateStateButtonAdd()
	{
		disableAdd = true;
		disableUpdate = true;
		disableDelete = true;
		disableFind = true;
		disableSave = false;
		disableUndo = false;

	}
	private void UpdateStateButtonUndo()
	{
		disableAdd = false;
		disableUpdate = false;
		disableDelete = false;
		disableFind = false;
		disableSave = true;
		disableUndo = true;

	}
	//loai chung tu
	private IEnumerable<LoaiChungTuModel> listLoaiChungTu { get; set; }
	private LoaiChungTuModel loaiChungTuModel { get; set; } = new LoaiChungTuModel();
	// nguon goc loi bao hanh
	private IEnumerable<MnNguonGocLoiModel> listNguonGocLoi { get; set; }
	private MnNguonGocLoiModel mnNguonGocLoiBaoHanhModel { get; set; } = new MnNguonGocLoiModel();

	// loai chung tu zet duyet
	private IEnumerable<LCTXETDUYETModel> listChungTuXD { get; set; }
	private LCTXETDUYETModel lctXETDUYETModel { get; set; } = new LCTXETDUYETModel();
	// du lieu input
	private EmsDeNghiChinhSuaDuLieuInModel inModel { get; set; } = new EmsDeNghiChinhSuaDuLieuInModel();
	// user
	private string username = "";
	private DateTime dateFrom = DateTime.Today;

	//Convert
	Func<LoaiChungTuModel, string> converterLoaiChungTu = p => p?.LoaiPhieu;
	Func<MnNguonGocLoiModel, string> converterNguonGocLoiBH = p => p?.LoaiLoi;
	Func<LCTXETDUYETModel, string> converterLoaiChungTuXD = p => p?.MoTa;
	//


	//
	protected override async Task OnInitializedAsync()
	{

		var checkAuth = await auth.GetAuthenticationStateAsync();
		if (checkAuth != null)
		{
			username = checkAuth.User.Identity.Name;
			if (username != null)
			{
				Console.WriteLine("username dang nhap : " + username);
				listLoaiChungTu = (await MNService.ListChungTu()).ToList();
				listNguonGocLoi = (await MNService.ListNguonGocLoi()).ToList();
				listChungTuXD = (await MNService.ListLCTXETDUYET()).ToList();
			}
		}
	}
	private UploadedFile uploadedFile = new UploadedFile();
	private async Task OnChange(InputFileChangeEventArgs e)
	{
		var files = e.GetMultipleFiles();
		if(files != null)
		{
			foreach (var file in files)
			{
				using (var ms = new MemoryStream())
				{
					await file.OpenReadStream().CopyToAsync(ms);
					uploadedFile.FileName = file.Name;
					uploadedFile.FileContent = ms.ToArray();
				}
			}
		}

	}
	private async Task SaveEMSChungTu()
	{

		inModel.LoaiChungTu = lctXETDUYETModel.MaXetDuyet;
		inModel.NguyeNhanLoi = mnNguonGocLoiBaoHanhModel.SoChungTu;
		inModel.HinhThucChinhSua = lctXETDUYETModel.MaXetDuyet;
		inModel.ChungTuLq = loaiChungTuModel.LoaiPhieu;
		inModel.CreatedBy = username;
		inModel.UrlAnh = uploadedFile;
		if (inModel.CreatedBy == null)
		{
			Snackbar.Add("Chua co ten username", Severity.Warning);
		}
		else if (inModel.LoaiChungTu == null)
		{
			Snackbar.Add("Chua co loai chung tu", Severity.Warning);
		}
		else if (inModel.NguyeNhanLoi == null)
		{
			Snackbar.Add("Chua co nguyen nhan gay loi", Severity.Warning);
		}
		else if (inModel.HinhThucChinhSua == null)
		{
			Snackbar.Add("Chua chon hinh thuc chinh sua ", Severity.Warning);
		}
		else if (inModel.SoChungTu == null)
		{
			Snackbar.Add("Chua co so  chung tu", Severity.Warning);
		}
		else if (inModel.ChungTuLq == null)
		{
			Snackbar.Add("Chua co chung tu lien quan", Severity.Warning);
		}
		else if (inModel.HinhThucChinhSua == null)
		{
			Snackbar.Add("Chua co hinh thuc chinh sua", Severity.Warning);
		}
		else if (inModel.NoiDung == null)
		{
			Snackbar.Add("Chua co noi dung", Severity.Warning);
		}
		else if( inModel.UrlAnh == null)
		{
			Snackbar.Add("Chua gan anh chun tu lien quan ",Severity.Warning);
		}
		else
		{
			var rs = await DeNghiService.InsertPhieuDeNghiChinhSua(inModel);
			if (rs.Successful)
			{
				Snackbar.Add("Them thanh cong", Severity.Success);
			}
			else
			{
				Snackbar.Add("Loi :" + rs.Errors, Severity.Error);
			}
		}

	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpclient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDeNghiChinhSuaDuLieuService DeNghiService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMNService MNService { get; set; }
    }
}
#pragma warning restore 1591
