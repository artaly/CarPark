
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
            this.btnParkingMonitoring = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dshDate = new System.Windows.Forms.Label();
            this.timerDash = new System.Windows.Forms.Timer(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.btnParkingMonitoring);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 1081);
            this.panel1.TabIndex = 0;
            // 
            // btnParkingMonitoring
            // 
            this.btnParkingMonitoring.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.btnParkingMonitoring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.btnParkingMonitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParkingMonitoring.BorderRadius = 0;
            this.btnParkingMonitoring.ButtonText = "Park Monitoring";
            this.btnParkingMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParkingMonitoring.DisabledColor = System.Drawing.Color.Gray;
            this.btnParkingMonitoring.Iconcolor = System.Drawing.Color.Transparent;
            this.btnParkingMonitoring.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnParkingMonitoring.Iconimage")));
            this.btnParkingMonitoring.Iconimage_right = null;
            this.btnParkingMonitoring.Iconimage_right_Selected = null;
            this.btnParkingMonitoring.Iconimage_Selected = null;
            this.btnParkingMonitoring.IconMarginLeft = 0;
            this.btnParkingMonitoring.IconMarginRight = 0;
            this.btnParkingMonitoring.IconRightVisible = true;
            this.btnParkingMonitoring.IconRightZoom = 0D;
            this.btnParkingMonitoring.IconVisible = true;
            this.btnParkingMonitoring.IconZoom = 90D;
            this.btnParkingMonitoring.IsTab = false;
            this.btnParkingMonitoring.Location = new System.Drawing.Point(0, 111);
            this.btnParkingMonitoring.Margin = new System.Windows.Forms.Padding(0);
            this.btnParkingMonitoring.Name = "btnParkingMonitoring";
            this.btnParkingMonitoring.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.btnParkingMonitoring.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.btnParkingMonitoring.OnHoverTextColor = System.Drawing.Color.White;
            this.btnParkingMonitoring.selected = false;
            this.btnParkingMonitoring.Size = new System.Drawing.Size(342, 74);
            this.btnParkingMonitoring.TabIndex = 12;
            this.btnParkingMonitoring.Text = "Park Monitoring";
            this.btnParkingMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnParkingMonitoring.Textcolor = System.Drawing.Color.White;
            this.btnParkingMonitoring.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Manage User";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 184);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(25)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(342, 74);
            this.bunifuFlatButton1.TabIndex = 13;
            this.bunifuFlatButton1.Text = "Manage User";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
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
        private Bunifu.Framework.UI.BunifuFlatButton btnParkingMonitoring;
        private System.Windows.Forms.Label dshDate;
        private System.Windows.Forms.Timer timerDash;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}