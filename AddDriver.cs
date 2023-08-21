using CMB_Delivery_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMB_Delivery_Management
{
    public partial class AddDriver : Form
    {
        public AddDriver()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private bool CheckDriverExists(string driverId)
        {

            SqlConnection connection = new SqlConnection(DAO.ConnectionString);
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM DriverCred WHERE DriverId = '{driverId}'";
                SqlCommand command = new SqlCommand(query, connection);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string Did = DriverId.Text;

            bool driverExists = CheckDriverExists(Did);

            if (driverExists)
            {
                MessageBox.Show("A driver with the same ID already exists.");
                return;
            }


            string DName = DriverName.Text; 
                string Date = Driver_DateJoined.Text;
                string Age = DriverAge.Text;

                SqlConnection connection = new SqlConnection(DAO.ConnectionString);
                
                connection.Open();

                
                string query = $"INSERT INTO DriverCred (DriverId,Driver_name,Driver_DateJoined,Driver_age) VALUES ('{Did}', '{DName}','{Date}','{Age}')";
                SqlCommand command = new SqlCommand(query, connection);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Driver information inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Insertion failed.");
                }

                connection.Close();
            }

        }
}
