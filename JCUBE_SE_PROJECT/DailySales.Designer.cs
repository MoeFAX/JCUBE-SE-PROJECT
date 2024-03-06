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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboClerk = new System.Windows.Forms.ComboBox();
            this.totalVal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSoldItems = new System.Windows.Forms.DataGridView();
            this.DSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CancelOrder = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sold Items";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.comboClerk);
            this.panel2.Controls.Add(this.totalVal);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.dateFrom);
            this.panel2.Controls.Add(this.dateTo);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 504);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 50);
            this.panel2.TabIndex = 2;
            // 
            // comboClerk
            // 
            this.comboClerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClerk.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClerk.FormattingEnabled = true;
            this.comboClerk.Location = new System.Drawing.Point(554, 13);
            this.comboClerk.Name = "comboClerk";
            this.comboClerk.Size = new System.Drawing.Size(115, 28);
            this.comboClerk.TabIndex = 16;
            this.comboClerk.SelectedIndexChanged += new System.EventHandler(this.comboClerk_SelectedIndexChanged);
            // 
            // totalVal
            // 
            this.totalVal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalVal.Location = new System.Drawing.Point(882, 14);
            this.totalVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalVal.Name = "totalVal";
            this.totalVal.Size = new System.Drawing.Size(172, 26);
            this.totalVal.TabIndex = 15;
            this.totalVal.Text = "0.00";
            this.totalVal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Location = new System.Drawing.Point(815, 14);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 26);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(231, 14);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(105, 26);
            this.dateFrom.TabIndex = 4;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(408, 14);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(110, 26);
            this.dateTo.TabIndex = 4;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(363, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 26);
            this.label11.TabIndex = 8;
            this.label11.Text = "To:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(27, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 26);
            this.label10.TabIndex = 7;
            this.label10.Text = "Filter By Date From:";
            // 
            // dgvSoldItems
            // 
            this.dgvSoldItems.AllowUserToAddRows = false;
            this.dgvSoldItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvSoldItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoldItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoldItems.ColumnHeadersHeight = 30;
            this.dgvSoldItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSoldItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DSNo,
            this.DSInvoice,
            this.DSItemCode,
            this.DSDescription,
            this.DSPrice,
            this.DSQuantity,
            this.DSDiscount,
            this.DSTotal,
            this.CancelOrder});
            this.dgvSoldItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoldItems.EnableHeadersVisualStyles = false;
            this.dgvSoldItems.GridColor = System.Drawing.Color.Snow;
            this.dgvSoldItems.Location = new System.Drawing.Point(0, 33);
            this.dgvSoldItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSoldItems.Name = "dgvSoldItems";
            this.dgvSoldItems.RowHeadersVisible = false;
            this.dgvSoldItems.RowHeadersWidth = 51;
            this.dgvSoldItems.RowTemplate.Height = 24;
            this.dgvSoldItems.Size = new System.Drawing.Size(1067, 471);
            this.dgvSoldItems.TabIndex = 3;
            this.dgvSoldItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoldItems_CellContentClick);
            // 
            // DSNo
            // 
            this.DSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSNo.HeaderText = "No";
            this.DSNo.MinimumWidth = 6;
            this.DSNo.Name = "DSNo";
            this.DSNo.Width = 63;
            // 
            // DSInvoice
            // 
            this.DSInvoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSInvoice.HeaderText = "Invoice#";
            this.DSInvoice.MinimumWidth = 6;
            this.DSInvoice.Name = "DSInvoice";
            this.DSInvoice.Width = 120;
            // 
            // DSItemCode
            // 
            this.DSItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSItemCode.HeaderText = "Item Code";
            this.DSItemCode.MinimumWidth = 6;
            this.DSItemCode.Name = "DSItemCode";
            this.DSItemCode.Width = 135;
            // 
            // DSDescription
            // 
            this.DSDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DSDescription.HeaderText = "Description";
            this.DSDescription.MinimumWidth = 6;
            this.DSDescription.Name = "DSDescription";
            // 
            // DSPrice
            // 
            this.DSPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSPrice.HeaderText = "Price";
            this.DSPrice.MinimumWidth = 6;
            this.DSPrice.Name = "DSPrice";
            this.DSPrice.Width = 81;
            // 
            // DSQuantity
            // 
            this.DSQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSQuantity.HeaderText = "Quantity";
            this.DSQuantity.MinimumWidth = 6;
            this.DSQuantity.Name = "DSQuantity";
            this.DSQuantity.Width = 119;
            // 
            // DSDiscount
            // 
            this.DSDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSDiscount.HeaderText = "Discount";
            this.DSDiscount.MinimumWidth = 6;
            this.DSDiscount.Name = "DSDiscount";
            this.DSDiscount.Width = 116;
            // 
            // DSTotal
            // 
            this.DSTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSTotal.HeaderText = "Total";
            this.DSTotal.MinimumWidth = 6;
            this.DSTotal.Name = "DSTotal";
            this.DSTotal.Width = 80;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_cancel_20;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 6;
            // 
            // CancelOrder
            // 
            this.CancelOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CancelOrder.HeaderText = "";
            this.CancelOrder.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_cancel_20;
            this.CancelOrder.MinimumWidth = 6;
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Width = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_print_50;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Location = new System.Drawing.Point(723, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(42, 34);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.UseSelectable = true;
            // 
            // DailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvSoldItems);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DailySales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailySales";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DailySales_KeyDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroButton btnPrint;
        private System.Windows.Forms.Label totalVal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox comboClerk;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSTotal;
        private System.Windows.Forms.DataGridViewImageColumn CancelOrder;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.DataGridView dgvSoldItems;
    }
}