#pragma checksum "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1618eceaf20337e459b39294533ed35db9cd7c21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_CreateCourse), @"mvc.1.0.view", @"/Views/Courses/CreateCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/CreateCourse.cshtml", typeof(AspNetCore.Views_Courses_CreateCourse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1618eceaf20337e459b39294533ed35db9cd7c21", @"/Views/Courses/CreateCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785ad00e7bb8a6dc301ae3fe11dae786cf54b7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_CreateCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningApp.Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Dodaj kurs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllCourses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
  
    ViewData["Title"] = "CreateCourse";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 71, true);
            WriteLiteral("\r\n<h2>Dodaj kurs</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n");
            EndContext();
#line 10 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
         using (Html.BeginForm("CreateCourse", "Courses"))
        {

#line default
#line hidden
            BeginContext(272, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(327, 26, false);
#line 13 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.LabelFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(353, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(372, 28, false);
#line 14 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.TextBoxFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(400, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(419, 38, false);
#line 15 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(457, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(534, 26, false);
#line 18 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.LabelFor(c => c.Link));

#line default
#line hidden
            EndContext();
            BeginContext(560, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(579, 28, false);
#line 19 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.TextBoxFor(c => c.Link));

#line default
#line hidden
            EndContext();
            BeginContext(607, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(626, 38, false);
#line 20 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Link));

#line default
#line hidden
            EndContext();
            BeginContext(664, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(741, 33, false);
#line 23 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.LabelFor(c => c.Description));

#line default
#line hidden
            EndContext();
            BeginContext(774, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(793, 36, false);
#line 24 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.TextAreaFor(c => c.Description));

#line default
#line hidden
            EndContext();
            BeginContext(829, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(848, 45, false);
#line 25 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Description));

#line default
#line hidden
            EndContext();
            BeginContext(893, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(930, 25, false);
#line 28 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
       Write(Html.HiddenFor(c => c.Id));

#line default
#line hidden
            EndContext();
            BeginContext(970, 23, false);
#line 29 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(995, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1007, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc96dae46d2a4fe9b19a10c0c896b62d", async() => {
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
#line 30 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
                                          WriteLiteral(Url.Action("AllCourses", "Courses", new { area = "" }));

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
            BeginContext(1169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
        }

#line default
#line hidden
            BeginContext(1182, 80, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                ");
            EndContext();
            BeginContext(1262, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "013dbb0f377f46a7a69c0c82c605a7aa", async() => {
                BeginContext(1343, 5, true);
                WriteLiteral("Nazad");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1357, 58, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1432, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1439, 59, false);
#line 40 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(1498, 3, true);
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