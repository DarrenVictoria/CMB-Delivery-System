using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMB_Delivery_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        }

        private void BaggagePickUp_Click(object sender, EventArgs e)
        {
            // Calculate 25% of the maximum value of the progress bar
            int progressBarValue = (int)(progressBar1.Maximum * 0.50);
            // Set the progress bar value
            progressBar1.Value = progressBarValue;
        }

        private void OnGoingDelivery_Click(object sender, EventArgs e)
        {
            // Calculate 25% of the maximum value of the progress bar
            int progressBarValue = (int)(progressBar1.Maximum * 0.75);
            // Set the progress bar value
            progressBar1.Value = progressBarValue;
        }
        private void SuccessDelivery_Click(object sender, EventArgs e)
        {
            // Calculate 25% of the maximum value of the progress bar
            int progressBarValue = (int)(progressBar1.Maximum * 1.0);
            // Set the progress bar value
            progressBar1.Value = progressBarValue;
        }
    }
}
