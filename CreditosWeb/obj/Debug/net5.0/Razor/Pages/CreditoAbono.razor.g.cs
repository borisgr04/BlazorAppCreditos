#pragma checksum "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\Pages\CreditoAbono.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "745111b452e66a0d17e416ee12be352b10134a1d"
// <auto-generated/>
#pragma warning disable 1591
namespace CreditosWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\_Imports.razor"
using CreditosWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\_Imports.razor"
using CreditosWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\Pages\CreditoAbono.razor"
using CreditosWeb.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/credito-add-abono/{CreditoId}")]
    public partial class CreditoAbono : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddMarkupContent(1, " Registrar Abono Cr??dito ");
#nullable restore
#line 6 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\Pages\CreditoAbono.razor"
__builder.AddContent(2, CreditoId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "placeholder", "digite el valor");
            __builder.AddAttribute(6, "type", "number");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\Pages\CreditoAbono.razor"
                                            valor

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => valor = __value, valor, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\Pages\CreditoAbono.razor"
                  AddAbono

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Agregar Abono");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\RepoUpc\BlazorAppClase\BlazorAppCreditos\CreditosWeb\Pages\CreditoAbono.razor"
       
   [Parameter]
   public string CreditoId { get; set; }

   private decimal valor;
   private string resultado;
   
   private async Task AddAbono()
   {
        await CreditoService.InsertAbonoAsync(Convert.ToInt32(CreditoId),DateTime.Now, valor);
        NavigationManager.NavigateTo("Creditos");
   }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CreditoService CreditoService { get; set; }
    }
}
#pragma warning restore 1591
