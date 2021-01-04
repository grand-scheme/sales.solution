using System.Collections.Generic;

namespace Sales.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription, string vendorDate)
    {
      Name = vendorName;
      Description = vendorDescription;
      Date = vendorDate;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};
    }
    
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    
    // STATIC methods
    public static void ClearAll()
    {
      _instances.Clear();
    }
    
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    
    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}