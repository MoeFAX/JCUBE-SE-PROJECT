namespace JCUBE_SE_PROJECT
{
    partial class StockInHistoryUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInHistoryUI));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStockHistory = new System.Windows.Forms.DataGridView();
            this.SIHIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIHRefCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIHInvCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIHDescCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIHQuantCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIHSIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIHSIBCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIHStatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIHSupplierCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.PrintStockHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "STOCK IN HISTORY";
            // 
            // dgvStockHistory
            // 
            this.dgvStockHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvStockHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStockHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SIHIDCol,
            this.SIHRefCol,
            this.SIHInvCodeCol,
            this.SIHDescCol,
            this.SIHQuantCol,
            this.SIHSIDCol,
            this.SIHSIBCol,
            this.SIHStatusCol,
            this.SIHSupplierCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockHistory.EnableHeadersVisualStyles = false;
            this.dgvStockHistory.Location = new System.Drawing.Point(16, 57);
            this.dgvStockHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStockHistory.Name = "dgvStockHistory";
            this.dgvStockHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvStockHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStockHistory.RowHeadersVisible = false;
            this.dgvStockHistory.RowHeadersWidth = 51;
            this.dgvStockHistory.RowTemplate.Height = 24;
            this.dgvStockHistory.Size = new System.Drawing.Size(896, 461);
            this.dgvStockHistory.TabIndex = 10;
            // 
            // SIHIDCol
            // 
            this.SIHIDCol.HeaderText = "ID";
            this.SIHIDCol.MinimumWidth = 6;
            this.SIHIDCol.Name = "SIHIDCol";
            this.SIHIDCol.Width = 50;
            // 
            // SIHRefCol
            // 
            this.SIHRefCol.HeaderText = "Reference #";
            this.SIHRefCol.MinimumWidth = 6;
            this.SIHRefCol.Name = "SIHRefCol";
            this.SIHRefCol.Width = 125;
            // 
            // SIHInvCodeCol
            // 
            this.SIHInvCodeCol.HeaderText = "Inventory Code";
            this.SIHInvCodeCol.MinimumWidth = 6;
            this.SIHInvCodeCol.Name = "SIHInvCodeCol";
            this.SIHInvCodeCol.Width = 125;
            // 
            // SIHDescCol
            // 
            this.SIHDescCol.HeaderText = "Description";
            this.SIHDescCol.MinimumWidth = 6;
            this.SIHDescCol.Name = "SIHDescCol";
            this.SIHDescCol.Width = 125;
            // 
            // SIHQuantCol
            // 
            this.SIHQuantCol.HeaderText = "Qty";
            this.SIHQuantCol.MinimumWidth = 6;
            this.SIHQuantCol.Name = "SIHQuantCol";
            this.SIHQuantCol.Width = 50;
            // 
            // SIHSIDCol
            // 
            this.SIHSIDCol.HeaderText = "Stock In Date";
            this.SIHSIDCol.MinimumWidth = 6;
            this.SIHSIDCol.Name = "SIHSIDCol";
            this.SIHSIDCol.Width = 125;
            // 
            // SIHSIBCol
            // 
            this.SIHSIBCol.HeaderText = "Stock In By";
            this.SIHSIBCol.MinimumWidth = 6;
            this.SIHSIBCol.Name = "SIHSIBCol";
            this.SIHSIBCol.Width = 125;
            // 
            // SIHStatusCol
            // 
            this.SIHStatusCol.HeaderText = "Status";
            this.SIHStatusCol.MinimumWidth = 6;
            this.SIHStatusCol.Name = "SIHStatusCol";
            this.SIHStatusCol.Width = 75;
            // 
            // SIHSupplierCol
            // 
            this.SIHSupplierCol.HeaderText = "Supplier";
            this.SIHSupplierCol.MinimumWidth = 6;
            this.SIHSupplierCol.Name = "SIHSupplierCol";
            this.SIHSupplierCol.Width = 95;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(819, 542);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(849, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Manage\r\nRecord";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(466, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Local Data";
            // 
            // pbRefresh
            // 
            this.pbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pbRefresh.Image")));
            this.pbRefresh.Location = new System.Drawing.Point(430, 542);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(30, 30);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRefresh.TabIndex = 26;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Filter By Date From:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(185, 546);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(99, 22);
            this.dtpStartDate.TabIndex = 30;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(325, 546);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(99, 22);
            this.dtpEndDate.TabIndex = 31;
            // 
            // PrintStockHistory
            // 
            this.PrintStockHistory.FlatAppearance.BorderSize = 0;
            this.PrintStockHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintStockHistory.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintStockHistory.Image = ((System.Drawing.Image)(resources.GetObject("PrintStockHistory.Image")));
            this.PrintStockHistory.Location = new System.Drawing.Point(587, 542);
            this.PrintStockHistory.MinimumSize = new System.Drawing.Size(20, 20);
            this.PrintStockHistory.Name = "PrintStockHistory";
            this.PrintStockHistory.Size = new System.Drawing.Size(27, 28);
            this.PrintStockHistory.TabIndex = 32;
            this.PrintStockHistory.UseVisualStyleBackColor = true;
            this.PrintStockHistory.Click += new System.EventHandler(this.PrintStockHistory_Click);
            // 
            // StockInHistoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 592);
            this.Controls.Add(this.PrintStockHistory);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvStockHistory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockInHistoryUI";
            this.Text = "Stock in History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStockHistory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIHIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIHRefCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIHInvCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIHDescCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIHQuantCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIHSIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIHSIBCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIHStatusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIHSupplierCol;
        public System.Windows.Forms.DateTimePicker dtpStartDate;
        public System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button PrintStockHistory;
    }
}