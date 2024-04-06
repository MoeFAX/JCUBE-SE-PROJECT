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
            this.Usernamelbl = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.NPEyeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTEyeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameField
            // 
            this.UsernameField.Location = new System.Drawing.Point(174, 39);
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(459, 30);
            this.UsernameField.TabIndex = 28;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Location = new System.Drawing.Point(68, 45);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(103, 21);
            this.Usernamelbl.TabIndex = 29;
            this.Usernamelbl.Text = "Username:";
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(174, 88);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '●';
            this.PasswordField.Size = new System.Drawing.Size(459, 30);
            this.PasswordField.TabIndex = 30;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Location = new System.Drawing.Point(76, 93);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(95, 21);
            this.Passwordlbl.TabIndex = 31;
            this.Passwordlbl.Text = "Password:";
            // 
            // RTPasswordField
            // 
            this.RTPasswordField.Location = new System.Drawing.Point(174, 138);
            this.RTPasswordField.Name = "RTPasswordField";
            this.RTPasswordField.PasswordChar = '●';
            this.RTPasswordField.Size = new System.Drawing.Size(459, 30);
            this.RTPasswordField.TabIndex = 32;
            // 
            // RTPasswordlbl
            // 
            this.RTPasswordlbl.AutoSize = true;
            this.RTPasswordlbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTPasswordlbl.Location = new System.Drawing.Point(8, 144);
            this.RTPasswordlbl.Name = "RTPasswordlbl";
            this.RTPasswordlbl.Size = new System.Drawing.Size(163, 21);
            this.RTPasswordlbl.TabIndex = 33;
            this.RTPasswordlbl.Text = "Re-type Password:";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Administrator",
            "Sales Clerk"});
            this.RoleComboBox.Location = new System.Drawing.Point(174, 238);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(459, 29);
            this.RoleComboBox.TabIndex = 34;
            // 
            // Rolelbl
            // 
            this.Rolelbl.AutoSize = true;
            this.Rolelbl.Location = new System.Drawing.Point(118, 243);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(53, 21);
            this.Rolelbl.TabIndex = 35;
            this.Rolelbl.Text = "Role:";
            // 
            // FullnameField
            // 
            this.FullnameField.Location = new System.Drawing.Point(174, 189);
            this.FullnameField.Name = "FullnameField";
            this.FullnameField.Size = new System.Drawing.Size(459, 30);
            this.FullnameField.TabIndex = 36;
            // 
            // Fullnamelbl
            // 
            this.Fullnamelbl.AutoSize = true;
            this.Fullnamelbl.Location = new System.Drawing.Point(71, 195);
            this.Fullnamelbl.Name = "Fullnamelbl";
            this.Fullnamelbl.Size = new System.Drawing.Size(100, 21);
            this.Fullnamelbl.TabIndex = 37;
            this.Fullnamelbl.Text = "Full Name:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(371, 289);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 30);
            this.CancelBtn.TabIndex = 39;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(155)))), ((int)(((byte)(97)))));
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(254, 289);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 30);
            this.SaveBtn.TabIndex = 38;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NPEyeBtn
            // 
            this.NPEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.NPEyeBtn.Image = ((System.Drawing.Image)(resources.GetObject("NPEyeBtn.Image")));
            this.NPEyeBtn.Location = new System.Drawing.Point(609, 93);
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
            this.RTEyeBtn.Location = new System.Drawing.Point(609, 143);
            this.RTEyeBtn.Name = "RTEyeBtn";
            this.RTEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.RTEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RTEyeBtn.TabIndex = 57;
            this.RTEyeBtn.TabStop = false;
            // 
            // CreateAccount
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(727, 335);
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
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.NPEyeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTEyeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UsernameField;
        private System.Windows.Forms.Label Usernamelbl;
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
    }
}