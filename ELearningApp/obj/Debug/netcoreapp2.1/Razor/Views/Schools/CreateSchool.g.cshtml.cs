#pragma checksum "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ce8a31ed519e0cdd5f8bec6f558d1c8bb5c3de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schools_CreateSchool), @"mvc.1.0.view", @"/Views/Schools/CreateSchool.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Schools/CreateSchool.cshtml", typeof(AspNetCore.Views_Schools_CreateSchool))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2ce8a31ed519e0cdd5f8bec6f558d1c8bb5c3de", @"/Views/Schools/CreateSchool.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785ad00e7bb8a6dc301ae3fe11dae786cf54b7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Schools_CreateSchool : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningApp.ViewModels.SchoolCourseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml"
  
    ViewData["Title"] = "CreateSchool";
    Layout = "~/Views/Shared/_DataTablesLayoutPartial.cshtml";

#line default
#line hidden
            BeginContext(166, 79, true);
            WriteLiteral("\r\n<h2>Dodaj školu</h2>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4\">\r\n");
            EndContext();
#line 11 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml"
         using (Html.BeginForm("CreateSchool", "Schools"))
        {

#line default
#line hidden
            BeginContext(316, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(371, 33, false);
#line 14 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml"
           Write(Html.LabelFor(s => s.School.Name));

#line default
#line hidden
            EndContext();
            BeginContext(404, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(423, 68, false);
#line 15 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml"
           Write(Html.TextBoxFor(s => s.School.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(491, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(510, 45, false);
#line 16 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml"
           Write(Html.ValidationMessageFor(s => s.School.Name));

#line default
#line hidden
            EndContext();
            BeginContext(555, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(590, 32, false);
#line 18 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml"
       Write(Html.HiddenFor(s => s.School.Id));

#line default
#line hidden
            EndContext();
            BeginContext(637, 23, false);
#line 19 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(662, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(674, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb71919f04614ddbb34eb862a0128489", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml"
                                          WriteLiteral(Url.Action("AllSchools", "Schools", new { area = "" }));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(832, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml"
        }

#line default
#line hidden
            BeginContext(845, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(884, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(891, 59, false);
#line 26 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Schools\CreateSchool.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(950, 3, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ELearningApp.ViewModels.SchoolCourseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
