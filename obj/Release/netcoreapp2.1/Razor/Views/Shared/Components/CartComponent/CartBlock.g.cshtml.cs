#pragma checksum "C:\Users\LDF\Documents\GIT\MiniMarket\Views\Shared\Components\CartComponent\CartBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c496f6df7ddadf3cd919c3e2576dc0511f8a42de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartComponent_CartBlock), @"mvc.1.0.view", @"/Views/Shared/Components/CartComponent/CartBlock.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartComponent/CartBlock.cshtml", typeof(AspNetCore.Views_Shared_Components_CartComponent_CartBlock))]
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
#line 1 "C:\Users\LDF\Documents\GIT\MiniMarket\Views\_ViewImports.cshtml"
using MiniMarket;

#line default
#line hidden
#line 2 "C:\Users\LDF\Documents\GIT\MiniMarket\Views\_ViewImports.cshtml"
using MiniMarket.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c496f6df7ddadf3cd919c3e2576dc0511f8a42de", @"/Views/Shared/Components/CartComponent/CartBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a45bd8c1fac61c6de84d4c277f720d840cac8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartComponent_CartBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/card_fully.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/card_empty.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 51, true);
            WriteLiteral("<li class=\"nav-item\" style=\"margin-left:10px;\">\r\n\r\n");
            EndContext();
#line 3 "C:\Users\LDF\Documents\GIT\MiniMarket\Views\Shared\Components\CartComponent\CartBlock.cshtml"
     if (ViewBag.Order != null && ViewBag.Order.Items.Count>0)
    {

#line default
#line hidden
            BeginContext(122, 31, true);
            WriteLiteral("        <a class=\"navbar-brand\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 153, "\"", 188, 1);
#line 5 "C:\Users\LDF\Documents\GIT\MiniMarket\Views\Shared\Components\CartComponent\CartBlock.cshtml"
WriteAttributeValue("", 160, Url.Action("Index","Order"), 160, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(189, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(204, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b21d94fc2c264447ae83708cff6ca133", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(271, 23, true);
            WriteLiteral("\r\n        </a>\r\n       ");
            EndContext();
            BeginContext(296, 7, true);
            WriteLiteral("Сумма: ");
            EndContext();
            BeginContext(304, 17, false);
#line 8 "C:\Users\LDF\Documents\GIT\MiniMarket\Views\Shared\Components\CartComponent\CartBlock.cshtml"
           Write(ViewBag.OrderSumm);

#line default
#line hidden
            EndContext();
            BeginContext(321, 4, true);
            WriteLiteral(" р\r\n");
            EndContext();
#line 9 "C:\Users\LDF\Documents\GIT\MiniMarket\Views\Shared\Components\CartComponent\CartBlock.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(349, 31, true);
            WriteLiteral("        <a class=\"navbar-brand\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 380, "\"", 415, 1);
#line 12 "C:\Users\LDF\Documents\GIT\MiniMarket\Views\Shared\Components\CartComponent\CartBlock.cshtml"
WriteAttributeValue("", 387, Url.Action("Index","Order"), 387, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(416, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(431, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "025be226c5cb4452abdcba4faff03897", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(498, 16, true);
            WriteLiteral("\r\n        </a>\r\n");
            EndContext();
#line 15 "C:\Users\LDF\Documents\GIT\MiniMarket\Views\Shared\Components\CartComponent\CartBlock.cshtml"
    }

#line default
#line hidden
            BeginContext(521, 9, true);
            WriteLiteral("\r\n\r\n</li>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
