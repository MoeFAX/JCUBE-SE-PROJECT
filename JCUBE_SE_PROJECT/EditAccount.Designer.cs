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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.CreateAccountlbl = new System.Windows.Forms.Label();
            this.EditAccountIDField = new System.Windows.Forms.TextBox();
            this.EditAccountIDlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditRoleComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(371, 290);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 30);
            this.CancelBtn.TabIndex = 52;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(254, 290);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 30);
            this.SaveBtn.TabIndex = 51;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditFullnameField
            // 
            this.EditFullnameField.Location = new System.Drawing.Point(174, 183);
            this.EditFullnameField.Name = "EditFullnameField";
            this.EditFullnameField.Size = new System.Drawing.Size(459, 30);
            this.EditFullnameField.TabIndex = 49;
            // 
            // EditFullnamelbl
            // 
            this.EditFullnamelbl.AutoSize = true;
            this.EditFullnamelbl.Location = new System.Drawing.Point(71, 189);
            this.EditFullnamelbl.Name = "EditFullnamelbl";
            this.EditFullnamelbl.Size = new System.Drawing.Size(100, 21);
            this.EditFullnamelbl.TabIndex = 50;
            this.EditFullnamelbl.Text = "Full Name:";
            // 
            // EditUsernameField
            // 
            this.EditUsernameField.Location = new System.Drawing.Point(174, 134);
            this.EditUsernameField.Name = "EditUsernameField";
            this.EditUsernameField.Size = new System.Drawing.Size(459, 30);
            this.EditUsernameField.TabIndex = 41;
            // 
            // EditUsernamelbl
            // 
            this.EditUsernamelbl.AutoSize = true;
            this.EditUsernamelbl.Location = new System.Drawing.Point(68, 140);
            this.EditUsernamelbl.Name = "EditUsernamelbl";
            this.EditUsernamelbl.Size = new System.Drawing.Size(103, 21);
            this.EditUsernamelbl.TabIndex = 42;
            this.EditUsernamelbl.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.CreateAccountlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 50);
            this.panel1.TabIndex = 40;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(693, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(26, 28);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CreateAccountlbl
            // 
            this.CreateAccountlbl.AutoSize = true;
            this.CreateAccountlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountlbl.Location = new System.Drawing.Point(12, 18);
            this.CreateAccountlbl.Name = "CreateAccountlbl";
            this.CreateAccountlbl.Size = new System.Drawing.Size(134, 23);
            this.CreateAccountlbl.TabIndex = 1;
            this.CreateAccountlbl.Text = "Edit Account";
            // 
            // EditAccountIDField
            // 
            this.EditAccountIDField.Location = new System.Drawing.Point(174, 83);
            this.EditAccountIDField.Name = "EditAccountIDField";
            this.EditAccountIDField.ReadOnly = true;
            this.EditAccountIDField.Size = new System.Drawing.Size(459, 30);
            this.EditAccountIDField.TabIndex = 53;
            // 
            // EditAccountIDlbl
            // 
            this.EditAccountIDlbl.AutoSize = true;
            this.EditAccountIDlbl.Location = new System.Drawing.Point(53, 90);
            this.EditAccountIDlbl.Name = "EditAccountIDlbl";
            this.EditAccountIDlbl.Size = new System.Drawing.Size(118, 21);
            this.EditAccountIDlbl.TabIndex = 54;
            this.EditAccountIDlbl.Text = "Account ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Role:";
            // 
            // EditRoleComboBox
            // 
            this.EditRoleComboBox.FormattingEnabled = true;
            this.EditRoleComboBox.Items.AddRange(new object[] {
            "Administrator",
            "Sales Clerk"});
            this.EditRoleComboBox.Location = new System.Drawing.Point(174, 233);
            this.EditRoleComboBox.Name = "EditRoleComboBox";
            this.EditRoleComboBox.Size = new System.Drawing.Size(459, 29);
            this.EditRoleComboBox.TabIndex = 57;
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 345);
            this.Controls.Add(this.EditRoleComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditAccountIDlbl);
            this.Controls.Add(this.EditAccountIDField);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EditFullnameField);
            this.Controls.Add(this.EditFullnamelbl);
            this.Controls.Add(this.EditUsernameField);
            this.Controls.Add(this.EditUsernamelbl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label EditFullnamelbl;
        private System.Windows.Forms.Label EditUsernamelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label CreateAccountlbl;
        public System.Windows.Forms.TextBox EditUsernameField;
        public System.Windows.Forms.TextBox EditFullnameField;
        public System.Windows.Forms.TextBox EditAccountIDField;
        private System.Windows.Forms.Label EditAccountIDlbl;
        public System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox EditRoleComboBox;
    }
}