#pragma checksum "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb90e7f9d71113e79051d7a5fe3b7827cf656442"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb90e7f9d71113e79051d7a5fe3b7827cf656442", @"/Views/Courses/CreateCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785ad00e7bb8a6dc301ae3fe11dae786cf54b7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_CreateCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningApp.Models.Course>
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
            BeginContext(130, 70, true);
            WriteLiteral("\r\n<h2>Dodaj kurs</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4\">\r\n");
            EndContext();
#line 10 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
         using (Html.BeginForm("CreateCourse", "Courses"))
        {

#line default
#line hidden
            BeginContext(271, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(326, 26, false);
#line 13 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.LabelFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(352, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(371, 60, false);
#line 14 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.TextBoxFor(c => c.Name, new { @class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(431, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(450, 38, false);
#line 15 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(488, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(565, 26, false);
#line 18 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.LabelFor(c => c.Link));

#line default
#line hidden
            EndContext();
            BeginContext(591, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(610, 61, false);
#line 19 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.TextBoxFor(c => c.Link, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(671, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(690, 38, false);
#line 20 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Link));

#line default
#line hidden
            EndContext();
            BeginContext(728, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(805, 33, false);
#line 23 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.LabelFor(c => c.Description));

#line default
#line hidden
            EndContext();
            BeginContext(838, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(857, 69, false);
#line 24 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.TextAreaFor(c => c.Description, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(926, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(945, 45, false);
#line 25 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
           Write(Html.ValidationMessageFor(c => c.Description));

#line default
#line hidden
            EndContext();
            BeginContext(990, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(1027, 25, false);
#line 28 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
       Write(Html.HiddenFor(c => c.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 23, false);
#line 29 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1092, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1104, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9fa0c5b02b8c4a33b48bdac2eeee98fe", async() => {
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
            BeginContext(1266, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
        } 

#line default
#line hidden
            BeginContext(1280, 36, true);
            WriteLiteral("        <hr />\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1333, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1340, 59, false);
#line 36 "C:\Users\Johny\Desktop\Sol_ELearningApp\ELearningApp\Views\Courses\CreateCourse.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(1399, 3, true);
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
