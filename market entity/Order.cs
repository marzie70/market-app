using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_entity
{
   public class Order
    {
       public Order()
       {
            Id = Guid.NewGuid();
       }
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public List<OrderItem> OrderItem { get; set; }
    }
}