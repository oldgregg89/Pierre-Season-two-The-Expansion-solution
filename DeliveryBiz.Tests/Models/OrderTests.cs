using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeliveryBiz.Models;
using System.Collections.Generic;
using System;

namespace DeliveryBiz
{
  [TestClass]
  public class OrderTest 
  {
    public void Remove()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstenceOfOrder_Order()
    {
      Order newOrder = new Order ("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string discription = "Ordered 30 chocolate tacos";
      Order newOrder = new Order(discription);
      string result = newOrder.Description;
      Assert.AreEqual(discription, result);
    }
  }
}