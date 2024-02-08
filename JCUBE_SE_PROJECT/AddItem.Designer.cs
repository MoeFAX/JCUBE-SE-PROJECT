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
            this.DescField = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(727, 50);
            this.panel1.TabIndex = 2;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(693, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(26, 28);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            // 
            // AddItemlbl
            // 
            this.AddItemlbl.AutoSize = true;
            this.AddItemlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemlbl.Location = new System.Drawing.Point(12, 18);
            this.AddItemlbl.Name = "AddItemlbl";
            this.AddItemlbl.Size = new System.Drawing.Size(101, 23);
            this.AddItemlbl.TabIndex = 1;
            this.AddItemlbl.Text = "Add Item";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(371, 334);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 30);
            this.CancelBtn.TabIndex = 31;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(254, 334);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 30);
            this.SaveBtn.TabIndex = 30;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // Categorylbl
            // 
            this.Categorylbl.AutoSize = true;
            this.Categorylbl.Location = new System.Drawing.Point(67, 223);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(101, 21);
            this.Categorylbl.TabIndex = 29;
            this.Categorylbl.Text = "Category:";
            // 
            // Brandlbl
            // 
            this.Brandlbl.AutoSize = true;
            this.Brandlbl.Location = new System.Drawing.Point(103, 182);
            this.Brandlbl.Name = "Brandlbl";
            this.Brandlbl.Size = new System.Drawing.Size(65, 21);
            this.Brandlbl.TabIndex = 28;
            this.Brandlbl.Text = "Brand:";
            // 
            // DescField
            // 
            this.DescField.Location = new System.Drawing.Point(174, 136);
            this.DescField.Name = "DescField";
            this.DescField.Size = new System.Drawing.Size(459, 30);
            this.DescField.TabIndex = 22;
            // 
            // Desclbl
            // 
            this.Desclbl.AutoSize = true;
            this.Desclbl.Location = new System.Drawing.Point(56, 139);
            this.Desclbl.Name = "Desclbl";
            this.Desclbl.Size = new System.Drawing.Size(112, 21);
            this.Desclbl.TabIndex = 27;
            this.Desclbl.Text = "Description:";
            // 
            // ItemCodeField
            // 
            this.ItemCodeField.Location = new System.Drawing.Point(467, 84);
            this.ItemCodeField.Name = "ItemCodeField";
            this.ItemCodeField.Size = new System.Drawing.Size(166, 30);
            this.ItemCodeField.TabIndex = 21;
            // 
            // ItemCodelbl
            // 
            this.ItemCodelbl.AutoSize = true;
            this.ItemCodelbl.Location = new System.Drawing.Point(349, 87);
            this.ItemCodelbl.Name = "ItemCodelbl";
            this.ItemCodelbl.Size = new System.Drawing.Size(112, 21);
            this.ItemCodelbl.TabIndex = 26;
            this.ItemCodelbl.Text = "Item Code:";
            // 
            // InvCodeField
            // 
            this.InvCodeField.Location = new System.Drawing.Point(174, 84);
            this.InvCodeField.Name = "InvCodeField";
            this.InvCodeField.Size = new System.Drawing.Size(166, 30);
            this.InvCodeField.TabIndex = 20;
            // 
            // InventoryCodelbl
            // 
            this.InventoryCodelbl.AutoSize = true;
            this.InventoryCodelbl.Location = new System.Drawing.Point(12, 87);
            this.InventoryCodelbl.Name = "InventoryCodelbl";
            this.InventoryCodelbl.Size = new System.Drawing.Size(156, 21);
            this.InventoryCodelbl.TabIndex = 25;
            this.InventoryCodelbl.Text = "Inventory Code:";
            // 
            // BrandField
            // 
            this.BrandField.FormattingEnabled = true;
            this.BrandField.Location = new System.Drawing.Point(174, 179);
            this.BrandField.Name = "BrandField";
            this.BrandField.Size = new System.Drawing.Size(459, 29);
            this.BrandField.TabIndex = 32;
            // 
            // CategoryField
            // 
            this.CategoryField.FormattingEnabled = true;
            this.CategoryField.Location = new System.Drawing.Point(174, 223);
            this.CategoryField.Name = "CategoryField";
            this.CategoryField.Size = new System.Drawing.Size(459, 29);
            this.CategoryField.TabIndex = 33;
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Location = new System.Drawing.Point(110, 272);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(58, 21);
            this.Pricelbl.TabIndex = 34;
            this.Pricelbl.Text = "Price:";
            // 
            // PriceField
            // 
            this.PriceField.Location = new System.Drawing.Point(174, 272);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(166, 30);
            this.PriceField.TabIndex = 35;
            // 
            // reorderlbl
            // 
            this.reorderlbl.AutoSize = true;
            this.reorderlbl.Location = new System.Drawing.Point(367, 275);
            this.reorderlbl.Name = "reorderlbl";
            this.reorderlbl.Size = new System.Drawing.Size(94, 21);
            this.reorderlbl.TabIndex = 36;
            this.reorderlbl.Text = "Re-Order:";
            // 
            // reorderField
            // 
            this.reorderField.Location = new System.Drawing.Point(467, 273);
            this.reorderField.Name = "reorderField";
            this.reorderField.Size = new System.Drawing.Size(166, 30);
            this.reorderField.TabIndex = 37;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 385);
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
            this.Controls.Add(this.DescField);
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
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.Label Brandlbl;
        private System.Windows.Forms.TextBox DescField;
        private System.Windows.Forms.Label Desclbl;
        private System.Windows.Forms.TextBox ItemCodeField;
        private System.Windows.Forms.Label ItemCodelbl;
        private System.Windows.Forms.TextBox InvCodeField;
        private System.Windows.Forms.Label InventoryCodelbl;
        private System.Windows.Forms.ComboBox BrandField;
        private System.Windows.Forms.ComboBox CategoryField;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.Label reorderlbl;
        private System.Windows.Forms.NumericUpDown reorderField;
    }
}