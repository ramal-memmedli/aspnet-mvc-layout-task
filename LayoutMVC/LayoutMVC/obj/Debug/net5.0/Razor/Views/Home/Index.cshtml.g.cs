#pragma checksum "C:\Users\Ramal\Desktop\Desktop\programming\ASP.NET Projects\LayoutMVC\LayoutMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b27ccace8d9ae822068857c9709d9012d9b05d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LayoutMVC.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace LayoutMVC.Views.Home
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
#line 4 "C:\Users\Ramal\Desktop\Desktop\programming\ASP.NET Projects\LayoutMVC\LayoutMVC\Views\_ViewImports.cshtml"
using LayoutMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b27ccace8d9ae822068857c9709d9012d9b05d7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9db8c745da969b0ab01cf27743ce8e66806a6c0f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mountain>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n        <section class=\"container my-3\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\Ramal\Desktop\Desktop\programming\ASP.NET Projects\LayoutMVC\LayoutMVC\Views\Home\Index.cshtml"
                 for (int i = 0; i < @Model.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4\">\r\n                        <div class=\"card my-2\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 300, "\"", 324, 1);
#nullable restore
#line 9 "C:\Users\Ramal\Desktop\Desktop\programming\ASP.NET Projects\LayoutMVC\LayoutMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 306, Model[i].ImageUrl, 306, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" style=\"aspect-ratio: 16/9\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\Ramal\Desktop\Desktop\programming\ASP.NET Projects\LayoutMVC\LayoutMVC\Views\Home\Index.cshtml"
                                                  Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"card-text\">Location - ");
#nullable restore
#line 12 "C:\Users\Ramal\Desktop\Desktop\programming\ASP.NET Projects\LayoutMVC\LayoutMVC\Views\Home\Index.cshtml"
                                                           Write(Model[i].Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>Height - ");
#nullable restore
#line 12 "C:\Users\Ramal\Desktop\Desktop\programming\ASP.NET Projects\LayoutMVC\LayoutMVC\Views\Home\Index.cshtml"
                                                                                          Write(Model[i].Height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 656, "\"", 693, 2);
            WriteAttributeValue("", 663, "/home/carddetails/", 663, 18, true);
#nullable restore
#line 13 "C:\Users\Ramal\Desktop\Desktop\programming\ASP.NET Projects\LayoutMVC\LayoutMVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 681, Model[i].Id, 681, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Go Details</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 17 "C:\Users\Ramal\Desktop\Desktop\programming\ASP.NET Projects\LayoutMVC\LayoutMVC\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mountain>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
