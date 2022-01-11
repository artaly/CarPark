using CarPark.Database;
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


namespace CarPark.Interface
{
    public partial class Login : Form
    {
        public static SqlConnection con = new SqlConnection(UserSQL.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT role from employees WHERE username=@username and password=@password";
            string returnValue = "";
            using (con)
            {
                using (cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = tbxUsername.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = tbxPassword.Text;
                    con.Open();
                    returnValue = (string)cmd.ExecuteScalar();
                }
            }

            if (String.IsNullOrEmpty(returnValue))
            {
                MessageBox.Show("Fill up the fields!");
                return;
            }
            returnValue = returnValue.Trim();
            if (returnValue == "Admin")
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
            else if (returnValue == "Employee")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Incorrect username or password");
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
