#pragma checksum "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ecb90e06cd652c673a9617a1c8d127a456b388b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_New), @"mvc.1.0.view", @"/Views/Orders/New.cshtml")]
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
#line 5 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\New.cshtml"
using VendorOrderTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ecb90e06cd652c673a9617a1c8d127a456b388b", @"/Views/Orders/New.cshtml")]
    public class Views_Orders_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Add Order</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\New.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h2>There are no orders here. </h2>\r\n");
#nullable restore
#line 12 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\New.cshtml"
}
else
{
  

#line default
#line hidden
#nullable disable
            WriteLiteral("  <form action=\"/orders\" method=\"post\">\r\n    <select name=\"orderVendorId\">\r\n");
#nullable restore
#line 18 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\New.cshtml"
         foreach (Vendor element in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <option");
            BeginWriteAttribute("value", " value=", 322, "", 349, 1);
#nullable restore
#line 20 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\New.cshtml"
WriteAttributeValue("", 329, element.GetListId(), 329, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\New.cshtml"
                                        Write(element.GetVendorName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 21 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\New.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </select>


    <label for=""title"">Title</label>
    <input id=""title"" name=""title"" type=""text"">

    <label for=""description"">Description</label>
    <input id=""description"" name=""description"" type=""text"">

    <label for=""price"">Price</label>
    <input id=""price"" name=""price"" type=""number"">

    <label for=""orderDate"">Order Date</label>
    <input id=""orderDate"" name=""orderDate"" type=""date"">

    <label for=""deliveryForDate"">Delivery-For Date</label>
    <input id=""deliveryForDate"" name=""deliveryForDate"" type=""date"">

    <label for=""sourDough"">Sourdough Bread</label>
    <input id=""sourDough"" name=""sourDough"" type=""number"">

    <label for=""milkLoaf"">Milk Loaf</label>
    <input id=""milkLoaf"" name=""milkLoaf"" type=""number"">

    <label for=""donut"">Donut</label>
    <input id=""donut"" name=""donut"" type=""number"">

    <label for=""croissant"">Croissant</label>
    <input id=""croissant"" name=""croissant"" type=""number"">

    <label for=""quiche"">Quiche</label>
    <input id=""quich");
            WriteLiteral("e\" name=\"quiche\" type=\"number\">\r\n\r\n    <label for=\"cheesePuff\">Cheese Puff</label>\r\n    <input id=\"cheesePuff\" name=\"cheesePuff\" type=\"number\">\r\n\r\n    <button type=\"submit\">Add</button>\r\n  </form>\r\n");
#nullable restore
#line 60 "C:\Users\Ana\Desktop\VendorOrderTracker.Solution\VendorOrderTracker\Views\Orders\New.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p><a href=\"/vendors\">Vendors</a></p>\r\n<p><a href=\"/orders\">Orders</a></p>\r\n<p><a href=\"/\">Home</a></p>");
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