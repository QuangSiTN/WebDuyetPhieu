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
    [Microsoft.AspNetCore.Components.RouteAttribute("/denghicapquyen")]
    public partial class DeNghiCapQuyen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\DeNghiCapQuyen.razor"
       
	// loai chung tu zet duyet
	private IEnumerable<LCTXETDUYETModel> listChungTuXD { get; set; }
	private LCTXETDUYETModel lctXETDUYETModel { get; set; } = new LCTXETDUYETModel();
	//chi nhanh
	private IEnumerable<InformationChiNhanhModel> listChiNhanh { get; set; }
	private InformationChiNhanhModel chiNhanhModel { get; set; } = new InformationChiNhanhModel();
	private ListInformationChiNhanh listInforChiNhanh { get; set; } = new ListInformationChiNhanh();
	//Convert
	Func<LoaiChungTuModel, string> converterLoaiChungTu = p => p?.LoaiPhieu;
	Func<LCTXETDUYETModel, string> converterLoaiChungTuXD = p => p?.MoTa;
	Func<InformationChiNhanhModel, string> convertChiNhanh = p => p?.TenChiNhanh;
	protected override async Task OnInitializedAsync()
	{
		listChungTuXD = (await MNService.ListLCTXETDUYET()).ToList();
		listInforChiNhanh = await MNService.GetAllChiNhanh();
		listChiNhanh = listInforChiNhanh.Data.OrderBy(x => x.TenChiNhanh);
	}
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
	//search chi  nhanh
	private async Task<IEnumerable<InformationChiNhanhModel>> SearchChiNhanh(string value)
	{
		await Task.Delay(5);
		if (string.IsNullOrEmpty(value))
			return listChiNhanh;
		return listChiNhanh.Where(x => x.TenChiNhanh.Contains(value, StringComparison.InvariantCultureIgnoreCase) || x.MaChiNhanh.Contains(value, StringComparison.InvariantCultureIgnoreCase));
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMNService MNService { get; set; }
    }
}
#pragma warning restore 1591
