#pragma checksum "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Schools\GetSchool.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e3d53e097517d81d2b5de0f8d23ac4c99f1b9b8"
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
#line 1 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\_ViewImports.cshtml"
using ELearningApp;

#line default
#line hidden
#line 2 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\_ViewImports.cshtml"
using ELearningApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e3d53e097517d81d2b5de0f8d23ac4c99f1b9b8", @"/Views/Schools/GetSchool.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785ad00e7bb8a6dc301ae3fe11dae786cf54b7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Schools_GetSchool : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningApp.Models.School>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Schools\GetSchool.cshtml"
  
    ViewData["Title"] = "GetSchool";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 57, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4\">\r\n        ");
            EndContext();
            BeginContext(185, 25, false);
#line 9 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Schools\GetSchool.cshtml"
   Write(Html.HiddenFor(c => c.Id));

#line default
#line hidden
            EndContext();
            BeginContext(210, 16, true);
            WriteLiteral("\r\n\r\n        <h2>");
            EndContext();
            BeginContext(227, 28, false);
#line 11 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Schools\GetSchool.cshtml"
       Write(Html.DisplayFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(255, 160, true);
            WriteLiteral("</h2>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                    Kurs\r\n            </div>\r\n        </div>   \r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ELearningApp.Models.School> Html { get; private set; }
    }
}
#pragma warning restore 1591
