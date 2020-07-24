using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeliveryBiz.Models;
using System.Collections.Generic;
using System;

namespace DeliveryBiz 
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
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
    [TestMethod]
    public void Find_ReturnCorrectOrder_Order()
    {
      string description1 = "They Ordered 200 bagels";
      string description2 = "Ordered 30 chocolate tacos";
      Order newOrder1 = new Order(description1);
      Order newOrder2 = new Order(description2);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetReturns_Int()
    {
      string description = "They Ordered 200 bagels";
      Order newOrder = new Order(description);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
  }
}