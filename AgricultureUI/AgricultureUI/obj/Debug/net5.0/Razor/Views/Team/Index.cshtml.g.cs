#pragma checksum "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c4b5aa61cab1d506aa03e30424fa017772dd4b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
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
#line 1 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c4b5aa61cab1d506aa03e30424fa017772dd4b7", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c879fa2ec19a6d1bee9947da469a80266efc7a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Takım Arkadaşlarımızın Listesi</h4>

            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <td>#</td>
                            <td>ID</td>
                            <td>Ad</td>
                            <td>Görev</td>
                            <td>Sil</td>
                            <td>Düzenle</td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"py-1\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1020, "\"", 1040, 1);
#nullable restore
#line 31 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml"
WriteAttributeValue("", 1026, item.ImageURL, 1026, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" />\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml"
                           Write(item.TeamID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml"
                           Write(item.PersonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1283, "\"", 1319, 2);
            WriteAttributeValue("", 1290, "/Team/DeleteTeam/", 1290, 17, true);
#nullable restore
#line 36 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml"
WriteAttributeValue("", 1307, item.TeamID, 1307, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1400, "\"", 1434, 2);
            WriteAttributeValue("", 1407, "/Team/EditTeam/", 1407, 15, true);
#nullable restore
#line 37 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml"
WriteAttributeValue("", 1422, item.TeamID, 1422, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\melih\source\repos\AgricultureUI\AgricultureUI\Views\Team\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <br />\r\n                <a href=\"/Team/AddTeam\" class=\"btn btn-outline-info\">Yeni Takım Arkadaşı Girişi</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Team>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591