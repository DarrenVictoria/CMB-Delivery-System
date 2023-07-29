using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using CMB_Delivery_Management.Converters;

namespace CMB_Delivery_Management.Model
{
    internal class DAO
    {
        internal static String ConnectionString { get; set; } = $"Data Source={Server.Name};Initial Catalog=BaggageDeliverySystem;Integrated Security=True";
        

        internal static bool VerifyUser(String username, String passwordHash, AccountType type)
        {
            if (username == null || passwordHash == null) { return false; }

            try
            {
                SqlConnection Connection;
                
                using (Connection = new SqlConnection(ConnectionString))
                {
                    String ValidationQueury = "";

                    if (type == AccountType.Admin)
                    {
                        ValidationQueury = "SELECT * FROM UAdmin WHERE username=@uname";
                    }
                    else
                    {
                        ValidationQueury = "SELECT * FROM Driver WHERE username=@uname";
                    }

                    if (Connection.State == System.Data.ConnectionState.Closed)
                    Connection.Open();
                    SqlCommand ValidationCommand = new SqlCommand(ValidationQueury, Connection);
                    ValidationCommand.Parameters.AddWithValue("@uname", username);


                    SqlDataReader ValidationData = ValidationCommand.ExecuteReader();

                    if (!ValidationData.HasRows) 
                    {
                        if (Connection.State == System.Data.ConnectionState.Open)
                        {
                            Connection.Close();
                        }
                        return false; 
                    }

                    while (ValidationData.Read())
                    {

                        if (type == AccountType.Admin)
                        {
                            Admin tempUser = new Admin();
                            tempUser.username = username;
                            tempUser.passwordHash = ValidationData.GetString(1).Trim();

                            if (passwordHash.Equals(tempUser.passwordHash))
                            {
                                Instances.LoggedUser = tempUser;
                                Instances.LoggedUserAccountType = AccountType.Admin;

                                if (Connection.State == System.Data.ConnectionState.Open)
                                {
                                    Connection.Close();
                                }

                                return true;
                            }
                        }
                        else
                        {
                            Driver tempUser = new Driver();
                            tempUser.driverid = ValidationData.GetInt32(0);
                            tempUser.username = username;

                            tempUser.passwordHash = ValidationData.GetString(2).Trim();
                            if (passwordHash.Equals(tempUser.passwordHash))
                            {
                                Instances.LoggedUser = tempUser;
                                Instances.LoggedUserAccountType = AccountType.Driver;

                                if (Connection.State == System.Data.ConnectionState.Open)
                                {
                                    Connection.Close();
                                }

                                return true;
                            }
                        }   

                        if (Connection.State == System.Data.ConnectionState.Open)
                        {
                            Connection.Close();
                        }

                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return false;
        }
    }
}
