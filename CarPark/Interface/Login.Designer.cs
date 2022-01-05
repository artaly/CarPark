
namespace CarPark.Interface
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.ForeColor = System.Drawing.Color.White;
            this.tbxUsername.HintForeColor = System.Drawing.Color.Black;
            this.tbxUsername.HintText = "Username";
            this.tbxUsername.isPassword = false;
            this.tbxUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.tbxUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(178)))));
            this.tbxUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(211)))), ((int)(((byte)(241)))));
            this.tbxUsername.LineThickness = 4;
            this.tbxUsername.Location = new System.Drawing.Point(47, 295);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(401, 68);
            this.tbxUsername.TabIndex = 3;
            this.tbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.White;
            this.tbxPassword.HintForeColor = System.Drawing.Color.Black;
            this.tbxPassword.HintText = "Password";
            this.tbxPassword.isPassword = true;
            this.tbxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(140)))), ((int)(((byte)(160)))));
            this.tbxPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(178)))));
            this.tbxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(211)))), ((int)(((byte)(241)))));
            this.tbxPassword.LineThickness = 4;
            this.tbxPassword.Location = new System.Drawing.Point(47, 393);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(401, 68);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 4;
            this.btnLogin.ButtonText = "LOGIN";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = null;
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(127, 535);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(38)))), ((int)(((byte)(104)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(110)))), ((int)(((byte)(154)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(241, 54);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Open Sans SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(451, 12);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(33, 34);
            this.lblClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblClose.TabIndex = 9;
            this.lblClose.TabStop = false;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(496, 667);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lblClose;
    }
}