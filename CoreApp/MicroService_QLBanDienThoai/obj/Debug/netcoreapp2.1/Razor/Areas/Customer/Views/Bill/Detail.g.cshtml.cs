#pragma checksum "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5f8c817043f4a7d8eca71228438e6a6cb9fa3ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Bill_Detail), @"mvc.1.0.view", @"/Areas/Customer/Views/Bill/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Bill/Detail.cshtml", typeof(AspNetCore.Areas_Customer_Views_Bill_Detail))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 2 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f8c817043f4a7d8eca71228438e6a6cb9fa3ef", @"/Areas/Customer/Views/Bill/Detail.cshtml")]
    public class Areas_Customer_Views_Bill_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MicroService_QLBanDienThoai.Areas.Admin.Models.Detail_Order_Adapter>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admintemplate/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admintemplate/vendor/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admintemplate/vendor/jquery-easing/jquery.easing.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admintemplate/js/sb-admin.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#line 8 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
  
    MicroService_QLBanDienThoai.Areas.Customer.Models.ViewOrder _order = (MicroService_QLBanDienThoai.Areas.Customer.Models.ViewOrder)ViewBag.Order;


#line default
#line hidden
            BeginContext(402, 352, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <h1 class=""page-header"">Chi tiết đơn hàng:</h1>
        <div class=""row"">
            <div class=""col-lg-12"">


                <div class=""col-lg-4"" style=""display:inline-block;float:left;"">
                    <p>Mã hoá đơn:</p> <input type=""text"" class=""form-control"" readonly=""readonly""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 754, "\"", 772, 1);
#line 20 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
WriteAttributeValue("", 762, _order.Id, 762, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(773, 248, true);
            WriteLiteral(" id=\"searchList\" name=\"search\" readonly>\r\n                </div>\r\n                <div class=\"col-lg-4\" style=\"display:inline-block;float:left;\">\r\n                    <p>Mã khách hàng: </p><input type=\"text\" class=\"form-control\" readonly=\"readonly\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1021, "\"", 1046, 1);
#line 23 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
WriteAttributeValue("", 1029, _order.AccountID, 1029, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1047, 252, true);
            WriteLiteral(" id=\"sum_amount\" placeholder=\"\" name=\"\" readonly>\r\n                </div>\r\n                <div class=\"col-lg-4\" style=\"display:inline-block;float:left;\">\r\n                    <p>Tổng tiền</p> <input type=\"text\" readonly=\"readonly\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1299, "\"", 1341, 1);
#line 26 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
WriteAttributeValue("", 1307, _order.Amount.ToString("#.# VND"), 1307, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1342, 243, true);
            WriteLiteral(" id=\"\" placeholder=\"\" name=\"\" readonly>\r\n                </div>\r\n                <div class=\"col-lg-4\" style=\"display:inline-block;float:left;\">\r\n                    <p>Ngày mua: </p> <input type=\"text\" readonly=\"readonly\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1585, "\"", 1610, 1);
#line 29 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
WriteAttributeValue("", 1593, _order.OrderDate, 1593, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1611, 262, true);
            WriteLiteral(@" id=""_orderdate"" placeholder="""" name="""" readonly>
                </div>
                <div class=""col-lg-4"" style=""display:inline-block;float:left;"">
                    <p>Địa chỉ giao hàng: </p> <input type=""text"" readonly=""readonly"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1873, "\"", 1896, 1);
#line 32 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
WriteAttributeValue("", 1881, _order.Address, 1881, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1897, 255, true);
            WriteLiteral(" id=\"_addres\" placeholder=\"\" name=\"\" readonly>\r\n                </div>\r\n                <div class=\"col-lg-4\" style=\"display:inline-block;float:left;\">\r\n                    <p>Số điện thoại: </p> <input type=\"text\" readonly=\"readonly\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2152, "\"", 2173, 1);
#line 35 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
WriteAttributeValue("", 2160, _order.Phone, 2160, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2174, 653, true);
            WriteLiteral(@" id=""_phone"" placeholder="""" name="""" readonly>
                </div>
            </div>
        </div>
        <br />

        <table width=""100%"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Mã sản phẩm</th>
                    <th>Tên sản phẩm</th>
                    <th>Hình ảnh</th>
                    <th>Giá</th>
                    <th>Số lượng</th>
                </tr>
            </thead>
            <tbody class=""body-content"" id=""result_insert""></tbody>



        </table>
    </div>
</div>

");
            EndContext();
            BeginContext(2827, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6b55400dcba4394ad4c3f2976c55399", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2894, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2896, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c249861f1a47cc86b28ba137afeb23", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2979, 34, true);
            WriteLiteral("\r\n<!-- Core plugin JavaScript-->\r\n");
            EndContext();
            BeginContext(3013, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20c8370ebefe4693838c12ef74d7448d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3094, 40, true);
            WriteLiteral("\r\n<!-- Custom scripts for all pages-->\r\n");
            EndContext();
            BeginContext(3134, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "886b7c44f4cb48e99c4883ff73fd73a1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3192, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 65 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
  
      foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(3244, 125, true);
            WriteLiteral("        <script>\r\n            $(document).ready(function () {\r\n                    var data = {\r\n                        id: ");
            EndContext();
            BeginContext(3370, 14, false);
#line 71 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
                       Write(item.ProductID);

#line default
#line hidden
            EndContext();
            BeginContext(3384, 1017, true);
            WriteLiteral(@",
                    };
                    $.ajax({
                        url: ""/Customer/Bill/GetProduct"",
                        type: ""post"",
                        data: data,
                        success: function (data) {
                            var html = '';
                            html += '<tr style=""vertical-align: middle;"" class=""odd gradeX"" id=""' + data['id'] + '"">'
                            html += ' <td style=""vertical-align: middle;"" class=""item-AccountID list_product""><a href=""/Customer/SanPham/Index/' + data['productId']+'"">' + data['productId'] + '</a> </td>'
                            html += '<td style=""vertical-align: middle;"" class=""item-AccountName"">' + data['name'] + '</td>'
                            html += '<td style=""vertical-align: middle;"" class=""item-AccountName""> <img style=""max-width:15%"" src=""/HinhSanPham/' + data['image'] + '""/></td>'
                            html += '<td style=""vertical-align: middle;"" class=""item-AccountName"">' + ");
            EndContext();
            BeginContext(4402, 26, false);
#line 83 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
                                                                                                 Write(item.Price.ToString("#.#"));

#line default
#line hidden
            EndContext();
            BeginContext(4428, 117, true);
            WriteLiteral("+\' VND </td>\'\r\n                            html += \'<td style=\"vertical-align: middle;\" class=\"item-AccountName\">\' + ");
            EndContext();
            BeginContext(4546, 12, false);
#line 84 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
                                                                                                 Write(item.Quality);

#line default
#line hidden
            EndContext();
            BeginContext(4558, 291, true);
            WriteLiteral(@"+'</td>'
                            $('#result_insert').append(html);
                        },
                        error: function (data) {
                            alert(""Error: "" + data);
                        }
                    })
            })
        </script>
");
            EndContext();
#line 93 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Bill\Detail.cshtml"
        }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MicroService_QLBanDienThoai.Areas.Admin.Models.Detail_Order_Adapter>> Html { get; private set; }
    }
}
#pragma warning restore 1591
