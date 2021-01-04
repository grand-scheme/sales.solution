using System.Collections.Generic;

namespace Sales.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};
    }

    public static void ClearAll() // remove all products from list.
    {
      _instances.Clear();
    }
    
    public static List<Vendor> GetAll() // retrieve all products in order (belonging to vendor)
    {
      return _instances;
    }
    
    public static Vendor Find(int searchId) // look up single product in order //
    {
      return _instances[searchId - 1];
    }
    
    public void AddOrder(Order order) // adds order list to vendor singular
    {
      Orders.Add(order);
    }

    /////////////// static functions
    

    

    
  }
}