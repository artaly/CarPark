
using System.Drawing;

namespace CarPark
{
    partial class DashboardEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardEmployee));
            this.gpbInput = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTimeOut = new System.Windows.Forms.TextBox();
            this.tbxTimeIn = new System.Windows.Forms.TextBox();
            this.btnTimeOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimeIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.tbxLicense = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.lblOccupied = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblAvailableSlot = new System.Windows.Forms.Label();
            this.lblOccupiedSlot = new System.Windows.Forms.Label();
            this.gbpSlots = new System.Windows.Forms.GroupBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblClose = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.gbpSlots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInput
            // 
            this.gpbInput.Controls.Add(this.comboBox1);
            this.gpbInput.Controls.Add(this.label1);
            this.gpbInput.Controls.Add(this.tbxTimeOut);
            this.gpbInput.Controls.Add(this.tbxTimeIn);
            this.gpbInput.Controls.Add(this.btnTimeOut);
            this.gpbInput.Controls.Add(this.btnTimeIn);
            this.gpbInput.Controls.Add(this.lblTimeout);
            this.gpbInput.Controls.Add(this.lblTimeIn);
            this.gpbInput.Controls.Add(this.lblColor);
            this.gpbInput.Controls.Add(this.tbxColor);
            this.gpbInput.Controls.Add(this.lblBrand);
            this.gpbInput.Controls.Add(this.tbxBrand);
            this.gpbInput.Controls.Add(this.lblLicense);
            this.gpbInput.Controls.Add(this.tbxLicense);
            this.gpbInput.Location = new System.Drawing.Point(1022, 249);
            this.gpbInput.Name = "gpbInput";
            this.gpbInput.Size = new System.Drawing.Size(382, 540);
            this.gpbInput.TabIndex = 0;
            this.gpbInput.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Standard",
            "Luxury"});
            this.comboBox1.Location = new System.Drawing.Point(226, 224);
            this.comboBox1.MaxDropDownItems = 2;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 34);
            this.comboBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(136, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "TYPE";
            // 
            // tbxTimeOut
            // 
            this.tbxTimeOut.Enabled = false;
            this.tbxTimeOut.Location = new System.Drawing.Point(224, 382);
            this.tbxTimeOut.Multiline = true;
            this.tbxTimeOut.Name = "tbxTimeOut";
            this.tbxTimeOut.Size = new System.Drawing.Size(127, 34);
            this.tbxTimeOut.TabIndex = 17;
            // 
            // tbxTimeIn
            // 
            this.tbxTimeIn.Enabled = false;
            this.tbxTimeIn.Location = new System.Drawing.Point(225, 284);
            this.tbxTimeIn.Multiline = true;
            this.tbxTimeIn.Name = "tbxTimeIn";
            this.tbxTimeIn.Size = new System.Drawing.Size(127, 34);
            this.tbxTimeIn.TabIndex = 16;
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(125)))), ((int)(((byte)(89)))));
            this.btnTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.btnTimeOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimeOut.BorderRadius = 4;
            this.btnTimeOut.ButtonText = "OUT";
            this.btnTimeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimeOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimeOut.Iconimage = null;
            this.btnTimeOut.Iconimage_right = null;
            this.btnTimeOut.Iconimage_right_Selected = null;
            this.btnTimeOut.Iconimage_Selected = null;
            this.btnTimeOut.IconMarginLeft = 0;
            this.btnTimeOut.IconMarginRight = 0;
            this.btnTimeOut.IconRightVisible = true;
            this.btnTimeOut.IconRightZoom = 0D;
            this.btnTimeOut.IconVisible = true;
            this.btnTimeOut.IconZoom = 90D;
            this.btnTimeOut.IsTab = false;
            this.btnTimeOut.Location = new System.Drawing.Point(223, 423);
            this.btnTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.btnTimeOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(125)))), ((int)(((byte)(89)))));
            this.btnTimeOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimeOut.selected = false;
            this.btnTimeOut.Size = new System.Drawing.Size(127, 31);
            this.btnTimeOut.TabIndex = 15;
            this.btnTimeOut.Text = "OUT";
            this.btnTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimeOut.Textcolor = System.Drawing.Color.White;
            this.btnTimeOut.TextFont = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // btnTimeIn
            // 
            this.btnTimeIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.btnTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.btnTimeIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimeIn.BorderRadius = 4;
            this.btnTimeIn.ButtonText = "IN";
            this.btnTimeIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimeIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimeIn.Iconimage = null;
            this.btnTimeIn.Iconimage_right = null;
            this.btnTimeIn.Iconimage_right_Selected = null;
            this.btnTimeIn.Iconimage_Selected = null;
            this.btnTimeIn.IconMarginLeft = 0;
            this.btnTimeIn.IconMarginRight = 0;
            this.btnTimeIn.IconRightVisible = true;
            this.btnTimeIn.IconRightZoom = 0D;
            this.btnTimeIn.IconVisible = true;
            this.btnTimeIn.IconZoom = 90D;
            this.btnTimeIn.IsTab = false;
            this.btnTimeIn.Location = new System.Drawing.Point(224, 325);
            this.btnTimeIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimeIn.Name = "btnTimeIn";
            this.btnTimeIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.btnTimeIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.btnTimeIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimeIn.selected = false;
            this.btnTimeIn.Size = new System.Drawing.Size(127, 31);
            this.btnTimeIn.TabIndex = 14;
            this.btnTimeIn.Text = "IN";
            this.btnTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimeIn.Textcolor = System.Drawing.Color.White;
            this.btnTimeIn.TextFont = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeIn.Click += new System.EventHandler(this.btnTimeIn_Click);
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeout.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeout.Location = new System.Drawing.Point(81, 380);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(131, 33);
            this.lblTimeout.TabIndex = 7;
            this.lblTimeout.Text = "TIME OUT";
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeIn.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeIn.Location = new System.Drawing.Point(107, 284);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(105, 33);
            this.lblTimeIn.TabIndex = 6;
            this.lblTimeIn.Text = "TIME IN";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblColor.Location = new System.Drawing.Point(112, 162);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(100, 33);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "COLOR";
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(226, 162);
            this.tbxColor.Multiline = true;
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(127, 34);
            this.tbxColor.TabIndex = 4;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBrand.Location = new System.Drawing.Point(111, 100);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(101, 33);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "BRAND";
            // 
            // tbxBrand
            // 
            this.tbxBrand.Location = new System.Drawing.Point(226, 100);
            this.tbxBrand.Multiline = true;
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(127, 34);
            this.tbxBrand.TabIndex = 2;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblLicense.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLicense.Location = new System.Drawing.Point(21, 42);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(196, 33);
            this.lblLicense.TabIndex = 1;
            this.lblLicense.Text = "LICENSE PLATE";
            // 
            // tbxLicense
            // 
            this.tbxLicense.Location = new System.Drawing.Point(226, 42);
            this.tbxLicense.Multiline = true;
            this.tbxLicense.Name = "tbxLicense";
            this.tbxLicense.Size = new System.Drawing.Size(127, 34);
            this.tbxLicense.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1207, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dtgData
            // 
            this.dtgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgData.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgData.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgData.Location = new System.Drawing.Point(28, 249);
            this.dtgData.Name = "dtgData";
            this.dtgData.RowHeadersWidth = 51;
            this.dtgData.Size = new System.Drawing.Size(958, 535);
            this.dtgData.TabIndex = 2;
            this.dtgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgData_CellClick);
            // 
            // lblOccupied
            // 
            this.lblOccupied.AutoSize = true;
            this.lblOccupied.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupied.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOccupied.Location = new System.Drawing.Point(309, 16);
            this.lblOccupied.Name = "lblOccupied";
            this.lblOccupied.Size = new System.Drawing.Size(245, 59);
            this.lblOccupied.TabIndex = 3;
            this.lblOccupied.Text = "OCCUPIED";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAvailable.Location = new System.Drawing.Point(31, 16);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(257, 59);
            this.lblAvailable.TabIndex = 4;
            this.lblAvailable.Text = "AVAILABLE";
            // 
            // lblAvailableSlot
            // 
            this.lblAvailableSlot.AutoSize = true;
            this.lblAvailableSlot.Font = new System.Drawing.Font("Corbel", 79.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableSlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.lblAvailableSlot.Location = new System.Drawing.Point(110, 54);
            this.lblAvailableSlot.Name = "lblAvailableSlot";
            this.lblAvailableSlot.Size = new System.Drawing.Size(110, 131);
            this.lblAvailableSlot.TabIndex = 5;
            this.lblAvailableSlot.Text = "0";
            // 
            // lblOccupiedSlot
            // 
            this.lblOccupiedSlot.AutoSize = true;
            this.lblOccupiedSlot.Font = new System.Drawing.Font("Corbel", 79.8F);
            this.lblOccupiedSlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.lblOccupiedSlot.Location = new System.Drawing.Point(373, 54);
            this.lblOccupiedSlot.Name = "lblOccupiedSlot";
            this.lblOccupiedSlot.Size = new System.Drawing.Size(110, 131);
            this.lblOccupiedSlot.TabIndex = 6;
            this.lblOccupiedSlot.Text = "0";
            // 
            // gbpSlots
            // 
            this.gbpSlots.Controls.Add(this.lblOccupied);
            this.gbpSlots.Controls.Add(this.lblAvailable);
            this.gbpSlots.Controls.Add(this.lblAvailableSlot);
            this.gbpSlots.Controls.Add(this.lblOccupiedSlot);
            this.gbpSlots.Location = new System.Drawing.Point(28, 11);
            this.gbpSlots.Name = "gbpSlots";
            this.gbpSlots.Size = new System.Drawing.Size(592, 219);
            this.gbpSlots.TabIndex = 7;
            this.gbpSlots.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(81)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.ButtonText = "DELETE";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(28, 800);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(129, 44);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSales
            // 
            this.btnSales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSales.BorderRadius = 4;
            this.btnSales.ButtonText = "SALES REPORT";
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.DisabledColor = System.Drawing.Color.Gray;
            this.btnSales.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSales.Iconimage = null;
            this.btnSales.Iconimage_right = null;
            this.btnSales.Iconimage_right_Selected = null;
            this.btnSales.Iconimage_Selected = null;
            this.btnSales.IconMarginLeft = 0;
            this.btnSales.IconMarginRight = 0;
            this.btnSales.IconRightVisible = true;
            this.btnSales.IconRightZoom = 0D;
            this.btnSales.IconVisible = true;
            this.btnSales.IconZoom = 90D;
            this.btnSales.IsTab = false;
            this.btnSales.Location = new System.Drawing.Point(164, 800);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnSales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnSales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSales.selected = false;
            this.btnSales.Size = new System.Drawing.Size(168, 44);
            this.btnSales.TabIndex = 9;
            this.btnSales.Text = "SALES REPORT";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSales.Textcolor = System.Drawing.Color.White;
            this.btnSales.TextFont = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // lblClose
            // 
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(1415, 11);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(28, 28);
            this.lblClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblClose.TabIndex = 10;
            this.lblClose.TabStop = false;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(667, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 218);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(166, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "EMPLOYEE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(16, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "USERTYPE:";
            // 
            // DashboardEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1453, 878);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbpSlots);
            this.Controls.Add(this.dtgData);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.gpbInput);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.gpbInput.ResumeLayout(false);
            this.gpbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            this.gbpSlots.ResumeLayout(false);
            this.gbpSlots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInput;
        private System.Windows.Forms.TextBox tbxLicense;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox tbxBrand;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Label lblOccupied;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblAvailableSlot;
        private System.Windows.Forms.Label lblOccupiedSlot;
        private System.Windows.Forms.GroupBox gbpSlots;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnSales;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimeOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimeIn;
        private System.Windows.Forms.PictureBox lblClose;
        private System.Windows.Forms.TextBox tbxTimeOut;
        private System.Windows.Forms.TextBox tbxTimeIn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

