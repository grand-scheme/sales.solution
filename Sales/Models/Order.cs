using System;
using System.Collections.Generic;

namespace Sales.Models
{
  public class Order
  {
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public double ProductPrice { get; set; }
    public int ID { get; }
    // public int OrderDate {did we do anything with dates??? look into this later.}
    private static List<Order> _products = new List<Order> {} ;

    public Order(string productName, string productDescription, double productPrice)
    {
      ProductName = productName;
      ProductDescription = productDescription;
      ProductPrice = productPrice;
      _products.Add(this);
      ID = _products.Count;
    }



    /////////////// static functions
    public static List<Order> Collect() // retrieve all products in order (belonging to vendor)
    {
      return _products;
    }

    public static Order Lookup(int searchNo) // look up single product in order //
    {
      return _products[searchNo - 1];
    }

    public static void ClearAll() // remove all products from list. mostly for testing purposes. but possibly utilized in user interaction too.
    {
      _products.Clear();
    }
  }
}