using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApp.Models
{

    public class StockItem
    {
        public Employee[] ListOfOwners { get; set; } //we reuse the items...
        public string Model { get; set; }
        public string Make { get; set; }
        public string SerialId { get; set; }

    }
}
