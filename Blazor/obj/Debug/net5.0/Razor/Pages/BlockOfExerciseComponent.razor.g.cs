#pragma checksum "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8725872f947694193e45897f10c7341b2e63c10b"
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
#line 2 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
using MicroLMS.Domain;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditBlock/{IdBlock:int}")]
    public partial class BlockOfExerciseComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Редактирование блока упражнений </h1>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Изменить блок упражнений</h3>\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "\r\n    Название типа:\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "placeholder", "Введите тип блока");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                  TypeBlock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeBlock = __value, TypeBlock));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "\r\n    Изменение подтипа:\r\n    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "placeholder", "Введите подтип блока");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                  SubTypeBlock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SubTypeBlock = __value, SubTypeBlock));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "p");
            __builder.AddMarkupContent(17, "\r\n    Общие методические указания\r\n    ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "placeholder", "Введите общие методические указания");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                  ManualBlock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ManualBlock = __value, ManualBlock));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "p");
            __builder.AddMarkupContent(24, "\r\n    Примечания\r\n    ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "placeholder", "Введите Примечание");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                  CommentsBlock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CommentsBlock = __value, CommentsBlock));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "p");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                      ChangeBlock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "Изменить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n\r\n");
            __builder.OpenElement(35, "p");
            __builder.AddMarkupContent(36, "<h3>Cписиок упражнений в блоке.</h3>\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "table-responsive");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table table-striped");
            __builder.AddMarkupContent(41, "<thead class=\"thead-light\"><tr><th>Тип упражнения</th>\r\n                    <th>Номер</th>\r\n                    <th>Сложность</th>\r\n                    <th></th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(42, "tbody");
            __Blazor.Blazor.Pages.BlockOfExerciseComponent.TypeInference.CreateGenericListItems_0(__builder, 43, 44, 
#nullable restore
#line 48 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                                               exercises

#line default
#line hidden
#nullable disable
            , 45, (exercise) => (__builder2) => {
                __builder2.OpenComponent<Blazor.Shared.IndividualExercise>(46);
                __builder2.AddAttribute(47, "exercise", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MicroLMS.Domain.Exercise>(
#nullable restore
#line 50 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                                                      exercise

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "Delete", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MicroLMS.Domain.Exercise>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MicroLMS.Domain.Exercise>(this, 
#nullable restore
#line 50 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                                                                        DeleteExercise

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.AddMarkupContent(50, "<h3>Добавление нового упражнения в блок</h3>\r\n        ");
            __builder.OpenElement(51, "p");
            __builder.AddMarkupContent(52, "\r\n            Тип упражнения\r\n            ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "placeholder", "Тип упражнения");
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                          TypeExercise

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeExercise = __value, TypeExercise));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "p");
            __builder.AddMarkupContent(59, "\r\n            Номер упражнения\r\n            ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "placeholder", "номер упражнения");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                          TaskNumberExercise

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TaskNumberExercise = __value, TaskNumberExercise));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "p");
            __builder.AddMarkupContent(66, "\r\n            Сложность упражнения\r\n            ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "placeholder", "Справка по блоку");
            __builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                          DifficultyExercise

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => DifficultyExercise = __value, DifficultyExercise));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.OpenElement(72, "p");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                              AddExercise

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "Добавить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n        ");
            __builder.AddMarkupContent(77, "<h3>Ссылки на материал</h3>\r\n        ");
            __builder.OpenElement(78, "table");
            __builder.AddAttribute(79, "class", "table table-striped");
            __builder.AddMarkupContent(80, "<thead class=\"thead-light\"><tr><th>Тип контента</th>\r\n                    <th>Ссылка</th>\r\n                    <th></th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(81, "tbody");
            __Blazor.Blazor.Pages.BlockOfExerciseComponent.TypeInference.CreateGenericListItems_1(__builder, 82, 83, 
#nullable restore
#line 83 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                                               content

#line default
#line hidden
#nullable disable
            , 84, (cont) => (__builder2) => {
                __builder2.OpenComponent<Blazor.Shared.IndividualContentURL>(85);
                __builder2.AddAttribute(86, "contentURL", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MicroLMS.Domain.ContentURL>(
#nullable restore
#line 85 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                                                          cont

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "Delete", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MicroLMS.Domain.ContentURL>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MicroLMS.Domain.ContentURL>(this, 
#nullable restore
#line 85 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
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
            __builder.AddMarkupContent(88, "\r\n");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col text-center");
            __builder.AddMarkupContent(91, "<h3>Добавление контента в блок упражнений</h3>\r\n    ");
            __builder.OpenElement(92, "p");
            __builder.AddMarkupContent(93, "\r\n        Тип контента упражнений\r\n        ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "placeholder", "Тип контента");
            __builder.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 95 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                      TypeContent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TypeContent = __value, TypeContent));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    ");
            __builder.OpenElement(99, "p");
            __builder.AddMarkupContent(100, "\r\n        Ссылка на контент\r\n        ");
            __builder.OpenElement(101, "input");
            __builder.AddAttribute(102, "placeholder", "ссылка на контент");
            __builder.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                      URLContent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => URLContent = __value, URLContent));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n    ");
            __builder.OpenElement(106, "p");
            __builder.OpenElement(107, "button");
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
                          Addcontent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(109, "Добавить");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\Макс\Desktop\MicroLMS.API\Blazor\Pages\BlockOfExerciseComponent.razor"
       
    [Parameter]
    public int IdBlock { get; set; }

    public string TypeBlock;
    public string SubTypeBlock;
    public string ManualBlock;
    public string CommentsBlock;

    public string TypeExercise;
    public int TaskNumberExercise;
    public int DifficultyExercise;

    public string TypeContent;
    public string URLContent;

    BlockOfExercise block;
    public List<ContentURL> content { get; set; }
    public List<Exercise> exercises { get; set; }

    protected override async Task OnInitializedAsync()
    {

        block = await Http.GetFromJsonAsync<BlockOfExercise>
            ("https://localhost:44376/api/BlockOfExercises/" + IdBlock);
        TypeBlock = block.Type;
        SubTypeBlock = block.SubType;
        ManualBlock = block.Manual;
        CommentsBlock = block.Comments;
        exercises = await Http.GetFromJsonAsync<List<Exercise>>
("https://localhost:44376/api/BlockOfExercises/all/" + IdBlock);
        content = await Http.GetFromJsonAsync<List<ContentURL>>
    ("https://localhost:44376/api/ContentURL/all/" + IdBlock);
    }

    private async Task AddExercise()
    {
        Exercise exercise = new Exercise
        {
            Type = TypeExercise,
            TaskNumber = TaskNumberExercise,
            difficulty = DifficultyExercise,
            blockOfExercises = block
        };

        await Http.PostAsJsonAsync("https://localhost:44376/api/exercises/", exercise);
        exercises = await Http.GetFromJsonAsync<List<Exercise>>
        ("https://localhost:44376/api/BlockOfExercises/all/" + IdBlock);

    }

    private async Task Addcontent()
    {
        ContentURL Content = new ContentURL
        {
            Type = TypeContent,
            URL = URLContent,
            blockOfExercise = block

        };

        await Http.PostAsJsonAsync("https://localhost:44376/api/ContentURL/", Content);
        content = await Http.GetFromJsonAsync<List<ContentURL>>
        ("https://localhost:44376/api/ContentURL/all/" + IdBlock);

    }

    private async void DeleteExercise(Exercise exercise)
    {
        exercises.Remove(exercise);
        await Http.DeleteAsync("https://localhost:44376/api/exercises/" + exercise.Id);
    }
    private async void DeleteContent(ContentURL Content)
    {
        content.Remove(Content);
        await Http.DeleteAsync("https://localhost:44376/api/ContentURL/" + Content.Id);
    }

    private async void ChangeBlock()
    {
        block.Type = TypeBlock;
        block.SubType = SubTypeBlock;
        block.Manual = ManualBlock;
        block.Comments = CommentsBlock;

        await Http.PutAsJsonAsync("https://localhost:44376/api/BlockOfExercises/", block);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Blazor.Pages.BlockOfExerciseComponent
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