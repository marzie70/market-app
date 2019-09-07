using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_entity
{
    public class RackItemLevel
    {
        public RackItemLevel()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Item Item { get; set; }
        public Rack Rack { get; set; }
        //===

    }
}
