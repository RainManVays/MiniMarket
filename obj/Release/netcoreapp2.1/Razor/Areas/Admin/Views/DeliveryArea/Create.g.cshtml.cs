#pragma checksum "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\DeliveryArea\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da5a63ac28a35f8ad83930c40db431927afde955"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DeliveryArea_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/DeliveryArea/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/DeliveryArea/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_DeliveryArea_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da5a63ac28a35f8ad83930c40db431927afde955", @"/Areas/Admin/Views/DeliveryArea/Create.cshtml")]
    public class Areas_Admin_Views_DeliveryArea_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MiniMarket.Models.DeliveryArea>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\DeliveryArea\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(83, 241, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n<h4>DeliveryArea</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <form asp-action=\"Create\" method=\"post\">\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n            ");
            EndContext();
            BeginContext(325, 23, false);
#line 15 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\DeliveryArea\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(348, 98, true);
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label asp-for=\"Id\" class=\"control-label\">");
            EndContext();
            BeginContext(447, 30, false);
#line 17 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\DeliveryArea\Create.cshtml"
                                                     Write(Html.DisplayNameFor(x => x.Id));

#line default
#line hidden
            EndContext();
            BeginContext(477, 274, true);
            WriteLiteral(@"</label>
                <input asp-for=""Id"" name=""Id"" class=""form-control"" />
                <span asp-validation-for=""Id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label"">");
            EndContext();
            BeginContext(752, 32, false);
#line 22 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\DeliveryArea\Create.cshtml"
                                                       Write(Html.DisplayNameFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(784, 281, true);
            WriteLiteral(@"</label>
                <input asp-for=""Name"" name=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Image"" class=""control-label"">");
            EndContext();
            BeginContext(1066, 33, false);
#line 27 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\DeliveryArea\Create.cshtml"
                                                        Write(Html.DisplayNameFor(x => x.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 363, true);
            WriteLiteral(@"</label>
                <input asp-for=""Image"" class=""form-control"" />
                <span asp-validation-for=""Image"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <p>");
            EndContext();
            BeginContext(1463, 39, false);
#line 39 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\DeliveryArea\Create.cshtml"
  Write(Html.ActionLink("Back to list","Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 16, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MiniMarket.Models.DeliveryArea> Html { get; private set; }
    }
}
#pragma warning restore 1591
