#pragma checksum "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5c61f385d41677847bd054101d80cd8d179d216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ThongKe_DoanhThuTheoDT), @"mvc.1.0.view", @"/Areas/Admin/Views/ThongKe/DoanhThuTheoDT.cshtml")]
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
#line 2 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\_ViewImports.cshtml"
using CuaHangDienThoai.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5c61f385d41677847bd054101d80cd8d179d216", @"/Areas/Admin/Views/ThongKe/DoanhThuTheoDT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c81b1a8f9ef81bbd2ceef44ee517b11b3ebd31f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ThongKe_DoanhThuTheoDT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CuaHangDienThoai.Models.View.ThongKeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MenuPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
  
    ViewData["Title"] = "Thống kê";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5c61f385d41677847bd054101d80cd8d179d2163794", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"col-12\">\r\n    <canvas id=\"chart\" height=\"200\" width=\"400\"></canvas>\r\n    <div class=\"text-center\">\r\n        <h4 class=\"form-text text-info\">");
#nullable restore
#line 11 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                                   Write(Model.TenThongKe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
    </div>
    <div class=""col-12 text-center"">
        <table class=""table table-striped border rounded"">
            <tr>
                <th><label class=""form-text text-info"">Dòng điện thoại</label></th>
                <th><label class=""form-text text-info"">Tổng doanh thu</label></th>
                <th><label class=""form-text text-info"">Số lượng bán được</label> </th>
            </tr>
");
#nullable restore
#line 20 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
             for (int i = 0; i < Model.DanhSachDoanhSoVaDanhThuDT.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                   Write(Model.DanhSachDoanhSoVaDanhThuDT[i].ModelDT.TenModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"vnd\">");
#nullable restore
#line 24 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                               Write(Model.DanhSachDoanhSoVaDanhThuDT[i].DoanhThu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                   Write(Model.DanhSachDoanhSoVaDanhThuDT[i].SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </table>
    </div>
</div>

<script src=""https://cdn.jsdelivr.net/npm/chart.js@2.8.0/dist/Chart.min.js""></script>
<script>
    var ctx = document.getElementById('chart');
    var myChart = new Chart(ctx, {
    type: 'bar',

    data: {
        labels: [],
        datasets: [{
            data: [],
            backgroundColor: 'rgba(255, 99, 132, 0.9)',
            borderColor: 'rgba(255, 99, 132, 1)',
            borderWidth: 1,
            label: 'Doanh thu',

            // This binds the dataset to the left y axis
            yAxisID: 'A'
        }, {
            data: [],
            label: 'Right dataset',
            backgroundColor: 'rgba(75, 192, 192, 0.2)',
            borderColor: 'rgba(75, 192, 192, 0.5)',
            borderWidth: 1,
            label: 'Doanh số bán',
            // This binds the dataset to the right y axis
            yAxisID: 'B'
        }]

    },
    options: {
        scales: {
            yAxes: [{
                id: 'A',
     ");
            WriteLiteral(@"           type: 'linear',
                position: 'left',
                ticks: {
                    beginAtZero: true,
                           callback: function(value, index, values) {
                            return ToVND_Head(value);
                        }
                },
                scaleLabel: {
            display: true,
            labelString: 'Doanh Thu (VNĐ)'
          }
            }, {
                id: 'B',
                type: 'linear',
                position: 'right',
                ticks: {
                    beginAtZero: true
                    },
                scaleLabel: {
            display: true,
            labelString: 'Số lượng'
          }
            }]
        }
    }
    });


    // myChart.data.labels.push(""123"");
    //myChart.data.datasets[0].data.push(35);
    //myChart.data.datasets[1].data.push(0.5);
    //myChart.data.labels.push(""456"");
    //myChart.data.datasets[0].data.push(79);
    //myChart.data.datase");
            WriteLiteral("ts[1].data.push(0.2);\r\n\r\n\r\n\r\n");
#nullable restore
#line 104 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
     if(Model.DanhSachDoanhSoVaDanhThuDT!=null)
    {
        if(Model.DanhSachDoanhSoVaDanhThuDT.Count >8)
        {
            foreach(var item in Model.DanhSachDoanhSoVaDanhThuDT.Take(8))
            {
                 

#line default
#line hidden
#nullable disable
            WriteLiteral("myChart.data.labels.push(\"");
#nullable restore
#line 110 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                                            Write(item.ModelDT.TenModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");");
            WriteLiteral("\r\n");
            WriteLiteral("myChart.data.datasets[0].data.push(\"");
#nullable restore
#line 111 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                                                      Write(item.DoanhThu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");");
            WriteLiteral("\r\n");
            WriteLiteral("myChart.data.datasets[1].data.push(\"");
#nullable restore
#line 112 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                                                      Write(item.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");");
#nullable restore
#line 112 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                                                                                  

            }
        }
        else if(Model.DanhSachDoanhSoVaDanhThuDT.Count<=8)
        {
            foreach(var item in Model.DanhSachDoanhSoVaDanhThuDT)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("myChart.data.labels.push(\"");
#nullable restore
#line 120 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                                           Write(item.ModelDT.TenModel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");");
            WriteLiteral("\r\n");
            WriteLiteral("myChart.data.datasets[0].data.push(\"");
#nullable restore
#line 121 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                                                     Write(item.DoanhThu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");");
            WriteLiteral("\r\n");
            WriteLiteral("myChart.data.datasets[1].data.push(\"");
#nullable restore
#line 122 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                                                     Write(item.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");");
#nullable restore
#line 122 "C:\Microsoft\CNPM\CuaHangDienThoai\CuaHangDienThoai\Areas\Admin\Views\ThongKe\DoanhThuTheoDT.cshtml"
                                                                                 
            }
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("     myChart.update();\r\n\r\n\r\n\r\n</script>\r\n\r\n");
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
