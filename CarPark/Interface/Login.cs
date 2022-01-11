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
            if (tbxUsername.Text == "")
            {
                MessageBox.Show("Enter your username first", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxUsername.Focus();
            }
            else if (tbxPassword.Text == "")
            {
                MessageBox.Show("Enter your password first", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxPassword.Focus();
            }
            else
            {
                try
                {
                    QuerySelect = "SELECT * FROM UserAccount WHERE username='" + tbxUsername.Text + "' AND password='" + tbxPassword.Text + "'";
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand(QuerySelect, con);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        GetUserAccountID = reader["id"].ToString();
                        GetUserAccountType = reader["accounttype"].ToString();
                        GetUserAccountName = reader["name"].ToString();
                        GetUserAccountUsername = reader["username"].ToString();
                        Home h = new Home();
                        h.Show();
                        ClearAll();
                        reader.Close();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account! Try Again...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearAll();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /*
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
            */
        }

        private void lblClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact administrator");
        }
    }
}
