#pragma checksum "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Brand\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "805933d89d915e6f1ee4f8e5c201c85736a69fa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Brand_Update), @"mvc.1.0.view", @"/Areas/Admin/Views/Brand/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805933d89d915e6f1ee4f8e5c201c85736a69fa8", @"/Areas/Admin/Views/Brand/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93cd73e22661835ed154ed49500e68bec43e2d70", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Brand_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BrandVM>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Brand\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""contact-img-area"" style=""background-size:cover"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 text-center"">
                <div class=""con-text"">
                    <h2 class=""page-title"">Update</h2>
                    <p><a href=""#"">Brand</a> Brand Update</p>
                </div>
            </div>
        </div>
    </div>
</div>
");
            WriteLiteral(@"<div id=""alert""></div>
<section class=""login-area section-padding-100"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-12 col-lg-8"">
                <div class=""login-content"">
                    <h3>Brand Update</h3>
                    <!-- Update Form -->
                    <div class=""login-form"" style=""margin-bottom:30px"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805933d89d915e6f1ee4f8e5c201c85736a69fa84314", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <label>CompanyName</label>
                                <input type=""text"" id=""CompanyName"" class=""form-control"" placeholder=""Fill in blank"">
                            </div>
                            <div class=""form-group"">
                                <label>Description</label>
                                <input type=""text"" id=""Description"" class=""form-control"" placeholder=""Fill in blank"">
                            </div>
                            <div class=""form-group"">
                                <label>IsActive</label>
                                <input type=""checkbox"" id=""IsActive"">
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <button onclick=\"updatebtn()\" type=\"submit\" class=\"btn btn-primary mt-30\">Update</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    $(document).ready(function () {\r\n        var id =");
#nullable restore
#line 53 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Brand\Update.cshtml"
           Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:52607/api/Brand/GetBrandByID/"" + id,
                success: function (response)
                {
                    console.log(response)
                    $(""#CompanyName"").val(response.companyName);
                    $(""#Description"").val(response.description);
                    $(""#IsActive"").attr('checked', response.isActive);
                }
            })
    })
        function updatebtn() {
            var checkBox = document.getElementById(""IsActive"");
            var brand = new Object();
            brand.BrandID =");
#nullable restore
#line 69 "C:\Users\Emincan\source\repos\Peach-Proje\Peach.UI.MVC\Areas\Admin\Views\Brand\Update.cshtml"
                      Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            brand.CompanyName = $(""#CompanyName"").val();
            brand.Description = $(""#Description"").val();
            brand.IsActive = checkBox.checked;
            console.log(brand)
                $.ajax({
                type: ""POST"",
                    url: ""http://localhost:52607/api/Brand/UpdateBrand"",
                    data: JSON.stringify(brand),
                    contentType: ""application/json; charset=utf-8"",
                    success: function (response) {
                        if (response.check == true) {
                            $(""#alert"").html(""<div class='alert alert-success' role='alert'>"" + response.message + ""</div>"")
                        } else {
                            $(""#alert"").html(""<div class='alert alert-danger' role='alert'>"" + response.message + ""</div>"")
                        }
                    }
            })
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BrandVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
