using Microsoft.AspNetCore.Mvc;
using DeliveryBiz.Models;
using System.Collections.Generic;

namespace DeliveryBiz.Controllers
{
  public class OrdersController : Controller
  {
    [HttpPost("/orders")]
    public ActionResult Index(string description)
    {
      Order newOrder = new Order(description);
      Vendor vendor = Vendor.Find(0);
      vendor.AddOrder(newOrder);
      return View();
    }
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendors", vendor);
      return View(model);
    }
    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      return View();
    }
  }
}