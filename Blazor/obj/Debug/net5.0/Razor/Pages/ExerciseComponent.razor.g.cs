#pragma checksum "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b979fb32cf6444f8c24a98a4a9fc139b5d442a4"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
using MicroLMS.Domain;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditExercise/{IdEx:int}")]
    public partial class ExerciseComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddMarkupContent(1, "Редактирование упражнения ");
#nullable restore
#line 8 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
__builder.AddContent(2, NameEx);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(4, "<h3>Изменить название упражнения</h3>\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddMarkupContent(6, "\r\n    Изменение типа:\r\n    ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "placeholder", "Введите тип задания");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                  TypeEx

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeEx = __value, TypeEx));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "p");
            __builder.AddMarkupContent(13, "\r\n    Номер задания\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "placeholder", "");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                  TaskNumberEx

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TaskNumberEx = __value, TaskNumberEx));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenElement(19, "p");
            __builder.AddMarkupContent(20, "\r\n    Сложность задания\r\n    ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "placeholder", "");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                  difficultyEx

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => difficultyEx = __value, difficultyEx));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "p");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                      ChangeEx

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "Изменить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "table-responsive");
            __builder.AddMarkupContent(33, "<h3>Ссылки на материал</h3>\r\n    ");
            __builder.OpenElement(34, "table");
            __builder.AddAttribute(35, "class", "table table-striped");
            __builder.AddMarkupContent(36, "<thead class=\"thead-light\"><tr><th>Тип контента</th>\r\n                <th>Ссылка</th>\r\n                <th></th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(37, "tbody");
            __Blazor.Blazor.Pages.ExerciseComponent.TypeInference.CreateGenericListItems_0(__builder, 38, 39, 
#nullable restore
#line 42 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                                           content

#line default
#line hidden
#nullable disable
            , 40, (cont) => (__builder2) => {
                __builder2.OpenComponent<Blazor.Shared.IndividualContentURL>(41);
                __builder2.AddAttribute(42, "contentURL", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MicroLMS.Domain.ContentURL>(
#nullable restore
#line 44 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                                                      cont

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "Delete", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MicroLMS.Domain.ContentURL>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MicroLMS.Domain.ContentURL>(this, 
#nullable restore
#line 44 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                                                                    DeleteContent

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col text-center");
            __builder.AddMarkupContent(47, "<h3>Добавление контента в упражнение</h3>\r\n    ");
            __builder.OpenElement(48, "p");
            __builder.AddMarkupContent(49, "\r\n        Тип контента упражнений\r\n        ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "placeholder", "Тип контента");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                      TypeContent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeContent = __value, TypeContent));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "p");
            __builder.AddMarkupContent(56, "\r\n        Ссылка на контент\r\n        ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "placeholder", "ссылка на контент");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                      URLContent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => URLContent = __value, URLContent));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.OpenElement(62, "p");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                          Addcontent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "Добавить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "table-responsive");
            __builder.AddMarkupContent(69, "<h3>Ссылки на тест</h3>\r\n    ");
            __builder.OpenElement(70, "table");
            __builder.AddAttribute(71, "class", "table table-striped");
            __builder.AddMarkupContent(72, "<thead class=\"thead-light\"><tr><th>Название теста</th>\r\n                <th>Ссылка</th>\r\n                <th></th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(73, "tbody");
            __Blazor.Blazor.Pages.ExerciseComponent.TypeInference.CreateGenericListItems_1(__builder, 74, 75, 
#nullable restore
#line 77 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                                           testlinks

#line default
#line hidden
#nullable disable
            , 76, (testlink) => (__builder2) => {
                __builder2.OpenComponent<Blazor.Shared.IndividualTestLink>(77);
                __builder2.AddAttribute(78, "TestLink", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MicroLMS.Domain.TestLink>(
#nullable restore
#line 79 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                                                  testlink

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "Delete", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MicroLMS.Domain.TestLink>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MicroLMS.Domain.TestLink>(this, 
#nullable restore
#line 79 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                                                                    DeleteTestLink

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col text-center");
            __builder.AddMarkupContent(83, "<h3>Добавление теста в упражнение</h3>\r\n    ");
            __builder.OpenElement(84, "p");
            __builder.AddMarkupContent(85, "\r\n        Название теста\r\n        ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "placeholder", "Название теста");
            __builder.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                      NameTest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NameTest = __value, NameTest));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.OpenElement(91, "p");
            __builder.AddMarkupContent(92, "\r\n        Ссылка на тест\r\n        ");
            __builder.OpenElement(93, "input");
            __builder.AddAttribute(94, "placeholder", "ссылка на контент");
            __builder.AddAttribute(95, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                      URLTest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => URLTest = __value, URLTest));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.OpenElement(98, "p");
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
                          AddTestLink

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(101, "Добавить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\ExerciseComponent.razor"
      
    [Parameter]
    public int IdEx { get; set; }

    public string NameEx;

    public string TypeEx;
    public int TaskNumberEx;
    public int difficultyEx;

    public string TypeContent;
    public string URLContent;

    public string NameTest;
    public string URLTest;

    Exercise Exercise;
    public List<ContentURL> content { get; set; }
    public List<TestLink> testlinks { get; set; }

    protected override async Task OnInitializedAsync()
    {

        Exercise = await Http.GetFromJsonAsync<Exercise>
        ("https://localhost:44376/api/Exercises/" + IdEx);

        TypeEx = Exercise.Type;
        TaskNumberEx = Exercise.TaskNumber;
        difficultyEx = Exercise.difficulty;

        content = await Http.GetFromJsonAsync<List<ContentURL>>
    ("https://localhost:44376/api/ContentURL/allEx/" + IdEx);
        testlinks = await Http.GetFromJsonAsync<List<TestLink>>
("https://localhost:44376/api/TestLink/all/" + IdEx);

    }

    private async void DeleteContent(ContentURL Content)
    {
        content.Remove(Content);
        await Http.DeleteAsync("https://localhost:44376/api/ContentURL/" + Content.Id);
    }

    private async void DeleteTestLink(TestLink TestLink)
    {
        testlinks.Remove(TestLink);
        await Http.DeleteAsync("https://localhost:44376/api/TestLink/" + TestLink.Id);
    }

    private async Task AddTestLink()
    {
        TestLink TestLink = new TestLink
        {
            Name = NameTest,
            URL = URLTest,
            exercise = Exercise

        };

        await Http.PostAsJsonAsync("https://localhost:44376/api/TestLink/", TestLink);
        testlinks = await Http.GetFromJsonAsync<List<TestLink>>
    ("https://localhost:44376/api/TestLink/all/" + IdEx);


    }

    private async Task Addcontent()
    {
        ContentURL Content = new ContentURL
        {
            Type = TypeContent,
            URL = URLContent,
            exercise = Exercise

        };

        await Http.PostAsJsonAsync("https://localhost:44376/api/ContentURL/", Content);
        content = await Http.GetFromJsonAsync<List<ContentURL>>
        ("https://localhost:44376/api/ContentURL/allEx/" + IdEx);

    }


    private async void ChangeEx()
    {
        Exercise.Type = TypeEx;
        Exercise.TaskNumber = TaskNumberEx;
        Exercise.difficulty = difficultyEx;

        await Http.PutAsJsonAsync("https://localhost:44376/api/Exercises/", Exercise);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Blazor.Pages.ExerciseComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericListItems_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Blazor.Shared.GenericListItems<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ListOfItems", __arg0);
        __builder.AddAttribute(__seq1, "ItemTemp", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateGenericListItems_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Blazor.Shared.GenericListItems<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ListOfItems", __arg0);
        __builder.AddAttribute(__seq1, "ItemTemp", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
