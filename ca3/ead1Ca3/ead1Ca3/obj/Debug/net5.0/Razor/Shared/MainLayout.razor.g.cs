#pragma checksum "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62bc114f50e4454e4bf2ba124ac22d9197628589"
// <auto-generated/>
#pragma warning disable 1591
namespace ead1Ca3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\_Imports.razor"
using ead1Ca3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\_Imports.razor"
using ead1Ca3.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-68nzd4saf8");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-68nzd4saf8");
            __builder.OpenComponent<ead1Ca3.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-68nzd4saf8");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-68nzd4saf8><a href=\"http://metaweather.com/\" target=\"_blank\" class=\"ml-md-auto\" b-68nzd4saf8>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-68nzd4saf8");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\Aaron\Documents\GitHub\EAD1CA3\ca3\ead1Ca3\ead1Ca3\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
