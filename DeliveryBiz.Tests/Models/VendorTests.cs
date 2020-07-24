using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeliveryBiz.Models;
using System.Collections.Generic;
using System;

namespace DeliveryBiz
{
  [TestClass]
  public class VendorTest 
  {
    // public void Remove()
    // {
    //   Vendors.ClearAll();
    // }
    [TestMethod]
    public void VendorConstructor_CreatesInstenceOfVendors_Vendor()
    {
      Vendor newVendor = new Vendor ("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}