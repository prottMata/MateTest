#pragma checksum "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableLists\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "917b4cd08b34f0bcee473318a2d489077f8db859"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TableLists_Edit), @"mvc.1.0.view", @"/Views/TableLists/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"917b4cd08b34f0bcee473318a2d489077f8db859", @"/Views/TableLists/Edit.cshtml")]
    public class Views_TableLists_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MateTest2.MateT1.TableList>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableLists\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>TableList</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Listname"" class=""control-label""></label>
                <input asp-for=""Listname"" class=""form-control"" />
                <span asp-validation-for=""Listname"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DefaultList"" class=""control-label""></label>
                <input asp-for=""DefaultList"" class=""form-control"" />
                <span asp-validation-for=""DefaultList"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Hobby"" class=""control-label""></label>
                <input asp-for=""Hobby"" class=""form-control"" />
                <span as");
            WriteLiteral(@"p-validation-for=""Hobby"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UsersId"" class=""control-label""></label>
                <select asp-for=""UsersId"" class=""form-control"" asp-items=""ViewBag.UsersId""></select>
                <span asp-validation-for=""UsersId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\TableLists\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MateTest2.MateT1.TableList> Html { get; private set; }
    }
}
#pragma warning restore 1591
