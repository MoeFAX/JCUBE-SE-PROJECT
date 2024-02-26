namespace JCUBE_SE_PROJECT
{
    partial class UserAccountsUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountsUI));
            this.label9 = new System.Windows.Forms.Label();
            this.CABttn = new MetroFramework.Controls.MetroButton();
            this.CPBttn = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAUserNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAFullNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAAccActCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UARoleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditAcc = new System.Windows.Forms.DataGridViewImageColumn();
            this.ResetPwd = new System.Windows.Forms.DataGridViewImageColumn();
            this.ActivateAcc = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeactivateAcc = new System.Windows.Forms.DataGridViewImageColumn();
            this.ArchiveAcc = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            this.UAUserRolelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label9.Location = new System.Drawing.Point(16, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "USER ACCOUNTS";
            // 
            // CABttn
            // 
            this.CABttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.CABttn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CABttn.ForeColor = System.Drawing.SystemColors.Control;
            this.CABttn.Location = new System.Drawing.Point(16, 54);
            this.CABttn.Margin = new System.Windows.Forms.Padding(4);
            this.CABttn.Name = "CABttn";
            this.CABttn.Size = new System.Drawing.Size(149, 28);
            this.CABttn.TabIndex = 8;
            this.CABttn.Text = "Create Account";
            this.CABttn.UseCustomBackColor = true;
            this.CABttn.UseCustomForeColor = true;
            this.CABttn.UseSelectable = true;
            this.CABttn.Click += new System.EventHandler(this.CABttn_Click);
            // 
            // CPBttn
            // 
            this.CPBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.CPBttn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CPBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.CPBttn.Location = new System.Drawing.Point(189, 54);
            this.CPBttn.Margin = new System.Windows.Forms.Padding(4);
            this.CPBttn.Name = "CPBttn";
            this.CPBttn.Size = new System.Drawing.Size(149, 28);
            this.CPBttn.TabIndex = 9;
            this.CPBttn.Text = "Change Password";
            this.CPBttn.UseCustomBackColor = true;
            this.CPBttn.UseCustomForeColor = true;
            this.CPBttn.UseSelectable = true;
            this.CPBttn.Click += new System.EventHandler(this.CPBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Settings";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeColumns = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 9);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountID,
            this.UAUserNameCol,
            this.UAFullNameCol,
            this.UAAccActCol,
            this.UARoleCol,
            this.EditAcc,
            this.ResetPwd,
            this.ActivateAcc,
            this.DeactivateAcc,
            this.ArchiveAcc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(16, 107);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUser.Size = new System.Drawing.Size(896, 411);
            this.dgvUser.TabIndex = 18;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // AccountID
            // 
            this.AccountID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AccountID.HeaderText = "No";
            this.AccountID.MinimumWidth = 6;
            this.AccountID.Name = "AccountID";
            this.AccountID.Width = 54;
            // 
            // UAUserNameCol
            // 
            this.UAUserNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UAUserNameCol.HeaderText = "Username";
            this.UAUserNameCol.MinimumWidth = 6;
            this.UAUserNameCol.Name = "UAUserNameCol";
            this.UAUserNameCol.Width = 98;
            // 
            // UAFullNameCol
            // 
            this.UAFullNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UAFullNameCol.HeaderText = "Full Name";
            this.UAFullNameCol.MinimumWidth = 6;
            this.UAFullNameCol.Name = "UAFullNameCol";
            // 
            // UAAccActCol
            // 
            this.UAAccActCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UAAccActCol.HeaderText = "Account Activate";
            this.UAAccActCol.MinimumWidth = 6;
            this.UAAccActCol.Name = "UAAccActCol";
            this.UAAccActCol.Width = 149;
            // 
            // UARoleCol
            // 
            this.UARoleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UARoleCol.HeaderText = "Role";
            this.UARoleCol.MinimumWidth = 6;
            this.UARoleCol.Name = "UARoleCol";
            this.UARoleCol.Width = 63;
            // 
            // EditAcc
            // 
            this.EditAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EditAcc.HeaderText = "";
            this.EditAcc.Image = ((System.Drawing.Image)(resources.GetObject("EditAcc.Image")));
            this.EditAcc.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditAcc.MinimumWidth = 6;
            this.EditAcc.Name = "EditAcc";
            this.EditAcc.Width = 6;
            // 
            // ResetPwd
            // 
            this.ResetPwd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ResetPwd.HeaderText = "";
            this.ResetPwd.Image = ((System.Drawing.Image)(resources.GetObject("ResetPwd.Image")));
            this.ResetPwd.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ResetPwd.MinimumWidth = 6;
            this.ResetPwd.Name = "ResetPwd";
            this.ResetPwd.Width = 6;
            // 
            // ActivateAcc
            // 
            this.ActivateAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ActivateAcc.HeaderText = "";
            this.ActivateAcc.Image = ((System.Drawing.Image)(resources.GetObject("ActivateAcc.Image")));
            this.ActivateAcc.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ActivateAcc.MinimumWidth = 6;
            this.ActivateAcc.Name = "ActivateAcc";
            this.ActivateAcc.Width = 6;
            // 
            // DeactivateAcc
            // 
            this.DeactivateAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeactivateAcc.HeaderText = "";
            this.DeactivateAcc.Image = ((System.Drawing.Image)(resources.GetObject("DeactivateAcc.Image")));
            this.DeactivateAcc.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeactivateAcc.MinimumWidth = 6;
            this.DeactivateAcc.Name = "DeactivateAcc";
            this.DeactivateAcc.Width = 6;
            // 
            // ArchiveAcc
            // 
            this.ArchiveAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ArchiveAcc.HeaderText = "";
            this.ArchiveAcc.Image = ((System.Drawing.Image)(resources.GetObject("ArchiveAcc.Image")));
            this.ArchiveAcc.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ArchiveAcc.MinimumWidth = 6;
            this.ArchiveAcc.Name = "ArchiveAcc";
            this.ArchiveAcc.Width = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 530);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.BackgroundImage")));
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshBtn.ForeColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Location = new System.Drawing.Point(348, 53);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(30, 30);
            this.refreshBtn.TabIndex = 20;
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // UAUserRolelbl
            // 
            this.UAUserRolelbl.AutoSize = true;
            this.UAUserRolelbl.Location = new System.Drawing.Point(394, 66);
            this.UAUserRolelbl.Name = "UAUserRolelbl";
            this.UAUserRolelbl.Size = new System.Drawing.Size(44, 16);
            this.UAUserRolelbl.TabIndex = 21;
            this.UAUserRolelbl.Text = "label2";
            this.UAUserRolelbl.Visible = false;
            // 
            // UserAccountsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(928, 592);
            this.Controls.Add(this.UAUserRolelbl);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CPBttn);
            this.Controls.Add(this.CABttn);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserAccountsUI";
            this.Text = "User Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroButton CABttn;
        private MetroFramework.Controls.MetroButton CPBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAUserNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAFullNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAAccActCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UARoleCol;
        private System.Windows.Forms.DataGridViewImageColumn EditAcc;
        private System.Windows.Forms.DataGridViewImageColumn ResetPwd;
        private System.Windows.Forms.DataGridViewImageColumn ActivateAcc;
        private System.Windows.Forms.DataGridViewImageColumn DeactivateAcc;
        private System.Windows.Forms.DataGridViewImageColumn ArchiveAcc;
        private MetroFramework.Controls.MetroButton refreshBtn;
        public System.Windows.Forms.Label UAUserRolelbl;
    }
}