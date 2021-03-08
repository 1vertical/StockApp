using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApp.Models
{
    public class AssignedStock
    {
        public StockItem StockItem { get; set; }
        public int CurrentCount { get; set; }
        public DateTime ReceivalDate { get; set; }
        public DateTime InstallationDate { get; set; }
        public Computer ComputerId { get; set; }
        public Employee AgentId { get; set; }
        public Employee SpecialistId { get; set; } 
        public string[] Notes { get; set; }
    }
}
