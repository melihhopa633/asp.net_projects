#pragma checksum "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Address\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da806044645d6e2b581e70e66656bb7581b4d33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Address_Index), @"mvc.1.0.view", @"/Views/Address/Index.cshtml")]
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
#line 1 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Address\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da806044645d6e2b581e70e66656bb7581b4d33", @"/Views/Address/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c879fa2ec19a6d1bee9947da469a80266efc7a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Address_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Address>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Address\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Adres Listesi</h4>

            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <td>Açıklama 1</td>
                            <td>Açıklama 2</td>
                            <td>Açıklama 3</td>
                            <td>Açıklama 4</td>
                            <td>Düzenle</td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Address\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Address\Index.cshtml"
                           Write(item.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Address\Index.cshtml"
                           Write(item.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Address\Index.cshtml"
                           Write(item.Description3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Address\Index.cshtml"
                           Write(item.Description4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1173, "\"", 1216, 2);
            WriteAttributeValue("", 1180, "/Address/EditAddress/", 1180, 21, true);
#nullable restore
#line 33 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Address\Index.cshtml"
WriteAttributeValue("", 1201, item.AddressID, 1201, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 35 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Address\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <br />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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