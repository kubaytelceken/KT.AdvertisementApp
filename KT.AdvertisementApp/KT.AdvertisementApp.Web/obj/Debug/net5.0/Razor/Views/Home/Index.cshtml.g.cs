#pragma checksum "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9837c3d53e736f274b9900d5371756f5df0fa8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\_ViewImports.cshtml"
using KT.AdvertisementApp.Dtos.ProvidedServiceDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\_ViewImports.cshtml"
using KT.AdvertisementApp.Dtos.AdvertisementDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9837c3d53e736f274b9900d5371756f5df0fa8a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a50a49cb874d0c8e9c49eaac99d0693c67320ef1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProvidedServiceListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""masthead text-center text-white"">
    <div class=""masthead-content"">
        <div class=""container px-5"">
            <h1 class=""masthead-heading mb-0"">Advertisement App</h1>
            <h2 class=""masthead-subheading mb-0"">Desktop , Web And Mobile Apps</h2>
            <a class=""btn btn-primary btn-xl rounded-pill mt-5"" href=""#scroll"">Learn More</a>
        </div>
    </div>
    <div class=""bg-circle-1 bg-circle""></div>
    <div class=""bg-circle-2 bg-circle""></div>
    <div class=""bg-circle-3 bg-circle""></div>
    <div class=""bg-circle-4 bg-circle""></div>
</header>
");
#nullable restore
#line 19 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\Index.cshtml"
 for (int i = 0; i < Model?.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"scroll\">\r\n        <div class=\"container px-5\">\r\n            <div class=\"row gx-5 align-items-center\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 856, "\"", 898, 2);
            WriteAttributeValue("", 864, "col-lg-6", 864, 8, true);
#nullable restore
#line 24 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 872, i%2==0?"order-lg-2":"", 873, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"p-5\"><img class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 976, "\"", 1001, 1);
#nullable restore
#line 25 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 982, Model[i].ImagePath, 982, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" /></div>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1067, "\"", 1109, 2);
            WriteAttributeValue("", 1075, "col-lg-6", 1075, 8, true);
#nullable restore
#line 27 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1083, i%2==0?"order-lg-1":"", 1084, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"p-5\">\r\n                        <h2 class=\"display-4\">");
#nullable restore
#line 29 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\Index.cshtml"
                                         Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>");
#nullable restore
#line 30 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\Index.cshtml"
                      Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 36 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProvidedServiceListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
