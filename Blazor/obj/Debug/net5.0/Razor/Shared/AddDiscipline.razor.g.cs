#pragma checksum "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\AddDiscipline.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e93f14889bc8af9ea6a3ed3e68a1d83beca34afa"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\AddDiscipline.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\AddDiscipline.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\AddDiscipline.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\AddDiscipline.razor"
using MicroLMS.Domain;

#line default
#line hidden
#nullable disable
    public partial class AddDiscipline : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\AddDiscipline.razor"
                  ()=>AddDis.InvokeAsync()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(2, "Добавить");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\AddDiscipline.razor"
        


     [Parameter]
     public EventCallback<Discipline> AddDis { get; set; }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
