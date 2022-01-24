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
    public partial class Dashboard : Form
    {
        public Dashboard()
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
        public static int standardRate = 25;
        public static int luxuryRate = 50;
        //public static int rate = 25;
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
            string type = Login.GetUserAccountType.ToString();

            if (type == "Employee")
            {
                bunifuFlatButton1.Hide();
                btnAbandon.Hide();
            }


            DataLoader();
            btnAbandon.Enabled = false;
            timer.Enabled = true;

            /*int car_type;

            using (var con = new SqlConnection(UserSQL.ConString))
            {
                var sql = "SELECT ctype_id FROM car_transactions";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                    con.Open();
                    car_type = (int)cmd.ExecuteScalar();

                }
            }*/


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

            using (var con = new SqlConnection(UserSQL.ConString))
            {
                try
                {
                    string query = "select car_type, ctype_id from car_types";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "car_types");
                    cbxType.DisplayMember = "car_type";
                    cbxType.ValueMember = "ctype_id";
                    cbxType.DataSource = ds.Tables["car_types"];
                    con.Close();
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }
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
                            string txtDisplayDate = string.Format("{0:M/d/yyyy h:mm:ss tt}", date);
                            string dateToday = string.Format("{0:M/d/yyyy}", date);
                            var time = DateTime.Now;

                            String timeIn = time.ToString("h:mm:ss tt");

                            QueryInsert = "INSERT INTO car_transactions(brand, color, license_name, ctype_id, car_type, time_in, dateti, time_out, dateto, total_hours, date, amountpay) VALUES('" + tbxBrand.Text + "', '" + tbxColor.Text + "', '" + tbxLicense.Text + "', '" + cbxType.SelectedValue + "',  '" + cbxType.Text + "', '" + timeIn + "', '" + txtDisplayDate + "', '" + null + "', '" + null + "', '" + null + "', '" + dateToday + "', '" + null + "')";

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
            QuerySelect = "SELECT date AS 'Date', license_name AS 'License Plate', brand AS 'Brand', color AS 'Color', car_type as 'Type', time_in AS 'Time in', time_out AS 'Time out' FROM car_transactions ORDER BY id DESC";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dtgData.DataSource = dt;
            dtgData.Refresh();

            con.Close();
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
                    string txtDisplayDate = string.Format("{0:M/d/yyyy h:mm:ss tt}", date);
                    var time = DateTime.Now;

                    String timeOut = time.ToString("h:mm:ss tt");

                    QueryUpdate = "UPDATE car_transactions SET brand='" + tbxBrand.Text + "', color='" + tbxColor.Text + "', time_out='" + timeOut + "', dateto='" + txtDisplayDate + "' WHERE license_name='" + tbxLicense.Text + "'";
                    cmd = new SqlCommand(QueryUpdate, con);
                    cmd.ExecuteNonQuery();

                    /*string timeInt;

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
                    */

                    int hours;

                    using (var con = new SqlConnection(UserSQL.ConString))
                    {
                        var sql = "SELECT DATEDIFF(hour, dateti, dateto) FROM car_transactions WHERE license_name = @license_name";
                        using (var cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                            con.Open();
                            hours = (int)cmd.ExecuteScalar();

                        }
                    }


                    //int hours = (int)Convert.ToDateTime(timeOut).Subtract(Convert.ToDateTime(timeInt)).TotalHours;

                    int car_type;

                    using (var con = new SqlConnection(UserSQL.ConString))
                    {
                        var sql = "SELECT ctype_id FROM car_transactions WHERE license_name='" + tbxLicense.Text + "'";
                        using (var cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@license_name", tbxLicense.Text);
                            con.Open();
                            car_type = (int)cmd.ExecuteScalar();

                        }
                    }

                    if (hours > 0)
                    {
                        if (car_type == 1)
                        {
                            float amountToPay = hours * standardRate;
                            QueryUpdate = "UPDATE car_transactions SET amountpay ='" + amountToPay + "', total_hours='" + hours + "' WHERE license_name='" + tbxLicense.Text + "'";
                            cmd = new SqlCommand(QueryUpdate, con);
                            cmd.ExecuteNonQuery();
                        } else if (car_type == 2)
                        {
                            float amountToPay = hours * luxuryRate;
                            QueryUpdate = "UPDATE car_transactions SET amountpay ='" + amountToPay + "', total_hours='" + hours + "' WHERE license_name='" + tbxLicense.Text + "'";
                            cmd = new SqlCommand(QueryUpdate, con);
                            cmd.ExecuteNonQuery();
                        }   
                    }
                    else
                    {
                        float amountToPay = 0;
                        QueryUpdate = "UPDATE car_transactions SET amountpay ='" + amountToPay + "', total_hours='" + hours + "' WHERE license_name='" + tbxLicense.Text + "'";
                        cmd = new SqlCommand(QueryUpdate, con);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();

                    QueryInsert = "INSERT INTO transaction_history(brand, color, date, license_name, car_type, dateti, dateto, total_hours, amountpay) SELECT brand, color, date, license_name, car_type, dateti, dateto, total_hours, amountpay FROM car_transactions WHERE license_name = '" + tbxLicense.Text + "'";

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

            new Receipt().Show();

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
            

            lblUserType.Text = Login.GetUserAccountType.ToString();
            lblUser.Text = Login.GetUserAccountName.ToString();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            new TransactionSales().Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new PolicyList().Show();
            this.Hide();
        }

        private void lblUserType_Click(object sender, EventArgs e)
        {

        }

        private void btnAbandon_Click(object sender, EventArgs e)
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
                        float amountToPay = hours * standardRate;
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

                    QueryInsert = "INSERT INTO policy_list(date, license_name, total_hours, amountpay) SELECT date, license_name, total_hours, amountpay FROM car_transactions WHERE license_name = '" + tbxLicense.Text + "'";

                    con.Open();
                    cmd = new SqlCommand(QueryInsert, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Car moved to policy list!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

       private void dtgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
           {
               DataGridViewRow Row = dtgData.Rows[e.RowIndex];
                btnAbandon.Enabled = true;
                tbxTimeIn.Text = Row.Cells["Time in"].Value.ToString();
               tbxTimeOut.Text = Row.Cells["Time out"].Value.ToString();
               tbxLicense.Text = Row.Cells["License Plate"].Value.ToString();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
    }
