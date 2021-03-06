using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearList();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Assert.AreEqual(typeof(Vendor), ven1.GetType());
    }

    [TestMethod]
    public void GetList_RetreiveStaticList_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Vendor ven2 = new Vendor("a","b","c","d","e","f","g","h");
      List<Vendor> list1 = new List<Vendor> { ven1, ven2 };
      CollectionAssert.AreEqual(list1, Vendor.GetList());
    }

    [TestMethod]
    public void ClearList_ReturnAnEmptyStaticList_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Vendor ven2 = new Vendor("a","b","c","d","e","f","g","h");
      Vendor.ClearList();
      int listCount = Vendor.GetList().Count;
      Assert.AreEqual(0, listCount);
    }

    [TestMethod]
    public void FindById_ReturnObjectWithMatchingIdProperty_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      int venId = ven1.GetListId();
      Assert.AreEqual("a", Vendor.FindById(venId).GetVendorName());
    }

    [TestMethod]
    public void GetListId_GetListIdValue_True()
    {
      Vendor ven1 = new Vendor("a","b","c","d","e","f","g","h");
      Vendor ven2 = new Vendor("a","b","c","d","e","f","g","h");
      Vendor ven3 = new Vendor("a","b","c","d","e","f","g","h");
      Assert.AreEqual(3, ven3.GetListId());
    }

  }
}