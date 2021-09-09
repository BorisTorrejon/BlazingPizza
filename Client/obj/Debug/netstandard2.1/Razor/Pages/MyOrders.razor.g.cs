#pragma checksum "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db887b3c018b70d6a2e4a7b0409b740b2766396"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\_Imports.razor"
using BlazingPizza.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/myorders")]
    public partial class MyOrders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 5 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
     if (OrderWithStatus == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "Cargando...");
#nullable restore
#line 7 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
                                
    }
    else if(OrderWithStatus.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.AddMarkupContent(5, "<h2>No se ah realizado alguna orden</h2>\r\n        ");
            __builder.AddMarkupContent(6, "<a class=\"btn btn-success\" href>Ordena alguna pizza</a>\r\n");
#nullable restore
#line 13 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "list-group orders-list");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 17 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
             foreach(var Item in OrderWithStatus)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "list-group-item");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "h5");
#nullable restore
#line 21 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
__builder.AddContent(19, Item.Order.CreatedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        Pizzas:\r\n                        ");
            __builder.OpenElement(21, "strong");
#nullable restore
#line 23 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
__builder.AddContent(22, Item.Order.Pizzas.Count());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        Precio Total:\r\n                        ");
            __builder.OpenElement(24, "strong");
#nullable restore
#line 25 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
__builder.AddContent(25, Item.Order.GetFormattedTotalPrice());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col");
            __builder.AddMarkupContent(30, "\r\n                        Estatus: ");
            __builder.OpenElement(31, "strong");
#nullable restore
#line 28 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
__builder.AddContent(32, Item.StatusText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col text-right");
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "myorders/" + (
#nullable restore
#line 31 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
                                           Item.Order.OrderId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-success");
            __builder.AddMarkupContent(41, "\r\n                            Rastrear &gt;\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 36 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 38 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\MyOrders.razor"
       
    List<OrderWithStatus> OrderWithStatus;
    protected override async Task OnParametersSetAsync()
    {
        OrderWithStatus =
        await HttpClient.GetFromJsonAsync<List<OrderWithStatus>>("orders");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
