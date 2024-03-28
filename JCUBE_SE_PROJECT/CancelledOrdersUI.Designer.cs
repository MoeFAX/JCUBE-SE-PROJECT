namespace JCUBE_SE_PROJECT
{
    partial class CancelledOrdersUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelledOrdersUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvCancel = new System.Windows.Forms.DataGridView();
            this.btnLoadCancelled = new System.Windows.Forms.Button();
            this.dateToCancelled = new System.Windows.Forms.DateTimePicker();
            this.dateFromCancelled = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.flterLbl = new System.Windows.Forms.Label();
            this.COActionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COReasonCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COCancByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COQuantCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COInvCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COTransacCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label9.Location = new System.Drawing.Point(11, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "CANCELLED ORDERS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(849, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Manage\r\nRecord";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(819, 542);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // dgvCancel
            // 
            this.dgvCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvCancel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCancel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCancel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCancel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONoCol,
            this.COTransacCol,
            this.COInvCodeCol,
            this.COPriceCol,
            this.COQuantCol,
            this.COTotalCol,
            this.CODateCol,
            this.COCancByCol,
            this.COReasonCol,
            this.COActionCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCancel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCancel.EnableHeadersVisualStyles = false;
            this.dgvCancel.Location = new System.Drawing.Point(16, 57);
            this.dgvCancel.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCancel.Name = "dgvCancel";
            this.dgvCancel.ReadOnly = true;
            this.dgvCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCancel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCancel.RowHeadersVisible = false;
            this.dgvCancel.RowHeadersWidth = 51;
            this.dgvCancel.RowTemplate.Height = 24;
            this.dgvCancel.Size = new System.Drawing.Size(896, 461);
            this.dgvCancel.TabIndex = 22;
            // 
            // btnLoadCancelled
            // 
            this.btnLoadCancelled.BackColor = System.Drawing.Color.White;
            this.btnLoadCancelled.FlatAppearance.BorderSize = 0;
            this.btnLoadCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadCancelled.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCancelled.ForeColor = System.Drawing.Color.Black;
            this.btnLoadCancelled.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCancelled.Image")));
            this.btnLoadCancelled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadCancelled.Location = new System.Drawing.Point(503, 537);
            this.btnLoadCancelled.Name = "btnLoadCancelled";
            this.btnLoadCancelled.Size = new System.Drawing.Size(99, 35);
            this.btnLoadCancelled.TabIndex = 24;
            this.btnLoadCancelled.Text = "Load";
            this.btnLoadCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadCancelled.UseVisualStyleBackColor = false;
            this.btnLoadCancelled.Click += new System.EventHandler(this.btnLoadCancelled_Click);
            // 
            // dateToCancelled
            // 
            this.dateToCancelled.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToCancelled.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToCancelled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToCancelled.Location = new System.Drawing.Point(371, 540);
            this.dateToCancelled.Name = "dateToCancelled";
            this.dateToCancelled.Size = new System.Drawing.Size(112, 28);
            this.dateToCancelled.TabIndex = 27;
            // 
            // dateFromCancelled
            // 
            this.dateFromCancelled.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromCancelled.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromCancelled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromCancelled.Location = new System.Drawing.Point(185, 540);
            this.dateFromCancelled.Name = "dateFromCancelled";
            this.dateFromCancelled.Size = new System.Drawing.Size(110, 28);
            this.dateFromCancelled.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "To:";
            // 
            // flterLbl
            // 
            this.flterLbl.AutoSize = true;
            this.flterLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flterLbl.Location = new System.Drawing.Point(23, 543);
            this.flterLbl.Name = "flterLbl";
            this.flterLbl.Size = new System.Drawing.Size(142, 23);
            this.flterLbl.TabIndex = 23;
            this.flterLbl.Text = "Filter By Date:";
            // 
            // COActionCol
            // 
            this.COActionCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COActionCol.HeaderText = "Action";
            this.COActionCol.MinimumWidth = 6;
            this.COActionCol.Name = "COActionCol";
            this.COActionCol.ReadOnly = true;
            this.COActionCol.Width = 86;
            // 
            // COReasonCol
            // 
            this.COReasonCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COReasonCol.HeaderText = "Reason";
            this.COReasonCol.MinimumWidth = 6;
            this.COReasonCol.Name = "COReasonCol";
            this.COReasonCol.ReadOnly = true;
            // 
            // COCancByCol
            // 
            this.COCancByCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COCancByCol.HeaderText = "Cancelled By";
            this.COCancByCol.MinimumWidth = 6;
            this.COCancByCol.Name = "COCancByCol";
            this.COCancByCol.ReadOnly = true;
            this.COCancByCol.Width = 118;
            // 
            // CODateCol
            // 
            this.CODateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODateCol.HeaderText = "Date";
            this.CODateCol.MinimumWidth = 6;
            this.CODateCol.Name = "CODateCol";
            this.CODateCol.ReadOnly = true;
            this.CODateCol.Width = 76;
            // 
            // COTotalCol
            // 
            this.COTotalCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COTotalCol.HeaderText = "Total";
            this.COTotalCol.MinimumWidth = 6;
            this.COTotalCol.Name = "COTotalCol";
            this.COTotalCol.ReadOnly = true;
            this.COTotalCol.Width = 75;
            // 
            // COQuantCol
            // 
            this.COQuantCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COQuantCol.HeaderText = "Qty";
            this.COQuantCol.MinimumWidth = 6;
            this.COQuantCol.Name = "COQuantCol";
            this.COQuantCol.ReadOnly = true;
            this.COQuantCol.Width = 66;
            // 
            // COPriceCol
            // 
            this.COPriceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COPriceCol.HeaderText = "Price";
            this.COPriceCol.MinimumWidth = 6;
            this.COPriceCol.Name = "COPriceCol";
            this.COPriceCol.ReadOnly = true;
            this.COPriceCol.Width = 75;
            // 
            // COInvCodeCol
            // 
            this.COInvCodeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COInvCodeCol.HeaderText = "Item Code";
            this.COInvCodeCol.MinimumWidth = 6;
            this.COInvCodeCol.Name = "COInvCodeCol";
            this.COInvCodeCol.ReadOnly = true;
            this.COInvCodeCol.Width = 106;
            // 
            // COTransacCol
            // 
            this.COTransacCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COTransacCol.HeaderText = "Transaction No.";
            this.COTransacCol.MinimumWidth = 6;
            this.COTransacCol.Name = "COTransacCol";
            this.COTransacCol.ReadOnly = true;
            this.COTransacCol.Width = 133;
            // 
            // CONoCol
            // 
            this.CONoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CONoCol.HeaderText = "No";
            this.CONoCol.MinimumWidth = 6;
            this.CONoCol.Name = "CONoCol";
            this.CONoCol.ReadOnly = true;
            this.CONoCol.Width = 63;
            // 
            // CancelledOrdersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 592);
            this.Controls.Add(this.btnLoadCancelled);
            this.Controls.Add(this.dateToCancelled);
            this.Controls.Add(this.dateFromCancelled);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flterLbl);
            this.Controls.Add(this.dgvCancel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CancelledOrdersUI";
            this.Text = "Cancelled Orders";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvCancel;
        private System.Windows.Forms.Button btnLoadCancelled;
        private System.Windows.Forms.DateTimePicker dateToCancelled;
        private System.Windows.Forms.DateTimePicker dateFromCancelled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label flterLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COTransacCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COInvCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COQuantCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COTotalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COCancByCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COReasonCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COActionCol;
    }
}