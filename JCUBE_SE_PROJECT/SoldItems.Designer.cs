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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldItems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrintSold = new System.Windows.Forms.Button();
            this.btnTopSelling = new System.Windows.Forms.Button();
            this.btnLoadSold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateToSold = new System.Windows.Forms.DateTimePicker();
            this.dateFromSold = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.flterLbl = new System.Windows.Forms.Label();
            this.SoldTotal = new System.Windows.Forms.Label();
            this.dgvSoldItems = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnPrintSold);
            this.panel2.Controls.Add(this.btnTopSelling);
            this.panel2.Controls.Add(this.btnLoadSold);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 70);
            this.panel2.TabIndex = 9;
            // 
            // btnPrintSold
            // 
            this.btnPrintSold.BackColor = System.Drawing.Color.White;
            this.btnPrintSold.FlatAppearance.BorderSize = 0;
            this.btnPrintSold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSold.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSold.ForeColor = System.Drawing.Color.Black;
            this.btnPrintSold.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_print_30;
            this.btnPrintSold.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintSold.Location = new System.Drawing.Point(236, 18);
            this.btnPrintSold.Name = "btnPrintSold";
            this.btnPrintSold.Size = new System.Drawing.Size(173, 35);
            this.btnPrintSold.TabIndex = 16;
            this.btnPrintSold.Text = "Print Preview";
            this.btnPrintSold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintSold.UseVisualStyleBackColor = false;
            this.btnPrintSold.Click += new System.EventHandler(this.btnPrintSold_Click_1);
            // 
            // btnTopSelling
            // 
            this.btnTopSelling.BackColor = System.Drawing.Color.Transparent;
            this.btnTopSelling.FlatAppearance.BorderSize = 0;
            this.btnTopSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopSelling.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopSelling.ForeColor = System.Drawing.Color.Black;
            this.btnTopSelling.Image = ((System.Drawing.Image)(resources.GetObject("btnTopSelling.Image")));
            this.btnTopSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTopSelling.Location = new System.Drawing.Point(670, 18);
            this.btnTopSelling.Name = "btnTopSelling";
            this.btnTopSelling.Size = new System.Drawing.Size(136, 35);
            this.btnTopSelling.TabIndex = 1;
            this.btnTopSelling.Text = "Top Selling";
            this.btnTopSelling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopSelling.UseVisualStyleBackColor = false;
            this.btnTopSelling.Click += new System.EventHandler(this.btnTopSelling_Click);
            // 
            // btnLoadSold
            // 
            this.btnLoadSold.BackColor = System.Drawing.Color.White;
            this.btnLoadSold.FlatAppearance.BorderSize = 0;
            this.btnLoadSold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSold.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSold.ForeColor = System.Drawing.Color.Black;
            this.btnLoadSold.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadSold.Image")));
            this.btnLoadSold.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadSold.Location = new System.Drawing.Point(488, 18);
            this.btnLoadSold.Name = "btnLoadSold";
            this.btnLoadSold.Size = new System.Drawing.Size(108, 35);
            this.btnLoadSold.TabIndex = 15;
            this.btnLoadSold.Text = "Refresh";
            this.btnLoadSold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadSold.UseVisualStyleBackColor = false;
            this.btnLoadSold.Click += new System.EventHandler(this.btnLoadSold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 42);
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
            this.panel4.Size = new System.Drawing.Size(20, 477);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 477);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateToSold);
            this.panel1.Controls.Add(this.dateFromSold);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flterLbl);
            this.panel1.Controls.Add(this.SoldTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 67);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total Sales:";
            // 
            // dateToSold
            // 
            this.dateToSold.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToSold.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToSold.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToSold.Location = new System.Drawing.Point(366, 20);
            this.dateToSold.Name = "dateToSold";
            this.dateToSold.Size = new System.Drawing.Size(144, 32);
            this.dateToSold.TabIndex = 18;
            // 
            // dateFromSold
            // 
            this.dateFromSold.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromSold.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromSold.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromSold.Location = new System.Drawing.Point(152, 20);
            this.dateFromSold.Name = "dateFromSold";
            this.dateFromSold.Size = new System.Drawing.Size(142, 32);
            this.dateFromSold.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "To:";
            // 
            // flterLbl
            // 
            this.flterLbl.AutoSize = true;
            this.flterLbl.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flterLbl.Location = new System.Drawing.Point(31, 20);
            this.flterLbl.Name = "flterLbl";
            this.flterLbl.Size = new System.Drawing.Size(118, 30);
            this.flterLbl.TabIndex = 14;
            this.flterLbl.Text = "Filter From:";
            // 
            // SoldTotal
            // 
            this.SoldTotal.AutoSize = true;
            this.SoldTotal.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldTotal.Location = new System.Drawing.Point(753, 24);
            this.SoldTotal.Name = "SoldTotal";
            this.SoldTotal.Size = new System.Drawing.Size(51, 30);
            this.SoldTotal.TabIndex = 10;
            this.SoldTotal.Text = "0.00";
            // 
            // dgvSoldItems
            // 
            this.dgvSoldItems.AllowUserToAddRows = false;
            this.dgvSoldItems.AllowUserToDeleteRows = false;
            this.dgvSoldItems.AllowUserToResizeColumns = false;
            this.dgvSoldItems.AllowUserToResizeRows = false;
            this.dgvSoldItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvSoldItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoldItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSoldItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 9);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoldItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoldItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoldItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.InventoryCode,
            this.Description,
            this.Price,
            this.Qty,
            this.Discount,
            this.Total});
            this.dgvSoldItems.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoldItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoldItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoldItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSoldItems.EnableHeadersVisualStyles = false;
            this.dgvSoldItems.Location = new System.Drawing.Point(20, 70);
            this.dgvSoldItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSoldItems.Name = "dgvSoldItems";
            this.dgvSoldItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSoldItems.RowHeadersVisible = false;
            this.dgvSoldItems.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSoldItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSoldItems.RowTemplate.Height = 24;
            this.dgvSoldItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSoldItems.Size = new System.Drawing.Size(871, 407);
            this.dgvSoldItems.TabIndex = 12;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Visible = false;
            this.No.Width = 125;
            // 
            // InventoryCode
            // 
            this.InventoryCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryCode.HeaderText = "Inventory Code";
            this.InventoryCode.MinimumWidth = 6;
            this.InventoryCode.Name = "InventoryCode";
            this.InventoryCode.Width = 136;
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
            this.Price.Width = 101;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 95;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 95;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 69;
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
        private System.Windows.Forms.DataGridView dgvSoldItems;
        private System.Windows.Forms.Button btnLoadSold;
        private System.Windows.Forms.DateTimePicker dateToSold;
        private System.Windows.Forms.DateTimePicker dateFromSold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label flterLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnPrintSold;
        private System.Windows.Forms.Label label2;
    }
}