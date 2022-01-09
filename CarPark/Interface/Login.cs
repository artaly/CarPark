using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarPark.Interface
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (tbxUsername.Text == "" && tbxPassword.Text == "")
            {
                new AdminDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or Password you entered is incorrect. Try Again");
                tbxUsername.Text = "";
                tbxPassword.Text = "";

            }
        }

        private void lblClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
