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
  }
}