#pragma checksum "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\Shared\ProductItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25033b6feb2d1eb47942626a11e6511cc8ad95d1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using SharedLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class ProductItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "href", 
#nullable restore
#line 4 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\Shared\ProductItem.razor"
                Href

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", "list-group-item-action");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row row-cols-1 row-cols-md-2 g-4");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card");
                __builder2.AddMarkupContent(10, "<img src=\"/hatt.jpg\" class=\"card-img-top\" alt=\"...\">\r\n                ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.OpenElement(13, "h5");
                __builder2.AddAttribute(14, "class", "card-title");
                __builder2.AddContent(15, 
#nullable restore
#line 10 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\Shared\ProductItem.razor"
                                            Item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n\r\n                    ");
                __builder2.OpenElement(17, "p");
                __builder2.AddAttribute(18, "class", "card-text");
                __builder2.AddContent(19, 
#nullable restore
#line 12 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\Shared\ProductItem.razor"
                                          Item.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "p");
                __builder2.AddAttribute(22, "class", "card-text");
                __builder2.AddContent(23, 
#nullable restore
#line 13 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\Shared\ProductItem.razor"
                                          Item.Size

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenElement(25, "p");
                __builder2.AddAttribute(26, "class", "card-text");
                __builder2.AddContent(27, 
#nullable restore
#line 14 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\Shared\ProductItem.razor"
                                          Item.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "small");
                __builder2.AddAttribute(30, "class", "card-text");
                __builder2.AddContent(31, 
#nullable restore
#line 15 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\Shared\ProductItem.razor"
                                              Item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\steel\OneDrive\Skrivbord\Inlamningsuppgifterna\E-Cart\BlazorApp\Shared\ProductItem.razor"
       

    

    [Parameter]
    public Product Item { get; set; }
    public string Href { get; set; }



    protected override void OnInitialized()
    {

        Href = "product/" + Item.Id.ToString();

    }







#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591