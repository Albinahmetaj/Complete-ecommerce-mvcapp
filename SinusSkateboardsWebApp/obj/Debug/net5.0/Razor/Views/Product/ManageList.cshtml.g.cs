#pragma checksum "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd707314d2131fa33ce63c66bd32344ff5fdb061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ManageList), @"mvc.1.0.view", @"/Views/Product/ManageList.cshtml")]
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
#line 1 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\_ViewImports.cshtml"
using SinusSkateboardsWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\_ViewImports.cshtml"
using SinusSkateboardsWebApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd707314d2131fa33ce63c66bd32344ff5fdb061", @"/Views/Product/ManageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d4dd3511b050b74510d7f094aba83b95d8c949", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ManageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Edit items</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd707314d2131fa33ce63c66bd32344ff5fdb0614749", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 8 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
           Write(Html.DisplayNameFor(model => model.Photopath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
           Write(Html.DisplayNameFor(model => model.Titel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
           Write(Html.DisplayNameFor(model => model.ColorCategory.ColorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
           Write(Html.DisplayNameFor(model => model.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
           Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n\r\n");
#nullable restore
#line 34 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd707314d2131fa33ce63c66bd32344ff5fdb0619642", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1199, "~/Images/", 1199, 9, true);
#nullable restore
#line 41 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
AddHtmlAttributeValue("", 1208, item.Photopath, 1208, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Titel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ColorCategory.ColorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd707314d2131fa33ce63c66bd32344ff5fdb06113306", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
                                                                           WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Albin\source\repos\zocom-albin-karlsson\sinus-skateboards-Albinahmetaj\SinusSkateboardsWebApp\Views\Product\ManageList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591