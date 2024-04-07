namespace JCUBE_SE_PROJECT
{
    partial class PosUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosUI));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.btnSettlePayment = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelJcube = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.lblUserRolePOS = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.POSJCUBELOGOIMG = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JCubelbl = new System.Windows.Forms.Label();
            this.POSLoggedInlbl = new System.Windows.Forms.Label();
            this.POSNamelbl = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POSJCUBELOGOIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnChangePassword);
            this.panelSidebar.Controls.Add(this.btnDailySales);
            this.panelSidebar.Controls.Add(this.btnSettlePayment);
            this.panelSidebar.Controls.Add(this.btnCart);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(252, 652);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 620);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(252, 32);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 358);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(252, 50);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnDailySales
            // 
            this.btnDailySales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDailySales.FlatAppearance.BorderSize = 0;
            this.btnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailySales.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySales.ForeColor = System.Drawing.Color.White;
            this.btnDailySales.Location = new System.Drawing.Point(0, 308);
            this.btnDailySales.Margin = new System.Windows.Forms.Padding(2);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Size = new System.Drawing.Size(252, 50);
            this.btnDailySales.TabIndex = 0;
            this.btnDailySales.Text = "Daily Sales";
            this.btnDailySales.UseVisualStyleBackColor = true;
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettlePayment.Enabled = false;
            this.btnSettlePayment.FlatAppearance.BorderSize = 0;
            this.btnSettlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlePayment.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettlePayment.ForeColor = System.Drawing.Color.White;
            this.btnSettlePayment.Location = new System.Drawing.Point(0, 258);
            this.btnSettlePayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(252, 50);
            this.btnSettlePayment.TabIndex = 0;
            this.btnSettlePayment.Text = "Settle Payment";
            this.btnSettlePayment.UseVisualStyleBackColor = true;
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // btnCart
            // 
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Location = new System.Drawing.Point(0, 208);
            this.btnCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(252, 50);
            this.btnCart.TabIndex = 0;
            this.btnCart.Text = "Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.labelJcube);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(252, 208);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelJcube
            // 
            this.labelJcube.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelJcube.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJcube.ForeColor = System.Drawing.Color.White;
            this.labelJcube.Location = new System.Drawing.Point(0, 146);
            this.labelJcube.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJcube.Name = "labelJcube";
            this.labelJcube.Size = new System.Drawing.Size(252, 62);
            this.labelJcube.TabIndex = 0;
            this.labelJcube.Text = "JCUBE SHIELDWORKS CORPORATION";
            this.labelJcube.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panelTitle.Controls.Add(this.lblLoggedIn);
            this.panelTitle.Controls.Add(this.lblUserRolePOS);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(252, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(930, 62);
            this.panelTitle.TabIndex = 1;
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedIn.ForeColor = System.Drawing.Color.White;
            this.lblLoggedIn.Location = new System.Drawing.Point(782, 19);
            this.lblLoggedIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(88, 20);
            this.lblLoggedIn.TabIndex = 4;
            this.lblLoggedIn.Text = "Logged in as:";
            // 
            // lblUserRolePOS
            // 
            this.lblUserRolePOS.AutoSize = true;
            this.lblUserRolePOS.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRolePOS.ForeColor = System.Drawing.Color.White;
            this.lblUserRolePOS.Location = new System.Drawing.Point(782, 36);
            this.lblUserRolePOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserRolePOS.Name = "lblUserRolePOS";
            this.lblUserRolePOS.Size = new System.Drawing.Size(68, 20);
            this.lblUserRolePOS.TabIndex = 3;
            this.lblUserRolePOS.Text = "UserRole";
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.Controls.Add(this.POSLoggedInlbl);
            this.panelMain.Controls.Add(this.POSNamelbl);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.JCubelbl);
            this.panelMain.Controls.Add(this.POSJCUBELOGOIMG);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(252, 62);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(930, 590);
            this.panelMain.TabIndex = 2;
            // 
            // POSJCUBELOGOIMG
            // 
            this.POSJCUBELOGOIMG.BackColor = System.Drawing.Color.Transparent;
            this.POSJCUBELOGOIMG.Image = ((System.Drawing.Image)(resources.GetObject("POSJCUBELOGOIMG.Image")));
            this.POSJCUBELOGOIMG.Location = new System.Drawing.Point(580, 182);
            this.POSJCUBELOGOIMG.Name = "POSJCUBELOGOIMG";
            this.POSJCUBELOGOIMG.Size = new System.Drawing.Size(275, 254);
            this.POSJCUBELOGOIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.POSJCUBELOGOIMG.TabIndex = 2;
            this.POSJCUBELOGOIMG.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Point of Sales System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JCubelbl
            // 
            this.JCubelbl.AutoSize = true;
            this.JCubelbl.BackColor = System.Drawing.Color.Transparent;
            this.JCubelbl.Font = new System.Drawing.Font("Noto Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JCubelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.JCubelbl.Location = new System.Drawing.Point(5, 201);
            this.JCubelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JCubelbl.Name = "JCubelbl";
            this.JCubelbl.Size = new System.Drawing.Size(520, 42);
            this.JCubelbl.TabIndex = 7;
            this.JCubelbl.Text = "JCUBE SHIELDWORKS CORPORATION";
            this.JCubelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // POSLoggedInlbl
            // 
            this.POSLoggedInlbl.AutoSize = true;
            this.POSLoggedInlbl.BackColor = System.Drawing.Color.Transparent;
            this.POSLoggedInlbl.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSLoggedInlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.POSLoggedInlbl.Location = new System.Drawing.Point(3, 361);
            this.POSLoggedInlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.POSLoggedInlbl.Name = "POSLoggedInlbl";
            this.POSLoggedInlbl.Size = new System.Drawing.Size(167, 35);
            this.POSLoggedInlbl.TabIndex = 10;
            this.POSLoggedInlbl.Text = "Logged in as:";
            this.POSLoggedInlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // POSNamelbl
            // 
            this.POSNamelbl.AutoSize = true;
            this.POSNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.POSNamelbl.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSNamelbl.ForeColor = System.Drawing.Color.White;
            this.POSNamelbl.Location = new System.Drawing.Point(4, 396);
            this.POSNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.POSNamelbl.Name = "POSNamelbl";
            this.POSNamelbl.Size = new System.Drawing.Size(106, 30);
            this.POSNamelbl.TabIndex = 9;
            this.POSNamelbl.Text = "Fullname";
            this.POSNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1182, 652);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PosUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jcube Point Of Sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PosUI_FormClosing);
            this.Load += new System.EventHandler(this.PosUI_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POSJCUBELOGOIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnDailySales;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelJcube;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoggedIn;
        public System.Windows.Forms.Label lblUserRolePOS;
        public System.Windows.Forms.Button btnSettlePayment;
        private System.Windows.Forms.PictureBox POSJCUBELOGOIMG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label JCubelbl;
        public System.Windows.Forms.Label POSLoggedInlbl;
        public System.Windows.Forms.Label POSNamelbl;
    }
}

