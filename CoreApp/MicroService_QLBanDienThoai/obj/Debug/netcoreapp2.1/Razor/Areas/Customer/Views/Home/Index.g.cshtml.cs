#pragma checksum "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0495f90f7455cc250f72db064e6b20f3d894451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 4 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0495f90f7455cc250f72db064e6b20f3d894451", @"/Areas/Customer/Views/Home/Index.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MicroService_QLBanDienThoai.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/maintemplate/images/bottom1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/maintemplate/images/bottom2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admintemplate2/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(187, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
            BeginContext(281, 2989, true);
            WriteLiteral(@"<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
    <!-- Indicators -->
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1"" class=""""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2"" class=""""></li>
        <li data-target=""#myCarousel"" data-slide-to=""3"" class=""""></li>
        <li data-target=""#myCarousel"" data-slide-to=""4"" class=""""></li>
    </ol>




    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active"">
            <div class=""container"">
                <div class=""carousel-caption"">
                    <h3><span>500+</span>mẫu điện thoại</h3>
                    <p>Dẫn đầu xu hướng </p>

                </div>
            </div>
        </div>
        <div class=""item item2"">
            <div class=""container"">
                <div class=""carousel-caption"">
                    <h3>Giáng Sinh Giảm đến <span>5");
            WriteLiteral(@"0%</span></h3>
                    <p>Và nhiều ưu đãi hấp dẫn khác</p>

                </div>
            </div>
        </div>
        <div class=""item item3"">
            <div class=""container"">
                <div class=""carousel-caption"">
                    <h3>Bộ sưu tập<span>Điện thoại</span></h3>
                    <p>Cập nhật mẫu mã liên tục mỗi ngày</p>

                </div>
            </div>
        </div>
        <div class=""item item4"">
            <div class=""container"">
                <div class=""carousel-caption"">
                    <h3>Thời Thượng</h3>
                    <p>Màu sắc đa dạng và cuốn hút</p>
                </div>
            </div>
        </div>
        <div class=""item item5"">
            <div class=""container"">
                <div class=""carousel-caption"">
                    <h3>Hiện Đại</h3>
                    <p>Điện thoại kết hợp công nghệ mới</p>

                </div>
            </div>
        </div>
    </div>



    <a");
            WriteLiteral(@" class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
    <!-- The Modal -->
</div>

<!-- quảng cáo -->
<div class=""container"">
    <div class=""quangcao"">
    </div>
</div>
<!-- //quảng cáo -->
<!-- //banner -->
<div class=""banner_bottom_agile_info"">
    <div class=""container"">
        <div class=""banner_bottom_agile_info_inner_w3ls"" style=""display: flex; justify-content: center;"">
            <div class=""col-md-6 wthree_banner_bottom_grid_three_left1 grid"">
                <figure class=""effect-roxy"">
                    ");
            EndContext();
            BeginContext(3270, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "056a10333fe346139096246433d37ea2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3348, 362, true);
            WriteLiteral(@"
                    <figcaption>
                        <h3><span>P</span>HONEX</h3>
                        <p>Sản phẩm mới</p>
                    </figcaption>
                </figure>
            </div>
            <div class=""col-md-6 wthree_banner_bottom_grid_three_left1 grid"">
                <figure class=""effect-roxy"">
                    ");
            EndContext();
            BeginContext(3710, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f6da6a5b01fa40f9af4ce22feb043a2d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3788, 504, true);
            WriteLiteral(@"
                    <figcaption>
                        <h3><span>P</span>HONEX</h3>
                        <p>Sản phẩm mới</p>
                    </figcaption>
                </figure>
            </div>
            <div class=""clearfix""></div>
        </div>
    </div>
</div>

<!-- /new_arrivals -->
<div class=""new_arrivals_agile_w3ls_info"">
    <div class=""container"">
        <h3 class=""wthree_text_info"">Tìm Kiếm <span>Phổ Biến</span></h3>
        <div id=""horizontalTab"">

");
            EndContext();
            BeginContext(4578, 84, true);
            WriteLiteral("            </ul>\r\n            <div class=\"tab1\">\r\n                <!--/tab_one-->\r\n");
            EndContext();
#line 134 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                 foreach (var item in ViewBag.listsp)
                {

#line default
#line hidden
            BeginContext(4736, 277, true);
            WriteLiteral(@"                    <div class=""tab1"">
                        <div class=""col-md-3 product-men"">
                            <div class=""men-pro-item simpleCart_shelfItem"">

                                <div class=""men-thumb-item"">
                                    ");
            EndContext();
            BeginContext(5013, 273, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca3ce6814e146c483f85f9475604a60", async() => {
                BeginContext(5111, 67, true);
                WriteLiteral("\r\n                                        <div class=\"anhsanpham-4\"");
                EndContext();
                BeginWriteAttribute("style", " style=\"", 5178, "\"", 5236, 4);
                WriteAttributeValue("", 5186, "background-image:", 5186, 17, true);
                WriteAttributeValue(" ", 5203, "url(\'/HinhSanPham/", 5204, 19, true);
#line 142 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 5222, item.Image, 5222, 11, false);

#line default
#line hidden
                WriteAttributeValue("", 5233, "\');", 5233, 3, true);
                EndWriteAttribute();
                BeginContext(5237, 45, true);
                WriteLiteral("></div>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 141 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                         WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5286, 150, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"item-info-product \">\r\n                                    <h4>\r\n");
            EndContext();
#line 147 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                                         if (item.Name.Length > 20)
                                        {

#line default
#line hidden
            BeginContext(5548, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(5592, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b90c19ecd6254dd79a6704f0d5b6c656", async() => {
                BeginContext(5691, 26, false);
#line 149 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                                                         Write(item.Name.Substring(0, 18));

#line default
#line hidden
                EndContext();
                BeginContext(5717, 3, true);
                WriteLiteral("...");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 149 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                                 WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5724, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 150 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(5858, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(5902, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbdb4c87c50149e89114dd6a24c95cf2", async() => {
                BeginContext(6001, 9, false);
#line 153 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                                                         Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 153 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                                 WriteLiteral(item.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6014, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 154 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(6059, 157, true);
            WriteLiteral("                                    </h4>\r\n                                    <div class=\"info-product-price\">\r\n                                        <h5>");
            EndContext();
            BeginContext(6217, 28, false);
#line 157 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                                       Write(item.Price.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(6245, 247, true);
            WriteLiteral(" đ</h5>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"clearfix\"></div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 164 "F:\GitHub\MicroService_QLBanDienThoai\Project\MicroService_QLBanDienThoai\Areas\Customer\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(6511, 2443, true);
            WriteLiteral(@"                <!--//tab_one-->
                <!--/tab_two-->
                <div class=""tab2"">
                    <div class=""clearfix""></div>
                    <div class=""clearfix""></div>
                </div>
                <!--//tab_two-->
                <div class=""tab3"">


                    <div class=""clearfix""></div>
                </div>
                <div class=""tab4"">

                    <div class=""clearfix""></div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- //new_arrivals -->
<!-- /we-offer -->
<!-- //we-offer -->
<!-- Quảng cáo-->
<div class=""container"">

</div>
<!-- //Quảng cáo-->
<!--/grids-->
<div class=""coupons"">
    <div class=""coupons-grids text-center"">
        <div class=""w3layouts_mail_grid"">
            <div class=""col-md-3 w3layouts_mail_grid_left"">
                <div class=""w3layouts_mail_grid_left1 hvr-radial-out"">
                    <i class=""fa fa-truck"" aria-hidden=""true""></i>
             ");
            WriteLiteral(@"   </div>
                <div class=""w3layouts_mail_grid_left2"">
                    <h3>GIAO HÀNG TOÀN QUỐC</h3>

                </div>
            </div>
            <div class=""col-md-3 w3layouts_mail_grid_left"">
                <div class=""w3layouts_mail_grid_left1 hvr-radial-out"">
                    <i class=""fa fa-headphones"" aria-hidden=""true""></i>
                </div>
                <div class=""w3layouts_mail_grid_left2"">
                    <h3>HỖ TRỢ 24/7</h3>

                </div>
            </div>
            <div class=""col-md-3 w3layouts_mail_grid_left"">
                <div class=""w3layouts_mail_grid_left1 hvr-radial-out"">
                    <i class=""fa fa-shopping-bag"" aria-hidden=""true""></i>
                </div>
                <div class=""w3layouts_mail_grid_left2"">
                    <h3>THANH TOÁN ONLINE THUẬN TIỆN</h3>

                </div>
            </div>
            <div class=""col-md-3 w3layouts_mail_grid_left"">
                <div class=""w3");
            WriteLiteral(@"layouts_mail_grid_left1 hvr-radial-out"">
                    <i class=""fa fa-gift"" aria-hidden=""true""></i>
                </div>
                <div class=""w3layouts_mail_grid_left2"">
                    <h3>NHIỀU CHƯƠNG TRÌNH ƯU ĐÃI HẤP DẪN</h3>

                </div>
            </div>
            <div class=""clearfix""> </div>
        </div>

    </div>
</div>
<!--grids-->
");
            EndContext();
            BeginContext(8954, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e79bd495d8143dea4a5ebc3607a1ddb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9022, 1165, true);
            WriteLiteral(@"
<script>
    window.onload = loadhetquangcao();
    function loadquangcao(mavitri) {
        let taga = mavitri + ""a"";
        $.ajax({
            url: ""/Customer/QuangCao/LoadQuangCao"",
            type: ""post"",
            data: { ""mavitri"": mavitri },
            dataType: 'json',

            success: function (data) {
                if (data != null) {

                    //let obj = JSON.parse(data);

                    $(""#"" + taga).attr(""href"", ""http://www."" + data.DuongDan);
                    $(""#"" + mavitri).attr(""src"", ""/Hinh/QuangCao/"" + data.Hinh);
                    //alert(data);
                }
                else {

                    document.getElementById(taga).href = ""#"";

                }



            },


            error: function (jqXHR, exception) {
                alert(exception + "" "" + jqXHR.status);
            }

        });

    }
    function loadhetquangcao() {
        loadquangcao('VTA1');
        loadquangcao('VTA2');");
            WriteLiteral("\n        loadquangcao(\'VTA3\');\r\n        loadquangcao(\'VTA4\');\r\n        loadquangcao(\'VTB1\');\r\n        loadquangcao(\'VTB2\');\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MicroService_QLBanDienThoai.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
