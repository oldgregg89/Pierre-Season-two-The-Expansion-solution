using System.Collections.Generic;

namespace DeliveryBiz.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Price {get;set;}
    public string Description { get; set; }
    public string Date {get;set;}

    public int Id { get; }
    private static int IdMarker = 1;
    private static List<Order> _instances = new List<Order> ();

  
    public Order(string title, string price, string description, string date)
    {
      Title = title;
      Price = price;
      Description = description;
      Date = date;
      _instances.Add(this);
      Id = IdMarker;
      IdMarker += 1;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}