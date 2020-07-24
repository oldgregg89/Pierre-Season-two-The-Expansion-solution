using Microsoft.AspNetCore.Mvc;
using DeliveryBiz.Models;

namespace DeliveryBiz.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}