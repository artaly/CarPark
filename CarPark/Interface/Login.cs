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
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        public static string QueryDelete;
        public static string GetUserAccountType;
        public static string GetUserAccountName;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            QuerySelect = "SELECT * FROM employees WHERE username='" + tbxUsername.Text + "' AND password='" + tbxPassword.Text + "'";
            con.Close();
            con.Open();
            cmd = new SqlCommand(QuerySelect, con);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                GetUserAccountType = reader["role"].ToString();
                GetUserAccountName = reader["first_name"].ToString();
            }
            con.Close();

            string query = "SELECT role from employees WHERE username=@username and password=@password";
            string returnValue = "";
            con.Open();
            using (con)
            {
                using (cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = tbxUsername.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = tbxPassword.Text;
                    
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
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
                tbxUsername.Text = "";
                tbxPassword.Text = "";
            }
            con.Close();
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
