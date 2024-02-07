namespace JCUBE_SE_PROJECT
{
    partial class DailySales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sold Items";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(-8, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 41);
            this.panel2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_print_50;
            this.label13.Location = new System.Drawing.Point(512, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 32);
            this.label13.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(358, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "Role:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(20, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Filter By Date From:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DSNo,
            this.DSInvoice,
            this.DSItemCode,
            this.DSDescription,
            this.DSPrice,
            this.DSQuantity,
            this.DSDiscount,
            this.DSTotal});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Snow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 383);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DSNo
            // 
            this.DSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSNo.HeaderText = "No";
            this.DSNo.Name = "DSNo";
            this.DSNo.Width = 53;
            // 
            // DSInvoice
            // 
            this.DSInvoice.HeaderText = "Invoice#";
            this.DSInvoice.Name = "DSInvoice";
            // 
            // DSItemCode
            // 
            this.DSItemCode.HeaderText = "Item Code";
            this.DSItemCode.Name = "DSItemCode";
            // 
            // DSDescription
            // 
            this.DSDescription.HeaderText = "Description";
            this.DSDescription.Name = "DSDescription";
            // 
            // DSPrice
            // 
            this.DSPrice.HeaderText = "Price";
            this.DSPrice.Name = "DSPrice";
            // 
            // DSQuantity
            // 
            this.DSQuantity.HeaderText = "Quantity";
            this.DSQuantity.Name = "DSQuantity";
            // 
            // DSDiscount
            // 
            this.DSDiscount.HeaderText = "Discount";
            this.DSDiscount.Name = "DSDiscount";
            // 
            // DSTotal
            // 
            this.DSTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DSTotal.HeaderText = "Total";
            this.DSTotal.Name = "DSTotal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(18, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(204, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "To:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(180, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(18, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(405, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(17, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // DailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "DailySales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailySales";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSTotal;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}