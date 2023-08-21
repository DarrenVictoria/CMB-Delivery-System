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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMB_Delivery_Management
{
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }

        

        

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            PopulateDriverComboBox();
        }

        
     

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            Address.Text = "";
            Baggage.Text = "";
            contact.Text = "";
        
            description.Text = "";
            status.Text = "STATUS : PENDING";
            status.BackColor = Color.RoyalBlue;
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();

        }


        private bool CheckDeliveryExists(string BaggageId)
        {
            SqlConnection connection = new SqlConnection(DAO.ConnectionString);
            
            
                connection.Open();

                string query = $"SELECT COUNT(*) FROM DeliveryInfo WHERE deliveryid = '{BaggageId}'";
                SqlCommand command = new SqlCommand(query, connection);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string BaggageId = Baggage.Text;

            bool deliveryExists = CheckDeliveryExists(BaggageId);

            if (deliveryExists)
            {
                MessageBox.Show("A driver with the same ID already exists.");
                return;
            }


            
            string Add = Address.Text;
            int ContactNo = int.Parse(contact.Text);
            string Desc = description.Text;
            int DriverId = int.Parse(comboBox1.Text);

            SqlConnection connection = new SqlConnection(DAO.ConnectionString);
            
            connection.Open();


            string query = $"INSERT INTO DeliveryInfo (DeliveryID,DriverID,Address,Contact,Description) VALUES ('{BaggageId}','{DriverId}' ,'{Add}','{ContactNo}','{Desc}')";
            SqlCommand command = new SqlCommand(query, connection);

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("New Delivery added successfully.");
            }
            else
            {
                MessageBox.Show("Insertion failed.");
            }

            connection.Close();
        

            status.ForeColor = Color.Black;
            status.BackColor = Color.DarkSeaGreen;
            status.Text = "STATUS : SUBMITTED";

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
        

        private void button2_Click(object sender, EventArgs e)
        {
            PendingDeliveries objPdeliveries = new PendingDeliveries();
            objPdeliveries.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Drivers objdriverpage = new Drivers();
            objdriverpage.Show();
            this.Hide();
        }
    }
}
