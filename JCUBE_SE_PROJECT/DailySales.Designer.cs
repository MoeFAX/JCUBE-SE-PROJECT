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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySales));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblClerk = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.comboClerk = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalVal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvSoldItems = new System.Windows.Forms.DataGridView();
            this.DSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelOrder = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lblTo);
            this.panel2.Controls.Add(this.dateFrom);
            this.panel2.Controls.Add(this.lblClerk);
            this.panel2.Controls.Add(this.dateTo);
            this.panel2.Controls.Add(this.comboClerk);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 50);
            this.panel2.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTo.Location = new System.Drawing.Point(374, 11);
            this.lblTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(40, 30);
            this.lblTo.TabIndex = 18;
            this.lblTo.Text = "To:";
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(213, 11);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(137, 31);
            this.dateFrom.TabIndex = 4;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // lblClerk
            // 
            this.lblClerk.AutoSize = true;
            this.lblClerk.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClerk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClerk.Location = new System.Drawing.Point(645, 11);
            this.lblClerk.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClerk.Name = "lblClerk";
            this.lblClerk.Size = new System.Drawing.Size(66, 30);
            this.lblClerk.TabIndex = 19;
            this.lblClerk.Text = "Clerk:";
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(438, 11);
            this.dateTo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(132, 31);
            this.dateTo.TabIndex = 4;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // comboClerk
            // 
            this.comboClerk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClerk.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClerk.FormattingEnabled = true;
            this.comboClerk.Location = new System.Drawing.Point(731, 11);
            this.comboClerk.Margin = new System.Windows.Forms.Padding(5);
            this.comboClerk.Name = "comboClerk";
            this.comboClerk.Size = new System.Drawing.Size(201, 34);
            this.comboClerk.TabIndex = 16;
            this.comboClerk.SelectedIndexChanged += new System.EventHandler(this.comboClerk_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(223, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 28);
            this.label11.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(72, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 30);
            this.label10.TabIndex = 7;
            this.label10.Text = "Filter From:";
            // 
            // totalVal
            // 
            this.totalVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalVal.AutoSize = true;
            this.totalVal.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalVal.Location = new System.Drawing.Point(781, 17);
            this.totalVal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.totalVal.Name = "totalVal";
            this.totalVal.Size = new System.Drawing.Size(52, 30);
            this.totalVal.TabIndex = 15;
            this.totalVal.Text = "0.00";
            this.totalVal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Location = new System.Drawing.Point(722, 17);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 30);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
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
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoldItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvSoldItems.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoldItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoldItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSoldItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSoldItems.EnableHeadersVisualStyles = false;
            this.dgvSoldItems.Location = new System.Drawing.Point(0, 57);
            this.dgvSoldItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSoldItems.Name = "dgvSoldItems";
            this.dgvSoldItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Noto Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoldItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSoldItems.RowHeadersVisible = false;
            this.dgvSoldItems.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvSoldItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSoldItems.RowTemplate.Height = 24;
            this.dgvSoldItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSoldItems.Size = new System.Drawing.Size(982, 446);
            this.dgvSoldItems.TabIndex = 3;
            this.dgvSoldItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoldItems_CellContentClick);
            // 
            // DSNo
            // 
            this.DSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSNo.HeaderText = "No";
            this.DSNo.MinimumWidth = 6;
            this.DSNo.Name = "DSNo";
            this.DSNo.Visible = false;
            this.DSNo.Width = 125;
            // 
            // DSInvoice
            // 
            this.DSInvoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSInvoice.HeaderText = "Invoice No.";
            this.DSInvoice.MinimumWidth = 6;
            this.DSInvoice.Name = "DSInvoice";
            this.DSInvoice.Width = 110;
            // 
            // DSItemCode
            // 
            this.DSItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DSItemCode.HeaderText = "Item Code";
            this.DSItemCode.MinimumWidth = 104;
            this.DSItemCode.Name = "DSItemCode";
            this.DSItemCode.Width = 120;
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
            this.DSPrice.Width = 69;
            // 
            // DSQuantity
            // 
            this.DSQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSQuantity.HeaderText = "Quantity";
            this.DSQuantity.MinimumWidth = 6;
            this.DSQuantity.Name = "DSQuantity";
            this.DSQuantity.Width = 95;
            // 
            // DSDiscount
            // 
            this.DSDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSDiscount.HeaderText = "Discount";
            this.DSDiscount.MinimumWidth = 6;
            this.DSDiscount.Name = "DSDiscount";
            this.DSDiscount.Width = 95;
            // 
            // DSTotal
            // 
            this.DSTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSTotal.HeaderText = "Total";
            this.DSTotal.MinimumWidth = 6;
            this.DSTotal.Name = "DSTotal";
            this.DSTotal.Width = 69;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(175, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sold Items";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.totalVal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 57);
            this.panel1.TabIndex = 20;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_print_30;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(214, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(173, 35);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print Preview";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_cancel_20;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // DailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvSoldItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailySales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Sales";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DailySales_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totalVal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox comboClerk;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.DataGridView dgvSoldItems;
        private System.Windows.Forms.Label lblClerk;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSTotal;
        private System.Windows.Forms.DataGridViewImageColumn CancelOrder;
    }
}