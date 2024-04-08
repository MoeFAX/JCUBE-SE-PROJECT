namespace JCUBE_SE_PROJECT
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Categorylbl = new System.Windows.Forms.Label();
            this.Brandlbl = new System.Windows.Forms.Label();
            this.Desclbl = new System.Windows.Forms.Label();
            this.ItemCodeField = new System.Windows.Forms.TextBox();
            this.ItemCodelbl = new System.Windows.Forms.Label();
            this.InvCodeField = new System.Windows.Forms.TextBox();
            this.InventoryCodelbl = new System.Windows.Forms.Label();
            this.BrandField = new System.Windows.Forms.ComboBox();
            this.CategoryField = new System.Windows.Forms.ComboBox();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.reorderlbl = new System.Windows.Forms.Label();
            this.reorderField = new System.Windows.Forms.NumericUpDown();
            this.AcquiredCostField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reorderField)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(404, 267);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 35);
            this.CancelBtn.TabIndex = 31;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(155)))), ((int)(((byte)(97)))));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(287, 267);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 35);
            this.SaveBtn.TabIndex = 30;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Categorylbl
            // 
            this.Categorylbl.AutoSize = true;
            this.Categorylbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylbl.Location = new System.Drawing.Point(410, 141);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(92, 27);
            this.Categorylbl.TabIndex = 29;
            this.Categorylbl.Text = "Category:";
            // 
            // Brandlbl
            // 
            this.Brandlbl.AutoSize = true;
            this.Brandlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brandlbl.Location = new System.Drawing.Point(35, 143);
            this.Brandlbl.Name = "Brandlbl";
            this.Brandlbl.Size = new System.Drawing.Size(124, 27);
            this.Brandlbl.TabIndex = 28;
            this.Brandlbl.Text = "Brand Name:";
            // 
            // Desclbl
            // 
            this.Desclbl.AutoSize = true;
            this.Desclbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desclbl.Location = new System.Drawing.Point(36, 95);
            this.Desclbl.Name = "Desclbl";
            this.Desclbl.Size = new System.Drawing.Size(114, 27);
            this.Desclbl.TabIndex = 27;
            this.Desclbl.Text = "Description:";
            // 
            // ItemCodeField
            // 
            this.ItemCodeField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCodeField.Location = new System.Drawing.Point(528, 38);
            this.ItemCodeField.Name = "ItemCodeField";
            this.ItemCodeField.Size = new System.Drawing.Size(203, 32);
            this.ItemCodeField.TabIndex = 21;
            // 
            // ItemCodelbl
            // 
            this.ItemCodelbl.AutoSize = true;
            this.ItemCodelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCodelbl.Location = new System.Drawing.Point(410, 43);
            this.ItemCodelbl.Name = "ItemCodelbl";
            this.ItemCodelbl.Size = new System.Drawing.Size(104, 27);
            this.ItemCodelbl.TabIndex = 26;
            this.ItemCodelbl.Text = "Item Code:";
            // 
            // InvCodeField
            // 
            this.InvCodeField.Enabled = false;
            this.InvCodeField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvCodeField.Location = new System.Drawing.Point(198, 40);
            this.InvCodeField.Name = "InvCodeField";
            this.InvCodeField.ReadOnly = true;
            this.InvCodeField.Size = new System.Drawing.Size(166, 32);
            this.InvCodeField.TabIndex = 20;
            // 
            // InventoryCodelbl
            // 
            this.InventoryCodelbl.AutoSize = true;
            this.InventoryCodelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryCodelbl.Location = new System.Drawing.Point(36, 43);
            this.InventoryCodelbl.Name = "InventoryCodelbl";
            this.InventoryCodelbl.Size = new System.Drawing.Size(145, 27);
            this.InventoryCodelbl.TabIndex = 25;
            this.InventoryCodelbl.Text = "Inventory Code:";
            // 
            // BrandField
            // 
            this.BrandField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandField.FormattingEnabled = true;
            this.BrandField.Location = new System.Drawing.Point(198, 135);
            this.BrandField.Name = "BrandField";
            this.BrandField.Size = new System.Drawing.Size(166, 35);
            this.BrandField.TabIndex = 32;
            // 
            // CategoryField
            // 
            this.CategoryField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryField.FormattingEnabled = true;
            this.CategoryField.Location = new System.Drawing.Point(528, 138);
            this.CategoryField.Name = "CategoryField";
            this.CategoryField.Size = new System.Drawing.Size(203, 35);
            this.CategoryField.TabIndex = 33;
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelbl.Location = new System.Drawing.Point(410, 192);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(49, 27);
            this.Pricelbl.TabIndex = 34;
            this.Pricelbl.Text = "SRP:";
            // 
            // PriceField
            // 
            this.PriceField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceField.Location = new System.Drawing.Point(462, 189);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(91, 32);
            this.PriceField.TabIndex = 35;
            // 
            // reorderlbl
            // 
            this.reorderlbl.AutoSize = true;
            this.reorderlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderlbl.Location = new System.Drawing.Point(559, 192);
            this.reorderlbl.Name = "reorderlbl";
            this.reorderlbl.Size = new System.Drawing.Size(93, 27);
            this.reorderlbl.TabIndex = 36;
            this.reorderlbl.Text = "Re-Order:";
            // 
            // reorderField
            // 
            this.reorderField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderField.Location = new System.Drawing.Point(659, 189);
            this.reorderField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.reorderField.Name = "reorderField";
            this.reorderField.Size = new System.Drawing.Size(72, 32);
            this.reorderField.TabIndex = 37;
            this.reorderField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AcquiredCostField
            // 
            this.AcquiredCostField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcquiredCostField.Location = new System.Drawing.Point(198, 189);
            this.AcquiredCostField.Name = "AcquiredCostField";
            this.AcquiredCostField.Size = new System.Drawing.Size(166, 32);
            this.AcquiredCostField.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "Acquisition Cost:";
            // 
            // DescriptionField
            // 
            this.DescriptionField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionField.Location = new System.Drawing.Point(198, 92);
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.Size = new System.Drawing.Size(533, 32);
            this.DescriptionField.TabIndex = 40;
            // 
            // AddItem
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(773, 317);
            this.Controls.Add(this.DescriptionField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcquiredCostField);
            this.Controls.Add(this.reorderField);
            this.Controls.Add(this.reorderlbl);
            this.Controls.Add(this.PriceField);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.CategoryField);
            this.Controls.Add(this.BrandField);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Categorylbl);
            this.Controls.Add(this.Brandlbl);
            this.Controls.Add(this.Desclbl);
            this.Controls.Add(this.ItemCodeField);
            this.Controls.Add(this.ItemCodelbl);
            this.Controls.Add(this.InvCodeField);
            this.Controls.Add(this.InventoryCodelbl);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Module";
            ((System.ComponentModel.ISupportInitialize)(this.reorderField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.Label Brandlbl;
        private System.Windows.Forms.Label Desclbl;
        private System.Windows.Forms.Label ItemCodelbl;
        private System.Windows.Forms.Label InventoryCodelbl;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.Label reorderlbl;
        public System.Windows.Forms.Button CancelBtn;
        public System.Windows.Forms.Button SaveBtn;
        public System.Windows.Forms.TextBox ItemCodeField;
        public System.Windows.Forms.TextBox InvCodeField;
        public System.Windows.Forms.ComboBox BrandField;
        public System.Windows.Forms.ComboBox CategoryField;
        public System.Windows.Forms.TextBox PriceField;
        public System.Windows.Forms.NumericUpDown reorderField;
        public System.Windows.Forms.TextBox AcquiredCostField;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox DescriptionField;
    }
}