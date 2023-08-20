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
    public partial class PendingDeliveries : Form
    {
        public PendingDeliveries()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditDeliveries editobj = new EditDeliveries();
            editobj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditDeliveries editobj = new EditDeliveries();
            editobj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Dashboard objdashboard = new Dashboard();
            objdashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void LoadDeliveryData()
        {
            SqlConnection connection = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT * FROM DeliveryInfo", connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["DeliveryID"], reader["DriverID"], reader["Address"], reader["Contact"], reader["Description"], reader["PickupStatus"], reader["DeliveryStatus"]);
            }

            reader.Close();
            connection.Close();
        }

        private void PendingDeliveries_Load(object sender, EventArgs e)
        {
            LoadDeliveryData();   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadDeliveryData();
        }

        private void DeleteSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string deliveryId = selectedRow.Cells["DeliveryName"].Value.ToString();


                dataGridView1.Rows.Remove(selectedRow);


                DeleteDriverFromDatabase(deliveryId);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }


        private void DeleteDriverFromDatabase(string deliveryId)
        {
            SqlConnection connection = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True");
            try
            {
                connection.Open();

                string query = "DELETE FROM DeliveryInfo WHERE DeliveryID = @DeliveryID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DeliveryID", deliveryId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delivery information deleted successfully.");
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }
    }
}
