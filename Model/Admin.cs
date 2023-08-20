using CMB_Delivery_Management.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMB_Delivery_Management.Model
{

    internal class Admin
    {
        public string username { get; set; }
        public string passwordHash { get; set; }
        

    }

    public class Driver
    {
        public string username { get; set; }
        public string passwordHash { get; set; }
        public int DriverId { get; set; }

        public string Driver_name { get; set; } 

        public string Driver_DateJoined { get; set; }   
        public int Driver_age { get; set; }

        public string Driver_Status { get; set; }   
    }

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
