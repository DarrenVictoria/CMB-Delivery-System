using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CMB_Delivery_Management.Model
{
    internal class DAO
    {
        internal static String ConnectionString { get; set; }
        internal static SqlConnection Connection { get; set; }

        internal DAO() 
        {
            ConnectionString = $"Data Source={Server.Name};Initial Catalog=BaggageDeliverySystem;Integrated Security=True";
            Connection = new SqlConnection(ConnectionString) ;
        }

        internal static bool VerifyUser(String username, String passwordHash, AccountType type)
        {
            if (username == null || passwordHash == null) { return false; }

            try
            {
                using (Connection)
                {
                    
                    String ValidationQueury = "SELECT * FROM User WHERE username=@uname";
                    SqlCommand ValidationCommand = new SqlCommand(ValidationQueury);
                    ValidationCommand.Parameters.AddWithValue("@uname", username);

                    if (Connection.State == System.Data.ConnectionState.Closed)
                        Connection.Open();

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
                        User tempUser = new User();
                        tempUser.username = username;
                        tempUser.passwordHash = ValidationData.GetString(1);
                        tempUser.type = User.ParseAccountType(ValidationData.GetString(2));

                        if (passwordHash.Equals(tempUser.passwordHash)
                            && type.Equals(tempUser.type))
                        {
                            Instances.LoggedUser = tempUser;

                            if (Connection.State == System.Data.ConnectionState.Open)
                            {
                                Connection.Close();
                            }

                            return false;
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
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }

            return false;
        }
    }
}
