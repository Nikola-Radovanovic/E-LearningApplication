#pragma checksum "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\GetSchool.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "320faa20e560ae74f074905333675de40c7566c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schools_GetSchool), @"mvc.1.0.view", @"/Views/Schools/GetSchool.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schools/GetSchool.cshtml", typeof(AspNetCore.Views_Schools_GetSchool))]
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
#line 1 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\_ViewImports.cshtml"
using ELearningApp;

#line default
#line hidden
#line 2 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\_ViewImports.cshtml"
using ELearningApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"320faa20e560ae74f074905333675de40c7566c9", @"/Views/Schools/GetSchool.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785ad00e7bb8a6dc301ae3fe11dae786cf54b7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Schools_GetSchool : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningApp.ViewModels.SchoolCourseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\GetSchool.cshtml"
  
    ViewData["Title"] = "GetSchool";
    Layout = "~/Views/Shared/_DataTablesLayoutPartial.cshtml";

#line default
#line hidden
            BeginContext(164, 32, false);
#line 6 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\GetSchool.cshtml"
Write(Html.HiddenFor(c => c.School.Id));

#line default
#line hidden
            EndContext();
            BeginContext(196, 61, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-5\">\r\n        <h1>");
            EndContext();
            BeginContext(258, 35, false);
#line 9 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\GetSchool.cshtml"
       Write(Html.DisplayFor(c => c.School.Name));

#line default
#line hidden
            EndContext();
            BeginContext(293, 327, true);
            WriteLiteral(@"</h1>
    </div>
    <div class=""col-lg-7"">
        <table id=""schools"" class=""table table-bordered"">
            <thead>
                <tr class=""bg-primary"">
                    <th><h3>Kursevi</h3></th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
            EndContext();
            BeginContext(621, 35, false);
#line 20 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\GetSchool.cshtml"
                   Write(Html.DisplayFor(c => c.School.Name));

#line default
#line hidden
            EndContext();
            BeginContext(656, 191, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#schools\').DataTable();\r\n    });\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ELearningApp.ViewModels.SchoolCourseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
