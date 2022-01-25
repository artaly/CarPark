using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CarPark.Database;
using System;

namespace CarPark.Interface
{
    public partial class TransactionSales : Form
    {
        public static SqlConnection con = new SqlConnection(UserSQL.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static string QuerySelect;

        public TransactionSales()
        {
            InitializeComponent();
        }

        public void DataLoader()
        {
            con.Open();

            QuerySelect = "SELECT date as 'Date', license_name AS 'PLATE NUMBER', car_type AS 'TYPE', dateti as 'TIME IN', dateto as 'TIME OUT', total_hours AS 'TOTAL HOURS PARKED', amountpay AS 'AMOUNT PAID', issued_by as 'Issued By' FROM transaction_history ORDER BY date ASC";

            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            con.Close();

            dt = new DataTable();
            adapter.Fill(dt);

            dgtTransactionDetails.DataSource = dt;
            dgtTransactionDetails.Refresh();

            cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT SUM(amountpay) FROM transaction_history WHERE date>='" + dtpFromDate.Text + "' AND date<='" + dtpToDate.Text + "'";

            try
            {
                var obj = cmd.ExecuteScalar();
                double result = obj != null ? (double)obj : 0;
                
                lblTotal.Text = "PHP " + result.ToString();
            } catch
            {
                //MessageBox.Show("No transaction!");
            }
            con.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           DataLoader();
                try
                {
                    dtpFromDate.Format = DateTimePickerFormat.Custom;
                    dtpToDate.Format = DateTimePickerFormat.Custom;

                    dtpFromDate.CustomFormat = "M/d/yyyy";
                    dtpToDate.CustomFormat = "M/d/yyyy";
                    con.Open();

                    QuerySelect = "SELECT date as 'Date', license_name AS 'PLATE NUMBER', car_type AS 'TYPE', dateti as 'TIME IN', dateto as 'TIME OUT', total_hours AS 'TOTAL HOURS PARKED', amountpay AS 'AMOUNT PAID', issued_by as 'Issued By' FROM transaction_history WHERE date>='" + dtpFromDate.Text + "' AND date<='" + dtpToDate.Text + "' ORDER BY date ASC";

                    cmd = new SqlCommand(QuerySelect, con);

                    adapter = new SqlDataAdapter(cmd);
                    con.Close();

                    dt = new DataTable();
                    adapter.Fill(dt);

                    dgtTransactionDetails.DataSource = dt;
                    dgtTransactionDetails.Refresh();

                    cmd = con.CreateCommand();
                    con.Open();
                    cmd.CommandText = "SELECT SUM(amountpay) FROM transaction_history WHERE date>='" + dtpFromDate.Text + "' AND date<='" + dtpToDate.Text + "' ORDER BY date ASC";

                    try
                    {
                        var obj = cmd.ExecuteScalar();
                        double result = obj != null ? (double)obj : 0;

                        lblTotal.Text = "PHP " + result.ToString();
                    }
                    catch
                    {
                        //MessageBox.Show("No transaction!");
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void TransactionSales_Load(object sender, EventArgs e)
        {
            DataLoader();
        }
    }
}
