#pragma checksum "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8df2d0e623c87588f6f9af349b28df46a6ddf0d6"
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
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

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
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
 if (loading == true)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudProgressLinear>(0);
            __builder.AddAttribute(1, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                              Color.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 9 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                     Size.Small

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Indeterminate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 10 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "max-width: 800px;position:sticky;padding-left:35%;margin-top:50px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                          loginModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                     OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\t\t\t");
                __builder2.OpenComponent<MudBlazor.MudCard>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCardHeader>(14);
                    __builder3.AddAttribute(15, "Style", " background-color: #EEEEEE;");
                    __builder3.AddAttribute(16, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(17);
                        __builder4.AddAttribute(18, "Style", "text-align: center; background-color: #EEEEEE; font-family: \'Times New Roman\', Times, serif;");
                        __builder4.AddAttribute(19, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 19 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                                                                            Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(21, " Đăng nhập ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(22, "\r\n\t\t\t\t");
                    __builder3.OpenComponent<MudBlazor.MudCardContent>(23);
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudForm>(25);
                        __builder4.AddAttribute(26, "IsValid", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                             success

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "IsValidChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => success = __value, success))));
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudTextField<string>>(29);
                            __builder5.AddAttribute(30, "Label", "Username");
                            __builder5.AddAttribute(31, "Immediate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(32, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                                 GETSITE

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(33, "Required", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                                                    true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(34, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 24 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(35, "For", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 25 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                 () => loginModel.UserName

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(36, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 25 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                     loginModel.UserName

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(37, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.UserName = __value, loginModel.UserName))));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(38, "\r\n\t\t\t\t\t\t");
                            __builder5.OpenComponent<MudBlazor.MudTextField<string>>(39);
                            __builder5.AddAttribute(40, "Label", "Password");
                            __builder5.AddAttribute(41, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 26 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                           Variant.Outlined

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(42, "For", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 27 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                 () => loginModel.Password

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(43, "InputType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.InputType>(
#nullable restore
#line 28 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                   InputType.Password

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(44, "Required", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                  true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(45, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 27 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                     loginModel.Password

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(46, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Password = __value, loginModel.Password))));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(47, "\r\n\t\t\t\t\t\t");
                            __builder5.OpenComponent<MudBlazor.MudSelect<ChiNhanhLoginModel>>(48);
                            __builder5.AddAttribute(49, "Style", "margin-top:10px;");
                            __builder5.AddAttribute(50, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 30 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                                                              Variant.Outlined

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(51, "Label", " Chi nhánh ");
                            __builder5.AddAttribute(52, "ToStringFunc", (System.Func<ChiNhanhLoginModel, System.String>)(
#nullable restore
#line 30 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                                                                                                                   converterTenChiNhanh

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(53, "AnchorOrigin", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Origin>(
#nullable restore
#line 30 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                                                                                                                                                       Origin.BottomCenter

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(54, "Margin", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Margin>(
#nullable restore
#line 30 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                                                                                                                                                                                    Margin.Dense

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(55, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChiNhanhLoginModel>(
#nullable restore
#line 30 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                                 chiNhanhLoginModel

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(56, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ChiNhanhLoginModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ChiNhanhLoginModel>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => chiNhanhLoginModel = __value, chiNhanhLoginModel))));
                            __builder5.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
#nullable restore
#line 31 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                             if (chiNhanhLoginModel != null)
							{

#line default
#line hidden
#nullable disable
                                __Blazor.DuyetPhieu.Client.Pages.Login.TypeInference.CreateMudSelectItem_0(__builder6, 58, 59, 
#nullable restore
#line 33 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                       chiNhanhLoginModel

#line default
#line hidden
#nullable disable
                                , 60, (__builder7) => {
#nullable restore
#line 33 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
__builder7.AddContent(61, chiNhanhLoginModel.TenChiNhanh);

#line default
#line hidden
#nullable disable
                                }
                                );
#nullable restore
#line 34 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
							}

#line default
#line hidden
#nullable disable
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n\t\t\t\t");
                    __builder3.OpenComponent<MudBlazor.MudCardActions>(63);
                    __builder3.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudButton>(65);
                        __builder4.AddAttribute(66, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 40 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                           ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(67, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 40 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                       Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(68, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 40 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                              Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(69, "Disabled", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
                                                                                                                         !success

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(70, "Class", "ml-auto");
                        __builder4.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(72, "Login");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\lequa\OneDrive\Documents\GitHub\WebDuyetPhieu\DuyetPhieu\DuyetPhieu\Client\Pages\Login.razor"
       
	bool loading = false;
	bool success;
	private LoginModel loginModel { get; set; } = new LoginModel();
	private ListChiNhanhLogin listChiNhanhLogin { get; set; } = new ListChiNhanhLogin();
	private List<ChiNhanhLoginModel> listchiNhanhLoginModel { get; set; } = new List<ChiNhanhLoginModel>();
	private ChiNhanhLoginModel chiNhanhLoginModel { get; set; }
	private async Task OnValidSubmit()
	{
		loginModel.MaChiNhanh = chiNhanhLoginModel.MaChiNhanh;
		if (loginModel.UserName == null)
		{
			snackBar.Add(" vui lòng nhập Username để đăng nhập ", Severity.Warning);
		}
		else if (loginModel == null)
		{
			snackBar.Add(" vui lòng nhập Login để đăng nhập ", Severity.Warning);
		}
		else {
			
			loading = true;
			var result = await UserService.Login(loginModel);
			loading = false;
			if (result.Successful)
			{
				snackBar.Add("Đăng nhập thành công ", Severity.Success);
				NavigationManager.NavigateTo("/", true);
			}
			else
			{
				snackBar.Add(result.Errors.ToString(), Severity.Error);
				NavigationManager.NavigateTo("/login");
			}
		}
	}
	Func<ChiNhanhLoginModel, string> converterTenChiNhanh = p => p?.TenChiNhanh;
	private async Task GETSITE(KeyboardEventArgs e)
	{

		if (e.Key == "Enter")
		{
			if(loginModel.UserName == null)
			{
				Console.WriteLine("Ten dang nhap khong co ");
			}
			else if (loginModel.UserName != null)
			{
				Console.WriteLine("Ten dang nhap " + loginModel.UserName);
				chiNhanhLoginModel =await MNService.GetNameSiteByUserName(loginModel.UserName);
			}
			else
			{
				Console.WriteLine("Ten dang nhap khong co ");
			}

		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMNService MNService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
namespace __Blazor.DuyetPhieu.Client.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudSelectItem_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
