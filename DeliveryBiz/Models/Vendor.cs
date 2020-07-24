using System.Collections.Generic;

namespace DeliveryBiz.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Order { get; set; }
  
    public Vendor(string vendorName)
    {
      Name = vendorName;
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
  }
}