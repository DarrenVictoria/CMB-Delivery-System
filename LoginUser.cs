using CMB_Delivery_Management.Converters;
using CMB_Delivery_Management.Helpers;
using CMB_Delivery_Management.Model;
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
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            string uname = tb_username.Text;
            string password = Hashing.CalculateMD5(tb_password.Text);

            var isValidUser = DAO.VerifyUser(uname, password, AccountType.Driver);
            if (isValidUser)
            {
                Driverdelivery objdriverdashboard = new Driverdelivery();
                objdriverdashboard.Show();
                this.Hide();
            }
        }
    }
}
