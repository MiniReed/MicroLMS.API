// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\Shared\ListLessons.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\Shared\ListLessons.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\Shared\ListLessons.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\Shared\ListLessons.razor"
using MicroLMS.Domain;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dedit/{Id:int}")]
    public partial class ListLessons : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\1234\Desktop\MicroLMS.API\Blazor\Shared\ListLessons.razor"
           


        [Parameter]
        public int Id { get; set; }

        Discipline discipline;
        public string name;
        private IEnumerable<Lesson> les;

        protected override async Task OnParametersSetAsync()
        {

            discipline = await Http.GetFromJsonAsync<Discipline>
                ("https://localhost:44376/api/Disciplines/" + Id);
            name = discipline.Name;
            les = await Http.GetFromJsonAsync<Lesson[]>
                ("https://localhost:44376/api/Disciplines/all/" + Id);
        }


        //var discipline = new Discipline { Id = id, Name = "dsd" };
        //newName = "";

        //await Http.PutAsJsonAsync<Discipline>("https://localhost:44376/api/Disciplines/3", discipline);

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
