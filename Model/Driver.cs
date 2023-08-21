using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMB_Delivery_Management.Model
{
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
}
