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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 233 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Index.razor"
      
	private TestModel testModel;
	Justify _justify = Justify.Center;
	//thong tin  search
	private ThongTinTiepNhanSearch searchModel { get; set; } = new ThongTinTiepNhanSearch();
	private DateTime? dateFrom = DateTime.Today;
	private DateTime ndFrom;
	private string strDateFrom;
	private DateTime? dateTo = DateTime.Today;
	private DateTime ndTo;
	private string strDateTo;
	//disable button
	private bool disableAdd = false;
	private bool disableUpdate = false;
	private bool disableDelete = false;
	private bool disableSave = true;
	private bool disableUndo = true;
	private bool disableFind = false;
	//disable textfield
	private bool disabletxtSbn = false;
	private string value { get; set; } = "Ch???n lo???i ch???ng t???";
	private IEnumerable<string> options { get; set; } = new HashSet<string>() { };
	private DateTime? date = DateTime.Today;
	private string strDate;
	public class TestModel
	{
		public string a { get; set; }
		public string b { get; set; }
	};
	private IEnumerable<TestModel> Elements = new List<TestModel>();
	private void UpdateStateButtonAdd()
	{
		disableAdd = true;
		disableUpdate = true;
		disableDelete = true;
		disableFind = true;
		disableSave = false;
		disableUndo = false;
		disabletxtSbn = false;
	}
	private void UpdateStateButtonUndo()
	{
		disableAdd = false;
		disableUpdate = false;
		disableDelete = false;
		disableFind = false;
		disableSave = true;
		disableUndo = true;
		disabletxtSbn = true;
	}
	//model
	//chi nhanh
	private ListInformationChiNhanh listChiNhanh { get; set; } = new ListInformationChiNhanh();
	private IEnumerable<InformationChiNhanhModel> listInfChiNhanh { get; set; }
	private InformationChiNhanhModel infChiNhanhModel { get; set; } = new InformationChiNhanhModel();
	//tram bao hanh
	private ListInformationChiNhanh listTramBaoHanh { get; set; } = new ListInformationChiNhanh();
	private IEnumerable<InformationChiNhanhModel> listInfTramBaoHanh { get; set; }
	private InformationChiNhanhModel infTramBaoHanhModel { get; set; } = new InformationChiNhanhModel();

	//loai hang bao hanh
	private IEnumerable<MnLoaiHangBhModel> listLoaiHangBH { get; set; }
	private MnLoaiHangBhModel mnLoaiHangBhModel { get; set; } = new MnLoaiHangBhModel();
	//loai chung tu
	private IEnumerable<LoaiChungTuModel> listLoaiChungTu { get; set; }
	private LoaiChungTuModel loaiChungTuModel { get; set; } = new LoaiChungTuModel();
	// nguon goc loi bao hanh
	private IEnumerable<MnNguonGocLoiModel> listNguonGocLoi { get; set; }
	private MnNguonGocLoiModel mnNguonGocLoiBaoHanhModel { get; set; } = new MnNguonGocLoiModel();
	// loai dich vu
	private IEnumerable<MnLoaiDichVuBhModel> listLoaiDichVu { get; set; }
	private MnLoaiDichVuBhModel mnLoaiDichVuBhModel { get; set; } = new MnLoaiDichVuBhModel();
	// tinh trang bao hanh
	private IEnumerable<MnTinhTrangBhModel> listTinhTrangBH { get; set; }
	private MnTinhTrangBhModel mnTinhTrangBhModel { get; set; } = new MnTinhTrangBhModel();
	protected override async Task OnInitializedAsync()
	{
		listLoaiHangBH = (await MNService.ListLoaiBaoHanh()).ToList();
		listChiNhanh = await MNService.GetAllChiNhanh();
		if (listChiNhanh.Error == 0)
		{
			listInfChiNhanh = listChiNhanh.Data.OrderBy(x => x.TenChiNhanh);
		}
		listLoaiChungTu = (await MNService.ListChungTu()).ToList();
		listTramBaoHanh = await MNService.ListTramBaoHanh();
		if (listTramBaoHanh.Error == 0)
		{
			listInfTramBaoHanh = listTramBaoHanh.Data.OrderBy(x => x.TenChiNhanh);
		}
		listNguonGocLoi = (await MNService.ListNguonGocLoi()).ToList();
		listLoaiDichVu = (await MNService.ListLoaiDichVu()).ToList();
		listTinhTrangBH = (await MNService.ListTinhTrangBaoHanh()).ToList();
	}
	private void Luu()
	{
		if (infChiNhanhModel == null)
		{
			Console.WriteLine("Model chi nhanh null ");
		}
		else
		{
			Console.WriteLine("Ban dang chon chi nhanh " + infChiNhanhModel.TenChiNhanh + " Ma kho " + infChiNhanhModel.MaChiNhanh);
		}
	}
	//convert
	Func<InformationChiNhanhModel, string> converterChiNhanh = p => p?.TenChiNhanh;
	Func<InformationChiNhanhModel, string> converterTramBaoHanh = p => p?.TenChiNhanh;
	Func<MnLoaiHangBhModel, string> converterLoaiHangBH = p => p?.TenLoaiHang;
	Func<LoaiChungTuModel, string> converterLoaiChungTu = p => p?.LoaiPhieu;
	Func<MnNguonGocLoiModel, string> converterNguonGocLoiBH = p => p?.LoaiLoi;
	Func<MnLoaiDichVuBhModel, string> converterLoaiDichVu = p => p?.TenLoaiDichVu;
	Func<MnTinhTrangBhModel, string> converterTinhTrangBH = p => p?.TinhTrang;
	//search chi  nhanh
	private async Task<IEnumerable<InformationChiNhanhModel>> SearchChiNhanh(string value)
	{
		await Task.Delay(5);
		if (string.IsNullOrEmpty(value))
			return listInfChiNhanh;
		return listInfChiNhanh.Where(x => x.TenChiNhanh.Contains(value, StringComparison.InvariantCultureIgnoreCase) || x.MaChiNhanh.Contains(value, StringComparison.InvariantCultureIgnoreCase));
	}
	private async Task<IEnumerable<InformationChiNhanhModel>> SearchTramBaoHanh(string value)
	{
		await Task.Delay(5);
		if (string.IsNullOrEmpty(value))
			return listInfTramBaoHanh;
		return listInfTramBaoHanh.Where(x => x.TenChiNhanh.Contains(value, StringComparison.InvariantCultureIgnoreCase) || x.MaChiNhanh.Contains(value, StringComparison.InvariantCultureIgnoreCase));
	}
	//xu ly button search
	private async Task SearchThongTinPhieuBienNhan()
	{
		ndFrom = Convert.ToDateTime(dateFrom);
		strDateFrom = ndFrom.ToString("MM/dd/yyyy");
		ndTo = Convert.ToDateTime(dateTo);
		strDateTo = ndTo.ToString("MM/dd/yyyy");
		Console.WriteLine("Du lieu ra : So phieu " + searchModel.SoPhieuBienNhan);
		Console.WriteLine("Tu ngay " + strDateFrom);
		Console.WriteLine("Den ngay : " + strDateTo);

	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMNService MNService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
