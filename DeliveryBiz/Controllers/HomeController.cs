using Microsoft.AspNetCore.Mvc;

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