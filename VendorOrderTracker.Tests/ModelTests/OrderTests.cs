using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearList();
      Vendor.ClearList();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Order ord1 = new Order(1, "txt", "desc", 2, "od","dfd",1,1,1,1,1,1);
      Assert.AreEqual(typeof(Order), ord1.GetType());
    }
  }
}