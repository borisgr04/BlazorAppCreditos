// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CreditosWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\RepoUpc\BlazorApp\CreditosWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RepoUpc\BlazorApp\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\RepoUpc\BlazorApp\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\RepoUpc\BlazorApp\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\RepoUpc\BlazorApp\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\RepoUpc\BlazorApp\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\RepoUpc\BlazorApp\CreditosWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\RepoUpc\BlazorApp\CreditosWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\RepoUpc\BlazorApp\CreditosWeb\_Imports.razor"
using CreditosWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\RepoUpc\BlazorApp\CreditosWeb\_Imports.razor"
using CreditosWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\RepoUpc\BlazorApp\CreditosWeb\Pages\Creditos.razor"
using CreditosWeb.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/creditos")]
    public partial class Creditos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\RepoUpc\BlazorApp\CreditosWeb\Pages\Creditos.razor"
       
    private Credito[] creditos;
   
   protected override async Task OnInitializedAsync()
   {
        creditos = await CreditoService.GetCreditosAsync();
   }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CreditoService CreditoService { get; set; }
    }
}
#pragma warning restore 1591
