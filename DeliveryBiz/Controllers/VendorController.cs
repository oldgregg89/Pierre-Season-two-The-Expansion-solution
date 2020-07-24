using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using DeliveryBiz.Models;

namespace DeliveryBiz.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendor/{Id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrder = selectedVendor.Order;
      model.Add("vendor",selectedVendor);
      model.Add("order",vendorOrder);
      return View(model);
    }
    [HttpPost("/vendor/{vendorId}/order")]
    public ActionResult Create(int vendorId, string orderDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDescription);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrder = foundVendor.Order;
      model.Add("order", vendorOrder);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}
