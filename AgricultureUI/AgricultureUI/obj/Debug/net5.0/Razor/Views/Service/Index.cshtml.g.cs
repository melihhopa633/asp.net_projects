#pragma checksum "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d732a36039b6fa30e5a7760c7dfed56c2b818661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Service\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d732a36039b6fa30e5a7760c7dfed56c2b818661", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c879fa2ec19a6d1bee9947da469a80266efc7a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Hizmet Listesi</h4>
            <p class=""card-description"">

            </p>
            <div class=""table-responsive pt-3"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Service\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Service\Index.cshtml"
                           Write(item.ServiceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Service\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1046, "\"", 1091, 2);
            WriteAttributeValue("", 1053, "/Service/DeleteService/", 1053, 23, true);
#nullable restore
#line 31 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Service\Index.cshtml"
WriteAttributeValue("", 1076, item.ServiceID, 1076, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1172, "\"", 1215, 2);
            WriteAttributeValue("", 1179, "/Service/EditService/", 1179, 21, true);
#nullable restore
#line 32 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Service\Index.cshtml"
WriteAttributeValue("", 1200, item.ServiceID, 1200, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Service\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <a href=\"/Service/AddService/\" class=\"btn btn-outline-info\">Yeni Hizmet Girişi</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
