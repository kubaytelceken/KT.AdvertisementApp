#pragma checksum "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0311f19991976e46e8b787a16ef1ad6c4778bf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HumanResource), @"mvc.1.0.view", @"/Views/Home/HumanResource.cshtml")]
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
#nullable restore
#line 4 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\_ViewImports.cshtml"
using KT.AdvertisementApp.Dtos.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\_ViewImports.cshtml"
using KT.AdvertisementApp.Dtos.GenderDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\_ViewImports.cshtml"
using KT.AdvertisementApp.Dtos.AdvertisementAppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\_ViewImports.cshtml"
using KT.AdvertisementApp.Dtos.AdvertisementAppUserStatusDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\_ViewImports.cshtml"
using KT.AdvertisementApp.Dtos.MilitaryStatusDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\_ViewImports.cshtml"
using KT.AdvertisementApp.Dtos.AppRoleDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\_ViewImports.cshtml"
using KT.AdvertisementApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\_ViewImports.cshtml"
using KT.AdvertisementApp.Common.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0311f19991976e46e8b787a16ef1ad6c4778bf3", @"/Views/Home/HumanResource.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a9801d5a3709b26bfaf94d130c0dc5117ad995", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HumanResource : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdvertisementListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Advertisement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Send", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"dummy mt-5\">\r\n\r\n</div>\r\n\r\n<div class=\"container my-3\">\r\n    <div class=\"accordion\" id=\"accordionExample\">\r\n\r\n");
#nullable restore
#line 13 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
         for (int i = 0; i < Model?.Count; i++)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"accordion-item\">\r\n                <h2 class=\"accordion-header\"");
            BeginWriteAttribute("id", " id=\"", 350, "\"", 375, 2);
            WriteAttributeValue("", 355, "heading-", 355, 8, true);
#nullable restore
#line 17 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 363, Model[i].Id, 363, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapse-");
#nullable restore
#line 18 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
                                                                                                                  Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("aria-expanded", " aria-expanded=\"", 511, "\"", 534, 1);
#nullable restore
#line 18 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 527, i==0, 527, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 535, "\"", 572, 2);
            WriteAttributeValue("", 551, "collapse-", 551, 9, true);
#nullable restore
#line 18 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 560, Model[i].Id, 560, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 19 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
                   Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </button>\r\n                </h2>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 691, "\"", 717, 2);
            WriteAttributeValue("", 696, "collapse-", 696, 9, true);
#nullable restore
#line 22 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 705, Model[i].Id, 705, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 718, "\"", 771, 3);
            WriteAttributeValue("", 726, "accordion-collapse", 726, 18, true);
            WriteAttributeValue(" ", 744, "collapse", 745, 9, true);
#nullable restore
#line 22 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
WriteAttributeValue(" ", 753, i==0?"show":"", 754, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 772, "\"", 810, 2);
            WriteAttributeValue("", 790, "heading-", 790, 8, true);
#nullable restore
#line 22 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
WriteAttributeValue("", 798, Model[i].Id, 798, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-parent=\"#accordionExample\">\r\n                    <div class=\"accordion-body\">\r\n                       ");
#nullable restore
#line 24 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
                  Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <p>\r\n");
#nullable restore
#line 27 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
                             if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0311f19991976e46e8b787a16ef1ad6c4778bf311107", async() => {
                WriteLiteral("Ba??vur");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-advertisementId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
                                                                   WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["advertisementId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-advertisementId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["advertisementId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-light text-center\">\r\n    Ba??vuru Yapabilmeniz ????in Giri?? Yapman??z Gerekmektedir. ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0311f19991976e46e8b787a16ef1ad6c4778bf313997", async() => {
                WriteLiteral("Giri?? Yap");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 36 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 42 "D:\Web\KT.AdvertisementApp\KT.AdvertisementApp.Web\Views\Home\HumanResource.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AdvertisementListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
