#pragma checksum "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea7925242f9286c445330cd03b4c17e1fbf45f67"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea7925242f9286c445330cd03b4c17e1fbf45f67", @"/Views/Courses/CreateCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785ad00e7bb8a6dc301ae3fe11dae786cf54b7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_CreateCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningApp.ViewModels.CourseCategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Dodaj kurs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(151, 70, true);
            WriteLiteral("\r\n<h2>Dodaj kurs</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4\">\r\n");
            EndContext();
#line 10 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
         using (Html.BeginForm("CreateCourse", "Courses"))
        {

#line default
#line hidden
            BeginContext(292, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(347, 33, false);
#line 13 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.LabelFor(c => c.Course.Name));

#line default
#line hidden
            EndContext();
            BeginContext(380, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(399, 68, false);
#line 14 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.TextBoxFor(c => c.Course.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(467, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(486, 45, false);
#line 15 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Course.Name));

#line default
#line hidden
            EndContext();
            BeginContext(531, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(608, 33, false);
#line 18 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.LabelFor(c => c.Course.Link));

#line default
#line hidden
            EndContext();
            BeginContext(641, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(660, 68, false);
#line 19 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.TextBoxFor(c => c.Course.Link, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(728, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(747, 45, false);
#line 20 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Course.Link));

#line default
#line hidden
            EndContext();
            BeginContext(792, 60, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1253, 74, true);
            WriteLiteral("            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1328, 40, false);
#line 31 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.LabelFor(c => c.Course.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1387, 76, false);
#line 32 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.TextAreaFor(c => c.Course.Description, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1482, 52, false);
#line 33 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Course.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1611, 35, false);
#line 36 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.LabelFor(c => c.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1646, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1665, 71, false);
#line 37 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.TextAreaFor(c => c.Category.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1736, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1755, 47, false);
#line 38 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1802, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(1839, 32, false);
#line 41 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
       Write(Html.HiddenFor(c => c.Course.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1886, 23, false);
#line 42 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1911, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1923, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0774d43494e465bb8cd27f35522344c", async() => {
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
#line 43 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
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
            BeginContext(2085, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
        }

#line default
#line hidden
            BeginContext(2098, 36, true);
            WriteLiteral("        <hr />\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2153, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2160, 59, false);
#line 50 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(2219, 3, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ELearningApp.ViewModels.CourseCategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
