#pragma checksum "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6df6f13780e420e63e658acb675d2a2d80d538f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TableTasks_Index), @"mvc.1.0.view", @"/Views/TableTasks/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6df6f13780e420e63e658acb675d2a2d80d538f", @"/Views/TableTasks/Index.cshtml")]
    public class Views_TableTasks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MateTest2.MateT1.TableTask>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Taskname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdStatusNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Taskname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdStatusNavigation.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 801, "\"", 824, 1);
#nullable restore
#line 34 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml"
WriteAttributeValue("", 816, item.Id, 816, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 877, "\"", 900, 1);
#nullable restore
#line 35 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml"
WriteAttributeValue("", 892, item.Id, 892, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 955, "\"", 978, 1);
#nullable restore
#line 36 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml"
WriteAttributeValue("", 970, item.Id, 970, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableTasks\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MateTest2.MateT1.TableTask>> Html { get; private set; }
    }
}
#pragma warning restore 1591
