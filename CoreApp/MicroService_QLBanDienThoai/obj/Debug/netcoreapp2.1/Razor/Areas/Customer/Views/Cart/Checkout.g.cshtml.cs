#pragma checksum "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9494bbc6fb7ff98d19867dbd06c1a64a5eaf7404"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Cart_Checkout), @"mvc.1.0.view", @"/Areas/Customer/Views/Cart/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Cart/Checkout.cshtml", typeof(AspNetCore.Areas_Customer_Views_Cart_Checkout))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 3 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9494bbc6fb7ff98d19867dbd06c1a64a5eaf7404", @"/Areas/Customer/Views/Cart/Checkout.cshtml")]
    public class Areas_Customer_Views_Cart_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MicroService_QLBanDienThoai.Areas.Customer.Models.ViewCart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap_theme.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/payment.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/maintemplate/css/font-awesome.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/maintemplate/js/jquery-2.1.4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/payment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
  
    Layout = null;

#line default
#line hidden
#line 7 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
  
    if (Model.Count == 0)
    {

#line default
#line hidden
            BeginContext(207, 92, true);
            WriteLiteral("        <script>\r\n            alert(\"Bạn chưa mua sản phẩm\")\r\n             location.href = \"");
            EndContext();
            BeginContext(300, 26, false);
#line 12 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
                         Write(Url.Action("Index","Cart"));

#line default
#line hidden
            EndContext();
            BeginContext(326, 23, true);
            WriteLiteral("\";\r\n        </script>\r\n");
            EndContext();
#line 14 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
    }


