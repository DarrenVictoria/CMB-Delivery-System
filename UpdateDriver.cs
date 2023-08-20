using CMB_Delivery_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMB_Delivery_Management
{
    public partial class UpdateDriver : Form
    {
        public Driver SelectedDriver {get;set;}
        
        public UpdateDriver()
        {
            InitializeComponent();
        }

        private void UpdateDriver_Load(object sender, EventArgs e)
        {
            if(SelectedDriver == null)
            {
                this.Hide();
                return;
            }

            DriverId.Text = SelectedDriver.DriverId.ToString();
            DriverName.Text = SelectedDriver.Driver_name;
            Driver_DateJoined.Text = SelectedDriver.Driver_DateJoined;
            DriverAge.Text = SelectedDriver.Driver_age.ToString();

        }

        public void SelectDriver(int driverId)
        {
    

            SqlConnection connection = new SqlConnection(DAO.ConnectionString);
            try
            {
                connection.Open();

                string query = "SELECT * FROM DriverCred WHERE DriverID = @DriverId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverID", driverId);

                SqlDataReader reader = command.ExecuteReader();

                SelectedDriver = new Driver();

                while (reader.Read())
                {
                    SelectedDriver.DriverId = reader.GetInt32(0);
                    SelectedDriver.Driver_name = reader.GetString(1);
                    SelectedDriver.Driver_DateJoined = reader.GetDateTime(2).ToString("d");
                    SelectedDriver.Driver_age = reader.GetInt32(3);
                    SelectedDriver.Driver_Status = reader.GetString(4);
                }   

                reader.Close();
                connection.Close();
            }
            catch (Exception ex) { 
                Debug.WriteLine(ex);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                
            }

        }

        private void UpdateDriverFromDatabase()
        {

            int driverId = int.Parse(DriverId.Text.Trim());
            string drivername = DriverName.Text.Trim();   
            string EmployementDate = Driver_DateJoined.Text.Trim();
            int driverAge = int.Parse(DriverAge.Text.Trim());


            SqlConnection connection = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True");
            try
            {
                connection.Open();

                //string query = "UPDATE DriverCred SET DriverId = {driverid}, Driver_name = {drivername}, Driver_DateJoined = {EmployementDate} , Driver_age = {driverAge} WHERE DriverId = @DriverId";
                string query = "UPDATE DriverCred SET Driver_name = @DriverName, Driver_DateJoined = @EmploymentDate, Driver_age = @DriverAge WHERE DriverId = @DriverId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverId", driverId);
                command.Parameters.AddWithValue("@DriverName", drivername);
                command.Parameters.AddWithValue("@EmploymentDate", EmployementDate);
                command.Parameters.AddWithValue("@DriverAge", driverAge);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Driver information updated successfully.");
                }
                else
                {
                    MessageBox.Show("Deletion failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDriverFromDatabase();
            
        }
    }
}
