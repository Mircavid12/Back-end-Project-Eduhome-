#pragma checksum "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13204dccd37cd5bafac4fa0d6e6600fcb18995b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EduAdmin_Views_Teacher_Detail), @"mvc.1.0.view", @"/Areas/EduAdmin/Views/Teacher/Detail.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\_ViewImports.cshtml"
using Eduhome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\_ViewImports.cshtml"
using Eduhome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\_ViewImports.cshtml"
using Eduhome.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13204dccd37cd5bafac4fa0d6e6600fcb18995b9", @"/Areas/EduAdmin/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b552d45505e801bfad2a92865142ab4761a164bd", @"/Areas/EduAdmin/Views/_ViewImports.cshtml")]
    public class Areas_EduAdmin_Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teachers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-6 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <div class=\"col-lg-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13204dccd37cd5bafac4fa0d6e6600fcb18995b95087", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 230, "~/assets/img/teacher/", 230, 21, true);
#nullable restore
#line 10 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 251, Model.Image, 251, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">Teacher Name: ");
#nullable restore
#line 14 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\Teacher\Detail.cshtml"
                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4 class=\"card-title\">Teacher Position: ");
#nullable restore
#line 15 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\Teacher\Detail.cshtml"
                                                        Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n            </div>\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">About Teacher:  ");
#nullable restore
#line 20 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\Teacher\Detail.cshtml"
                                                      Write(Model.TeacherDetails.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n            </div>\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">Degree: ");
#nullable restore
#line 25 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\Teacher\Detail.cshtml"
                                              Write(Model.TeacherDetails.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4 class=\"card-title\"> Experience: ");
#nullable restore
#line 26 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\Teacher\Detail.cshtml"
                                                   Write(Model.TeacherDetails.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4 class=\"card-title\"> Hobbies: ");
#nullable restore
#line 27 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\Teacher\Detail.cshtml"
                                                Write(Model.TeacherDetails.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4 class=\"card-title\"> Faculty: ");
#nullable restore
#line 28 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Areas\EduAdmin\Views\Teacher\Detail.cshtml"
                                                Write(Model.TeacherDetails.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13204dccd37cd5bafac4fa0d6e6600fcb18995b99880", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teachers> Html { get; private set; }
    }
}
#pragma warning restore 1591
