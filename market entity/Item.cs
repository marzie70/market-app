using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_entity
{
   public class Item
   {
       public Item()
       {
            Id = Guid.NewGuid();
       }
       public Guid Id { get; set; }
       public string Name { get; set; }
      
   }
   public enum Unit
   {
        Kilo,
        Meter,
        Number
   }  
}
