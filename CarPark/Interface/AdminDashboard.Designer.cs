
namespace CarPark.Interface
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalesReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dshDate = new System.Windows.Forms.Label();
            this.timerDash = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btnSalesReport);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 1081);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.panel2.Controls.Add(this.dshDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 111);
            this.panel2.TabIndex = 0;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.btnSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnSalesReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalesReport.BorderRadius = 0;
            this.btnSalesReport.ButtonText = "List Of Items";
            this.btnSalesReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesReport.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalesReport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalesReport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalesReport.Iconimage")));
            this.btnSalesReport.Iconimage_right = null;
            this.btnSalesReport.Iconimage_right_Selected = null;
            this.btnSalesReport.Iconimage_Selected = null;
            this.btnSalesReport.IconMarginLeft = 0;
            this.btnSalesReport.IconMarginRight = 0;
            this.btnSalesReport.IconRightVisible = true;
            this.btnSalesReport.IconRightZoom = 0D;
            this.btnSalesReport.IconVisible = true;
            this.btnSalesReport.IconZoom = 90D;
            this.btnSalesReport.IsTab = false;
            this.btnSalesReport.Location = new System.Drawing.Point(0, 104);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.btnSalesReport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.btnSalesReport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalesReport.selected = false;
            this.btnSalesReport.Size = new System.Drawing.Size(342, 74);
            this.btnSalesReport.TabIndex = 12;
            this.btnSalesReport.Text = "List Of Items";
            this.btnSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalesReport.Textcolor = System.Drawing.Color.White;
            this.btnSalesReport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dshDate
            // 
            this.dshDate.AutoSize = true;
            this.dshDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dshDate.Location = new System.Drawing.Point(62, 39);
            this.dshDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dshDate.Name = "dshDate";
            this.dshDate.Size = new System.Drawing.Size(199, 29);
            this.dshDate.TabIndex = 2;
            this.dshDate.Text = "Date Placeholder";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1937, 1081);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalesReport;
        private System.Windows.Forms.Label dshDate;
        private System.Windows.Forms.Timer timerDash;
    }
}