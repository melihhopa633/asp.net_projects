#pragma checksum "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Shared\Components\_TopAddressPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec648f3ba25e60ca8c0954038b60cda2efeda1f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TopAddressPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TopAddressPartial/Default.cshtml")]
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
#line 1 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\_ViewImports.cshtml"
using AgricultureUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\_ViewImports.cshtml"
using AgricultureUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Shared\Components\_TopAddressPartial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec648f3ba25e60ca8c0954038b60cda2efeda1f0", @"/Views/Shared/Components/_TopAddressPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c879fa2ec19a6d1bee9947da469a80266efc7a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TopAddressPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Address>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"w3l_header_left\">\r\n");
#nullable restore
#line 6 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Shared\Components\_TopAddressPartial\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n            <li><span class=\"glyphicon glyphicon-map-marker\" aria-hidden=\"true\"></span>");
#nullable restore
#line 9 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Shared\Components\_TopAddressPartial\Default.cshtml"
                                                                                  Write(item.Description3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><span class=\"glyphicon glyphicon-earphone\" aria-hidden=\"true\"></span>");
#nullable restore
#line 10 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Shared\Components\_TopAddressPartial\Default.cshtml"
                                                                                Write(item.Description4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><span class=\"glyphicon glyphicon-envelope\" aria-hidden=\"true\"></span> <a href=\"mailto:info@example.com\">");
#nullable restore
#line 11 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Shared\Components\_TopAddressPartial\Default.cshtml"
                                                                                                                   Write(item.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n        </ul>\r\n");
#nullable restore
#line 13 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Shared\Components\_TopAddressPartial\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Address>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
