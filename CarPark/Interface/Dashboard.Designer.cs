
using System.Drawing;

namespace CarPark
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.gpbInput = new System.Windows.Forms.GroupBox();
            this.btnAbandon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbxType = new System.Windows.Forms.ComboBox();
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
            this.lblOccupied = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblAvailableSlot = new System.Windows.Forms.Label();
            this.lblOccupiedSlot = new System.Windows.Forms.Label();
            this.gbpSlots = new System.Windows.Forms.GroupBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblClose = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.gpbInput.SuspendLayout();
            this.gbpSlots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInput
            // 
            this.gpbInput.Controls.Add(this.btnAbandon);
            this.gpbInput.Controls.Add(this.cbxType);
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
            this.gpbInput.Location = new System.Drawing.Point(1363, 306);
            this.gpbInput.Margin = new System.Windows.Forms.Padding(4);
            this.gpbInput.Name = "gpbInput";
            this.gpbInput.Padding = new System.Windows.Forms.Padding(4);
            this.gpbInput.Size = new System.Drawing.Size(509, 665);
            this.gpbInput.TabIndex = 0;
            this.gpbInput.TabStop = false;
            // 
            // btnAbandon
            // 
            this.btnAbandon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(125)))), ((int)(((byte)(89)))));
            this.btnAbandon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.btnAbandon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbandon.BorderRadius = 4;
            this.btnAbandon.ButtonText = "ABANDONED?";
            this.btnAbandon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbandon.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbandon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbandon.Iconimage = null;
            this.btnAbandon.Iconimage_right = null;
            this.btnAbandon.Iconimage_right_Selected = null;
            this.btnAbandon.Iconimage_Selected = null;
            this.btnAbandon.IconMarginLeft = 0;
            this.btnAbandon.IconMarginRight = 0;
            this.btnAbandon.IconRightVisible = true;
            this.btnAbandon.IconRightZoom = 0D;
            this.btnAbandon.IconVisible = true;
            this.btnAbandon.IconZoom = 90D;
            this.btnAbandon.IsTab = false;
            this.btnAbandon.Location = new System.Drawing.Point(297, 594);
            this.btnAbandon.Margin = new System.Windows.Forms.Padding(5);
            this.btnAbandon.Name = "btnAbandon";
            this.btnAbandon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.btnAbandon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(125)))), ((int)(((byte)(89)))));
            this.btnAbandon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAbandon.selected = false;
            this.btnAbandon.Size = new System.Drawing.Size(169, 38);
            this.btnAbandon.TabIndex = 21;
            this.btnAbandon.Text = "ABANDONED?";
            this.btnAbandon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbandon.Textcolor = System.Drawing.Color.White;
            this.btnAbandon.TextFont = new System.Drawing.Font("Open Sans SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAbandon.Click += new System.EventHandler(this.btnAbandon_Click);
            // 
            // cbxType
            // 
            this.cbxType.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(301, 276);
            this.cbxType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxType.MaxDropDownItems = 2;
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(168, 40);
            this.cbxType.TabIndex = 20;
            this.cbxType.Text = "Standard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(178, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "TYPE";
            // 
            // tbxTimeOut
            // 
            this.tbxTimeOut.Enabled = false;
            this.tbxTimeOut.Location = new System.Drawing.Point(299, 470);
            this.tbxTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTimeOut.Multiline = true;
            this.tbxTimeOut.Name = "tbxTimeOut";
            this.tbxTimeOut.Size = new System.Drawing.Size(168, 41);
            this.tbxTimeOut.TabIndex = 17;
            // 
            // tbxTimeIn
            // 
            this.tbxTimeIn.Enabled = false;
            this.tbxTimeIn.Location = new System.Drawing.Point(300, 350);
            this.tbxTimeIn.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTimeIn.Multiline = true;
            this.tbxTimeIn.Name = "tbxTimeIn";
            this.tbxTimeIn.Size = new System.Drawing.Size(168, 41);
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
            this.btnTimeOut.Location = new System.Drawing.Point(297, 521);
            this.btnTimeOut.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.btnTimeOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(125)))), ((int)(((byte)(89)))));
            this.btnTimeOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimeOut.selected = false;
            this.btnTimeOut.Size = new System.Drawing.Size(169, 38);
            this.btnTimeOut.TabIndex = 15;
            this.btnTimeOut.Text = "OUT";
            this.btnTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimeOut.Textcolor = System.Drawing.Color.White;
            this.btnTimeOut.TextFont = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTimeIn.Location = new System.Drawing.Point(299, 400);
            this.btnTimeIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimeIn.Name = "btnTimeIn";
            this.btnTimeIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.btnTimeIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.btnTimeIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimeIn.selected = false;
            this.btnTimeIn.Size = new System.Drawing.Size(169, 38);
            this.btnTimeIn.TabIndex = 14;
            this.btnTimeIn.Text = "IN";
            this.btnTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimeIn.Textcolor = System.Drawing.Color.White;
            this.btnTimeIn.TextFont = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeIn.Click += new System.EventHandler(this.btnTimeIn_Click);
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeout.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeout.Location = new System.Drawing.Point(112, 469);
            this.lblTimeout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(158, 40);
            this.lblTimeout.TabIndex = 7;
            this.lblTimeout.Text = "TIME OUT";
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeIn.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimeIn.Location = new System.Drawing.Point(144, 351);
            this.lblTimeIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(126, 40);
            this.lblTimeIn.TabIndex = 6;
            this.lblTimeIn.Text = "TIME IN";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblColor.Location = new System.Drawing.Point(150, 200);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(120, 40);
            this.lblColor.TabIndex = 5;
            this.lblColor.Text = "COLOR";
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(301, 199);
            this.tbxColor.Margin = new System.Windows.Forms.Padding(4);
            this.tbxColor.Multiline = true;
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(168, 41);
            this.tbxColor.TabIndex = 4;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBrand.Location = new System.Drawing.Point(147, 124);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(123, 40);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "BRAND";
            // 
            // tbxBrand
            // 
            this.tbxBrand.Location = new System.Drawing.Point(301, 123);
            this.tbxBrand.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBrand.Multiline = true;
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(168, 41);
            this.tbxBrand.TabIndex = 2;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblLicense.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLicense.Location = new System.Drawing.Point(34, 53);
            this.lblLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(236, 40);
            this.lblLicense.TabIndex = 1;
            this.lblLicense.Text = "LICENSE PLATE";
            // 
            // tbxLicense
            // 
            this.tbxLicense.Location = new System.Drawing.Point(301, 52);
            this.tbxLicense.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLicense.Multiline = true;
            this.tbxLicense.Name = "tbxLicense";
            this.tbxLicense.Size = new System.Drawing.Size(168, 41);
            this.tbxLicense.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1641, 34);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // lblOccupied
            // 
            this.lblOccupied.AutoSize = true;
            this.lblOccupied.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupied.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOccupied.Location = new System.Drawing.Point(412, 20);
            this.lblOccupied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccupied.Name = "lblOccupied";
            this.lblOccupied.Size = new System.Drawing.Size(307, 73);
            this.lblOccupied.TabIndex = 3;
            this.lblOccupied.Text = "OCCUPIED";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAvailable.Location = new System.Drawing.Point(41, 20);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(322, 73);
            this.lblAvailable.TabIndex = 4;
            this.lblAvailable.Text = "AVAILABLE";
            // 
            // lblAvailableSlot
            // 
            this.lblAvailableSlot.AutoSize = true;
            this.lblAvailableSlot.Font = new System.Drawing.Font("Corbel", 79.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableSlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.lblAvailableSlot.Location = new System.Drawing.Point(147, 66);
            this.lblAvailableSlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableSlot.Name = "lblAvailableSlot";
            this.lblAvailableSlot.Size = new System.Drawing.Size(139, 164);
            this.lblAvailableSlot.TabIndex = 5;
            this.lblAvailableSlot.Text = "0";
            // 
            // lblOccupiedSlot
            // 
            this.lblOccupiedSlot.AutoSize = true;
            this.lblOccupiedSlot.Font = new System.Drawing.Font("Corbel", 79.8F);
            this.lblOccupiedSlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(117)))), ((int)(((byte)(110)))));
            this.lblOccupiedSlot.Location = new System.Drawing.Point(497, 66);
            this.lblOccupiedSlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccupiedSlot.Name = "lblOccupiedSlot";
            this.lblOccupiedSlot.Size = new System.Drawing.Size(139, 164);
            this.lblOccupiedSlot.TabIndex = 6;
            this.lblOccupiedSlot.Text = "0";
            // 
            // gbpSlots
            // 
            this.gbpSlots.Controls.Add(this.lblOccupied);
            this.gbpSlots.Controls.Add(this.lblAvailable);
            this.gbpSlots.Controls.Add(this.lblAvailableSlot);
            this.gbpSlots.Controls.Add(this.lblOccupiedSlot);
            this.gbpSlots.Location = new System.Drawing.Point(37, 14);
            this.gbpSlots.Margin = new System.Windows.Forms.Padding(4);
            this.gbpSlots.Name = "gbpSlots";
            this.gbpSlots.Padding = new System.Windows.Forms.Padding(4);
            this.gbpSlots.Size = new System.Drawing.Size(789, 270);
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
            this.btnDelete.Location = new System.Drawing.Point(37, 985);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(30)))), ((int)(((byte)(49)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(172, 54);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSales.Location = new System.Drawing.Point(219, 985);
            this.btnSales.Margin = new System.Windows.Forms.Padding(5);
            this.btnSales.Name = "btnSales";
            this.btnSales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnSales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(105)))));
            this.btnSales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSales.selected = false;
            this.btnSales.Size = new System.Drawing.Size(224, 54);
            this.btnSales.TabIndex = 9;
            this.btnSales.Text = "SALES REPORT";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSales.Textcolor = System.Drawing.Color.White;
            this.btnSales.TextFont = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // lblClose
            // 
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(2011, 1);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(37, 34);
            this.lblClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblClose.TabIndex = 10;
            this.lblClose.TabStop = false;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 4;
            this.bunifuFlatButton1.ButtonText = "POLICY LIST";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(453, 985);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(239)))), ((int)(((byte)(172)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(207, 54);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "POLICY LIST";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.lblUserType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(1203, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(413, 269);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUser.Location = new System.Drawing.Point(105, 90);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(194, 73);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "NAME";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.Transparent;
            this.lblUserType.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserType.Location = new System.Drawing.Point(221, 33);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(118, 40);
            this.lblUserType.TabIndex = 3;
            this.lblUserType.Text = "ADMIN";
            this.lblUserType.Click += new System.EventHandler(this.lblUserType_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "USERTYPE:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(888, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dtgData
            // 
            this.dtgData.AllowUserToAddRows = false;
            this.dtgData.AllowUserToDeleteRows = false;
            this.dtgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgData.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dtgData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Location = new System.Drawing.Point(37, 314);
            this.dtgData.Margin = new System.Windows.Forms.Padding(4);
            this.dtgData.Name = "dtgData";
            this.dtgData.ReadOnly = true;
            this.dtgData.RowHeadersWidth = 51;
            this.dtgData.Size = new System.Drawing.Size(1318, 657);
            this.dtgData.TabIndex = 35;
            this.dtgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgData_CellClick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1942, 1081);
            this.Controls.Add(this.dtgData);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbpSlots);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.gpbInput);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.gpbInput.ResumeLayout(false);
            this.gpbInput.PerformLayout();
            this.gbpSlots.ResumeLayout(false);
            this.gbpSlots.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbandon;
        private System.Windows.Forms.DataGridView dtgData;
    }
}

