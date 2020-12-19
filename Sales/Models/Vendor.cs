using System.Collections.Generic;

namespace Sales.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendors = new List<Vendor> {};
    public string VendorName { get; set; }
    public int ID { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _vendors.Add(this);
      ID = _vendors.Count;
      Orders = new List<Order> {};
    }

    public void AddOrder(Order orderInput) // adds order list to vendor singular
    {
      Orders.Add(orderInput);
    }

    /////////////// static functions
    public static List<Vendor> Collect() // retrieve all products in order (belonging to vendor)
    {
      return _vendors;
    }

    public static Vendor Lookup(int searchNo) // look up single product in order //
    {
      return _vendors[searchNo - 1];
    }

    public static void ClearAll() // remove all products from list.
    {
      _vendors.Clear();
    }
  }
}