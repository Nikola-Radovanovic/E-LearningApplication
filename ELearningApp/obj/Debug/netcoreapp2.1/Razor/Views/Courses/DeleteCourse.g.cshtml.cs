#pragma checksum "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\DeleteCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64edd4a28cf5f6e0d9951fbc1fd9ad641aa71778"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_DeleteCourse), @"mvc.1.0.view", @"/Views/Courses/DeleteCourse.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/DeleteCourse.cshtml", typeof(AspNetCore.Views_Courses_DeleteCourse))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64edd4a28cf5f6e0d9951fbc1fd9ad641aa71778", @"/Views/Courses/DeleteCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785ad00e7bb8a6dc301ae3fe11dae786cf54b7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_DeleteCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ELearningApp.Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\DeleteCourse.cshtml"
  
    ViewData["Title"] = "DeleteCourse";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 115, true);
            WriteLiteral("\r\n<h3>Da li ste sigurni da želite da izbrišete kurs?</h3>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n");
            EndContext();
#line 11 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\DeleteCourse.cshtml"
         using (Html.BeginForm("DeleteCourse", "Courses"))
        {
            

#line default
#line hidden
            BeginContext(329, 25, false);
#line 13 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\DeleteCourse.cshtml"
       Write(Html.HiddenFor(c => c.Id));

#line default
#line hidden
            EndContext();
            BeginContext(356, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(368, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e6545dbfec3452a969df5ffda4a2953", async() => {
                BeginContext(400, 92, true);
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(499, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\Milica\Desktop\E-LearningApplication\ELearningApp\Views\Courses\DeleteCourse.cshtml"
        }

#line default
#line hidden
            BeginContext(512, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
