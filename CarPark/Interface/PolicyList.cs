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
    public partial class PolicyList : Form
    {
        public static SqlConnection con = new SqlConnection(UserSQL.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
        public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();
        public static string QuerySelect;
        public static string QueryInsert;
        public static string QueryUpdate;
        public static string QueryDelete;

        public PolicyList()
        {
            InitializeComponent();
        }

        public void DataLoader()
        {
            
            con.Open();
            QuerySelect = "SELECT date as 'Date', license_name AS 'PLATE NUMBER', car_type AS 'TYPE', dateti as 'TIME IN', dateto as 'TIME OUT', total_hours AS 'TOTAL HOURS PARKED', amountpay AS 'AMOUNT PAID', issued_by as 'Issued By' FROM policy_list";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            con.Close();

            dt = new DataTable();
            adapter.Fill(dt);

            dgtTransactionDetails.DataSource = dt;
            dgtTransactionDetails.Refresh();
            dgtTransactionDetails.Columns[0].Visible = false;

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

                QuerySelect = "SELECT date as 'Date', license_name AS 'PLATE NUMBER', car_type AS 'TYPE', dateti as 'TIME IN', dateto as 'TIME OUT', total_hours AS 'TOTAL HOURS PARKED', amountpay AS 'AMOUNT PAID', issued_by as 'Issued By' FROM policy_list WHERE date>='" + dtpFromDate.Text + "' AND date<='" + dtpToDate.Text + "' ORDER BY date ASC";

                cmd = new SqlCommand(QuerySelect, con);

                adapter = new SqlDataAdapter(cmd);
                con.Close();

                dt = new DataTable();
                adapter.Fill(dt);

                dgtTransactionDetails.DataSource = dt;
                dgtTransactionDetails.Refresh();

                lblTotal.Visible = true;
                lblForTotal.Visible = true;


                cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "SELECT SUM(amountpay) FROM policy_list WHERE date>='" + dtpFromDate.Text + "' AND date<='" + dtpToDate.Text + "'";

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

        private void PolicyList_Load(object sender, EventArgs e)
        {
            lblTotal.Visible = false;
            lblForTotal.Visible = false;

            QuerySelect = "SELECT id as 'ID', date as 'Date', license_name AS 'PLATE NUMBER', total_hours AS 'TOTAL HOURS PARKED', amountpay AS 'AMOUNT UNPAID' FROM policy_list ORDER BY date ASC";
            cmd = new SqlCommand(QuerySelect, con);
            
            adapter = new SqlDataAdapter(cmd);
            con.Close();

            dt = new DataTable();
            adapter.Fill(dt);

            dgtTransactionDetails.DataSource = dt;
            dgtTransactionDetails.Refresh();
            dgtTransactionDetails.Columns[0].Visible = false;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            QueryInsert = "INSERT INTO transaction_history(brand, color, date, license_name, car_type, dateti, dateto, total_hours, amountpay, issued_by) SELECT brand, color, date, license_name, car_type, dateti, dateto, total_hours, amountpay, issued_by FROM policy_list WHERE id = '" + lblNo.Text + "'";

            con.Open();
            cmd = new SqlCommand(QueryInsert, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Car moved to sales report!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            new Receipt().Show();

            QueryDelete = "DELETE FROM policy_list WHERE id = '" + lblNo.Text + "'";
            con.Open();
            cmd = new SqlCommand(QueryDelete, con);
            cmd.ExecuteNonQuery();
            con.Close();
            DataLoader();
        }

        private void dgtTransactionDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow Row = dgtTransactionDetails.Rows[e.RowIndex];
                    lblNo.Text = Row.Cells["ID"].Value.ToString();
                }
            } catch (Exception w)
            {

            }
            {

            }
        }

        private void copyAlltoClipboard()
        {

            dgtTransactionDetails.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgtTransactionDetails.MultiSelect = true;
            dgtTransactionDetails.SelectAll();
            DataObject dataObj = dgtTransactionDetails.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            dgtTransactionDetails.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgtTransactionDetails.MultiSelect = true;
            //dgtTransactionDetails.SelectAll();
        }

        private void ExportToExcel()
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblNo_Click(object sender, EventArgs e)
        {

        }
    }
}
