using Microsoft.AspNetCore.Mvc;

namespace Sales.Controllers
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