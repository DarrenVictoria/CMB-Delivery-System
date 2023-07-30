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

    internal class Driver
    {
        public string username { get; set; }
        public string passwordHash { get; set; }
        public int driverid { get; set; }

    }


}
