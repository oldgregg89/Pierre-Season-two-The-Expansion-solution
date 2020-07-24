using System.Collections.Generic;

namespace DeliveryBiz.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};
  
    public Order(string description)
    {
      Description = description;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}