#pragma checksum "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "725468cd7bedc4b76c28af261fff22040a0ce40f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_UpdateCourse), @"mvc.1.0.view", @"/Views/Courses/UpdateCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/UpdateCourse.cshtml", typeof(AspNetCore.Views_Courses_UpdateCourse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"725468cd7bedc4b76c28af261fff22040a0ce40f", @"/Views/Courses/UpdateCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785ad00e7bb8a6dc301ae3fe11dae786cf54b7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_UpdateCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningApp.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
  
    ViewData["Title"] = "UpdateCourse";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 84, true);
            WriteLiteral("\r\n<h2>Izmeni podatke o kursu</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4\">\r\n");
            EndContext();
#line 11 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
         using (Html.BeginForm("UpdateCourse", "Courses"))
        {

#line default
#line hidden
            BeginContext(285, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(340, 26, false);
#line 14 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
           Write(Html.LabelFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(366, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(385, 61, false);
#line 15 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
           Write(Html.TextBoxFor(c => c.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(446, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(465, 38, false);
#line 16 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(503, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(580, 26, false);
#line 19 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
           Write(Html.LabelFor(c => c.Link));

#line default
#line hidden
            EndContext();
            BeginContext(606, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(625, 61, false);
#line 20 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
           Write(Html.TextBoxFor(c => c.Link, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(686, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(705, 38, false);
#line 21 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Link));

#line default
#line hidden
            EndContext();
            BeginContext(743, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(820, 33, false);
#line 24 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
           Write(Html.LabelFor(c => c.Description));

#line default
#line hidden
            EndContext();
            BeginContext(853, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(872, 68, false);
#line 25 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
           Write(Html.TextBoxFor(c => c.Description, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(940, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(959, 45, false);
#line 26 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(1039, 25, false);
#line 28 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
       Write(Html.HiddenFor(c => c.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 23, false);
#line 29 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1104, 77, true);
            WriteLiteral("            <input type=\"submit\" class=\"btn btn-primary\" value=\"Sačuvaj\" />\r\n");
            EndContext();
#line 31 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
        }

#line default
#line hidden
            BeginContext(1192, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1231, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1238, 59, false);
#line 36 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\UpdateCourse.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(1297, 3, true);
                WriteLiteral(";\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ELearningApp.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
