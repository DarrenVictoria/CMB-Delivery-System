using CMB_Delivery_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMB_Delivery_Management.Converters
{
    public enum AccountType
    {
        Admin,
        Driver,
        None
    }
    internal static class AccountTypeConverter
    {
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
