using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_entity
{
    class OrderItem
    {
       public OrderItem()
       {
            Id = Guid.NewGuid();
       }
      public Guid Id { get; set; }
      public decimal NetPrice { get; set; }
      public int Quantity { get; set; }
      public decimal TotalPrice { get; set; }
      public decimal UnitPrice { get; set; }
      public Item Item { get; set; }
      public Rack Rack { get; set; }
      int a = 1;
      int b = 1;
      
    }
}
