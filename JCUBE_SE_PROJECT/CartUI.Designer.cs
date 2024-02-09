namespace JCUBE_SE_PROJECT
{
    partial class CartUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemCodeLabel = new System.Windows.Forms.Label();
            this.searchProdLabel = new System.Windows.Forms.Label();
            this.transactionNoLabel = new System.Windows.Forms.Label();
            this.salesTotalLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.vatableLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.addDiscountLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newTransactionLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.searchProdTB = new MetroFramework.Controls.MetroTextBox();
            this.itemCodeTB = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemCodeLabel
            // 
            this.itemCodeLabel.AutoSize = true;
            this.itemCodeLabel.BackColor = System.Drawing.Color.White;
            this.itemCodeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCodeLabel.Location = new System.Drawing.Point(8, 87);
            this.itemCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemCodeLabel.Name = "itemCodeLabel";
            this.itemCodeLabel.Size = new System.Drawing.Size(121, 23);
            this.itemCodeLabel.TabIndex = 1;
            this.itemCodeLabel.Text = "Item Code:";
            // 
            // searchProdLabel
            // 
            this.searchProdLabel.AutoSize = true;
            this.searchProdLabel.BackColor = System.Drawing.Color.White;
            this.searchProdLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProdLabel.Location = new System.Drawing.Point(319, 87);
            this.searchProdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchProdLabel.Name = "searchProdLabel";
            this.searchProdLabel.Size = new System.Drawing.Size(166, 23);
            this.searchProdLabel.TabIndex = 3;
            this.searchProdLabel.Text = "Search Product:";
            // 
            // transactionNoLabel
            // 
            this.transactionNoLabel.AutoSize = true;
            this.transactionNoLabel.BackColor = System.Drawing.Color.White;
            this.transactionNoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.transactionNoLabel.Location = new System.Drawing.Point(20, 4);
            this.transactionNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transactionNoLabel.Name = "transactionNoLabel";
            this.transactionNoLabel.Size = new System.Drawing.Size(151, 22);
            this.transactionNoLabel.TabIndex = 8;
            this.transactionNoLabel.Text = "Transaction No:";
            // 
            // salesTotalLabel
            // 
            this.salesTotalLabel.AutoSize = true;
            this.salesTotalLabel.BackColor = System.Drawing.Color.White;
            this.salesTotalLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.salesTotalLabel.Location = new System.Drawing.Point(20, 41);
            this.salesTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salesTotalLabel.Name = "salesTotalLabel";
            this.salesTotalLabel.Size = new System.Drawing.Size(83, 19);
            this.salesTotalLabel.TabIndex = 9;
            this.salesTotalLabel.Text = "Sales Total:";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.BackColor = System.Drawing.Color.White;
            this.discountLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.discountLabel.Location = new System.Drawing.Point(20, 60);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(72, 19);
            this.discountLabel.TabIndex = 10;
            this.discountLabel.Text = "Discount:";
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.BackColor = System.Drawing.Color.White;
            this.vatLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.vatLabel.Location = new System.Drawing.Point(20, 79);
            this.vatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(36, 19);
            this.vatLabel.TabIndex = 11;
            this.vatLabel.Text = "VAT:";
            // 
            // vatableLabel
            // 
            this.vatableLabel.AutoSize = true;
            this.vatableLabel.BackColor = System.Drawing.Color.White;
            this.vatableLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.vatableLabel.Location = new System.Drawing.Point(20, 98);
            this.vatableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vatableLabel.Name = "vatableLabel";
            this.vatableLabel.Size = new System.Drawing.Size(68, 19);
            this.vatableLabel.TabIndex = 12;
            this.vatableLabel.Text = "VATable:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.White;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.dateLabel.Location = new System.Drawing.Point(449, 4);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(123, 22);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Date Today:";
            // 
            // addDiscountLabel
            // 
            this.addDiscountLabel.BackColor = System.Drawing.Color.White;
            this.addDiscountLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiscountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addDiscountLabel.Location = new System.Drawing.Point(681, 87);
            this.addDiscountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addDiscountLabel.Name = "addDiscountLabel";
            this.addDiscountLabel.Size = new System.Drawing.Size(142, 23);
            this.addDiscountLabel.TabIndex = 5;
            this.addDiscountLabel.Text = "Add Discount";
            this.addDiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.InventoryCode,
            this.Description,
            this.Price,
            this.Quantity,
            this.Discount,
            this.Total});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Snow;
            this.dataGridView1.Location = new System.Drawing.Point(19, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 304);
            this.dataGridView1.TabIndex = 1;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 55;
            // 
            // InventoryCode
            // 
            this.InventoryCode.HeaderText = "Inventory Code";
            this.InventoryCode.MinimumWidth = 6;
            this.InventoryCode.Name = "InventoryCode";
            this.InventoryCode.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.Width = 125;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // newTransactionLabel
            // 
            this.newTransactionLabel.AutoSize = true;
            this.newTransactionLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTransactionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(46)))), ((int)(((byte)(73)))));
            this.newTransactionLabel.Location = new System.Drawing.Point(8, 9);
            this.newTransactionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newTransactionLabel.Name = "newTransactionLabel";
            this.newTransactionLabel.Size = new System.Drawing.Size(333, 40);
            this.newTransactionLabel.TabIndex = 0;
            this.newTransactionLabel.Text = "NEW TRANSACTION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDiscount);
            this.panel2.Controls.Add(this.newTransactionLabel);
            this.panel2.Controls.Add(this.itemCodeLabel);
            this.panel2.Controls.Add(this.searchProdLabel);
            this.panel2.Controls.Add(this.addDiscountLabel);
            this.panel2.Controls.Add(this.searchProdTB);
            this.panel2.Controls.Add(this.itemCodeTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(19, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 123);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 427);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.transactionNoLabel);
            this.panel3.Controls.Add(this.dateLabel);
            this.panel3.Controls.Add(this.vatableLabel);
            this.panel3.Controls.Add(this.salesTotalLabel);
            this.panel3.Controls.Add(this.discountLabel);
            this.panel3.Controls.Add(this.vatLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 427);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 127);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1046, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 304);
            this.panel4.TabIndex = 18;
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_discount_642;
            this.btnDiscount.Location = new System.Drawing.Point(819, 84);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(34, 35);
            this.btnDiscount.TabIndex = 7;
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // searchProdTB
            // 
            // 
            // 
            // 
            this.searchProdTB.CustomButton.Image = null;
            this.searchProdTB.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.searchProdTB.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchProdTB.CustomButton.Name = "";
            this.searchProdTB.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.searchProdTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchProdTB.CustomButton.TabIndex = 1;
            this.searchProdTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchProdTB.CustomButton.UseSelectable = true;
            this.searchProdTB.CustomButton.Visible = false;
            this.searchProdTB.DisplayIcon = true;
            this.searchProdTB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchProdTB.Icon = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_search_50__1_;
            this.searchProdTB.IconRight = true;
            this.searchProdTB.Lines = new string[0];
            this.searchProdTB.Location = new System.Drawing.Point(493, 86);
            this.searchProdTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchProdTB.MaxLength = 32767;
            this.searchProdTB.Name = "searchProdTB";
            this.searchProdTB.PasswordChar = '\0';
            this.searchProdTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchProdTB.SelectedText = "";
            this.searchProdTB.SelectionLength = 0;
            this.searchProdTB.SelectionStart = 0;
            this.searchProdTB.ShortcutsEnabled = true;
            this.searchProdTB.Size = new System.Drawing.Size(180, 28);
            this.searchProdTB.TabIndex = 4;
            this.searchProdTB.UseSelectable = true;
            this.searchProdTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchProdTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // itemCodeTB
            // 
            // 
            // 
            // 
            this.itemCodeTB.CustomButton.Image = null;
            this.itemCodeTB.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.itemCodeTB.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.itemCodeTB.CustomButton.Name = "";
            this.itemCodeTB.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.itemCodeTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.itemCodeTB.CustomButton.TabIndex = 1;
            this.itemCodeTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.itemCodeTB.CustomButton.UseSelectable = true;
            this.itemCodeTB.CustomButton.Visible = false;
            this.itemCodeTB.DisplayIcon = true;
            this.itemCodeTB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.itemCodeTB.Icon = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_search_50__1_;
            this.itemCodeTB.IconRight = true;
            this.itemCodeTB.Lines = new string[0];
            this.itemCodeTB.Location = new System.Drawing.Point(131, 86);
            this.itemCodeTB.Margin = new System.Windows.Forms.Padding(4);
            this.itemCodeTB.MaxLength = 32767;
            this.itemCodeTB.Name = "itemCodeTB";
            this.itemCodeTB.PasswordChar = '\0';
            this.itemCodeTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemCodeTB.SelectedText = "";
            this.itemCodeTB.SelectionLength = 0;
            this.itemCodeTB.SelectionStart = 0;
            this.itemCodeTB.ShortcutsEnabled = true;
            this.itemCodeTB.Size = new System.Drawing.Size(180, 28);
            this.itemCodeTB.TabIndex = 2;
            this.itemCodeTB.UseSelectable = true;
            this.itemCodeTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.itemCodeTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CartUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CartUI";
            this.Text = "Jcube Point of Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label itemCodeLabel;
        private MetroFramework.Controls.MetroTextBox itemCodeTB;
        private System.Windows.Forms.Label searchProdLabel;
        private MetroFramework.Controls.MetroTextBox searchProdTB;
        private System.Windows.Forms.Label addDiscountLabel;
        private System.Windows.Forms.Label transactionNoLabel;
        private System.Windows.Forms.Label salesTotalLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label vatableLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label newTransactionLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDiscount;
    }
}