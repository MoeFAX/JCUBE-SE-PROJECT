namespace JCUBE_SE_PROJECT
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.UsernameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.RTPasswordField = new System.Windows.Forms.TextBox();
            this.RTPasswordlbl = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.Rolelbl = new System.Windows.Forms.Label();
            this.FullnameField = new System.Windows.Forms.TextBox();
            this.Fullnamelbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.NPEyeBtn = new System.Windows.Forms.PictureBox();
            this.RTEyeBtn = new System.Windows.Forms.PictureBox();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.AUsernamelbl = new System.Windows.Forms.Label();
            this.APasswordlbl = new System.Windows.Forms.Label();
            this.ARTPasswordlbl = new System.Windows.Forms.Label();
            this.AFullnamelbl = new System.Windows.Forms.Label();
            this.ARolelbl = new System.Windows.Forms.Label();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.AEmaillbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.UASlctUserlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NPEyeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTEyeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameField
            // 
            this.UsernameField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameField.Location = new System.Drawing.Point(174, 39);
            this.UsernameField.MaxLength = 30;
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(459, 32);
            this.UsernameField.TabIndex = 28;
            this.UsernameField.TextChanged += new System.EventHandler(this.UsernameField_TextChanged);
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(174, 88);
            this.PasswordField.MaxLength = 255;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '●';
            this.PasswordField.Size = new System.Drawing.Size(459, 32);
            this.PasswordField.TabIndex = 30;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.Location = new System.Drawing.Point(70, 90);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(99, 27);
            this.Passwordlbl.TabIndex = 31;
            this.Passwordlbl.Text = "Password:";
            // 
            // RTPasswordField
            // 
            this.RTPasswordField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTPasswordField.Location = new System.Drawing.Point(174, 138);
            this.RTPasswordField.MaxLength = 255;
            this.RTPasswordField.Name = "RTPasswordField";
            this.RTPasswordField.PasswordChar = '●';
            this.RTPasswordField.Size = new System.Drawing.Size(459, 32);
            this.RTPasswordField.TabIndex = 32;
            this.RTPasswordField.TextChanged += new System.EventHandler(this.RTPasswordField_TextChanged);
            // 
            // RTPasswordlbl
            // 
            this.RTPasswordlbl.AutoSize = true;
            this.RTPasswordlbl.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTPasswordlbl.Location = new System.Drawing.Point(11, 141);
            this.RTPasswordlbl.Name = "RTPasswordlbl";
            this.RTPasswordlbl.Size = new System.Drawing.Size(162, 26);
            this.RTPasswordlbl.TabIndex = 33;
            this.RTPasswordlbl.Text = "Confirm Password:";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleComboBox.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.ItemHeight = 27;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Administrator",
            "Sales Clerk"});
            this.RoleComboBox.Location = new System.Drawing.Point(174, 286);
            this.RoleComboBox.MaxLength = 15;
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(459, 35);
            this.RoleComboBox.TabIndex = 15;
            this.RoleComboBox.TextChanged += new System.EventHandler(this.RoleComboBox_TextChanged);
            // 
            // Rolelbl
            // 
            this.Rolelbl.AutoSize = true;
            this.Rolelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolelbl.Location = new System.Drawing.Point(117, 291);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(54, 27);
            this.Rolelbl.TabIndex = 35;
            this.Rolelbl.Text = "Role:";
            // 
            // FullnameField
            // 
            this.FullnameField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameField.Location = new System.Drawing.Point(174, 189);
            this.FullnameField.MaxLength = 60;
            this.FullnameField.Name = "FullnameField";
            this.FullnameField.Size = new System.Drawing.Size(459, 32);
            this.FullnameField.TabIndex = 60;
            this.FullnameField.TextChanged += new System.EventHandler(this.FullnameField_TextChanged);
            // 
            // Fullnamelbl
            // 
            this.Fullnamelbl.AutoSize = true;
            this.Fullnamelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullnamelbl.Location = new System.Drawing.Point(64, 191);
            this.Fullnamelbl.Name = "Fullnamelbl";
            this.Fullnamelbl.Size = new System.Drawing.Size(103, 27);
            this.Fullnamelbl.TabIndex = 37;
            this.Fullnamelbl.Text = "Full Name:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(371, 338);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 35);
            this.CancelBtn.TabIndex = 39;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(155)))), ((int)(((byte)(97)))));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(254, 338);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 35);
            this.SaveBtn.TabIndex = 38;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NPEyeBtn
            // 
            this.NPEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.NPEyeBtn.Image = ((System.Drawing.Image)(resources.GetObject("NPEyeBtn.Image")));
            this.NPEyeBtn.Location = new System.Drawing.Point(610, 92);
            this.NPEyeBtn.Name = "NPEyeBtn";
            this.NPEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.NPEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NPEyeBtn.TabIndex = 56;
            this.NPEyeBtn.TabStop = false;
            // 
            // RTEyeBtn
            // 
            this.RTEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.RTEyeBtn.Image = ((System.Drawing.Image)(resources.GetObject("RTEyeBtn.Image")));
            this.RTEyeBtn.Location = new System.Drawing.Point(610, 142);
            this.RTEyeBtn.Name = "RTEyeBtn";
            this.RTEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.RTEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RTEyeBtn.TabIndex = 57;
            this.RTEyeBtn.TabStop = false;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.Location = new System.Drawing.Point(91, 42);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(80, 27);
            this.Usernamelbl.TabIndex = 29;
            this.Usernamelbl.Text = "User ID:";
            this.Usernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AUsernamelbl
            // 
            this.AUsernamelbl.AutoSize = true;
            this.AUsernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.AUsernamelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUsernamelbl.ForeColor = System.Drawing.Color.Red;
            this.AUsernamelbl.Location = new System.Drawing.Point(633, 40);
            this.AUsernamelbl.Name = "AUsernamelbl";
            this.AUsernamelbl.Size = new System.Drawing.Size(22, 27);
            this.AUsernamelbl.TabIndex = 58;
            this.AUsernamelbl.Text = "*";
            this.AUsernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // APasswordlbl
            // 
            this.APasswordlbl.AutoSize = true;
            this.APasswordlbl.BackColor = System.Drawing.Color.Transparent;
            this.APasswordlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APasswordlbl.ForeColor = System.Drawing.Color.Red;
            this.APasswordlbl.Location = new System.Drawing.Point(633, 88);
            this.APasswordlbl.Name = "APasswordlbl";
            this.APasswordlbl.Size = new System.Drawing.Size(22, 27);
            this.APasswordlbl.TabIndex = 59;
            this.APasswordlbl.Text = "*";
            this.APasswordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ARTPasswordlbl
            // 
            this.ARTPasswordlbl.AutoSize = true;
            this.ARTPasswordlbl.BackColor = System.Drawing.Color.Transparent;
            this.ARTPasswordlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARTPasswordlbl.ForeColor = System.Drawing.Color.Red;
            this.ARTPasswordlbl.Location = new System.Drawing.Point(633, 139);
            this.ARTPasswordlbl.Name = "ARTPasswordlbl";
            this.ARTPasswordlbl.Size = new System.Drawing.Size(22, 27);
            this.ARTPasswordlbl.TabIndex = 60;
            this.ARTPasswordlbl.Text = "*";
            this.ARTPasswordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AFullnamelbl
            // 
            this.AFullnamelbl.AutoSize = true;
            this.AFullnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.AFullnamelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AFullnamelbl.ForeColor = System.Drawing.Color.Red;
            this.AFullnamelbl.Location = new System.Drawing.Point(633, 190);
            this.AFullnamelbl.Name = "AFullnamelbl";
            this.AFullnamelbl.Size = new System.Drawing.Size(22, 27);
            this.AFullnamelbl.TabIndex = 61;
            this.AFullnamelbl.Text = "*";
            this.AFullnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ARolelbl
            // 
            this.ARolelbl.AutoSize = true;
            this.ARolelbl.BackColor = System.Drawing.Color.Transparent;
            this.ARolelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARolelbl.ForeColor = System.Drawing.Color.Red;
            this.ARolelbl.Location = new System.Drawing.Point(633, 291);
            this.ARolelbl.Name = "ARolelbl";
            this.ARolelbl.Size = new System.Drawing.Size(22, 27);
            this.ARolelbl.TabIndex = 62;
            this.ARolelbl.Text = "*";
            this.ARolelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.Location = new System.Drawing.Point(174, 236);
            this.EmailField.MaxLength = 60;
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(459, 32);
            this.EmailField.TabIndex = 63;
            this.EmailField.TextChanged += new System.EventHandler(this.EmailField_TextChanged);
            // 
            // AEmaillbl
            // 
            this.AEmaillbl.AutoSize = true;
            this.AEmaillbl.BackColor = System.Drawing.Color.Transparent;
            this.AEmaillbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AEmaillbl.ForeColor = System.Drawing.Color.Red;
            this.AEmaillbl.Location = new System.Drawing.Point(633, 238);
            this.AEmaillbl.Name = "AEmaillbl";
            this.AEmaillbl.Size = new System.Drawing.Size(22, 27);
            this.AEmaillbl.TabIndex = 64;
            this.AEmaillbl.Text = "*";
            this.AEmaillbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.BackColor = System.Drawing.Color.Transparent;
            this.Emaillbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(29, 238);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(138, 27);
            this.Emaillbl.TabIndex = 65;
            this.Emaillbl.Text = "Email Address:";
            // 
            // UASlctUserlbl
            // 
            this.UASlctUserlbl.AutoSize = true;
            this.UASlctUserlbl.BackColor = System.Drawing.Color.Transparent;
            this.UASlctUserlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UASlctUserlbl.Location = new System.Drawing.Point(575, 342);
            this.UASlctUserlbl.Name = "UASlctUserlbl";
            this.UASlctUserlbl.Size = new System.Drawing.Size(80, 27);
            this.UASlctUserlbl.TabIndex = 66;
            this.UASlctUserlbl.Text = "User ID:";
            this.UASlctUserlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UASlctUserlbl.Visible = false;
            // 
            // CreateAccount
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(727, 391);
            this.Controls.Add(this.UASlctUserlbl);
            this.Controls.Add(this.AEmaillbl);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.ARolelbl);
            this.Controls.Add(this.AFullnamelbl);
            this.Controls.Add(this.RTEyeBtn);
            this.Controls.Add(this.NPEyeBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.FullnameField);
            this.Controls.Add(this.Fullnamelbl);
            this.Controls.Add(this.Rolelbl);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.RTPasswordField);
            this.Controls.Add(this.RTPasswordlbl);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.UsernameField);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.AUsernamelbl);
            this.Controls.Add(this.APasswordlbl);
            this.Controls.Add(this.ARTPasswordlbl);
            this.Controls.Add(this.Emaillbl);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            ((System.ComponentModel.ISupportInitialize)(this.NPEyeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTEyeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.TextBox RTPasswordField;
        private System.Windows.Forms.Label RTPasswordlbl;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label Rolelbl;
        private System.Windows.Forms.TextBox FullnameField;
        private System.Windows.Forms.Label Fullnamelbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.PictureBox NPEyeBtn;
        private System.Windows.Forms.PictureBox RTEyeBtn;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label AUsernamelbl;
        public System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.Label APasswordlbl;
        private System.Windows.Forms.Label ARTPasswordlbl;
        private System.Windows.Forms.Label AFullnamelbl;
        private System.Windows.Forms.Label ARolelbl;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Label AEmaillbl;
        private System.Windows.Forms.Label Emaillbl;
        public System.Windows.Forms.Label UASlctUserlbl;
    }
}