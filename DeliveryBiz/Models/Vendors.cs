using System.Collections.Generic;

namespace DeliveryBiz.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; } = new List<Order> {};
  
    public Vendor(string vendorName)
    {
      Name = vendorName;
      Id = _instances.Count;
      _instances.Add(this);
    }
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
      return _instances[searchId];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}