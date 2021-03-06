#pragma checksum "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1bcea28d933ec195fa3eb90419e90ea42fac58c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_OrderList), @"mvc.1.0.view", @"/Views/Shared/OrderList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/OrderList.cshtml", typeof(AspNetCore.Views_Shared_OrderList))]
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
#line 1 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\_ViewImports.cshtml"
using NaturalCosmetics.ViewModels;

#line default
#line hidden
#line 2 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\_ViewImports.cshtml"
using NaturalCosmetics.Models;

#line default
#line hidden
#line 3 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\_ViewImports.cshtml"
using NaturalCosmetics.Dto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bcea28d933ec195fa3eb90419e90ea42fac58c", @"/Views/Shared/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e79771a1e9d4a7e7838bcc2247e1cd11a82e15", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyOrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
 if (Model?.Count() <= 0)
{

#line default
#line hidden
            BeginContext(70, 95, true);
            WriteLiteral("    <div>\r\n        <p>Chưa có sản phẩm nào đặt. Hãy chọn sản phẩm và đặt hàng</p>\r\n    </div>\r\n");
            EndContext();
#line 8 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
    return;
}

#line default
#line hidden
            BeginContext(181, 234, true);
            WriteLiteral("\r\n<table class=\"table table-striped text-center\">\r\n    <thead>\r\n        <tr>\r\n            <th>Địa chỉ thanh toán</th>\r\n            <th>Tóm tắt đơn hàng</th>\r\n            <th>Tổng cộng</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
            EndContext();
#line 21 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
            BeginContext(465, 114, true);
            WriteLiteral("            <tr>\r\n\r\n                <td class=\"text-justify\">\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(580, 33, false);
#line 27 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                   Write(order.OrderPlaceDetails.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(613, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(615, 32, false);
#line 27 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                                                      Write(order.OrderPlaceDetails.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(647, 27, true);
            WriteLiteral(",\r\n                        ");
            EndContext();
            BeginContext(675, 36, false);
#line 28 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                   Write(order.OrderPlaceDetails.AddressLine1);

#line default
#line hidden
            EndContext();
            BeginContext(711, 55, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div>");
            EndContext();
            BeginContext(767, 35, false);
#line 30 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                    Write(order.OrderPlaceDetails.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(802, 33, true);
            WriteLiteral("</div>\r\n                    <div>");
            EndContext();
            BeginContext(836, 29, false);
#line 31 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                    Write(order.OrderPlaceDetails.Email);

#line default
#line hidden
            EndContext();
            BeginContext(865, 87, true);
            WriteLiteral("</div>\r\n                    <br />\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(953, 49, false);
#line 34 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                   Write(order.OrderPlacedTime.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 157, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    <table class=\"table\">\r\n                        <tbody>\r\n");
            EndContext();
#line 43 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                             foreach (var item in order.CosmeticsOrderInfos)
                            {

#line default
#line hidden
            BeginContext(1268, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1389, 9, false);
#line 47 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1398, 87, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
            EndContext();
#line 50 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                                          var value = String.Format("{0,-5:N0}đ", item.Price); 

#line default
#line hidden
            BeginContext(1582, 5, false);
#line 50 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                                                                                           Write(value);

#line default
#line hidden
            EndContext();
            BeginContext(1587, 3, true);
            WriteLiteral(" * ");
            EndContext();
            BeginContext(1591, 8, false);
#line 50 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                                                                                                    Write(item.Qty);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 53 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"

                            }

#line default
#line hidden
            BeginContext(1716, 111, true);
            WriteLiteral("                        </tbody>\r\n\r\n                    </table>\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 60 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                      var value1 = String.Format("{0,-5:N0}đ", order.OrderTotal); 

#line default
#line hidden
            BeginContext(1911, 6, false);
#line 60 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"
                                                                              Write(value1);

#line default
#line hidden
            EndContext();
            BeginContext(1917, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 63 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Views\Shared\OrderList.cshtml"

        }

#line default
#line hidden
            BeginContext(1974, 24, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyOrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
