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
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "They Ordered 200 bagels";
      Order newOrder = new Order(description);
      string updateDescription = "They changed their order to 150 bagels";
      newOrder.Description = updateDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updateDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}