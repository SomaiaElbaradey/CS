#pragma checksum "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bec81e5d9e21ffc8c4d18fa368a894f78b01582"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/trainees/all")]
    public partial class All : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>All Trainees</h3>\r\n\r\n");
            __builder.OpenElement(1, "a");
            __builder.AddAttribute(2, "class", "btn btn-secondary mb-3");
            __builder.AddAttribute(3, "href", 
#nullable restore
#line 5 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
                                          $"trainee/create"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " Add new Trainee");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-striped");
            __builder.AddMarkupContent(8, "<tr><th>Id</th>\r\n        <th>Name</th>\r\n        <th>Gender</th>\r\n        <th>Mobile No.</th>\r\n        <th>Birthdate</th>\r\n        <th>Is Graduated</th>\r\n        <th></th></tr>");
#nullable restore
#line 16 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
     foreach (var trainee in trainees)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 19 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
                 trainee.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 20 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
                 trainee.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 21 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
                 trainee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 22 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
                 trainee.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 23 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
                 trainee.BirthDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 24 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
                 trainee.IsGraduated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 26 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
                           $"trainee/details/{trainee.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "class", "btn btn-primary mx-2");
            __builder.AddContent(32, " Details ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, " |\r\n                ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", 
#nullable restore
#line 27 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
                           $"trainee/update/{trainee.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "class", "btn btn-dark mx-2");
            __builder.AddContent(37, " Update ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\All.razor"
       
    List<sharedLibarary.Trainee> trainees = sharedLibarary.ITIContext.trainees;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
