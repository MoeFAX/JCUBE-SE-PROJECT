namespace JCUBE_SE_PROJECT
{
    partial class EditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccount));
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EditFullnameField = new System.Windows.Forms.TextBox();
            this.EditFullnamelbl = new System.Windows.Forms.Label();
            this.EditUsernameField = new System.Windows.Forms.TextBox();
            this.EditUsernamelbl = new System.Windows.Forms.Label();
            this.EditAccountIDlbl = new System.Windows.Forms.Label();
            this.EditRolelbl = new System.Windows.Forms.Label();
            this.EditRoleComboBox = new System.Windows.Forms.ComboBox();
            this.AEditUsernamelbl = new System.Windows.Forms.Label();
            this.AEditFullnamelbl = new System.Windows.Forms.Label();
            this.AEditRolelbl = new System.Windows.Forms.Label();
            this.AEditEmaillbl = new System.Windows.Forms.Label();
            this.EditEmailField = new System.Windows.Forms.TextBox();
            this.EditEmaillbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.CancelBtn.Location = new System.Drawing.Point(371, 240);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 35);
            this.CancelBtn.TabIndex = 52;
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
            this.SaveBtn.Location = new System.Drawing.Point(254, 240);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 35);
            this.SaveBtn.TabIndex = 51;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditFullnameField
            // 
            this.EditFullnameField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFullnameField.Location = new System.Drawing.Point(174, 86);
            this.EditFullnameField.MaxLength = 60;
            this.EditFullnameField.Name = "EditFullnameField";
            this.EditFullnameField.Size = new System.Drawing.Size(459, 32);
            this.EditFullnameField.TabIndex = 49;
            this.EditFullnameField.TextChanged += new System.EventHandler(this.EditFullnameField_TextChanged);
            // 
            // EditFullnamelbl
            // 
            this.EditFullnamelbl.AutoSize = true;
            this.EditFullnamelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFullnamelbl.Location = new System.Drawing.Point(68, 89);
            this.EditFullnamelbl.Name = "EditFullnamelbl";
            this.EditFullnamelbl.Size = new System.Drawing.Size(103, 27);
            this.EditFullnamelbl.TabIndex = 50;
            this.EditFullnamelbl.Text = "Full Name:";
            // 
            // EditUsernameField
            // 
            this.EditUsernameField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUsernameField.Location = new System.Drawing.Point(174, 37);
            this.EditUsernameField.MaxLength = 30;
            this.EditUsernameField.Name = "EditUsernameField";
            this.EditUsernameField.Size = new System.Drawing.Size(459, 32);
            this.EditUsernameField.TabIndex = 41;
            this.EditUsernameField.TextChanged += new System.EventHandler(this.EditUsernameField_TextChanged);
            // 
            // EditUsernamelbl
            // 
            this.EditUsernamelbl.AutoSize = true;
            this.EditUsernamelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUsernamelbl.Location = new System.Drawing.Point(92, 38);
            this.EditUsernamelbl.Name = "EditUsernamelbl";
            this.EditUsernamelbl.Size = new System.Drawing.Size(80, 27);
            this.EditUsernamelbl.TabIndex = 42;
            this.EditUsernamelbl.Text = "User ID:";
            // 
            // EditAccountIDlbl
            // 
            this.EditAccountIDlbl.AutoSize = true;
            this.EditAccountIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAccountIDlbl.Location = new System.Drawing.Point(610, 248);
            this.EditAccountIDlbl.Name = "EditAccountIDlbl";
            this.EditAccountIDlbl.Size = new System.Drawing.Size(97, 22);
            this.EditAccountIDlbl.TabIndex = 54;
            this.EditAccountIDlbl.Text = "Account ID";
            this.EditAccountIDlbl.Visible = false;
            // 
            // EditRolelbl
            // 
            this.EditRolelbl.AutoSize = true;
            this.EditRolelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRolelbl.Location = new System.Drawing.Point(117, 192);
            this.EditRolelbl.Name = "EditRolelbl";
            this.EditRolelbl.Size = new System.Drawing.Size(54, 27);
            this.EditRolelbl.TabIndex = 56;
            this.EditRolelbl.Text = "Role:";
            // 
            // EditRoleComboBox
            // 
            this.EditRoleComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditRoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditRoleComboBox.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRoleComboBox.FormattingEnabled = true;
            this.EditRoleComboBox.Items.AddRange(new object[] {
            "Administrator",
            "Sales Clerk"});
            this.EditRoleComboBox.Location = new System.Drawing.Point(174, 188);
            this.EditRoleComboBox.MaxLength = 15;
            this.EditRoleComboBox.Name = "EditRoleComboBox";
            this.EditRoleComboBox.Size = new System.Drawing.Size(459, 35);
            this.EditRoleComboBox.TabIndex = 57;
            this.EditRoleComboBox.TextChanged += new System.EventHandler(this.EditRoleComboBox_TextChanged);
            // 
            // AEditUsernamelbl
            // 
            this.AEditUsernamelbl.AutoSize = true;
            this.AEditUsernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.AEditUsernamelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AEditUsernamelbl.ForeColor = System.Drawing.Color.Red;
            this.AEditUsernamelbl.Location = new System.Drawing.Point(633, 38);
            this.AEditUsernamelbl.Name = "AEditUsernamelbl";
            this.AEditUsernamelbl.Size = new System.Drawing.Size(22, 27);
            this.AEditUsernamelbl.TabIndex = 59;
            this.AEditUsernamelbl.Text = "*";
            this.AEditUsernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AEditFullnamelbl
            // 
            this.AEditFullnamelbl.AutoSize = true;
            this.AEditFullnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.AEditFullnamelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AEditFullnamelbl.ForeColor = System.Drawing.Color.Red;
            this.AEditFullnamelbl.Location = new System.Drawing.Point(633, 87);
            this.AEditFullnamelbl.Name = "AEditFullnamelbl";
            this.AEditFullnamelbl.Size = new System.Drawing.Size(22, 27);
            this.AEditFullnamelbl.TabIndex = 60;
            this.AEditFullnamelbl.Text = "*";
            this.AEditFullnamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AEditRolelbl
            // 
            this.AEditRolelbl.AutoSize = true;
            this.AEditRolelbl.BackColor = System.Drawing.Color.Transparent;
            this.AEditRolelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AEditRolelbl.ForeColor = System.Drawing.Color.Red;
            this.AEditRolelbl.Location = new System.Drawing.Point(633, 192);
            this.AEditRolelbl.Name = "AEditRolelbl";
            this.AEditRolelbl.Size = new System.Drawing.Size(22, 27);
            this.AEditRolelbl.TabIndex = 61;
            this.AEditRolelbl.Text = "*";
            this.AEditRolelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AEditEmaillbl
            // 
            this.AEditEmaillbl.AutoSize = true;
            this.AEditEmaillbl.BackColor = System.Drawing.Color.Transparent;
            this.AEditEmaillbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AEditEmaillbl.ForeColor = System.Drawing.Color.Red;
            this.AEditEmaillbl.Location = new System.Drawing.Point(633, 139);
            this.AEditEmaillbl.Name = "AEditEmaillbl";
            this.AEditEmaillbl.Size = new System.Drawing.Size(22, 27);
            this.AEditEmaillbl.TabIndex = 67;
            this.AEditEmaillbl.Text = "*";
            this.AEditEmaillbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditEmailField
            // 
            this.EditEmailField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmailField.Location = new System.Drawing.Point(174, 137);
            this.EditEmailField.MaxLength = 60;
            this.EditEmailField.Name = "EditEmailField";
            this.EditEmailField.Size = new System.Drawing.Size(459, 32);
            this.EditEmailField.TabIndex = 66;
            this.EditEmailField.TextChanged += new System.EventHandler(this.EditEmailField_TextChanged);
            // 
            // EditEmaillbl
            // 
            this.EditEmaillbl.AutoSize = true;
            this.EditEmaillbl.BackColor = System.Drawing.Color.Transparent;
            this.EditEmaillbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmaillbl.Location = new System.Drawing.Point(30, 139);
            this.EditEmaillbl.Name = "EditEmaillbl";
            this.EditEmaillbl.Size = new System.Drawing.Size(138, 27);
            this.EditEmaillbl.TabIndex = 68;
            this.EditEmaillbl.Text = "Email Address:";
            // 
            // EditAccount
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(727, 290);
            this.Controls.Add(this.AEditEmaillbl);
            this.Controls.Add(this.EditEmailField);
            this.Controls.Add(this.AEditRolelbl);
            this.Controls.Add(this.AEditFullnamelbl);
            this.Controls.Add(this.AEditUsernamelbl);
            this.Controls.Add(this.EditRoleComboBox);
            this.Controls.Add(this.EditRolelbl);
            this.Controls.Add(this.EditAccountIDlbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EditFullnameField);
            this.Controls.Add(this.EditFullnamelbl);
            this.Controls.Add(this.EditUsernameField);
            this.Controls.Add(this.EditUsernamelbl);
            this.Controls.Add(this.EditEmaillbl);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label EditFullnamelbl;
        private System.Windows.Forms.Label EditUsernamelbl;
        public System.Windows.Forms.TextBox EditUsernameField;
        public System.Windows.Forms.TextBox EditFullnameField;
        public System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label EditRolelbl;
        public System.Windows.Forms.ComboBox EditRoleComboBox;
        public System.Windows.Forms.Label EditAccountIDlbl;
        private System.Windows.Forms.Label AEditUsernamelbl;
        private System.Windows.Forms.Label AEditFullnamelbl;
        private System.Windows.Forms.Label AEditRolelbl;
        private System.Windows.Forms.Label AEditEmaillbl;
        private System.Windows.Forms.Label EditEmaillbl;
        public System.Windows.Forms.TextBox EditEmailField;
    }
}