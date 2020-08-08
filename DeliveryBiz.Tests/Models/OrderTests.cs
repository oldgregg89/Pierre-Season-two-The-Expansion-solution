using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeliveryBiz.Models;
using System.Collections.Generic;
using System;

namespace DeliveryBiz 
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstenceOfOrder_Order()
    {
      Order newOrder = new Order ("test", "test", "test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrderPrice_ReturnsPrice_String()
    {
      string testprice = "100";
      Order newOrder = new Order("test", testprice, "test", "test");
      string result = newOrder.Description;
      Assert.AreEqual(testprice, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "They Ordered 200 bagels";
      Order newOrder = new Order("test", "test", description, "test");
      string updateDescription = "They changed their order to 150 bagels";
      newOrder.Description = updateDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updateDescription, result);
    }
    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetReturns_Int()
    {
      string description = "They Ordered 200 bagels";
      Order newOrder = new Order("test", "test", description, "test");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
  }
}