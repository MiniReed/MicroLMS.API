// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Pages
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
#line 2 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\DisComponent.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\DisComponent.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\DisComponent.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\DisComponent.razor"
using MicroLMS.Domain;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditDis/{IdDis:int}")]
    public partial class DisComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\DisComponent.razor"
       
    [Parameter]
    public int IdDis { get; set; }

    Discipline discipline;
    public string NameDis;
    public string newName;

    public string NameLes;
    public string TypeLes;
    public int HourseQuantity;

    public List<Lesson> lessons { get; set; }

    protected override async Task OnInitializedAsync()
    {

        discipline = await Http.GetFromJsonAsync<Discipline>
            ("https://localhost:44376/api/Disciplines/" + IdDis);
        NameDis = discipline.Name;
        lessons = await Http.GetFromJsonAsync<List<Lesson>>
    ("https://localhost:44376/api/Disciplines/all/" + IdDis);
    }

    private async Task Addles()
    {
        Lesson lesson = new Lesson
        {
            Name = NameLes,
            HourseQuantity = HourseQuantity,
            Type = TypeLes,
            Discipline = discipline
        };

        await Http.PostAsJsonAsync("https://localhost:44376/api/Lessons/", lesson);
        lessons = await Http.GetFromJsonAsync<List<Lesson>>
        ("https://localhost:44376/api/Disciplines/all/" + IdDis);

    }

    private async void DeleteLes(Lesson lesson)
    {
        lessons.Remove(lesson);
        await Http.DeleteAsync("https://localhost:44376/api/Lessons/" + lesson.Id);
    }

    private async void ChangeDis()
    {

        discipline.Name = NameDis;
        await Http.PutAsJsonAsync("https://localhost:44376/api/Disciplines/", discipline);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
