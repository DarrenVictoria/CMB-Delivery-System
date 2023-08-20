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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
                    }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Address.Text = "";
            Baggage.Text = "";
            contact.Text = "";
            tempbox.Text = "";
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

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }


        private bool CheckDeliveryExists(string BaggageId)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True"))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM DeliveryInfo WHERE deliveryid = '{BaggageId}'";
                SqlCommand command = new SqlCommand(query, connection);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
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
            int DriverId = 7;

            SqlConnection connection = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True");
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            description.Text = tempbox.Text;
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
       

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        
            
        }
    }
}
