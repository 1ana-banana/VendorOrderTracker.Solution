#pragma checksum "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc668f788e5d4a960d206d4c8b6d9980b34e3439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 5 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\Index.cshtml"
using VendorOrderTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc668f788e5d4a960d206d4c8b6d9980b34e3439", @"/Views/Orders/Index.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Orders</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h2>There are no orders to see here.</h2>\r\n");
#nullable restore
#line 12 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\Index.cshtml"
 foreach (Order element in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h2><a");
            BeginWriteAttribute("href", " href=\"", 212, "\"", 246, 2);
            WriteAttributeValue("", 219, "orders/", 219, 7, true);
#nullable restore
#line 16 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\Index.cshtml"
WriteAttributeValue("", 226, element.GetListId(), 226, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\Index.cshtml"
                                       Write(element.GetOrderId());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n");
#nullable restore
#line 17 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p><a href=\"/orders/new\">Add new order</a></p>\r\n<p><a href=\"/vendors\">Vendors</a></p>\r\n<p><a href=\"/\">Home</a></p>");
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
