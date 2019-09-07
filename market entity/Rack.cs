using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_entity
{
   public class Rack
    {
       public Rack()
       {
            Id = Guid.NewGuid();
       }
      public Guid Id { get; set; }
      public int Limit { get; set; }
      public string Location { get; set; }
      public List<Rack> rack { get; set; }
        int a = 0;
        int b = 0;
        int c = 0;
       //.........

    }
}
