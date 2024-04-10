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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountsUI));
            this.UAHeadinglbl = new System.Windows.Forms.Label();
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
            this.UAUserRolelbl = new System.Windows.Forms.Label();
            this.CABttn = new System.Windows.Forms.Button();
            this.CPBttn = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // UAHeadinglbl
            // 
            this.UAHeadinglbl.AutoSize = true;
            this.UAHeadinglbl.BackColor = System.Drawing.SystemColors.Control;
            this.UAHeadinglbl.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UAHeadinglbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.UAHeadinglbl.Location = new System.Drawing.Point(16, 11);
            this.UAHeadinglbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UAHeadinglbl.Name = "UAHeadinglbl";
            this.UAHeadinglbl.Size = new System.Drawing.Size(205, 35);
            this.UAHeadinglbl.TabIndex = 6;
            this.UAHeadinglbl.Text = "USER ACCOUNTS";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvUser.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUser.Size = new System.Drawing.Size(896, 472);
            this.dgvUser.TabIndex = 18;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // AccountID
            // 
            this.AccountID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AccountID.HeaderText = "No";
            this.AccountID.MinimumWidth = 6;
            this.AccountID.Name = "AccountID";
            this.AccountID.ReadOnly = true;
            this.AccountID.Visible = false;
            this.AccountID.Width = 125;
            // 
            // UAUserNameCol
            // 
            this.UAUserNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UAUserNameCol.HeaderText = "User ID";
            this.UAUserNameCol.MinimumWidth = 6;
            this.UAUserNameCol.Name = "UAUserNameCol";
            this.UAUserNameCol.ReadOnly = true;
            this.UAUserNameCol.Width = 150;
            // 
            // UAFullNameCol
            // 
            this.UAFullNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UAFullNameCol.HeaderText = "Full Name";
            this.UAFullNameCol.MinimumWidth = 6;
            this.UAFullNameCol.Name = "UAFullNameCol";
            this.UAFullNameCol.ReadOnly = true;
            this.UAFullNameCol.Width = 250;
            // 
            // UAAccActCol
            // 
            this.UAAccActCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UAAccActCol.HeaderText = "Account Activate";
            this.UAAccActCol.MinimumWidth = 6;
            this.UAAccActCol.Name = "UAAccActCol";
            this.UAAccActCol.ReadOnly = true;
            this.UAAccActCol.Width = 149;
            // 
            // UARoleCol
            // 
            this.UARoleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UARoleCol.HeaderText = "Role";
            this.UARoleCol.MinimumWidth = 80;
            this.UARoleCol.Name = "UARoleCol";
            this.UARoleCol.ReadOnly = true;
            // 
            // EditAcc
            // 
            this.EditAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditAcc.HeaderText = "";
            this.EditAcc.Image = ((System.Drawing.Image)(resources.GetObject("EditAcc.Image")));
            this.EditAcc.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditAcc.MinimumWidth = 30;
            this.EditAcc.Name = "EditAcc";
            this.EditAcc.Width = 30;
            // 
            // ResetPwd
            // 
            this.ResetPwd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ResetPwd.HeaderText = "";
            this.ResetPwd.Image = ((System.Drawing.Image)(resources.GetObject("ResetPwd.Image")));
            this.ResetPwd.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ResetPwd.MinimumWidth = 30;
            this.ResetPwd.Name = "ResetPwd";
            this.ResetPwd.Width = 30;
            // 
            // ActivateAcc
            // 
            this.ActivateAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ActivateAcc.HeaderText = "";
            this.ActivateAcc.Image = ((System.Drawing.Image)(resources.GetObject("ActivateAcc.Image")));
            this.ActivateAcc.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ActivateAcc.MinimumWidth = 30;
            this.ActivateAcc.Name = "ActivateAcc";
            this.ActivateAcc.Width = 30;
            // 
            // DeactivateAcc
            // 
            this.DeactivateAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeactivateAcc.HeaderText = "";
            this.DeactivateAcc.Image = ((System.Drawing.Image)(resources.GetObject("DeactivateAcc.Image")));
            this.DeactivateAcc.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeactivateAcc.MinimumWidth = 30;
            this.DeactivateAcc.Name = "DeactivateAcc";
            this.DeactivateAcc.Width = 30;
            // 
            // ArchiveAcc
            // 
            this.ArchiveAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ArchiveAcc.HeaderText = "";
            this.ArchiveAcc.Image = ((System.Drawing.Image)(resources.GetObject("ArchiveAcc.Image")));
            this.ArchiveAcc.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ArchiveAcc.MinimumWidth = 30;
            this.ArchiveAcc.Name = "ArchiveAcc";
            this.ArchiveAcc.Width = 30;
            // 
            // UAUserRolelbl
            // 
            this.UAUserRolelbl.AutoSize = true;
            this.UAUserRolelbl.Location = new System.Drawing.Point(844, 67);
            this.UAUserRolelbl.Name = "UAUserRolelbl";
            this.UAUserRolelbl.Size = new System.Drawing.Size(44, 16);
            this.UAUserRolelbl.TabIndex = 21;
            this.UAUserRolelbl.Text = "label2";
            this.UAUserRolelbl.Visible = false;
            // 
            // CABttn
            // 
            this.CABttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.CABttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CABttn.FlatAppearance.BorderSize = 0;
            this.CABttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CABttn.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CABttn.ForeColor = System.Drawing.Color.White;
            this.CABttn.Location = new System.Drawing.Point(16, 54);
            this.CABttn.Margin = new System.Windows.Forms.Padding(4);
            this.CABttn.Name = "CABttn";
            this.CABttn.Size = new System.Drawing.Size(149, 28);
            this.CABttn.TabIndex = 53;
            this.CABttn.Text = "Create Account";
            this.CABttn.UseVisualStyleBackColor = false;
            this.CABttn.Click += new System.EventHandler(this.CABttn_Click);
            // 
            // CPBttn
            // 
            this.CPBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.CPBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CPBttn.FlatAppearance.BorderSize = 0;
            this.CPBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPBttn.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPBttn.ForeColor = System.Drawing.Color.White;
            this.CPBttn.Location = new System.Drawing.Point(181, 54);
            this.CPBttn.Margin = new System.Windows.Forms.Padding(4);
            this.CPBttn.Name = "CPBttn";
            this.CPBttn.Size = new System.Drawing.Size(149, 28);
            this.CPBttn.TabIndex = 54;
            this.CPBttn.Text = "Change Password";
            this.CPBttn.UseVisualStyleBackColor = false;
            this.CPBttn.Click += new System.EventHandler(this.CPBttn_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 30;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 30;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 30;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn4.Image")));
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.MinimumWidth = 30;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Width = 30;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn5.Image")));
            this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn5.MinimumWidth = 30;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.Width = 30;
            // 
            // refreshBtn
            // 
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshBtn.Location = new System.Drawing.Point(355, 49);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(107, 34);
            this.refreshBtn.TabIndex = 55;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // UserAccountsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(928, 592);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.CPBttn);
            this.Controls.Add(this.CABttn);
            this.Controls.Add(this.UAUserRolelbl);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.UAHeadinglbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAccountsUI";
            this.Text = "User Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUser;
        public System.Windows.Forms.Label UAUserRolelbl;
        private System.Windows.Forms.Label UAHeadinglbl;
        private System.Windows.Forms.Button CABttn;
        private System.Windows.Forms.Button CPBttn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
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
        private System.Windows.Forms.Button refreshBtn;
    }
}