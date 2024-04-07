namespace JCUBE_SE_PROJECT
{
    partial class StocksArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StocksArchive));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StocksArchivesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintStockArchives = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.side2 = new System.Windows.Forms.Panel();
            this.dgvStockEntryArchive = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restore = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockEntryArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StocksArchivesLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 70);
            this.panel2.TabIndex = 4;
            // 
            // StocksArchivesLabel
            // 
            this.StocksArchivesLabel.AutoSize = true;
            this.StocksArchivesLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocksArchivesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.StocksArchivesLabel.Location = new System.Drawing.Point(21, 22);
            this.StocksArchivesLabel.Name = "StocksArchivesLabel";
            this.StocksArchivesLabel.Size = new System.Drawing.Size(187, 27);
            this.StocksArchivesLabel.TabIndex = 0;
            this.StocksArchivesLabel.Text = "Stocks Archives";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrintStockArchives);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 485);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 69);
            this.panel1.TabIndex = 6;
            // 
            // PrintStockArchives
            // 
            this.PrintStockArchives.FlatAppearance.BorderSize = 0;
            this.PrintStockArchives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintStockArchives.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintStockArchives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.PrintStockArchives.Image = ((System.Drawing.Image)(resources.GetObject("PrintStockArchives.Image")));
            this.PrintStockArchives.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintStockArchives.Location = new System.Drawing.Point(849, 12);
            this.PrintStockArchives.MinimumSize = new System.Drawing.Size(20, 20);
            this.PrintStockArchives.Name = "PrintStockArchives";
            this.PrintStockArchives.Size = new System.Drawing.Size(168, 45);
            this.PrintStockArchives.TabIndex = 33;
            this.PrintStockArchives.Text = "Print Preview";
            this.PrintStockArchives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintStockArchives.UseVisualStyleBackColor = true;
            this.PrintStockArchives.Click += new System.EventHandler(this.PrintStockArchives_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 415);
            this.panel3.TabIndex = 8;
            // 
            // side2
            // 
            this.side2.Dock = System.Windows.Forms.DockStyle.Right;
            this.side2.Location = new System.Drawing.Point(1047, 70);
            this.side2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(20, 415);
            this.side2.TabIndex = 9;
            // 
            // dgvStockEntryArchive
            // 
            this.dgvStockEntryArchive.AllowUserToAddRows = false;
            this.dgvStockEntryArchive.AllowUserToDeleteRows = false;
            this.dgvStockEntryArchive.AllowUserToResizeColumns = false;
            this.dgvStockEntryArchive.AllowUserToResizeRows = false;
            this.dgvStockEntryArchive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvStockEntryArchive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockEntryArchive.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStockEntryArchive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 9);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockEntryArchive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockEntryArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockEntryArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.ItemID,
            this.Stocks,
            this.SupplierID,
            this.Status,
            this.Restore,
            this.Delete});
            this.dgvStockEntryArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockEntryArchive.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockEntryArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockEntryArchive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStockEntryArchive.EnableHeadersVisualStyles = false;
            this.dgvStockEntryArchive.Location = new System.Drawing.Point(20, 70);
            this.dgvStockEntryArchive.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStockEntryArchive.Name = "dgvStockEntryArchive";
            this.dgvStockEntryArchive.ReadOnly = true;
            this.dgvStockEntryArchive.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStockEntryArchive.RowHeadersVisible = false;
            this.dgvStockEntryArchive.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvStockEntryArchive.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockEntryArchive.RowTemplate.Height = 24;
            this.dgvStockEntryArchive.Size = new System.Drawing.Size(1027, 415);
            this.dgvStockEntryArchive.TabIndex = 18;
            this.dgvStockEntryArchive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockEntryArchive_CellContentClick);
            // 
            // StockID
            // 
            this.StockID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockID.HeaderText = "StockID";
            this.StockID.MinimumWidth = 6;
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            this.StockID.Visible = false;
            this.StockID.Width = 125;
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemID.HeaderText = "Item Name";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // Stocks
            // 
            this.Stocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stocks.HeaderText = "Stocks";
            this.Stocks.MinimumWidth = 6;
            this.Stocks.Name = "Stocks";
            this.Stocks.ReadOnly = true;
            this.Stocks.Width = 81;
            // 
            // SupplierID
            // 
            this.SupplierID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierID.HeaderText = "Supplier Name";
            this.SupplierID.MinimumWidth = 6;
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Restore
            // 
            this.Restore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Restore.HeaderText = "";
            this.Restore.Image = global::JCUBE_SE_PROJECT.Properties.Resources.local_data_icon;
            this.Restore.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Restore.MinimumWidth = 6;
            this.Restore.Name = "Restore";
            this.Restore.ReadOnly = true;
            this.Restore.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 21;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_cancel_20;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // StocksArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvStockEntryArchive);
            this.Controls.Add(this.side2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StocksArchive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks Archive";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockEntryArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label StocksArchivesLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel side2;
        private System.Windows.Forms.DataGridView dgvStockEntryArchive;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button PrintStockArchives;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Restore;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}