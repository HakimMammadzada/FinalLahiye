#pragma checksum "C:\Users\User\Desktop\proje\FurnitureProject\FurnitureProject\Views\Shared\Components\Card\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc145dc7093bdea59969f0ba4f9f112ef16e856"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Card_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Card/Default.cshtml")]
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
#line 1 "C:\Users\User\Desktop\proje\FurnitureProject\FurnitureProject\Views\_ViewImports.cshtml"
using FurnitureProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\proje\FurnitureProject\FurnitureProject\Views\_ViewImports.cshtml"
using FurnitureProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc145dc7093bdea59969f0ba4f9f112ef16e856", @"/Views/Shared/Components/Card/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f7dc27b6825caaef6a4fb74584d06be1e3e8159", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Card_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FurnitureProject.Data.Entities.BasketProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"shopping-cart-wrap\" style=\"font-size: 25px; left: 38%; bottom: 52%;\">\r\n        <a href=\"#\"><i class=\"icon-handbag\"></i> <span id=\"cart-total\"></span></a>\r\n        <ul class=\"mini-cart\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\proje\FurnitureProject\FurnitureProject\Views\Shared\Components\Card\Default.cshtml"
             foreach (var product in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"cart-item\">\r\n                    <div class=\"cart-image\">\r\n                        <a href=\"single-product.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5cc145dc7093bdea59969f0ba4f9f112ef16e8564267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 493, "~/images/product/", 493, 17, true);
#nullable restore
#line 12 "C:\Users\User\Desktop\proje\FurnitureProject\FurnitureProject\Views\Shared\Components\Card\Default.cshtml"
AddHtmlAttributeValue("", 510, product.Mainimage, 510, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"cart-title\">\r\n                        <a href=\"single-product.html\"><h4>");
#nullable restore
#line 15 "C:\Users\User\Desktop\proje\FurnitureProject\FurnitureProject\Views\Shared\Components\Card\Default.cshtml"
                                                     Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\r\n                        <span class=\"quantity\">");
#nullable restore
#line 16 "C:\Users\User\Desktop\proje\FurnitureProject\FurnitureProject\Views\Shared\Components\Card\Default.cshtml"
                                          Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <div class=\"price-box\"><span class=\"new-price\">$");
#nullable restore
#line 17 "C:\Users\User\Desktop\proje\FurnitureProject\FurnitureProject\Views\Shared\Components\Card\Default.cshtml"
                                                                   Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                        <a class=\"remove_from_cart\" href=\"#\"><i class=\"icon-trash icons\"></i></a>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 21 "C:\Users\User\Desktop\proje\FurnitureProject\FurnitureProject\Views\Shared\Components\Card\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"subtotal-titles\">\r\n                <div class=\"subtotal-titles\"><h3>Sub-Total :</h3><span>$ 230.99</span></div>\r\n            </li>\r\n");
            WriteLiteral("        </ul>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FurnitureProject.Data.Entities.BasketProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
