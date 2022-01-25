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

        private void ExportToExcel()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            try
            {
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                for (j = 0; j < dgtTransactionDetails.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    Microsoft.Office.Interop.Excel.Range myRange1 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + 8];
                    Microsoft.Office.Interop.Excel.Range myRange2 = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + 1, StartCol + 8];
                    myRange.Value2 = dgtTransactionDetails.Columns[j].HeaderText;
                    //myRange1.Value2 = label8.Text + " = " + lblPayable.Text;
                    //myRange2.Value2 = label5.Text + " = " + lblTotalAmount.Text;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dgtTransactionDetails.Rows.Count; i++)
                {
                    for (j = 0; j < dgtTransactionDetails.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgtTransactionDetails[j, i].Value == null ? "" : dgtTransactionDetails[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

    }
}
