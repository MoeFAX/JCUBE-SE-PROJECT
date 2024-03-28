namespace JCUBE_SE_PROJECT
{
    partial class StocksUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StocksUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dtpStockEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStockStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.mngStocks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvStockEntry = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.dtpStockEndDate);
            this.panel1.Controls.Add(this.dtpStockStartDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addbutton);
            this.panel1.Controls.Add(this.mngStocks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 100);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(544, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "Local Data";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtpStockEndDate
            // 
            this.dtpStockEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpStockEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStockEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStockEndDate.Location = new System.Drawing.Point(474, 42);
            this.dtpStockEndDate.Name = "dtpStockEndDate";
            this.dtpStockEndDate.Size = new System.Drawing.Size(22, 22);
            this.dtpStockEndDate.TabIndex = 5;
            // 
            // dtpStockStartDate
            // 
            this.dtpStockStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpStockStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStockStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStockStartDate.Location = new System.Drawing.Point(407, 42);
            this.dtpStockStartDate.Name = "dtpStockStartDate";
            this.dtpStockStartDate.Size = new System.Drawing.Size(19, 22);
            this.dtpStockStartDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By Date From:";
            // 
            // addbutton
            // 
            this.addbutton.FlatAppearance.BorderSize = 0;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Image = ((System.Drawing.Image)(resources.GetObject("addbutton.Image")));
            this.addbutton.Location = new System.Drawing.Point(839, 23);
            this.addbutton.MinimumSize = new System.Drawing.Size(20, 20);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(52, 59);
            this.addbutton.TabIndex = 1;
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // mngStocks
            // 
            this.mngStocks.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngStocks.Image = ((System.Drawing.Image)(resources.GetObject("mngStocks.Image")));
            this.mngStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mngStocks.Location = new System.Drawing.Point(16, 16);
            this.mngStocks.Name = "mngStocks";
            this.mngStocks.Size = new System.Drawing.Size(149, 75);
            this.mngStocks.TabIndex = 0;
            this.mngStocks.Text = "Manage Stocks";
            this.mngStocks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 70);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK IN ENTRY";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 374);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(891, 70);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 374);
            this.panel4.TabIndex = 3;
            // 
            // dgvStockEntry
            // 
            this.dgvStockEntry.AllowUserToAddRows = false;
            this.dgvStockEntry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvStockEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockEntry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockEntry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockEntry.ColumnHeadersHeight = 30;
            this.dgvStockEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStockEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.ItemID,
            this.Stocks,
            this.SupplierID,
            this.StockInDate,
            this.Status,
            this.Edit,
            this.Delete});
            this.dgvStockEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockEntry.EnableHeadersVisualStyles = false;
            this.dgvStockEntry.GridColor = System.Drawing.Color.Snow;
            this.dgvStockEntry.Location = new System.Drawing.Point(20, 70);
            this.dgvStockEntry.Name = "dgvStockEntry";
            this.dgvStockEntry.RowHeadersVisible = false;
            this.dgvStockEntry.RowHeadersWidth = 51;
            this.dgvStockEntry.RowTemplate.Height = 24;
            this.dgvStockEntry.Size = new System.Drawing.Size(871, 374);
            this.dgvStockEntry.TabIndex = 4;
            this.dgvStockEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockEntry_CellContentClick);
            // 
            // StockID
            // 
            this.StockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockID.HeaderText = "StockID";
            this.StockID.MinimumWidth = 6;
            this.StockID.Name = "StockID";
            this.StockID.Width = 106;
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemID.HeaderText = "Item Name";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            // 
            // Stocks
            // 
            this.Stocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stocks.HeaderText = "Stocks";
            this.Stocks.MinimumWidth = 6;
            this.Stocks.Name = "Stocks";
            this.Stocks.Width = 94;
            // 
            // SupplierID
            // 
            this.SupplierID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierID.HeaderText = "Supplier Name";
            this.SupplierID.MinimumWidth = 6;
            this.SupplierID.Name = "SupplierID";
            // 
            // StockInDate
            // 
            this.StockInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockInDate.HeaderText = "StockInDate";
            this.StockInDate.MinimumWidth = 6;
            this.StockInDate.Name = "StockInDate";
            this.StockInDate.Width = 150;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 92;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 21;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 21;
            // 
            // StocksUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 544);
            this.ControlBox = false;
            this.Controls.Add(this.dgvStockEntry);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StocksUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label mngStocks;
        private System.Windows.Forms.DataGridView dgvStockEntry;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStockStartDate;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DateTimePicker dtpStockEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}