#line default
#line hidden
            BeginContext(361, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(388, 683, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf4866c4b0de4a05a794fe8b6056c660", async() => {
                BeginContext(394, 200, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <title>Thanh toán</title>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    ");
                EndContext();
                BeginContext(594, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fd8ad5dfd4c462c8071ae78475c0630", async() => {
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
                BeginContext(681, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(687, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de6aeaff0a9545c89c016a5ec8b7479d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(780, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(786, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2264a49afad3426497b3eaaa515ab065", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(867, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(873, 99, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51bb7c9e18f54d6b8c00c5e861f2bb67", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(972, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(978, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9617e69a049d4c4f811a41bb43cbfaed", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1062, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1071, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1075, 9335, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db2c57b9932e47e1914c9010c6765366", async() => {
                BeginContext(1081, 552, true);
                WriteLiteral(@"
    <div class=""payment"" style=""display:block;"" id=""html_payment"">
        <div class=""container"">
            <div class=""row"">
                <div class=""logo col-xs-12"">
                    <img src="""" alt=""/index"">
                </div>
                <div class=""frmPayment"">
                    <div class=""bill_payment col-xs-12 col-md-4 pull_right_desktop"">
                        <div class=""col-xs-12 a_left border_top_bottom"">
                            <div class=""col-xs-6"">
                                <h4>Đơn hàng ( ");
                EndContext();
                BeginContext(1634, 11, false);
#line 43 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
                                          Write(Model.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1645, 404, true);
                WriteLiteral(@" )</h4>
                            </div>
                            <div class=""col-xs-6 a_right"">
                                <a class=""hidden-sm hidden-md hidden-lg"" onclick=""clickShowFooter('detail_order')"" href=""#"">Xem chi tiết ></a>
                            </div>
                            <div class=""col-xs-12 no_padding border_top"" id=""detail_order"" style=""padding: 0px 0px;"">
");
                EndContext();
#line 49 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
                                  
                                    decimal sum = 0;
                                    foreach (var item in Model)
                                    {

#line default
#line hidden
                BeginContext(2243, 203, true);
                WriteLiteral("                                        <div style=\"margin-top: 15px;\">\r\n                                            <div class=\"img_payment col-xs-3\">\r\n\r\n                                                ");
                EndContext();
                BeginContext(2446, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "69b9426d30bd4b7bbf3767a8258da329", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2456, "~/HinhSanPham/", 2456, 14, true);
#line 56 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
AddHtmlAttributeValue("", 2470, item.Product_Id.Image, 2470, 22, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2494, 200, true);
                WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"col-xs-5 name_payment no_padding\">\r\n                                                <div> ");
                EndContext();
                BeginContext(2695, 20, false);
#line 59 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
                                                 Write(item.Product_Id.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2715, 25, true);
                WriteLiteral(" <b style=\"color:red;\">x(");
                EndContext();
                BeginContext(2741, 13, false);
#line 59 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
                                                                                               Write(item.quantity);

#line default
#line hidden
                EndContext();
                BeginContext(2754, 212, true);
                WriteLiteral(")</b></div>\r\n                                            </div>\r\n                                            <div class=\"col-xs-4 price_payment no_padding\">\r\n                                                <div> ");
                EndContext();
                BeginContext(2967, 37, false);
#line 62 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
                                                 Write(item.Product_Id.Price.ToString("0.#"));

#line default
#line hidden
                EndContext();
                BeginContext(3004, 110, true);
                WriteLiteral(" đ</div>\r\n                                            </div>\r\n                                        </div>\r\n");
                EndContext();
#line 65 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
                                        sum += item.Product_Id.Price * item.quantity;

                                    }
                                

#line default
#line hidden
                BeginContext(3277, 457, true);
                WriteLiteral(@"
                                <div class=""clearfix""></div>
                            </div>
                        </div>
                        <div class=""col-xs-12 border_bottom"" style=""padding: 15px;"">
                            <div class=""col-xs-6 a_left"">
                                Tạm tính:
                            </div>
                            <div class=""col-xs-6 a_right"">
                                <label>  ");
                EndContext();
                BeginContext(3735, 19, false);
#line 78 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
                                    Write(sum.ToString("0.#"));

#line default
#line hidden
                EndContext();
                BeginContext(3754, 668, true);
                WriteLiteral(@" đ</label>
                            </div>
                            <div class=""col-xs-6 a_left"">
                                Phí vận chuyển:
                            </div>
                            <div class=""col-xs-6 a_right"">
                                <label> 0 đ</label>
                            </div>
                        </div>
                        <div class=""col-xs-12 "">
                            <div class=""col-xs-6 a_left"">
                                <h4>Tổng cộng:</h4>
                            </div>
                            <div class=""col-xs-6 a_right"">
                                <h4> ");
                EndContext();
                BeginContext(4423, 19, false);
#line 92 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
                                Write(sum.ToString("0.#"));

#line default
#line hidden
                EndContext();
                BeginContext(4442, 61, true);
                WriteLiteral(" đ</h4>\r\n                                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4503, "\"", 4515, 1);
#line 93 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 4511, sum, 4511, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4516, 1197, true);
                WriteLiteral(@" id=""amount_total""/>
                            </div>
                        </div>
                        <div class=""hidden-xs hidden-sm col-md-12 col-lg-12 btn_payment border_top"" style=""margin-bottom:15px;"">
                            <button class=""btn btn-info"" style=""width:100%"" id='sub_destop' type=""submit"">Mua hàng</button>
                            <a href=""/cart"">&lt; Quay lại giỏ hàng</a>
                        </div>
                    </div>
                    <div class=""information_payment col-xs-12 col-md-4"">
                        <div class=""col-xs-12 border_top"">
                            <h4><b><i class=""fa fa-id-card-o"" style=""padding-right:5px;""></i>Thông tin mua hàng</b></h4>
                            <h5><button class=""btn btn-info"" id=""update_profile""><i class=""fa fa-user"" style=""padding-right:5px;""></i>Cập nhật thông tin tài khoản</button></h5>
                        </div>

                        <div class=""col-xs-12"">
                            <i");
                WriteLiteral("nput name=\"BillingAddress.LastName\" type=\"text\" class=\"field__input form-control\"\r\n                                   placeholder=\"Họ và tên\" id=\"_billing_address_last_name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5713, "\"", 5762, 1);
#line 109 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
WriteAttributeValue("", 5721, Context.Session.GetString("TenDangNhap"), 5721, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5763, 3537, true);
                WriteLiteral(@" data-error=""Vui lòng nhập họ tên""
                                   required="""">
                            <input name=""BillingAddress.Phone"" bind-event-change=""saveAbandoned()"" type=""tel"" value=""""
                                   bind-event-focus=""handleFocus(this)"" bind-event-blur=""handleFieldBlur(this)"" class=""field__input form-control""
                                   id=""_billing_address_phone"" placeholder=""Số điện thoại"" data-error=""Vui lòng nhập số điện thoại""
                                   pattern=""^([0-9,\+,\-,\(,\),\.]{8,20})$"" bind=""billing_address.phone"">
                            <input name=""BillingAddress.Address1"" class=""field__input form-control"" value="""" placeholder=""Địa chỉ""
                                   id=""_billing_address_address1"">

                            <textarea name=""note"" bind-event-change=""saveAbandoned()"" id='inputNote' value="""" class=""field__input form-control m0""
                                      placeholder=""Ghi chú""></textarea>

       ");
                WriteLiteral(@"                 </div>
                    </div>
                    <div class=""ship_payment col-xs-12 col-md-4"">
                        <div class=""col-xs-12"">
                            <h4><b><i class=""fa fa-truck fa-lg"" style=""padding-right:5px;""></i>Vận chuyển</b></h4>
                            <input style=""height:13px;"" checked=""checked"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio2""
                                   value=""option2"">
                            <label>
                                Giao hàng tận nơi
                            </label>
                            <span class=""pull-right"" style=""text-align:right""><b>0 đ</b></span>
                        </div>
                        <div class=""col-xs-12 border_top"">
                            <h4><b><i class=""fa fa-credit-card fa-lg"" style=""padding-right:5px;""></i>Thanh toán</b></h4>

                            <input style=""height:13px;"" checked=""checked"" type=""radio"" name=""payment"" id=""payment""");
                WriteLiteral(@"
                                   value=""COD"">
                            <label>
                                Thanh toán khi giao hàng COD
                            </label>
                            <span class=""pull-right"" style=""text-align:right""><i class=""fa fa-money fa-lg""></i></span>
                            <div class=""clearfix""></div>
                            <input style=""height:13px;"" type=""radio"" name=""payment"" id=""payment"" value=""Paypal"" onclick=""alert('Hệ thống đang nâng cấp'); return false;"">
                            <label>
                                Thanh toán trực tuyến
                            </label>
                            <span class=""pull-right"" style=""text-align:right""><i class=""fa fa-money fa-lg""></i></span>
                            <br>
                            <br>
                            <label>Chú ý: Khi chọn COD bạn chỉ phải thanh toán khi nhận hàng</label>
                        </div>
                        <div class=""");
                WriteLiteral(@"col-xs-12 hidden-md hidden-lg btn_payment border_top"" style=""margin-bottom:15px;"">
                            <button class=""btn btn-info"" style=""width:100%"" id='sub_mobile' type=""submit"">Mua hàng</button>
                            <a href=""cart/"">&lt; Quay lại giỏ hàng</a>
                        </div>

                    </div>
                </div>
                <div class=""clearfix""></div>
            </div>
        </div>
    </div>
    ");
                EndContext();
                BeginContext(9300, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad3ff9884aae4a9cab452e013d1cd5e1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9362, 706, true);
                WriteLiteral(@"
    <script>
        $('#sub_destop').click(function (e) {
            e.preventDefault();
            var data = {
                address: $('#_billing_address_address1').val(),
                phone: $('#_billing_address_phone').val(),
                description: $('#inputNote').val(),
                amount: $('#amount_total').val(),
            };
            $.ajax({
                url: ""/Customer/Cart/ConfirmCheckOut"",
                type: ""post"",
                data: data,
                success: function (data) {
                    if (data == ""Thanh toán thành công"") {
                        alert(""Thanh toán thành công"")
                        location.href = """);
                EndContext();
                BeginContext(10069, 27, false);
#line 180 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Cart\Checkout.cshtml"
                                    Write(Url.Action("Index", "Cart"));

#line default
#line hidden
                EndContext();
                BeginContext(10096, 307, true);
                WriteLiteral(@""";
                    }
                    else {
                        alert(""Lỗi: Thanh toán thất bại"")
                    }
                },
                error: function (data) {
                    alert(""Error: "" + data);
                }
            })
        })
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10410, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MicroService_QLBanDienThoai.Areas.Customer.Models.ViewCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
