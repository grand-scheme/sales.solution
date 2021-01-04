using System.Collections.Generic;

namespace Sales.Models
{
  public class Order
  {
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    // public int OrderDate {did we do anything with dates??? look into this later.}
    private static List<Order> _instances = new List<Order> {} ;

    public Order(string name, string description, double price)
    {
      Name = name;
      Price = price;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    /////////////// static functions
    public static List<Order> GetAll() // retrieve all products in order (belonging to vendor)
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId) // look up single product in order //
    {
      return _instances[searchId - 1];
    }    
  }
}