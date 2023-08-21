using CMB_Delivery_Management.Converters;
using CMB_Delivery_Management.Helpers;
using CMB_Delivery_Management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMB_Delivery_Management
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            string uname = tb_username.Text;
            string password = Hashing.CalculateMD5(tb_password.Text);

            Debug.WriteLine(password);
            
            var isValidUser = DAO.VerifyUser(uname, password, AccountType.Admin);
            if (isValidUser)
            {
                Dashboard objdashboard = new Dashboard();
                objdashboard.Show();
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
