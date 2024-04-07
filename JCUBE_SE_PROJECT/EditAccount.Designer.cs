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
            this.label1 = new System.Windows.Forms.Label();
            this.EditRoleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(371, 190);
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
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(254, 190);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 35);
            this.SaveBtn.TabIndex = 51;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditFullnameField
            // 
            this.EditFullnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFullnameField.Location = new System.Drawing.Point(174, 86);
            this.EditFullnameField.Name = "EditFullnameField";
            this.EditFullnameField.Size = new System.Drawing.Size(459, 28);
            this.EditFullnameField.TabIndex = 49;
            // 
            // EditFullnamelbl
            // 
            this.EditFullnamelbl.AutoSize = true;
            this.EditFullnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFullnamelbl.Location = new System.Drawing.Point(69, 90);
            this.EditFullnamelbl.Name = "EditFullnamelbl";
            this.EditFullnamelbl.Size = new System.Drawing.Size(96, 22);
            this.EditFullnamelbl.TabIndex = 50;
            this.EditFullnamelbl.Text = "Full Name:";
            // 
            // EditUsernameField
            // 
            this.EditUsernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUsernameField.Location = new System.Drawing.Point(174, 37);
            this.EditUsernameField.Name = "EditUsernameField";
            this.EditUsernameField.Size = new System.Drawing.Size(459, 28);
            this.EditUsernameField.TabIndex = 41;
            // 
            // EditUsernamelbl
            // 
            this.EditUsernamelbl.AutoSize = true;
            this.EditUsernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUsernamelbl.Location = new System.Drawing.Point(93, 39);
            this.EditUsernamelbl.Name = "EditUsernamelbl";
            this.EditUsernamelbl.Size = new System.Drawing.Size(75, 22);
            this.EditUsernamelbl.TabIndex = 42;
            this.EditUsernamelbl.Text = "User ID:";
            // 
            // EditAccountIDlbl
            // 
            this.EditAccountIDlbl.AutoSize = true;
            this.EditAccountIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAccountIDlbl.Location = new System.Drawing.Point(610, 198);
            this.EditAccountIDlbl.Name = "EditAccountIDlbl";
            this.EditAccountIDlbl.Size = new System.Drawing.Size(97, 22);
            this.EditAccountIDlbl.TabIndex = 54;
            this.EditAccountIDlbl.Text = "Account ID";
            this.EditAccountIDlbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "Role:";
            // 
            // EditRoleComboBox
            // 
            this.EditRoleComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditRoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditRoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRoleComboBox.FormattingEnabled = true;
            this.EditRoleComboBox.Items.AddRange(new object[] {
            "Administrator",
            "Sales Clerk"});
            this.EditRoleComboBox.Location = new System.Drawing.Point(174, 136);
            this.EditRoleComboBox.Name = "EditRoleComboBox";
            this.EditRoleComboBox.Size = new System.Drawing.Size(459, 30);
            this.EditRoleComboBox.TabIndex = 57;
            // 
            // EditAccount
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(727, 241);
            this.Controls.Add(this.EditRoleComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditAccountIDlbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EditFullnameField);
            this.Controls.Add(this.EditFullnamelbl);
            this.Controls.Add(this.EditUsernameField);
            this.Controls.Add(this.EditUsernamelbl);
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
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox EditRoleComboBox;
        public System.Windows.Forms.Label EditAccountIDlbl;
    }
}