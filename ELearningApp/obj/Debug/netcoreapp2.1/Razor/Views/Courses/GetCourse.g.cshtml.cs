#pragma checksum "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\GetCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83439d5e630e9d0c742292ce5694aac43a310cdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_GetCourse), @"mvc.1.0.view", @"/Views/Courses/GetCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/GetCourse.cshtml", typeof(AspNetCore.Views_Courses_GetCourse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83439d5e630e9d0c742292ce5694aac43a310cdd", @"/Views/Courses/GetCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785ad00e7bb8a6dc301ae3fe11dae786cf54b7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_GetCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningApp.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\GetCourse.cshtml"
  
    ViewData["Title"] = "GetCourse";
    Layout = "~/Views/Shared/_DataTablesLayoutPartial.cshtml";

#line default
#line hidden
            BeginContext(144, 70, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12 text-center\">\r\n        ");
            EndContext();
            BeginContext(215, 25, false);
#line 9 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\GetCourse.cshtml"
   Write(Html.HiddenFor(c => c.Id));

#line default
#line hidden
            EndContext();
            BeginContext(240, 16, true);
            WriteLiteral("\r\n\r\n        <h2>");
            EndContext();
            BeginContext(257, 28, false);
#line 11 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\GetCourse.cshtml"
       Write(Html.DisplayFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(285, 89, true);
            WriteLiteral("</h2>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                ");
            EndContext();
            BeginContext(375, 26, false);
#line 15 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\GetCourse.cshtml"
           Write(Html.LabelFor(c => c.Link));

#line default
#line hidden
            EndContext();
            BeginContext(401, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(420, 28, false);
#line 16 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\GetCourse.cshtml"
           Write(Html.DisplayFor(c => c.Link));

#line default
#line hidden
            EndContext();
            BeginContext(448, 119, true);
            WriteLiteral(" \r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                ");
            EndContext();
            BeginContext(568, 33, false);
#line 21 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\GetCourse.cshtml"
           Write(Html.LabelFor(c => c.Description));

#line default
#line hidden
            EndContext();
            BeginContext(601, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(620, 35, false);
#line 22 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\GetCourse.cshtml"
           Write(Html.DisplayFor(c => c.Description));

#line default
#line hidden
            EndContext();
            BeginContext(655, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ELearningApp.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
