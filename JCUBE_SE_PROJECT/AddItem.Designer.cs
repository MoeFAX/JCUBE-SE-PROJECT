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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.AddItemlbl = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorderField)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.AddItemlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 50);
            this.panel1.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(738, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(26, 28);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddItemlbl
            // 
            this.AddItemlbl.AutoSize = true;
            this.AddItemlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemlbl.Location = new System.Drawing.Point(12, 18);
            this.AddItemlbl.Name = "AddItemlbl";
            this.AddItemlbl.Size = new System.Drawing.Size(134, 23);
            this.AddItemlbl.TabIndex = 1;
            this.AddItemlbl.Text = "Item Module";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(400, 312);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 30);
            this.CancelBtn.TabIndex = 31;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(283, 312);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 30);
            this.SaveBtn.TabIndex = 30;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Categorylbl
            // 
            this.Categorylbl.AutoSize = true;
            this.Categorylbl.Location = new System.Drawing.Point(406, 186);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(101, 21);
            this.Categorylbl.TabIndex = 29;
            this.Categorylbl.Text = "Category:";
            // 
            // Brandlbl
            // 
            this.Brandlbl.AutoSize = true;
            this.Brandlbl.Location = new System.Drawing.Point(31, 188);
            this.Brandlbl.Name = "Brandlbl";
            this.Brandlbl.Size = new System.Drawing.Size(124, 21);
            this.Brandlbl.TabIndex = 28;
            this.Brandlbl.Text = "Brand Name:";
            // 
            // Desclbl
            // 
            this.Desclbl.AutoSize = true;
            this.Desclbl.Location = new System.Drawing.Point(32, 140);
            this.Desclbl.Name = "Desclbl";
            this.Desclbl.Size = new System.Drawing.Size(112, 21);
            this.Desclbl.TabIndex = 27;
            this.Desclbl.Text = "Description:";
            // 
            // ItemCodeField
            // 
            this.ItemCodeField.Location = new System.Drawing.Point(524, 85);
            this.ItemCodeField.Name = "ItemCodeField";
            this.ItemCodeField.Size = new System.Drawing.Size(203, 30);
            this.ItemCodeField.TabIndex = 21;
            // 
            // ItemCodelbl
            // 
            this.ItemCodelbl.AutoSize = true;
            this.ItemCodelbl.Location = new System.Drawing.Point(406, 88);
            this.ItemCodelbl.Name = "ItemCodelbl";
            this.ItemCodelbl.Size = new System.Drawing.Size(112, 21);
            this.ItemCodelbl.TabIndex = 26;
            this.ItemCodelbl.Text = "Item Code:";
            // 
            // InvCodeField
            // 
            this.InvCodeField.Enabled = false;
            this.InvCodeField.Location = new System.Drawing.Point(194, 85);
            this.InvCodeField.Name = "InvCodeField";
            this.InvCodeField.ReadOnly = true;
            this.InvCodeField.Size = new System.Drawing.Size(166, 30);
            this.InvCodeField.TabIndex = 20;
            // 
            // InventoryCodelbl
            // 
            this.InventoryCodelbl.AutoSize = true;
            this.InventoryCodelbl.Location = new System.Drawing.Point(32, 88);
            this.InventoryCodelbl.Name = "InventoryCodelbl";
            this.InventoryCodelbl.Size = new System.Drawing.Size(156, 21);
            this.InventoryCodelbl.TabIndex = 25;
            this.InventoryCodelbl.Text = "Inventory Code:";
            // 
            // BrandField
            // 
            this.BrandField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandField.FormattingEnabled = true;
            this.BrandField.Location = new System.Drawing.Point(194, 180);
            this.BrandField.Name = "BrandField";
            this.BrandField.Size = new System.Drawing.Size(166, 29);
            this.BrandField.TabIndex = 32;
            // 
            // CategoryField
            // 
            this.CategoryField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryField.FormattingEnabled = true;
            this.CategoryField.Location = new System.Drawing.Point(524, 183);
            this.CategoryField.Name = "CategoryField";
            this.CategoryField.Size = new System.Drawing.Size(203, 29);
            this.CategoryField.TabIndex = 33;
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Location = new System.Drawing.Point(406, 237);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(46, 21);
            this.Pricelbl.TabIndex = 34;
            this.Pricelbl.Text = "SRP:";
            // 
            // PriceField
            // 
            this.PriceField.Location = new System.Drawing.Point(458, 234);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(91, 30);
            this.PriceField.TabIndex = 35;
            // 
            // reorderlbl
            // 
            this.reorderlbl.AutoSize = true;
            this.reorderlbl.Location = new System.Drawing.Point(555, 237);
            this.reorderlbl.Name = "reorderlbl";
            this.reorderlbl.Size = new System.Drawing.Size(94, 21);
            this.reorderlbl.TabIndex = 36;
            this.reorderlbl.Text = "Re-Order:";
            // 
            // reorderField
            // 
            this.reorderField.Location = new System.Drawing.Point(655, 234);
            this.reorderField.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.reorderField.Name = "reorderField";
            this.reorderField.Size = new System.Drawing.Size(72, 30);
            this.reorderField.TabIndex = 37;
            this.reorderField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AcquiredCostField
            // 
            this.AcquiredCostField.Location = new System.Drawing.Point(194, 234);
            this.AcquiredCostField.Name = "AcquiredCostField";
            this.AcquiredCostField.Size = new System.Drawing.Size(166, 30);
            this.AcquiredCostField.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Acquisition Cost:";
            // 
            // DescriptionField
            // 
            this.DescriptionField.Location = new System.Drawing.Point(194, 137);
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.Size = new System.Drawing.Size(533, 30);
            this.DescriptionField.TabIndex = 40;
            // 
            // AddItem
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(773, 385);
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
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorderField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label AddItemlbl;
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