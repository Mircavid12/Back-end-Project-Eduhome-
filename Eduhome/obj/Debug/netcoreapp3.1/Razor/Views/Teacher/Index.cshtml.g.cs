#pragma checksum "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80bd9e2cff50ae599dff670965e58c0560fdc7ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Index), @"mvc.1.0.view", @"/Views/Teacher/Index.cshtml")]
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
#line 1 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\_ViewImports.cshtml"
using Eduhome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\_ViewImports.cshtml"
using Eduhome.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80bd9e2cff50ae599dff670965e58c0560fdc7ed", @"/Views/Teacher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b552d45505e801bfad2a92865142ab4761a164bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teachers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TeacherDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>our teachers</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-area pt-150 pb-105"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 27 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
             foreach (Teachers t in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-teacher mb-45\">\r\n                        <div class=\"single-teacher-img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bd9e2cff50ae599dff670965e58c0560fdc7ed6543", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80bd9e2cff50ae599dff670965e58c0560fdc7ed6759", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1074, "~/assets/img/teacher/", 1074, 21, true);
#nullable restore
#line 32 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
AddHtmlAttributeValue("", 1095, t.Image, 1095, 8, false);

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
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                                                                                     WriteLiteral(t.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"single-teacher-content text-center\">\r\n                            <h2>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bd9e2cff50ae599dff670965e58c0560fdc7ed10703", async() => {
#nullable restore
#line 35 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                                                                                                       Write(t.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                                                                                         WriteLiteral(t.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h2>\r\n                            <h4>");
#nullable restore
#line 36 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                           Write(t.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <ul>\r\n");
#nullable restore
#line 38 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                                 foreach (TeacherBios tb in t.TeacherBios.Take(1))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1602, "\"", 1612, 1);
#nullable restore
#line 40 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1609, tb, 1609, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1701, "\"", 1711, 1);
#nullable restore
#line 41 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1708, tb, 1708, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1801, "\"", 1811, 1);
#nullable restore
#line 42 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1808, tb, 1808, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1897, "\"", 1907, 1);
#nullable restore
#line 43 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
WriteAttributeValue("", 1904, tb, 1904, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-twitter\"></i></a></li>\r\n");
#nullable restore
#line 44 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 49 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row text-center\">\r\n            <nav aria-label=\"...\">\r\n                <ul class=\"pagination pagination-lg\">\r\n");
#nullable restore
#line 54 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                     for (int i = 1; i <= ViewBag.PageCount; i++)
                    {
                        if (i == ViewBag.page)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item active\" aria-current=\"page\">\r\n                                <span class=\"page-link\">");
#nullable restore
#line 59 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n");
#nullable restore
#line 61 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80bd9e2cff50ae599dff670965e58c0560fdc7ed18018", async() => {
#nullable restore
#line 67 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                                                  Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                                       WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 69 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Teacher\Index.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<!-- Teacher End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teachers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
