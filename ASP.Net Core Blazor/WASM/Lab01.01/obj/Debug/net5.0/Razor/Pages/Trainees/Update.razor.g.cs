#pragma checksum "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f857bbbac07eadbdfe51d9b30d3d131255c2937"
// <auto-generated/>
#pragma warning disable 1591
namespace Lab01._01.Pages.Trainees
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Lab01._01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Lab01._01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/trainee/update/{TraineeId:int}")]
    public partial class Update : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Trainee Edit</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                  editedTrainee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group row");
                __builder2.AddMarkupContent(6, "<label for=\"Name\" class=\"col-form-label\">name: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(7);
                __builder2.AddAttribute(8, "id", "Name");
                __builder2.AddAttribute(9, "class", "form-control");
                __builder2.AddAttribute(10, "placeholder", "Enter name");
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                                                                editedTrainee.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editedTrainee.Name = __value, editedTrainee.Name))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => editedTrainee.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group row");
                __builder2.AddMarkupContent(17, "<label for=\"birthdate\" class=\"col-form-label\">Birthdate: </label>\r\n        ");
                __Blazor.Lab01._01.Pages.Trainees.Update.TypeInference.CreateInputDate_0(__builder2, 18, 19, "birthdate", 20, "form-control", 21, "Enter birthdate", 22, 
#nullable restore
#line 14 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                                                                     editedTrainee.BirthDate

#line default
#line hidden
#nullable disable
                , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editedTrainee.BirthDate = __value, editedTrainee.BirthDate)), 24, () => editedTrainee.BirthDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group row");
                __builder2.AddMarkupContent(28, "<label for=\"email\" class=\"col-form-label\">Email: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", "email");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "placeholder", "Enter email");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                                                                 editedTrainee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editedTrainee.Email = __value, editedTrainee.Email))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => editedTrainee.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group row");
                __builder2.AddMarkupContent(39, "<label for=\"MobileNo\" class=\"col-form-label\">Mobile No: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "id", "MobileNo");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "placeholder", "Enter phone number");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                                                                    editedTrainee.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editedTrainee.PhoneNumber = __value, editedTrainee.PhoneNumber))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => editedTrainee.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group row");
                __builder2.AddMarkupContent(50, "<label for=\"gender\" class=\"col-form-label\">Gender: </label>\r\n        ");
                __Blazor.Lab01._01.Pages.Trainees.Update.TypeInference.CreateInputSelect_1(__builder2, 51, 52, "gender", 53, "form-control", 54, 
#nullable restore
#line 29 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                                                                   editedTrainee.Gender

#line default
#line hidden
#nullable disable
                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editedTrainee.Gender = __value, editedTrainee.Gender)), 56, () => editedTrainee.Gender, 57, (__builder3) => {
                    __builder3.OpenElement(58, "option");
                    __builder3.AddAttribute(59, "value", 
#nullable restore
#line 30 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                             sharedLibarary.Gender.Male

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(60, "Male");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n            ");
                    __builder3.OpenElement(62, "option");
                    __builder3.AddAttribute(63, "value", 
#nullable restore
#line 31 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                             sharedLibarary.Gender.Female

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(64, "Female");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group row");
                __builder2.AddMarkupContent(68, "<label for=\"IsGraduated\" class=\"col-form-label\">IsGraduated: </label>\r\n        ");
                __Blazor.Lab01._01.Pages.Trainees.Update.TypeInference.CreateInputSelect_2(__builder2, 69, 70, "gender", 71, "form-control", 72, 
#nullable restore
#line 38 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                                                                   editedTrainee.IsGraduated

#line default
#line hidden
#nullable disable
                , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editedTrainee.IsGraduated = __value, editedTrainee.IsGraduated)), 74, () => editedTrainee.IsGraduated, 75, (__builder3) => {
                    __builder3.OpenElement(76, "option");
                    __builder3.AddAttribute(77, "value", 
#nullable restore
#line 39 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                             true

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(78, "true");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\r\n            ");
                    __builder3.OpenElement(80, "option");
                    __builder3.AddAttribute(81, "value", 
#nullable restore
#line 40 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                             false

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(82, "false");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n\r\n    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "form-group row");
                __builder2.AddMarkupContent(86, "<label for=\"TrackId\" class=\"col-form-label\">Track Id: </label>\r\n        ");
                __Blazor.Lab01._01.Pages.Trainees.Update.TypeInference.CreateInputNumber_3(__builder2, 87, 88, "TrackId", 89, "form-control", 90, 
#nullable restore
#line 46 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
                                                                    editedTrainee.TrackId

#line default
#line hidden
#nullable disable
                , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editedTrainee.TrackId = __value, editedTrainee.TrackId)), 92, () => editedTrainee.TrackId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n\r\n    ");
                __builder2.AddMarkupContent(94, "<button type=\"submit\" class=\"btn btn-primary\">Save</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Update.razor"
      
    [Parameter]
    public int TraineeId { get; set; }

    sharedLibarary.Trainee editedTrainee;

    protected override Task OnInitializedAsync()
    {
        editedTrainee = sharedLibarary.ITIContext.trainees.FirstOrDefault(e => e.Id == TraineeId);
        return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Lab01._01.Pages.Trainees.Update
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
