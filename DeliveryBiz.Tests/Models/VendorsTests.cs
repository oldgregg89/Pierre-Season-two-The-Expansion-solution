using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeliveryBiz.Models;
using System.Collections.Generic;
using System;

namespace DeliveryBiz
{
  [TestClass]
  public class VendorsTest : IDisposable
  {
    public void Dispose()
    {
      Vendors.ClearAll();
    }
  }
}