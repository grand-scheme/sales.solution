using System.Collections.Generic;

namespace Sales.Models
{
  public class Order
  {
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public double Id { get; }
    private static List<Order> _instances = new List<Order> {} ;

    public Order(string orderName, string orderDescription, string orderPrice)
    {
      Name = orderName;
      double parsePrice = (double.TryParse(orderPrice, out parsePrice) && parsePrice > 0) ? parsePrice : 0;
      Price = parsePrice;
      Description = orderDescription;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // STATIC methods
    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }

  }
}