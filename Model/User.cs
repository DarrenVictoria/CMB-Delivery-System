using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMB_Delivery_Management.Model
{
    public enum AccountType
    {
        Admin,
        Driver,
        None
    }

    internal class User
    {
        public string username { get; set; }
        public string passwordHash { get; set; }
        public AccountType type { get; set; }

        internal static AccountType ParseAccountType(string value)
        {
            switch (value)
            {
                case "Admin": return AccountType.Admin;
                case "Driver": return AccountType.Driver;
                default: return AccountType.None;
            }
        }
    }

    
}
