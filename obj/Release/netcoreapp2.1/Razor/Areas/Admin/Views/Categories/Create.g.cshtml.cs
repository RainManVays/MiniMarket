#pragma checksum "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\Categories\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28dd2374638344b2d555b3ce24ccd0daf1fdd41e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Categories/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_Categories_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28dd2374638344b2d555b3ce24ccd0daf1fdd41e", @"/Areas/Admin/Views/Categories/Create.cshtml")]
    public class Areas_Admin_Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MiniMarket.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\Categories\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(79, 211, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n<h4>Category</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <form  asp-action=\"Create\" asp-controller=\"Categories\" method=\"POST\" asp-anti-forgery=\"true\" >\r\n            ");
            EndContext();
            BeginContext(291, 23, false);
#line 14 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\Categories\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(314, 178, true);
            WriteLiteral("\r\n            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\r\n            <div class=\"form-group\">\r\n                <label asp-for=\"Id\" class=\"control-label\">");
            EndContext();
            BeginContext(493, 28, false);
#line 17 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\Categories\Create.cshtml"
                                                     Write(Html.DisplayNameFor(x=>x.Id));

#line default
#line hidden
            EndContext();
            BeginContext(521, 76, true);
            WriteLiteral("</label>\r\n                <input name=\"Id\" asp-for=\"Id\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 597, "\"", 614, 1);
#line 18 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\Categories\Create.cshtml"
WriteAttributeValue("", 605, Model.Id, 605, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(615, 198, true);
            WriteLiteral(" />\r\n                <span asp-validation-for=\"Id\" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label asp-for=\"Name\" class=\"control-label\">");
            EndContext();
            BeginContext(814, 32, false);
#line 22 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\Categories\Create.cshtml"
                                                       Write(Html.DisplayNameFor(x => x.Name));

#line default
#line hidden
            EndContext();
            BeginContext(846, 281, true);
            WriteLiteral(@"</label>
                <input name=""Name"" asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Image"" class=""control-label"">");
            EndContext();
            BeginContext(1128, 33, false);
#line 27 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\Categories\Create.cshtml"
                                                        Write(Html.DisplayNameFor(x => x.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 287, true);
            WriteLiteral(@"</label>
                <input name=""Image"" asp-for=""Image"" class=""form-control"" />
                <span asp-validation-for=""Image"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Discount"" class=""control-label"">");
            EndContext();
            BeginContext(1449, 36, false);
#line 32 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\Categories\Create.cshtml"
                                                           Write(Html.DisplayNameFor(x => x.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 336, true);
            WriteLiteral(@"</label>
                <input name=""Discount"" asp-for=""Discount"" class=""form-control"" />
                <span asp-validation-for=""Discount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""isVisible"" class=""control-label"">isVisible</label>
                    ");
            EndContext();
            BeginContext(1822, 34, false);
#line 38 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\Categories\Create.cshtml"
               Write(Html.CheckBoxFor(m => m.isVisible));

#line default
#line hidden
            EndContext();
            BeginContext(1856, 295, true);
            WriteLiteral(@"
                <span asp-validation-for=""isVisible"" class=""text-danger""></span>
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
            BeginContext(2152, 39, false);
#line 49 "C:\Users\LDF\Documents\GIT\MiniMarket\Areas\Admin\Views\Categories\Create.cshtml"
  Write(Html.ActionLink("Back to list","Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2191, 16, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MiniMarket.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
