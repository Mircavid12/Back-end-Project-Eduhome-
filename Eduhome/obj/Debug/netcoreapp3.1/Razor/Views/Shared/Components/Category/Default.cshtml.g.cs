#pragma checksum "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79eed03a668186248839f7f64096091cf77579d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79eed03a668186248839f7f64096091cf77579d6", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b552d45505e801bfad2a92865142ab4761a164bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categories>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Shared\Components\Category\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"single-blog-widget mb-50\">\r\n    <h3>categories</h3>\r\n    <ul>\r\n");
#nullable restore
#line 9 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Shared\Components\Category\Default.cshtml"
         foreach (Categories c in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a href=\"#\">");
#nullable restore
#line 11 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Shared\Components\Category\Default.cshtml"
                       Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 11 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Shared\Components\Category\Default.cshtml"
                                Write(c.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a></li>\r\n");
#nullable restore
#line 12 "C:\Users\Power Electronics\source\repos\Eduhome\Back-end-Project-Eduhome-\Eduhome\Views\Shared\Components\Category\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categories>> Html { get; private set; }
    }
}
#pragma warning restore 1591