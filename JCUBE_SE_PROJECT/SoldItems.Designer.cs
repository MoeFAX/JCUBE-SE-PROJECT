using System.Drawing;

namespace JCUBE_SE_PROJECT
{
    partial class SoldItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldItems));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTopSelling = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mngRecord = new System.Windows.Forms.Label();
            this.SoldTotal = new System.Windows.Forms.Label();
            this.dgvSoldItems = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintSold = new System.Windows.Forms.Button();
            this.btnLoadSold = new System.Windows.Forms.Button();
            this.dateToSold = new System.Windows.Forms.DateTimePicker();
            this.dateFromSold = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.flterLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnTopSelling);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 70);
            this.panel2.TabIndex = 9;
            // 
            // btnTopSelling
            // 
            this.btnTopSelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnTopSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopSelling.ForeColor = System.Drawing.Color.White;
            this.btnTopSelling.Location = new System.Drawing.Point(3, 34);
            this.btnTopSelling.Name = "btnTopSelling";
            this.btnTopSelling.Size = new System.Drawing.Size(131, 30);
            this.btnTopSelling.TabIndex = 1;
            this.btnTopSelling.Text = "View Top Selling";
            this.btnTopSelling.UseVisualStyleBackColor = false;
            this.btnTopSelling.Click += new System.EventHandler(this.btnTopSelling_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOLD ITEMS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(891, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 444);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 444);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPrintSold);
            this.panel1.Controls.Add(this.btnLoadSold);
            this.panel1.Controls.Add(this.dateToSold);
            this.panel1.Controls.Add(this.dateFromSold);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flterLbl);
            this.panel1.Controls.Add(this.mngRecord);
            this.panel1.Controls.Add(this.SoldTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 100);
            this.panel1.TabIndex = 8;
            // 
            // mngRecord
            // 
            this.mngRecord.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngRecord.Image = ((System.Drawing.Image)(resources.GetObject("mngRecord.Image")));
            this.mngRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mngRecord.Location = new System.Drawing.Point(758, 15);
            this.mngRecord.Name = "mngRecord";
            this.mngRecord.Size = new System.Drawing.Size(141, 75);
            this.mngRecord.TabIndex = 13;
            this.mngRecord.Text = "Manage Record";
            this.mngRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SoldTotal
            // 
            this.SoldTotal.AutoSize = true;
            this.SoldTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldTotal.Location = new System.Drawing.Point(638, 47);
            this.SoldTotal.Name = "SoldTotal";
            this.SoldTotal.Size = new System.Drawing.Size(48, 23);
            this.SoldTotal.TabIndex = 10;
            this.SoldTotal.Text = "0.00";
            // 
            // dgvSoldItems
            // 
            this.dgvSoldItems.AllowUserToAddRows = false;
            this.dgvSoldItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvSoldItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoldItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoldItems.ColumnHeadersHeight = 30;
            this.dgvSoldItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSoldItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.InventoryCode,
            this.Description,
            this.Price,
            this.Qty,
            this.Discount,
            this.Total});
            this.dgvSoldItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoldItems.EnableHeadersVisualStyles = false;
            this.dgvSoldItems.GridColor = System.Drawing.Color.Snow;
            this.dgvSoldItems.Location = new System.Drawing.Point(20, 70);
            this.dgvSoldItems.Name = "dgvSoldItems";
            this.dgvSoldItems.RowHeadersVisible = false;
            this.dgvSoldItems.RowHeadersWidth = 51;
            this.dgvSoldItems.RowTemplate.Height = 24;
            this.dgvSoldItems.Size = new System.Drawing.Size(871, 374);
            this.dgvSoldItems.TabIndex = 12;
            this.dgvSoldItems.DefaultCellStyle.Font = new Font("Arial", 10);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.DefaultCellStyle = dataGridViewCellStyle2;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 63;
            // 
            // InventoryCode
            // 
            this.InventoryCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryCode.HeaderText = "Inventory Code";
            this.InventoryCode.MinimumWidth = 6;
            this.InventoryCode.Name = "InventoryCode";
            this.InventoryCode.Width = 184;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "Unit Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 120;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 119;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 116;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 80;
            // 
            // btnPrintSold
            // 
            this.btnPrintSold.FlatAppearance.BorderSize = 0;
            this.btnPrintSold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSold.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSold.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintSold.Image")));
            this.btnPrintSold.Location = new System.Drawing.Point(470, 44);
            this.btnPrintSold.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnPrintSold.Name = "btnPrintSold";
            this.btnPrintSold.Size = new System.Drawing.Size(27, 28);
            this.btnPrintSold.TabIndex = 20;
            this.btnPrintSold.UseVisualStyleBackColor = true;
            // 
            // btnLoadSold
            // 
            this.btnLoadSold.BackColor = System.Drawing.Color.White;
            this.btnLoadSold.FlatAppearance.BorderSize = 0;
            this.btnLoadSold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSold.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSold.ForeColor = System.Drawing.Color.Black;
            this.btnLoadSold.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadSold.Image")));
            this.btnLoadSold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSold.Location = new System.Drawing.Point(352, 41);
            this.btnLoadSold.Name = "btnLoadSold";
            this.btnLoadSold.Size = new System.Drawing.Size(99, 35);
            this.btnLoadSold.TabIndex = 15;
            this.btnLoadSold.Text = "Load";
            this.btnLoadSold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadSold.UseVisualStyleBackColor = false;
            this.btnLoadSold.Click += new System.EventHandler(this.btnLoadSold_Click);
            // 
            // dateToSold
            // 
            this.dateToSold.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToSold.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToSold.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToSold.Location = new System.Drawing.Point(209, 44);
            this.dateToSold.Name = "dateToSold";
            this.dateToSold.Size = new System.Drawing.Size(112, 28);
            this.dateToSold.TabIndex = 18;
            // 
            // dateFromSold
            // 
            this.dateFromSold.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromSold.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromSold.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromSold.Location = new System.Drawing.Point(19, 44);
            this.dateFromSold.Name = "dateFromSold";
            this.dateFromSold.Size = new System.Drawing.Size(110, 28);
            this.dateFromSold.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "To:";
            // 
            // flterLbl
            // 
            this.flterLbl.AutoSize = true;
            this.flterLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flterLbl.Location = new System.Drawing.Point(17, 15);
            this.flterLbl.Name = "flterLbl";
            this.flterLbl.Size = new System.Drawing.Size(142, 23);
            this.flterLbl.TabIndex = 14;
            this.flterLbl.Text = "Filter By Date:";
            // 
            // SoldItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 544);
            this.Controls.Add(this.dgvSoldItems);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "SoldItems";
            this.Text = "SoldItems";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTopSelling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SoldTotal;
        private System.Windows.Forms.Label mngRecord;
        private System.Windows.Forms.DataGridView dgvSoldItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnPrintSold;
        private System.Windows.Forms.Button btnLoadSold;
        private System.Windows.Forms.DateTimePicker dateToSold;
        private System.Windows.Forms.DateTimePicker dateFromSold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label flterLbl;
    }
}