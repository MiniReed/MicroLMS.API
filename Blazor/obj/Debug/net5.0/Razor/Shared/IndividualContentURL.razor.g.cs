#pragma checksum "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\IndividualContentURL.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4144c1f2e437de878529f5e6dda543ee251ceb9"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
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
#line 11 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using MicroLMS.Domain;

#line default
#line hidden
#nullable disable
    public partial class IndividualContentURL : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\IndividualContentURL.razor"
 if (contentURL == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p></p>");
#nullable restore
#line 5 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\IndividualContentURL.razor"
}
else
{   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "tr");
            __builder.OpenElement(2, "td");
#nullable restore
#line 9 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\IndividualContentURL.razor"
__builder.AddContent(3, contentURL.Type);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "td");
#nullable restore
#line 10 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\IndividualContentURL.razor"
__builder.AddContent(6, contentURL.URL);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "td");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", "EditContentURL/" + (
#nullable restore
#line 11 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\IndividualContentURL.razor"
                                 contentURL.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "Изменить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\IndividualContentURL.razor"
                            ()=>Delete.InvokeAsync(contentURL)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "Удалить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\IndividualContentURL.razor"
   
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Shared\IndividualContentURL.razor"
       

    [Parameter]
    public ContentURL contentURL { get; set; }

    [Parameter]
    public EventCallback<ContentURL> Delete { get; set; }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
