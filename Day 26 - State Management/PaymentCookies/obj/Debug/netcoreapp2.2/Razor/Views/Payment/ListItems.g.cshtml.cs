#pragma checksum "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - State Management\PaymentCookies\Views\Payment\ListItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86c672572781bf8fc24cfd18ecf67544058cbc30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_ListItems), @"mvc.1.0.view", @"/Views/Payment/ListItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Payment/ListItems.cshtml", typeof(AspNetCore.Views_Payment_ListItems))]
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
#line 1 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - State Management\PaymentCookies\Views\_ViewImports.cshtml"
using PaymentCookies;

#line default
#line hidden
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - State Management\PaymentCookies\Views\_ViewImports.cshtml"
using PaymentCookies.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86c672572781bf8fc24cfd18ecf67544058cbc30", @"/Views/Payment/ListItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d3411cb48b54503f88b88342931b8c9e7f3d07", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_ListItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PaymentCookies.Models.Items>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - State Management\PaymentCookies\Views\Payment\ListItems.cshtml"
  
    ViewData["Title"] = "ListItems";

#line default
#line hidden
            BeginContext(47, 25, true);
            WriteLiteral("\r\n<h1>List Items</h1>\r\n\r\n");
            EndContext();
            BeginContext(121, 120, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Price</th>\r\n        <th>Quantity</th>\r\n    </tr>\r\n");
            EndContext();
#line 16 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - State Management\PaymentCookies\Views\Payment\ListItems.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(282, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(313, 9, false);
#line 19 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - State Management\PaymentCookies\Views\Payment\ListItems.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(322, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(346, 10, false);
#line 20 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - State Management\PaymentCookies\Views\Payment\ListItems.cshtml"
           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(356, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(380, 13, false);
#line 21 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - State Management\PaymentCookies\Views\Payment\ListItems.cshtml"
           Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(393, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(417, 64, false);
#line 22 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - State Management\PaymentCookies\Views\Payment\ListItems.cshtml"
           Write(Html.ActionLink("Add to Cart", "AddItemToCart", "Payment", item));

#line default
#line hidden
            EndContext();
            BeginContext(481, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 24 "C:\Users\grand\OneDrive\Desktop\Grand Circus Docs - Anna\det-q3-dotnet-2019\Day 26 - State Management\PaymentCookies\Views\Payment\ListItems.cshtml"
    }

#line default
#line hidden
            BeginContext(510, 14, true);
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PaymentCookies.Models.Items>> Html { get; private set; }
    }
}
#pragma warning restore 1591
