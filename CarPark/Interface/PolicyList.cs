﻿using System.Collections.Generic;
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
            lblTotal.Text = dtpFromDate.Text;
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Format = DateTimePickerFormat.Custom;

            dtpFromDate.CustomFormat = "M/d/yyyy";
            dtpToDate.CustomFormat = "M/d/yyyy";
            con.Open();
            QuerySelect = "SELECT date as 'Date', license_name AS 'PLATE NUMBER', total_hours AS 'TOTAL HOURS PARKED', amountpay AS 'AMOUNT PAID' FROM policy_list WHERE date>='" + dtpFromDate.Text + "' AND date<='" + dtpToDate.Text + "' ORDER BY date ASC";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            con.Close();

            dt = new DataTable();
            adapter.Fill(dt);

            dgtTransactionDetails.DataSource = dt;
            dgtTransactionDetails.Refresh();

            cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT SUM(amountpay) FROM policy_list WHERE date>='" + dtpFromDate.Text + "' AND date<='" + dtpToDate.Text + "'";

            try
            {
                var obj = cmd.ExecuteScalar();
                double result = obj != null ? (double)obj : 0;
                
                lblTotal.Text = "PHP " + result.ToString();
            } catch
            {
                MessageBox.Show("No transaction!");
            }
            con.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataLoader();
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

        private void PolicyList_Load(object sender, EventArgs e)
        {
            QuerySelect = "SELECT date as 'Date', license_name AS 'PLATE NUMBER', total_hours AS 'TOTAL HOURS PARKED', amountpay AS 'AMOUNT UNPAID' FROM policy_list ORDER BY date ASC";
            cmd = new SqlCommand(QuerySelect, con);

            adapter = new SqlDataAdapter(cmd);
            con.Close();

            dt = new DataTable();
            adapter.Fill(dt);

            dgtTransactionDetails.DataSource = dt;
            dgtTransactionDetails.Refresh();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            QueryInsert = "INSERT INTO transaction_history(date, license_name, total_hours, amountpay) SELECT date, license_name, total_hours, amountpay FROM policy_list WHERE license_name = '" + tbxLicense.Text + "'";

            con.Open();
            cmd = new SqlCommand(QueryInsert, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Car moved to sales report!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            QueryDelete = "DELETE FROM car_transactions WHERE brand = '" + tbxBrand.Text + "'";
            con.Open();
            cmd = new SqlCommand(QueryDelete, con);
            cmd.ExecuteNonQuery();
            con.Close();
            DataLoader();
        }
    }
}
