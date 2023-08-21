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
    public partial class Driverdelivery : Form
    {
        public string driverusername;
        private int SelectedDriverId;

        public Driverdelivery(string driverusername)
        {
            InitializeComponent();
            this.driverusername = driverusername;    
        }


        

        public static implicit operator Driverdelivery(Dashboard v)
        {
            throw new NotImplementedException();
        }

        


        public void LoadDeliveryData(string driverusername)
        {
            SqlConnection connection = new SqlConnection(DAO.ConnectionString);
            
            SqlCommand command = new SqlCommand("SELECT * FROM DeliveryInfo WHERE DriverID = (SELECT DriverID FROM Driver WHERE username = @username)", connection);
            command.Parameters.AddWithValue("@username", driverusername);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["DeliveryID"], reader["DriverID"], reader["Address"], reader["Contact"], reader["Description"], reader["ConfirmOrder"], reader["PickupStatus"], reader["OngoingDelivery"], reader["DeliveryStatus"]);
            }

            reader.Close();
            connection.Close();
        }

        private void Driverdelivery_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(driverusername))
            {
                LoadDeliveryData(driverusername);
            }
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int deliveryID = Convert.ToInt32(selectedRow.Cells["Column1"].Value);
                int driverID = Convert.ToInt32(selectedRow.Cells["Column2"].Value); 

                Delivery detailsForm = new Delivery(deliveryID,driverusername);
                detailsForm.Show();
                this.Close();
            }
        }

        private void DriverLogout_Click(object sender, EventArgs e)
        {
            LoginUser objLogOutUser= new LoginUser();
            objLogOutUser.Show();
            this.Hide();
        }
    }
}
