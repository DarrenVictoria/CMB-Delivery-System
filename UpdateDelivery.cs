using CMB_Delivery_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMB_Delivery_Management
{
    public partial class UpdateDelivery : Form
    {

        public Delivery SelectedDelivery { get; set; }

        public UpdateDelivery()
        {
            InitializeComponent();
        }

        public void SelectDelivery(int DeliveryID)
        {
            SqlConnection connection = new SqlConnection(DAO.ConnectionString);
            try
            {
                connection.Open();

                //string query = "SELECT * FROM DeliveryInfo WHERE DeliveryID = @DeliveryId";
                string query = "SELECT DeliveryID,DriverID,Address,Contact,Description FROM DeliveryInfo WHERE DeliveryID = @DeliveryId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DeliveryId", DeliveryID);

                SqlDataReader reader = command.ExecuteReader();

                SelectedDelivery = new Delivery();

                while (reader.Read())
                {
                    SelectedDelivery.DeliveryID = reader.GetInt32(0);
                    SelectedDelivery.DriverID = reader.GetInt32(1);
                    SelectedDelivery.Address = reader.GetString(2);
                    SelectedDelivery.Contact = reader.GetInt32(3).ToString();
                    SelectedDelivery.Description = reader.GetString(4);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                }

            }

        }

        private void UpdateDeliveryFromDatabase()
        {

            int deliveryId = int.Parse(Baggage.Text.Trim());
            
            string address = Address.Text.Trim();
            int Contact = int.Parse(contact.Text.Trim());
            string Description = description.Text.Trim();


            SqlConnection connection = new SqlConnection(DAO.ConnectionString);
            try
            {
                connection.Open();

                //string query = "UPDATE DriverCred SET DriverId = {driverid}, Driver_name = {drivername}, Driver_DateJoined = {EmployementDate} , Driver_age = {driverAge} WHERE DriverId = @DriverId";
                string query = "UPDATE DeliveryInfo SET DeliveryID = @deliveryId, Address = @address, Contact = @contact, Description = @Description WHERE DeliveryID= @deliveryId";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@deliveryId", deliveryId);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@contact", Contact);
                command.Parameters.AddWithValue("@Description", Description);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delivery information updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update failed.");
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

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDeliveryFromDatabase();
        }

        private void Baggage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Header_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDelivery_Load(object sender, EventArgs e)
        {
            if (SelectedDelivery == null)
            {
                this.Hide();
                return;
            }

            Baggage.Text = SelectedDelivery.DeliveryID.ToString();
            comboBox1.Text = SelectedDelivery.DriverID.ToString();
            Address.Text = SelectedDelivery.Address;
            contact.Text = SelectedDelivery.Contact.ToString();
            description.Text = SelectedDelivery.Description;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
