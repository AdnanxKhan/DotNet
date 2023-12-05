using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Order
    {
        public float TotalPrice;
        public DateTime DatePlaced;

        public Shipment Shipment { get; internal set; }
        public bool IsShipped { get; internal set; }
    }
}
