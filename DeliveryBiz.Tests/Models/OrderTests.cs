using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeliveryBiz.Models;
using System.Collections.Generic;
using System;

namespace DeliveryBiz
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Remove()
    {
      Orders.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstenceOfOrder_Vendor()
    {
      Order newOrder = new Order ("test Order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}