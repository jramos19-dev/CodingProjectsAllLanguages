using System.Collections.Generic;
using Packt.Shared;

namespace Packt.Shared
{
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string ShipperName { get; set; }
        public string Phone { get; set; }

        //related entities
        public ICollection<Order> Orders { get; set; }
    }
}