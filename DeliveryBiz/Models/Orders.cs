using System.Collections.Generic;

namespace DeliveryBiz.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Id { get; }
  
    public Order(string description)
    {
      Description = description;
      
    }
  }
}