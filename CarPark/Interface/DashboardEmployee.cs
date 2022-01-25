using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;
using CarPark.Database;
using CarPark.Interface;

namespace CarPark
{
    public partial class DashboardEmployee : Form
    {
        public DashboardEmployee()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(UserSQL.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static string QueryInsert;
        public static string QuerySelect;
        public static string QueryUpdate;
        public static string QueryDelete;
        public static int rate = 25;
        public static int available;
        public static int occupied;
        int numVehicles = 0;

        // Clear all input textboxes
        public void ClearAll()
        {
            tbxBrand.Text = "";
            tbxColor.Text = "";
            tbxLicense.Text = "";

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataLoader();
            timer.Enabled = true;

            int available;
            using (var con = new SqlConnection(UserSQL.ConString))
            {
                var sql = "SELECT available_slots FROM car_slots";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                    con.Open();
                    available = (int)cmd.ExecuteScalar();

                }
            }

            int occupied;

            using (var con = new SqlConnection(UserSQL.ConString))  
            {
                var sql = "SELECT occupied_slots FROM car_slots";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                    con.Open();
                    occupied = (int)cmd.ExecuteScalar();

                }
            }

            lblAvailableSlot.Text = available.ToString();
            lblOccupiedSlot.Text = occupied.ToString();
        }


        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            int available;
            using (var con = new SqlConnection(UserSQL.ConString))
            {
                var sql = "SELECT available_slots FROM car_slots";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                    con.Open();
                    available = (int)cmd.ExecuteScalar();

                }
            }

            int occupied;

            using (var con = new SqlConnection(UserSQL.ConString))
            {
                var sql = "SELECT occupied_slots FROM car_slots";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                    con.Open();
                    occupied = (int)cmd.ExecuteScalar();

                }
            }

            // Checks if fields are null
            if (string.IsNullOrWhiteSpace(tbxColor.Text) ||
                string.IsNullOrWhiteSpace(tbxBrand.Text) ||
                string.IsNullOrWhiteSpace(tbxLicense.Text)
                )
            {
                MessageBox.Show("Please complete the fields.", "Error");
            }
            else
            {
                available = available - 1;
                occupied = occupied + 1;

                /// Write data to labels
                lblAvailableSlot.Text = available.ToString();
                lblOccupiedSlot.Text = occupied.ToString();

                if (available > 0)
                {
                    try
                    {
                        QuerySelect = "SELECT * FROM car_transactions WHERE brand='" + tbxBrand.Text + "' AND color='" + tbxColor.Text + "' AND license_name='" + tbxLicense.Text + "'";
                        con.Close();
                        con.Open();
                        cmd = new SqlCommand(QuerySelect, con);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("This car has already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbxBrand.Focus();
                            ClearAll();
                        }
                        else
                        {
                            con.Close();
                            DateTime date = DateTime.Now;
                            string txtDisplayDate = string.Format("{0:M/d/yyyy}", date);
                            var time = DateTime.Now;

                            String timeIn = time.ToString("h:mm:ss tt");

                            QueryInsert = "INSERT INTO car_transactions(brand, color, license_name, time_in, time_out, total_hours, date, amountpay) VALUES('" + tbxBrand.Text + "', '" + tbxColor.Text + "', '" + tbxLicense.Text + "', '" + timeIn + "', '" + null + "', '" + null + "', '" + txtDisplayDate + "', '" + null + "')";

                            con.Open();
                            cmd = new SqlCommand(QueryInsert, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            QueryUpdate = "UPDATE car_slots SET available_slots='" + available + "', occupied_slots='" + occupied + "'";
                            con.Open();
                            cmd = new SqlCommand(QueryUpdate, con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            tbxBrand.Focus();
                            ClearAll();
                            DataLoader();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
                else
                    MessageBox.Show("Full Parking!", "Error");
            }     
        }

        public void DataLoader()
        {
            con.Close();
            con.Open();
            QuerySelect = "SELECT date AS 'Date',  license_name AS 'License Plate', brand AS 'Brand', color AS 'Color', time_in AS 'Time in', time_out AS 'Time out' FROM car_transactions ORDER BY id DESC";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dtgData.DataSource = dt;
            dtgData.Refresh();

            con.Close();
        }

        private void dtgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow Row = dtgData.Rows[e.RowIndex];

                tbxTimeIn.Text = Row.Cells["Time in"].Value.ToString();
                tbxTimeOut.Text = Row.Cells["Time out"].Value.ToString();
                tbxLicense.Text = Row.Cells["Plate Number"].Value.ToString();
                tbxBrand.Text = Row.Cells["Brand"].Value.ToString();
                tbxColor.Text = Row.Cells["Color"].Value.ToString();
               
                /// Prevent error when selecting rows with empty/null cells
                if (Row.Cells["Time out"].Value.ToString() != null)
                {

                    tbxTimeOut.Text = Row.Cells["Time out"].Value.ToString();
                }
                else
                {
                    lblTimeout.Text = null;
                }

            }
        }


        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            int available;
            using (var con = new SqlConnection(UserSQL.ConString))
            {
                var sql = "SELECT available_slots FROM car_slots";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                    con.Open();
                    available = (int)cmd.ExecuteScalar();

                }
            }

            int occupied;

            using (var con = new SqlConnection(UserSQL.ConString))
            {
                var sql = "SELECT occupied_slots FROM car_slots";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                    con.Open();
                    occupied = (int)cmd.ExecuteScalar();

                }
            }

            if (dtgData.Rows.Count > 0)
            {
                if (occupied > 0)
                {
                    available = available + 1;
                    occupied = occupied - 1;

                    lblAvailableSlot.Text = available.ToString();
                    lblOccupiedSlot.Text = occupied.ToString();

                    numVehicles = numVehicles + 1;

                    con.Close();
                    con.Open();
                    DateTime date = DateTime.Now;
                    var time = DateTime.Now;

                    String timeOut = time.ToString("h:mm:ss tt");

                    QueryUpdate = "UPDATE car_transactions SET brand='" + tbxBrand.Text + "', color='" + tbxColor.Text + "', time_out='" + timeOut + "' WHERE license_name='" + tbxLicense.Text + "'";
                    cmd = new SqlCommand(QueryUpdate, con);
                    cmd.ExecuteNonQuery();

                    string timeInt;

                    using (var con = new SqlConnection(UserSQL.ConString))
                    {
                        var sql = "SELECT time_in FROM car_transactions WHERE license_name = @license_name";
                        using (var cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                            con.Open();
                            timeInt = (string)cmd.ExecuteScalar();

                        }
                    }


                    int hours = (int)Convert.ToDateTime(timeOut).Subtract(Convert.ToDateTime(timeInt)).TotalHours;

                    if (hours > 0)
                    {
                        float amountToPay = hours * rate;
                        QueryUpdate = "UPDATE car_transactions SET amountpay ='" + amountToPay + "', total_hours='" + hours + "' WHERE license_name='" + tbxLicense.Text + "'";
                        cmd = new SqlCommand(QueryUpdate, con);
                        
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        float amountToPay = 0;
                        QueryUpdate = "UPDATE car_transactions SET amountpay ='" + amountToPay + "', total_hours='" + hours + "' WHERE license_name='" + tbxLicense.Text + "'";
                        cmd = new SqlCommand(QueryUpdate, con);
                        cmd.ExecuteNonQuery();
                        
                    }
                    con.Close();

                    QueryInsert = "INSERT INTO transaction_history(date, license_name, total_hours, amountpay) SELECT date, license_name, total_hours, amountpay FROM car_transactions WHERE license_name = '" + tbxLicense.Text + "'";

                    con.Open();
                    cmd = new SqlCommand(QueryInsert, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Car timed out!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QueryDelete = "DELETE FROM car_transactions WHERE brand = '" + tbxBrand.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(QueryDelete, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    QueryUpdate = "UPDATE car_slots SET available_slots='" + available + "', occupied_slots='" + occupied + "'";
                    con.Open();
                    cmd = new SqlCommand(QueryUpdate, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ClearAll();
                    DataLoader();
                }
            }

            else
            {
                MessageBox.Show("No entries currently available.", "Error");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int available;
            using (var con = new SqlConnection(UserSQL.ConString))
            {
                var sql = "SELECT available_slots FROM car_slots";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                    con.Open();
                    available = (int)cmd.ExecuteScalar();

                }
            }

            int occupied;

            using (var con = new SqlConnection(UserSQL.ConString))
            {
                var sql = "SELECT occupied_slots FROM car_slots";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                    con.Open();
                    occupied = (int)cmd.ExecuteScalar();

                }
            }

            available = available + 1;
            occupied = occupied - 1;

            lblAvailableSlot.Text = available.ToString();
            lblOccupiedSlot.Text = occupied.ToString();
            con.Close();
            con.Open();
            QueryDelete = "DELETE FROM car_transactions WHERE license_name='" + tbxLicense.Text + "'";
            cmd = new SqlCommand(QueryDelete, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            QueryUpdate = "UPDATE car_slots SET available_slots='" + available + "', occupied_slots='" + occupied + "'";
            con.Open();
            cmd = new SqlCommand(QueryUpdate, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ClearAll();
            DataLoader();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tbxTimeIn.Text = DateTime.Now.ToString("h:mm:ss tt");
            tbxTimeOut.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            new TransactionSales().Show();
            this.Hide();
        }
    }
}
