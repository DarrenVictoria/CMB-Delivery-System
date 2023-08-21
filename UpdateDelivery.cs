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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMB_Delivery_Management
{
    public partial class UpdateDelivery : Form
    {

        public Model.Delivery SelectedDelivery { get; set; }

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

               
                string query = "SELECT DeliveryID,DriverID,Address,Contact,Description FROM DeliveryInfo WHERE DeliveryID = @DeliveryId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DeliveryId", DeliveryID);

                SqlDataReader reader = command.ExecuteReader();

                SelectedDelivery = new Model.Delivery();

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
                
                MessageBox.Show($"Error: {ex.Message}", "Error");

        }

        }

        private void PopulateDriverComboBox()
        {
            try
            {
                SqlConnection connection = new SqlConnection(DAO.ConnectionString);
                string query = "SELECT DriverID FROM DriverCred";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["DriverID"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

               
                string query = "UPDATE DeliveryInfo SET DeliveryID = @deliveryId,DriverID = @driverid ,Address = @address, Contact = @contact, Description = @Description WHERE DeliveryID= @deliveryId";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@deliveryId", deliveryId);
                command.Parameters.AddWithValue("@driverid", comboBox1.Text);
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

    


        private void UpdateDelivery_Load(object sender, EventArgs e)
        {
            PopulateDriverComboBox();

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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Address.Text = "";
            Baggage.Text = "";
            contact.Text = "";

            description.Text = "";
            
        }
    }
}
