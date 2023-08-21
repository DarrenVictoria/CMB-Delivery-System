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
    public partial class Delivery : Form
    {
        private int SelecedtedDeliveryId;
        //private int SelectedDriverId;
        private String Selecteddriverusername;
        public int SelectedDriverId { get; set; } 

        public Delivery(int SelecedtedDeliveryId, string SelectedDriverUname)
        {
            InitializeComponent();
            this.SelecedtedDeliveryId = SelecedtedDeliveryId;
            this.Selecteddriverusername = SelectedDriverUname;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            orderid.Text = SelecedtedDeliveryId.ToString();

            using (SqlConnection connection = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True"))
            {
                connection.Open();

                string selectStatusQuery = "SELECT PickupStatus, DeliveryStatus,ConfirmOrder,OngoingDelivery FROM DeliveryInfo WHERE DeliveryId = @DeliveryId";
                SqlCommand selectCommand = new SqlCommand(selectStatusQuery, connection);
                selectCommand.Parameters.AddWithValue("@DeliveryId", SelecedtedDeliveryId);

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string pickupStatus = reader["PickupStatus"].ToString();
                        string deliveryStatus = reader["DeliveryStatus"].ToString();
                        string confirmorder = reader["ConfirmOrder"].ToString();
                        string ongoingdelivery = reader["OngoingDelivery"].ToString();
                        /*
                        if (confirmorder == "Confirmed" && pickupStatus == "BaggagePickedUp" && ongoingdelivery == "Ongoing" && deliveryStatus == "Successful")
                        {
                            progressBar1.Value = progressBar1.Maximum;
                        }
                        else if (confirmorder == "Confirmed")
                        {
                            progressBar1.Value = (int)(progressBar1.Maximum * 0.25);
                        }
                        else if (pickupStatus == "BaggagePickedUp")
                        {
                            progressBar1.Value = (int)(progressBar1.Maximum * 0.50);
                        }
                        else if (ongoingdelivery == "Ongoing")
                        {
                            progressBar1.Value = (int)(progressBar1.Maximum * 0.75);
                        }
                        else if (deliveryStatus == "Successful")
                        {
                            progressBar1.Value = progressBar1.Maximum;
                        }
                        else
                        {
                            progressBar1.Value = 0; // Default value
                        }
                        */
                        if(deliveryStatus == "Successfull")
                        {
                            progressBar1.Value = progressBar1.Maximum;
                        }
                        else if (ongoingdelivery == "Ongoing")
                        {
                            progressBar1.Value = (int)(progressBar1.Maximum * 0.75);
                        }
                        else if (pickupStatus == "Baggage Picked Up")
                        {
                            progressBar1.Value = (int)(progressBar1.Maximum * 0.50);
                        }
                        else if (confirmorder == "Confirmed")
                        {
                            progressBar1.Value = (int)(progressBar1.Maximum * 0.25);
                        }
                        else
                        {
                            progressBar1.Value = 0; // Default value
                        }
                    }
                }

                connection.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void lable3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        

        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            // Calculate 25% of the maximum value of the progress bar
            int progressBarValue = (int)(progressBar1.Maximum * 0.25);     
            // Set the progress bar value
            progressBar1.Value = progressBarValue;

            SqlConnection connection = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True");
            string updateStatus = "UPDATE DeliveryInfo SET ConfirmOrder = 'Confirmed' WHERE DeliveryId = @DeliveryId";
            SqlCommand command = new SqlCommand(updateStatus, connection);
            command.Parameters.AddWithValue("@DeliveryId", SelecedtedDeliveryId);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Delivery information updated successfully.");
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

            connection.Close();

        }

        private void BaggagePickUp_Click(object sender, EventArgs e)
        {
            // Calculate 25% of the maximum value of the progress bar
            int progressBarValue = (int)(progressBar1.Maximum * 0.50);
            // Set the progress bar value
            progressBar1.Value = progressBarValue;

            SqlConnection connection = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True");
            string updateStatus = "UPDATE DeliveryInfo SET PickupStatus = 'Baggage Picked Up' WHERE DeliveryId = @DeliveryId";
            SqlCommand command = new SqlCommand(updateStatus, connection);
            command.Parameters.AddWithValue("@DeliveryId", SelecedtedDeliveryId);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Delivery information updated successfully.");
            }
            else
            {
                MessageBox.Show("Update failed.");
            }   

            connection.Close();

        }

        private void OnGoingDelivery_Click(object sender, EventArgs e)
        {
            // Calculate 25% of the maximum value of the progress bar
            int progressBarValue = (int)(progressBar1.Maximum * 0.75);
            // Set the progress bar value
            progressBar1.Value = progressBarValue;

            SqlConnection connection = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True");
            string updateStatus = "UPDATE DeliveryInfo SET OngoingDelivery = 'Ongoing' WHERE DeliveryId = @DeliveryId";
            SqlCommand command = new SqlCommand(updateStatus, connection);
            command.Parameters.AddWithValue("@DeliveryId", SelecedtedDeliveryId);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Delivery information updated successfully.");
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

            connection.Close();
        }
        private void SuccessDelivery_Click(object sender, EventArgs e)
        {
            // Calculate 25% of the maximum value of the progress bar
            int progressBarValue = (int)(progressBar1.Maximum * 1.0);
            // Set the progress bar value
            progressBar1.Value = progressBarValue;


            SqlConnection connection = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True");
            string updateStatus = "UPDATE DeliveryInfo SET DeliveryStatus = 'Successfull' WHERE DeliveryId = @DeliveryId";
            SqlCommand command = new SqlCommand(updateStatus, connection);
            command.Parameters.AddWithValue("@DeliveryId", SelecedtedDeliveryId);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Delivery information updated successfully.");
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

            connection.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Driverdelivery objdriver = new Driverdelivery(Selecteddriverusername);
            objdriver.Show();
            this.Hide();
            
        }
    }
}
