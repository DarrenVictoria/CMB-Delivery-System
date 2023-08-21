using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using CMB_Delivery_Management.Model;

namespace CMB_Delivery_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        void UpdateOngoingCountLabel()
        {
            try
            {
                SqlConnection connection = new SqlConnection(DAO.ConnectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DeliveryInfo WHERE OngoingDelivery = 'Ongoing'", connection);
                int ongoingCount = (int)cmd.ExecuteScalar();
                connection.Close();

                label2.Text = ongoingCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        void UpdateTotalDriversLabel()
        {
            try
            {
                SqlConnection connection = new SqlConnection(DAO.ConnectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DriverCred", connection);
                int driverCount = (int)cmd.ExecuteScalar();
                connection.Close();

                drivercount.Text = driverCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        void FillChart()
        {
            try
            {
                SqlConnection connection = new SqlConnection(DAO.ConnectionString);

                DataTable dt = new DataTable();

                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ConfirmOrder,PickupStatus,OngoingDelivery,DeliveryStatus FROM DeliveryInfo", connection);
                da.Fill(dt);
                connection.Close();


                //int pendingCount = CountStatus(dt, "DeliveryStatus", "Pending");
                //int completedCount = CountStatus(dt, "DeliveryStatus", "Completed");
                int orderConfirmCount = CountStatus(dt, "ConfirmOrder", "Confirmed");
                int pickupStatusCount = CountStatus(dt, "PickupStatus", "Baggage Picked Up");
                int ongoingDeliveryCount = CountStatus(dt, "OngoingDelivery", "Ongoing");
                int deliveryStatusCount = CountStatus(dt, "DeliveryStatus", "Successfull");


                DeliveryStatusChart.Series.Clear();
                Series series = new Series
                {
                    Name = "Status",
                    IsVisibleInLegend = true,
                    ChartType = SeriesChartType.Pie
                };

                series.Points.AddXY("Order Confirm", orderConfirmCount);
                series.Points.AddXY("Pickup Status", pickupStatusCount);
                series.Points.AddXY("Ongoing Delivery", ongoingDeliveryCount);
                series.Points.AddXY("Delivery Status", deliveryStatusCount);


                series["PieLabelStyle"] = "Disabled";


                DeliveryStatusChart.Series.Add(series);
                DeliveryStatusChart.Titles.Add("Delivery Status");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }

        private int CountStatus(DataTable data, string columnName, string status)
        {
            int count = 0;
            foreach (DataRow row in data.Rows)
            {
                if (row[columnName].ToString().Equals(status, StringComparison.OrdinalIgnoreCase))
                    count++;
            }
            return count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Drivers objdriverpage = new Drivers();
            objdriverpage.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeliveryForm form = new DeliveryForm();
            form.Show();
            this.Hide();
        }

        private void DashboardLogOut_Click(object sender, EventArgs e)
        {
            LoginAdmin objLogOutAdmin = new LoginAdmin();
            objLogOutAdmin.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            FillChart();
            UpdateOngoingCountLabel();
            UpdateTotalDriversLabel();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PendingDeliveries objPdeliveries = new PendingDeliveries();
            objPdeliveries.Show();
            this.Hide();
        }
    }
}
