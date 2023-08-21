using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMB_Delivery_Management.Model
{
    public class Delivery
    {
        public int DeliveryID { get; set; }
        public int DriverID { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public string Description { get; set; }
        public string PickupStatus { get; set; }
        public string Delivery_Status { get; set; }
    }
}
