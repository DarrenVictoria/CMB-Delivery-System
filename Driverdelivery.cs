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
    public partial class Driverdelivery : Form
    {
        public Driverdelivery()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label8.BackColor = Color.LightGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label8.BackColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label8.BackColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
