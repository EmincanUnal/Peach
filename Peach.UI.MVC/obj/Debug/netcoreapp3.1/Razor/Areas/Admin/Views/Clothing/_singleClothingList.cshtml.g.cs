#pragma checksum "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "179450bca1886e8ac2e09c6a3fd2cd191becc545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Clothing__singleClothingList), @"mvc.1.0.view", @"/Areas/Admin/Views/Clothing/_singleClothingList.cshtml")]
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
#line 1 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\_ViewImports.cshtml"
using Peach.UI.MVC.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179450bca1886e8ac2e09c6a3fd2cd191becc545", @"/Areas/Admin/Views/Clothing/_singleClothingList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93cd73e22661835ed154ed49500e68bec43e2d70", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Clothing__singleClothingList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClothingVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Clothing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<table class=""data-table cart-table"">
    <thead>
        <tr>
            <th> Image</th>
            <th>Name</th>
            <th>Stock</th>
            <th>Price</th>
            <th>CompanyName</th>
            <th>CategoryName</th>
            <th>Continued</th>
            <th>Discount</th>
            <th>CreatedDate</th>
            <th>İsActive</th>
            <th colspan=""2""><button class=""btn btn-primary"">Add</button></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
         foreach (ClothingVM item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 611, "\"", 642, 2);
            WriteAttributeValue("", 617, "../..", 617, 5, true);
#nullable restore
#line 22 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
WriteAttributeValue("", 622, item.ClothingArtUrl, 622, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 643, "\"", 649, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:20px ;height:30px\" /></td>\r\n            <td><span>");
#nullable restore
#line 23 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td><span>");
#nullable restore
#line 24 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                 Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td><span>");
#nullable restore
#line 25 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td><span>");
#nullable restore
#line 26 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                 Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td><span>");
#nullable restore
#line 27 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                 Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td><span>");
#nullable restore
#line 28 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                 Write(item.Continued);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td><span>");
#nullable restore
#line 29 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                 Write(item.DisCounted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td><span>");
#nullable restore
#line 30 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                 Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td><span>");
#nullable restore
#line 31 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                 Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "179450bca1886e8ac2e09c6a3fd2cd191becc5458837", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                                                                                                         WriteLiteral(item.ClothingID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 36 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                 if (!item.IsActive)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button href=\"#\" style=\"border-style:none\" disabled class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1513, "\"", 1560, 4);
            WriteAttributeValue("", 1523, "DeleteClothingById", 1523, 18, true);
            WriteAttributeValue(" ", 1541, "(", 1542, 2, true);
#nullable restore
#line 38 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
WriteAttributeValue("", 1543, item.ClothingID, 1543, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1559, ")", 1559, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n");
#nullable restore
#line 39 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button style=\"border-style:none\" href=\"#\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1725, "\"", 1771, 3);
            WriteAttributeValue("", 1735, "DeleteClothingById(", 1735, 19, true);
#nullable restore
#line 42 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
WriteAttributeValue("", 1754, item.ClothingID, 1754, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1770, ")", 1770, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n");
#nullable restore
#line 43 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\_singleClothingList.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClothingVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591