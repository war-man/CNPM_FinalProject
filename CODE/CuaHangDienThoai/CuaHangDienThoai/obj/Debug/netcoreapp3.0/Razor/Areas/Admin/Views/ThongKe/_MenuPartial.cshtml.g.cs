#pragma checksum "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e99a42016712b0a8273877ae5c39d4d6c5815a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ThongKe__MenuPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/ThongKe/_MenuPartial.cshtml")]
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
#line 1 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\_ViewImports.cshtml"
using CuaHangDienThoai;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
using CuaHangDienThoai.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
using CuaHangDienThoai.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
using CuaHangDienThoai.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e99a42016712b0a8273877ae5c39d4d6c5815a0", @"/Areas/Admin/Views/ThongKe/_MenuPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c81b1a8f9ef81bbd2ceef44ee517b11b3ebd31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ThongKe__MenuPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CuaHangDienThoai.Models.View.ThongKeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("oninput", new global::Microsoft.AspNetCore.Html.HtmlString("checkTatCa()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
 if (TempData["ThongKe"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissible fade show\">\r\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n        <strong>");
#nullable restore
#line 10 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
           Write(TempData["ThongKe"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
    TempData.Remove("ThongKe");
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e99a42016712b0a8273877ae5c39d4d6c5815a06909", async() => {
                WriteLiteral("\r\n    <div class=\"row pt-3\">\r\n        <div class=\"col-1\"></div>\r\n        <div>\r\n            <label class=\"form-text pr-1\">Loại</label>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 21 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
       Write(Html.DropDownList("loaiThongKe", CuaHangDienThoai.Extensions.IEnumerableExtensions.ListThongKe(), "Chọn loại thống kê", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-1\"></div>\r\n        <div>\r\n            <label class=\"form-text pr-1\">Hãng</label>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 28 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
       Write(Html.DropDownList("hang", Model.DanhSachHang.ToSelectListHang(0), "Tất cả", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row pt-2\">\r\n        <div class=\"col-1\"></div>\r\n        <div>\r\n            <label class=\"form-text pr-1\">Thời gian từ</label>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 37 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
       Write(Html.Editor("batDau", new { htmlAttributes = new { @class = "form-control", @type = "date" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <label class=\"form-text pr-2 pl-2\">đến</label>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 43 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
       Write(Html.Editor("ketThuc", new { htmlAttributes = new { @class = "form-control", @type = "date" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"pl-4\">\r\n            ");
#nullable restore
#line 46 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\_MenuPartial.cshtml"
       Write(Html.CheckBox("tatCa", false, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <label class=\"form-text mt-2 pl-1\">Tất cả</label>\r\n        </div>\r\n    </div>\r\n    <div class=\"row pr-2 pb-2 pt-2\">\r\n        <div class=\"col-1\"></div>\r\n        <div class=\"col-2\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e99a42016712b0a8273877ae5c39d4d6c5815a09934", async() => {
                    WriteLiteral("Thống Kê");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    function checkTatCa() {
        var x = document.getElementById(""tatCa"").checked;
        if (x == true) {
            document.getElementById(""batDau"").readOnly = true;
            document.getElementById(""ketThuc"").readOnly = true;
        }
        else {
            document.getElementById(""batDau"").readOnly = false;
            document.getElementById(""ketThuc"").readOnly = false;
        }
    }
    window.onload = checkTatCa();
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CuaHangDienThoai.Models.View.ThongKeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
