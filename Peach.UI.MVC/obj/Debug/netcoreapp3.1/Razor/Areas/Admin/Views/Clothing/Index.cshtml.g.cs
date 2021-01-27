#pragma checksum "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdf9d029d1d2b80154233b626717bf7499b0a975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Clothing_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Clothing/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdf9d029d1d2b80154233b626717bf7499b0a975", @"/Areas/Admin/Views/Clothing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93cd73e22661835ed154ed49500e68bec43e2d70", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Clothing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Clothing\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<div class=""contact-img-area"" style=""background-size:cover"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 text-center"">
                <div class=""con-text"">
                    <h2 class=""page-title"">Details</h2>
                    <p><a href=""#"">Clothing</a> Clothing Details</p>
                </div>
            </div>
        </div>
    </div>
</div>
");
            WriteLiteral(@"<div>
    <div class=""container-fluid mt-30 mb-50"">
        <div class=""row"">
            <div class="" col-md-12"">
                <section class=""pages products-page section-padding-top"">
                    <div class=""col-md-1"">
                        <div class=""all-shop-sidebar"">
                            <div class=""top-shop-sidebar"">
                                <h3 class=""wg-title"">SHOP BY</h3>
                            </div>
                            <div class=""shop-one"" id=""categoryfilters"">
                                categoriler gelecek
                            </div>
                            <br />
                            <div class=""shop-one"" id=""brandfilters"">
                                brandler gelecek
                            </div>
                        </div>
                    </div>
                </section>

                <div class=""col-md-11"">
                    <div class="" ml-30 mr-30"">
                        <div id=""a");
            WriteLiteral("lert\">\r\n\r\n                        </div>\r\n                        <div class=\"table-content table-responsive\">\r\n                            <div id=\"clothingList\">\r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            GetClothingListAll()

            $.ajax({
                type: ""GET"",
                url: ""http://localhost:52607/api/Brand/GetBrandActive"",
                success: function (response) {
                    $.ajax({
                        type: ""POST"",
                        url: ""http://localhost:52719/Admin/Clothing/GetBrandFilters"",
                        contentType: ""application/json; charset=utf-8"",
                        data: JSON.stringify(response),
                        success: function (data) {
                            $(""#brandfilters"").html(data)
                        }
                    })
                }
            })
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:52607/api/Category/GetCategoryActive"",
                success: function (response) {
                    $.ajax({
                        type: ""POST"",
                        url");
                WriteLiteral(@": ""http://localhost:52719/Admin/Clothing/GetCategoryFilters"",
                        contentType: ""application/json; charset=utf-8"",
                        data: JSON.stringify(response),
                        success: function (data) {
                            $(""#categoryfilters"").html(data)
                        }
                    })
                }
            })
        })
        //Markalarına göre ürünleri listelemek için olusturdugum ajaxtır
        function GetClothingByBrand(id) {
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:52607/api/Clothing/GetClothingListBrand/"" + id,
                success: function (response) {
                    $.ajax({
                        type: ""POST"",
                        url: ""http://localhost:52719/Admin/Clothing/GetClothingList"",
                        contentType: ""application/json; charset=utf-8"",
                        data: JSON.stringify(response),
                        succ");
                WriteLiteral(@"ess: function (data) {
                            $(""#clothingList"").html(data)
                        }
                    })
                }
            })
        }
        //Kategorisine göre ürünleri listelemek için olusturdugum ajaxtır
        function GetClothingByCategory(cid) {
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:52607/api/Clothing/GetClothingByCategory/"" + cid,
                success: function (response) {
                    $.ajax({
                        type: ""POST"",
                        url: ""http://localhost:52719/Admin/Clothing/GetClothingList"",
                        contentType: ""application/json; charset=utf-8"",
                        data: JSON.stringify(response),
                        success: function (data) {
                            $(""#clothingList"").html(data)
                        }
                    })
                }
            })
        }
        //Tüm ürünleri listelemek için");
                WriteLiteral(@" oluşturdugum ajaxtır
        function GetClothingListAll() {
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:52607/api/Clothing/GetClothing"",
                success: function (response) {
                    console.log(response)
                    $.ajax({
                        type: ""POST"",
                        url: ""http://localhost:52719/Admin/Clothing/GetClothingList"",
                        contentType: ""application/json; charset=utf-8"",
                        data: JSON.stringify(response),
                        success: function (data) {
                            $(""#clothingList"").html(data)
                        }
                    })
                }
            })
        }
        function DeleteClothingById(clid) {
            var cvp = confirm(""Are you sure delete a clothing?"")

            if (cvp) {
                $.ajax({

                    type: ""GET"",
                    url: ""http://localhost:52607/ap");
                WriteLiteral(@"i/Clothing/DeleteClothingById/"" + clid,
                    success: function (data) {
                        if (cvp) {
                            alert(data.message)
                            location.reload();
                        }
                    }

                })
            }
        }

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591