#pragma checksum "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\UpdateSchool.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a63c6c47e31a951256ffb4c532edfccc4af6e2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schools_UpdateSchool), @"mvc.1.0.view", @"/Views/Schools/UpdateSchool.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schools/UpdateSchool.cshtml", typeof(AspNetCore.Views_Schools_UpdateSchool))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a63c6c47e31a951256ffb4c532edfccc4af6e2d", @"/Views/Schools/UpdateSchool.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785ad00e7bb8a6dc301ae3fe11dae786cf54b7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Schools_UpdateSchool : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningApp.Models.School>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\UpdateSchool.cshtml"
  
    ViewData["Title"] = "UpdateSchool";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 84, true);
            WriteLiteral("\r\n<h2>Izmeni podatke o školi</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4\">\r\n");
            EndContext();
#line 11 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\UpdateSchool.cshtml"
         using (Html.BeginForm("UpdateSchool", "Schools"))
         {

#line default
#line hidden
            BeginContext(286, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(341, 26, false);
#line 14 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\UpdateSchool.cshtml"
           Write(Html.LabelFor(s => s.Name));

#line default
#line hidden
            EndContext();
            BeginContext(367, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(386, 61, false);
#line 15 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\UpdateSchool.cshtml"
           Write(Html.TextBoxFor(s => s.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(447, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(466, 38, false);
#line 16 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\UpdateSchool.cshtml"
           Write(Html.ValidationMessageFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(504, 24, true);
            WriteLiteral("\r\n\r\n            </div>\r\n");
            EndContext();
            BeginContext(545, 25, false);
#line 19 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\UpdateSchool.cshtml"
           Write(Html.HiddenFor(s => s.Id));

#line default
#line hidden
            EndContext();
            BeginContext(589, 23, false);
#line 20 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\UpdateSchool.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(614, 77, true);
            WriteLiteral("            <input type=\"submit\" class=\"btn btn-primary\" value=\"Sačuvaj\" />\r\n");
            EndContext();
#line 22 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\UpdateSchool.cshtml"
         }

#line default
#line hidden
            BeginContext(703, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(744, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(751, 59, false);
#line 28 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\UpdateSchool.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(810, 3, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ELearningApp.Models.School> Html { get; private set; }
    }
}
#pragma warning restore 1591
