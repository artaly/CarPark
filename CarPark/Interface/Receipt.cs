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
using Microsoft.Reporting.WinForms;

namespace CarPark
{
    public partial class Receipt : Form
    {

        public static SqlConnection con = new SqlConnection(UserSQL.ConString);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader reader;
      //  public static SqlDataAdapter adapter;
        public static DataTable dt = new DataTable();

        public Receipt()
        {
            InitializeComponent();
        }



        private void Dashboard_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, license_name, car_type, dateti, dateto, total_hours, amountpay FROM transaction_history ORDER BY id DESC", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ForInvoice");

            ReportDataSource dataSource = new ReportDataSource("DataSet_Invoice", ds.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
