using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeliveryBiz.Models;
using System.Collections.Generic;
using System;

namespace DeliveryBiz
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstenceOfVendors_Vendor()
    {
      Vendor newVendor = new Vendor ("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Papa Haydn";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    

    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      string name = "Papa Haydn";
      Vendor newVendor = new Vendor(name);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Papa Haydn";
      string name2 = "Eats & Treats";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Papa Haydn";
      string name2 = "Eats & Treats";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      Vendor results = Vendor.Find(2);
      Assert.AreEqual(newVendor2, results);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string description = "Ordered 30 chocolate tacos";
      Order newOrder = new Order(description);
      List<Order> newList = new List<Order> {newOrder};
      string name = "Eats & Treats";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}