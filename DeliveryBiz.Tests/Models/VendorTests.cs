using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeliveryBiz.Models;
using System.Collections.Generic;
using System;

namespace DeliveryBiz
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Remove()
    {
      Vendors.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstenceOfVendors_Vendor()
    {
      Vendor newVendors = new Vendor ("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}