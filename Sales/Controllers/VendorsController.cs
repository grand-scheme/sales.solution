using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Sales.Models;

namespace Sales.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.Collect();
      return View(allVendors);
    }
    
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor aNewVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> salesModel = new Dictionary<string, object>();
      Vendor chosenVendor = Vendor.Lookup(id);
      List<Order> vendorsOrders = chosenVendor.Orders;
      salesModel.Add("vendor", chosenVendor);
      salesModel.Add("orders", vendorsOrders);
      return View(salesModel);
    }

    ////
    [HttpPost("/vendors/{vendorID}/orders")]
    public ActionResult Create(int vendorID, string productName, string productDescription, double productPrice)
    {
      Dictionary<string, object> salesModel = new Dictionary<string, object>();
      Vendor targettedVendor = Vendor.Lookup(vendorID);
      Order newOrder = new Order(productName, productDescription, productPrice); 
      targettedVendor.AddOrder(newOrder);
      List<Order> vendorOrders = targettedVendor.Orders;
      salesModel.Add("order", vendorOrders);
      salesModel.Add("vendor", targettedVendor);
      return View("Show", salesModel);
    }
  }
}