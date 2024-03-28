namespace JCUBE_SE_PROJECT
{
    partial class ItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addbtn = new System.Windows.Forms.Button();
            this.MngItemLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemListLabel = new System.Windows.Forms.Label();
            this.side2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcquiredCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Archive = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.MngItemLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 100);
            this.panel1.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Image = ((System.Drawing.Image)(resources.GetObject("addbtn.Image")));
            this.addbtn.Location = new System.Drawing.Point(865, 33);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(31, 31);
            this.addbtn.TabIndex = 1;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // MngItemLabel
            // 
            this.MngItemLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngItemLabel.Image = ((System.Drawing.Image)(resources.GetObject("MngItemLabel.Image")));
            this.MngItemLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MngItemLabel.Location = new System.Drawing.Point(23, 14);
            this.MngItemLabel.Name = "MngItemLabel";
            this.MngItemLabel.Size = new System.Drawing.Size(213, 67);
            this.MngItemLabel.TabIndex = 0;
            this.MngItemLabel.Text = "Manage Items";
            this.MngItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ItemListLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 70);
            this.panel2.TabIndex = 2;
            // 
            // ItemListLabel
            // 
            this.ItemListLabel.AutoSize = true;
            this.ItemListLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.ItemListLabel.Location = new System.Drawing.Point(22, 22);
            this.ItemListLabel.Name = "ItemListLabel";
            this.ItemListLabel.Size = new System.Drawing.Size(101, 27);
            this.ItemListLabel.TabIndex = 0;
            this.ItemListLabel.Text = "Item List";
            // 
            // side2
            // 
            this.side2.Dock = System.Windows.Forms.DockStyle.Right;
            this.side2.Location = new System.Drawing.Point(962, 70);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(20, 383);
            this.side2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 383);
            this.panel3.TabIndex = 5;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItem.ColumnHeadersHeight = 46;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.InventoryCode,
            this.ItemCode,
            this.Description,
            this.AcquiredCost,
            this.bid,
            this.cid,
            this.Price,
            this.ReOrder,
            this.Edit,
            this.Archive});
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.GridColor = System.Drawing.Color.Snow;
            this.dgvItem.Location = new System.Drawing.Point(20, 70);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.RowHeadersWidth = 51;
            this.dgvItem.RowTemplate.Height = 24;
            this.dgvItem.Size = new System.Drawing.Size(942, 383);
            this.dgvItem.TabIndex = 6;
            this.dgvItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellContentClick);
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "No";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 62;
            // 
            // InventoryCode
            // 
            this.InventoryCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryCode.HeaderText = "Inventory Code";
            this.InventoryCode.MinimumWidth = 6;
            this.InventoryCode.Name = "InventoryCode";
            this.InventoryCode.Width = 162;
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.MinimumWidth = 6;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Width = 123;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 134;
            // 
            // AcquiredCost
            // 
            this.AcquiredCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AcquiredCost.HeaderText = "Acquired Cost";
            this.AcquiredCost.MinimumWidth = 6;
            this.AcquiredCost.Name = "AcquiredCost";
            this.AcquiredCost.Width = 151;
            // 
            // bid
            // 
            this.bid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bid.HeaderText = "Brand";
            this.bid.MinimumWidth = 6;
            this.bid.Name = "bid";
            this.bid.Width = 87;
            // 
            // cid
            // 
            this.cid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cid.HeaderText = "Category";
            this.cid.MinimumWidth = 6;
            this.cid.Name = "cid";
            this.cid.Width = 123;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "SRP";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 68;
            // 
            // ReOrder
            // 
            this.ReOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReOrder.HeaderText = "Re-Order";
            this.ReOrder.MinimumWidth = 6;
            this.ReOrder.Name = "ReOrder";
            this.ReOrder.Width = 116;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Width = 6;
            // 
            // Archive
            // 
            this.Archive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Archive.HeaderText = "";
            this.Archive.Image = ((System.Drawing.Image)(resources.GetObject("Archive.Image")));
            this.Archive.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Archive.MinimumWidth = 6;
            this.Archive.Name = "Archive";
            this.Archive.Width = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSearch.Icon = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_search_50__1_;
            this.txtSearch.IconRight = true;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(450, 33);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(283, 31);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.side2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item List";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label MngItemLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ItemListLabel;
        private System.Windows.Forms.Panel side2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcquiredCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReOrder;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Archive;
        private MetroFramework.Controls.MetroTextBox txtSearch;
    }
}