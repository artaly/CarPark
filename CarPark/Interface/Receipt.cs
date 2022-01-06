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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        
        

        

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }


        private void btnTimeIn_Click(object sender, EventArgs e)
        {
           
        }

        public void DataLoader()
        {
            
        }

        private void dtgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
