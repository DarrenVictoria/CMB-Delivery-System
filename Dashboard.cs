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

namespace CMB_Delivery_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        void FillChart()
        {
            SqlConnection con = new SqlConnection("Data Source=TOASTER1\\MSSQLSERVER05;Initial Catalog=BaggageDeliverySystem;Integrated Security=True");
            DataTable dt = new DataTable();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT dstatus FROM newdelivery", con);
            da.Fill(dt);
            con.Close();

            
            int pendingCount = CountStatus(dt, "dstatus", "Pending");
            int completedCount = CountStatus(dt, "dstatus", "Completed");

            
            DeliveryStatusChart.Series.Clear();
            Series series = new Series
            {
                Name = "DeliveryStatus",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };

            series.Points.AddXY("Pending", pendingCount);
            series.Points.AddXY("Completed", completedCount);

            DeliveryStatusChart.Series.Add(series);
            DeliveryStatusChart.Titles.Add("Delivery Status");
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
        }

        private void ViewDelivery_Click(object sender, EventArgs e)
        {
            PendingDeliveries objPdeliveries = new PendingDeliveries();
            objPdeliveries.Show();
            this.Hide();
        }

        private void DeliveryStatusChart_Click(object sender, EventArgs e)
        {

        }
    }
}
