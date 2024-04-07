namespace JCUBE_SE_PROJECT
{
    partial class ItemListArchives
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemListArchives));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintItemListArchives = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemListArchivesLabel = new System.Windows.Forms.Label();
            this.side2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvItemListArchive = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquiredCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Restore = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemListArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrintItemListArchives);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 483);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 70);
            this.panel1.TabIndex = 2;
            // 
            // PrintItemListArchives
            // 
            this.PrintItemListArchives.FlatAppearance.BorderSize = 0;
            this.PrintItemListArchives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintItemListArchives.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintItemListArchives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.PrintItemListArchives.Image = ((System.Drawing.Image)(resources.GetObject("PrintItemListArchives.Image")));
            this.PrintItemListArchives.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintItemListArchives.Location = new System.Drawing.Point(770, 13);
            this.PrintItemListArchives.MinimumSize = new System.Drawing.Size(20, 20);
            this.PrintItemListArchives.Name = "PrintItemListArchives";
            this.PrintItemListArchives.Size = new System.Drawing.Size(169, 45);
            this.PrintItemListArchives.TabIndex = 34;
            this.PrintItemListArchives.Text = "Print Preview";
            this.PrintItemListArchives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintItemListArchives.UseVisualStyleBackColor = true;
            this.PrintItemListArchives.Click += new System.EventHandler(this.PrintItemListArchives_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ItemListArchivesLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 70);
            this.panel2.TabIndex = 3;
            // 
            // ItemListArchivesLabel
            // 
            this.ItemListArchivesLabel.AutoSize = true;
            this.ItemListArchivesLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListArchivesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.ItemListArchivesLabel.Location = new System.Drawing.Point(21, 22);
            this.ItemListArchivesLabel.Name = "ItemListArchivesLabel";
            this.ItemListArchivesLabel.Size = new System.Drawing.Size(204, 27);
            this.ItemListArchivesLabel.TabIndex = 0;
            this.ItemListArchivesLabel.Text = "Item List Archives";
            // 
            // side2
            // 
            this.side2.Dock = System.Windows.Forms.DockStyle.Right;
            this.side2.Location = new System.Drawing.Point(961, 70);
            this.side2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(20, 413);
            this.side2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 413);
            this.panel3.TabIndex = 6;
            // 
            // dgvItemListArchive
            // 
            this.dgvItemListArchive.AllowUserToAddRows = false;
            this.dgvItemListArchive.AllowUserToDeleteRows = false;
            this.dgvItemListArchive.AllowUserToResizeColumns = false;
            this.dgvItemListArchive.AllowUserToResizeRows = false;
            this.dgvItemListArchive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvItemListArchive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemListArchive.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItemListArchive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 9);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemListArchive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemListArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemListArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.InventoryCode,
            this.ItemCode,
            this.Description,
            this.AcquiredCost,
            this.bid,
            this.cid,
            this.Price,
            this.ReOrder,
            this.Restore,
            this.Delete});
            this.dgvItemListArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemListArchive.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemListArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemListArchive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItemListArchive.EnableHeadersVisualStyles = false;
            this.dgvItemListArchive.Location = new System.Drawing.Point(20, 70);
            this.dgvItemListArchive.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItemListArchive.Name = "dgvItemListArchive";
            this.dgvItemListArchive.ReadOnly = true;
            this.dgvItemListArchive.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItemListArchive.RowHeadersVisible = false;
            this.dgvItemListArchive.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvItemListArchive.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemListArchive.RowTemplate.Height = 24;
            this.dgvItemListArchive.Size = new System.Drawing.Size(941, 413);
            this.dgvItemListArchive.TabIndex = 18;
            this.dgvItemListArchive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemListArchive_CellContentClick);
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "No";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            this.ItemID.Width = 125;
            // 
            // InventoryCode
            // 
            this.InventoryCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InventoryCode.HeaderText = "Inventory Code";
            this.InventoryCode.MinimumWidth = 6;
            this.InventoryCode.Name = "InventoryCode";
            this.InventoryCode.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 104;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // AcquiredCost
            // 
            this.AcquiredCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AcquiredCost.HeaderText = "Acquired Cost";
            this.AcquiredCost.MinimumWidth = 6;
            this.AcquiredCost.Name = "AcquiredCost";
            this.AcquiredCost.ReadOnly = true;
            this.AcquiredCost.Width = 131;
            // 
            // bid
            // 
            this.bid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bid.HeaderText = "Brand";
            this.bid.MinimumWidth = 6;
            this.bid.Name = "bid";
            this.bid.ReadOnly = true;
            this.bid.Width = 75;
            // 
            // cid
            // 
            this.cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cid.HeaderText = "Category";
            this.cid.MinimumWidth = 6;
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            this.cid.Width = 97;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "SRP";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 65;
            // 
            // ReOrder
            // 
            this.ReOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReOrder.HeaderText = "Re-Order";
            this.ReOrder.MinimumWidth = 6;
            this.ReOrder.Name = "ReOrder";
            this.ReOrder.ReadOnly = true;
            this.ReOrder.Width = 98;
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
            this.Delete.Width = 6;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::JCUBE_SE_PROJECT.Properties.Resources.local_data_icon;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // ItemListArchives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.dgvItemListArchive);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.side2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemListArchives";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item List Archives";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemListArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ItemListArchivesLabel;
        private System.Windows.Forms.Panel side2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvItemListArchive;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button PrintItemListArchives;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquiredCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReOrder;
        private System.Windows.Forms.DataGridViewImageColumn Restore;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}