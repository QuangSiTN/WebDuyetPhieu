#pragma checksum "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\ViewImage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb3ed8758cf0dd263d579a05971c518efab74a6a"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewimage")]
    public partial class ViewImage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudPaper>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 4 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\ViewImage.razor"
     if (dsanh != null)
	{
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\ViewImage.razor"
         foreach (var anh in dsanh)
		{

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudPaper>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(4, "img");
                    __builder3.AddAttribute(5, "style", "width:400px;height:100px;");
                    __builder3.AddAttribute(6, "src", 
#nullable restore
#line 9 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\ViewImage.razor"
                                                             anh

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 11 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\ViewImage.razor"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\ViewImage.razor"
         
	}

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\ViewImage.razor"
       
	private string imgSrc;
	private List<string> dsanh = new List<string>();
	private IEnumerable<UploadedFile> listImg { get; set; }
	protected override async Task OnInitializedAsync()
	{
		listImg = (await denghichinhsuaService.getFile()).ToList();
		foreach(var i in listImg)
		{
			imgSrc = String.Format("data:image/gif;base64,{0}", Convert.ToBase64String(i.FileContent));
			dsanh.Add(imgSrc);
		}

	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDeNghiChinhSuaDuLieuService denghichinhsuaService { get; set; }
    }
}
#pragma warning restore 1591
