#pragma checksum "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\Subtasks\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc005dea35891099fc9e58d4fc08e6de2713c436"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subtasks_Edit), @"mvc.1.0.view", @"/Views/Subtasks/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc005dea35891099fc9e58d4fc08e6de2713c436", @"/Views/Subtasks/Edit.cshtml")]
    public class Views_Subtasks_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MateTest2.MateT1.Subtask>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\Subtasks\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Subtask</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""IdTask"" class=""control-label""></label>
                <select asp-for=""IdTask"" class=""form-control"" asp-items=""ViewBag.IdTask""></select>
                <span asp-validation-for=""IdTask"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SubtaskName"" class=""control-label""></label>
                <input asp-for=""SubtaskName"" class=""form-control"" />
                <span asp-validation-for=""SubtaskName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IdStatus"" class=""control-label""></label>
                <select asp-for=""IdStatus"" class=""form-con");
            WriteLiteral(@"trol"" asp-items=""ViewBag.IdStatus""></select>
                <span asp-validation-for=""IdStatus"" class=""text-danger""></span>
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
#line 43 "C:\Users\Джамиля.ТЕРМИНАТОР\source\repos\MateTest2\Views\Subtasks\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MateTest2.MateT1.Subtask> Html { get; private set; }
    }
}
#pragma warning restore 1591