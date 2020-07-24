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
    public ActionResult Create(string vendorName);
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");

    }
  }
}
