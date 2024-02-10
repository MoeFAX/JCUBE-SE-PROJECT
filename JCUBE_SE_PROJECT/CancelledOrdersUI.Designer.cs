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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CONoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COTransacCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COInvCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COQuantCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COCancByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COReasonCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COActionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filter By Date From:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 545);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "To:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(301, 545);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(70, 24);
            this.comboBox2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 542);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Local Data";
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(896, 461);
            this.dataGridView1.TabIndex = 22;
            // 
            // CONoCol
            // 
            this.CONoCol.HeaderText = "No";
            this.CONoCol.MinimumWidth = 6;
            this.CONoCol.Name = "CONoCol";
            this.CONoCol.Width = 50;
            // 
            // COTransacCol
            // 
            this.COTransacCol.HeaderText = "Transaction No.";
            this.COTransacCol.MinimumWidth = 6;
            this.COTransacCol.Name = "COTransacCol";
            this.COTransacCol.Width = 150;
            // 
            // COInvCodeCol
            // 
            this.COInvCodeCol.HeaderText = "Inventory Code";
            this.COInvCodeCol.MinimumWidth = 6;
            this.COInvCodeCol.Name = "COInvCodeCol";
            this.COInvCodeCol.Width = 130;
            // 
            // COPriceCol
            // 
            this.COPriceCol.HeaderText = "Price";
            this.COPriceCol.MinimumWidth = 6;
            this.COPriceCol.Name = "COPriceCol";
            this.COPriceCol.Width = 75;
            // 
            // COQuantCol
            // 
            this.COQuantCol.HeaderText = "Qty";
            this.COQuantCol.MinimumWidth = 6;
            this.COQuantCol.Name = "COQuantCol";
            this.COQuantCol.Width = 50;
            // 
            // COTotalCol
            // 
            this.COTotalCol.HeaderText = "Total";
            this.COTotalCol.MinimumWidth = 6;
            this.COTotalCol.Name = "COTotalCol";
            this.COTotalCol.Width = 75;
            // 
            // CODateCol
            // 
            this.CODateCol.HeaderText = "Date";
            this.CODateCol.MinimumWidth = 6;
            this.CODateCol.Name = "CODateCol";
            this.CODateCol.Width = 75;
            // 
            // COCancByCol
            // 
            this.COCancByCol.HeaderText = "Cancelled By";
            this.COCancByCol.MinimumWidth = 6;
            this.COCancByCol.Name = "COCancByCol";
            this.COCancByCol.Width = 130;
            // 
            // COReasonCol
            // 
            this.COReasonCol.HeaderText = "Reason";
            this.COReasonCol.MinimumWidth = 6;
            this.COReasonCol.Name = "COReasonCol";
            this.COReasonCol.Width = 80;
            // 
            // COActionCol
            // 
            this.COActionCol.HeaderText = "Action";
            this.COActionCol.MinimumWidth = 6;
            this.COActionCol.Name = "COActionCol";
            // 
            // CancelledOrdersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 592);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CancelledOrdersUI";
            this.Text = "Cancelled Orders";
            this.Load += new System.EventHandler(this.CancelledOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
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