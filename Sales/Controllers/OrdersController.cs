using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sales.Models;

namespace Sales.Controllers
{
  public class OrdersController : Controller
  {
    // [HttpGet("/vendors/{vendorID}/orders/new")]
    // public ActionResult Index()
    // {
    //   List<Order> allOrders = Order.Collect();
    //   return View(allOrders);
    // }

    [HttpGet("/vendors/{vendorID}/orders/new")]
    public ActionResult New(int vendorID)
    {
      Vendor targettedVendor = Vendor.Lookup(vendorID);
      return View(targettedVendor);
    }

    [HttpPost("/vendors/{vendorID}/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }

    [HttpGet("/vendors/{vendorID}/orders/{orderID}")]
    public ActionResult Show(int vendorID, int orderID)
    {
      Order calledOrder = Order.Lookup(orderID);
      Vendor targettedVendor = Vendor.Lookup(vendorID);
      Dictionary<string, object> salesModel = new Dictionary<string, object>();
      salesModel.Add("order", calledOrder);
      salesModel.Add("vendor", targettedVendor);
      return View(salesModel);
    }
  }
}