#pragma checksum "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7c5392d0c79426887ef2eb697add299db242d73"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pizza-cards");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 6 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
         if (Specials != null)
        {
            foreach (var Special in Specials)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "              ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
                              ()=>ShowConfigurePizzaDialog(Special)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "style", "background-image:url(\'" + (
#nullable restore
#line 11 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
                                                Special.ImageURL

#line default
#line hidden
#nullable disable
            ) + "\')");
            __builder.AddMarkupContent(10, "\r\n                  ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "pizza-info");
            __builder.AddMarkupContent(13, "\r\n                      ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "title");
#nullable restore
#line 13 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
__builder.AddContent(16, Special.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                      ");
#nullable restore
#line 14 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
__builder.AddContent(18, Special.Description);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "\r\n                      ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "price");
            __builder.AddMarkupContent(22, "\r\n                          ");
#nullable restore
#line 16 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
__builder.AddContent(23, Special.GetFormattedBasePrice());

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "\r\n                      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n              ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "  \r\n");
#nullable restore
#line 20 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
            };
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n");
#nullable restore
#line 25 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
 if (ShowingConfigureDialog)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.OpenComponent<BlazingPizza.Client.Shared.ConfigurePizzaDialog>(32);
            __builder.AddAttribute(33, "Pizza", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Shared.Pizza>(
#nullable restore
#line 27 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
                                 ConfiguringPizza

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, " \r\n");
#nullable restore
#line 28 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\b_e_t\Documents\00PROJECTS\BlazingPizza\Client\Pages\Index.razor"
      
    List<PizzaSpecial> Specials;
    Pizza ConfiguringPizza;
    bool ShowingConfigureDialog;


    protected async override Task OnInitializedAsync()
    {
        Specials = await httpClient.GetFromJsonAsync<List<PizzaSpecial>>("specials");
    }

    void ShowConfigurePizzaDialog(PizzaSpecial special)
    {
        ConfiguringPizza = new Pizza()
        {
            Special = special,
            SpecialId = special.Id,
            Size = Pizza.DefaultSize,
            Toppings = new List<PizzaTopping>()
        };
        ShowingConfigureDialog = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
