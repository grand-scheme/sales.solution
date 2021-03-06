using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sales.Models;

namespace Sales.Controllers
{
  public class OrdersController : Controller
  {
    // GET requests
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    // POST requests
    [HttpPost("/orders/delete")]
    public ActionResult Delete()
    {
      Order.ClearAll();
      return View();
    }
    
  }
}