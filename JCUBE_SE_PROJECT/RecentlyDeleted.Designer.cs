namespace JCUBE_SE_PROJECT
{
    partial class RecentlyDeleted
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecentlyDeleted));
            this.RDHeadinglbl = new System.Windows.Forms.Label();
            this.dgvUserArchive = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAUserNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAFullNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAEmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UARoleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UATimeArchCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAAccAgeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestoreAcc = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteAcc = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // RDHeadinglbl
            // 
            this.RDHeadinglbl.AutoSize = true;
            this.RDHeadinglbl.BackColor = System.Drawing.SystemColors.Control;
            this.RDHeadinglbl.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDHeadinglbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.RDHeadinglbl.Location = new System.Drawing.Point(7, 9);
            this.RDHeadinglbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RDHeadinglbl.Name = "RDHeadinglbl";
            this.RDHeadinglbl.Size = new System.Drawing.Size(234, 35);
            this.RDHeadinglbl.TabIndex = 7;
            this.RDHeadinglbl.Text = "RECENTLY DELETED";
            // 
            // dgvUserArchive
            // 
            this.dgvUserArchive.AllowUserToAddRows = false;
            this.dgvUserArchive.AllowUserToDeleteRows = false;
            this.dgvUserArchive.AllowUserToResizeColumns = false;
            this.dgvUserArchive.AllowUserToResizeRows = false;
            this.dgvUserArchive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvUserArchive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserArchive.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUserArchive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 9);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserArchive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountID,
            this.UAUserNameCol,
            this.UAFullNameCol,
            this.UAEmailCol,
            this.UARoleCol,
            this.UATimeArchCol,
            this.UAAccAgeCol,
            this.RestoreAcc,
            this.DeleteAcc});
            this.dgvUserArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserArchive.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserArchive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUserArchive.EnableHeadersVisualStyles = false;
            this.dgvUserArchive.Location = new System.Drawing.Point(13, 71);
            this.dgvUserArchive.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserArchive.Name = "dgvUserArchive";
            this.dgvUserArchive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvUserArchive.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserArchive.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUserArchive.RowHeadersVisible = false;
            this.dgvUserArchive.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvUserArchive.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserArchive.RowTemplate.Height = 24;
            this.dgvUserArchive.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserArchive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUserArchive.Size = new System.Drawing.Size(1022, 461);
            this.dgvUserArchive.TabIndex = 19;
            this.dgvUserArchive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserArchive_CellContentClick);
            this.dgvUserArchive.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUserArchive_CellFormatting);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Accounts stored here will automatically be deleted after 30 days.";
            // 
            // AccountID
            // 
            this.AccountID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AccountID.HeaderText = "No";
            this.AccountID.MinimumWidth = 6;
            this.AccountID.Name = "AccountID";
            this.AccountID.ReadOnly = true;
            this.AccountID.Visible = false;
            this.AccountID.Width = 32;
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
            this.UAFullNameCol.Width = 150;
            // 
            // UAEmailCol
            // 
            this.UAEmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UAEmailCol.HeaderText = "Email Address";
            this.UAEmailCol.MinimumWidth = 6;
            this.UAEmailCol.Name = "UAEmailCol";
            this.UAEmailCol.ReadOnly = true;
            this.UAEmailCol.Width = 175;
            // 
            // UARoleCol
            // 
            this.UARoleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UARoleCol.HeaderText = "Role";
            this.UARoleCol.MinimumWidth = 120;
            this.UARoleCol.Name = "UARoleCol";
            this.UARoleCol.ReadOnly = true;
            this.UARoleCol.Width = 120;
            // 
            // UATimeArchCol
            // 
            this.UATimeArchCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UATimeArchCol.HeaderText = "Time Archived";
            this.UATimeArchCol.MinimumWidth = 6;
            this.UATimeArchCol.Name = "UATimeArchCol";
            this.UATimeArchCol.ReadOnly = true;
            this.UATimeArchCol.Width = 180;
            // 
            // UAAccAgeCol
            // 
            this.UAAccAgeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UAAccAgeCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.UAAccAgeCol.HeaderText = "Account Age";
            this.UAAccAgeCol.MinimumWidth = 6;
            this.UAAccAgeCol.Name = "UAAccAgeCol";
            this.UAAccAgeCol.ReadOnly = true;
            // 
            // RestoreAcc
            // 
            this.RestoreAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RestoreAcc.HeaderText = "";
            this.RestoreAcc.Image = global::JCUBE_SE_PROJECT.Properties.Resources.local_data_icon;
            this.RestoreAcc.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.RestoreAcc.MinimumWidth = 6;
            this.RestoreAcc.Name = "RestoreAcc";
            this.RestoreAcc.Width = 30;
            // 
            // DeleteAcc
            // 
            this.DeleteAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteAcc.HeaderText = "";
            this.DeleteAcc.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAcc.Image")));
            this.DeleteAcc.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeleteAcc.MinimumWidth = 30;
            this.DeleteAcc.Name = "DeleteAcc";
            this.DeleteAcc.Width = 30;
            // 
            // RecentlyDeleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUserArchive);
            this.Controls.Add(this.RDHeadinglbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecentlyDeleted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecentlyDeleted";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserArchive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RDHeadinglbl;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        public System.Windows.Forms.DataGridView dgvUserArchive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAUserNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAFullNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAEmailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UARoleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UATimeArchCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAAccAgeCol;
        private System.Windows.Forms.DataGridViewImageColumn RestoreAcc;
        private System.Windows.Forms.DataGridViewImageColumn DeleteAcc;
    }
}