using System;
using System.Collections.Generic;

namespace Sales.Models
{
  public class Order
  {
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public int ProductPrice { get; set; }
    // public int OrderDate {did we do anything with dates??? look into this later.}
    private static List<Order> _products = new List<Order> {} ;

    public Order(string productName, string productDescription, int productPrice)
    {
      ProductName = productName;
      ProductDescription = productDescription;
      ProductPrice = productPrice;
    }
  }
}