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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartUI));
            this.searchProdLabel = new System.Windows.Forms.Label();
            this.transactionNoLabel = new System.Windows.Forms.Label();
            this.salesTotalLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.vatableLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.addDiscountLabel = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.newTransactionLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.clrCartLabel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDisplayTotal = new System.Windows.Forms.Label();
            this.DateTodayVal = new System.Windows.Forms.Label();
            this.vatableVal = new System.Windows.Forms.Label();
            this.vatVal = new System.Windows.Forms.Label();
            this.discountVal = new System.Windows.Forms.Label();
            this.SalesTotalVal = new System.Windows.Forms.Label();
            this.TransNoVal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddQty = new System.Windows.Forms.DataGridViewImageColumn();
            this.RemQty = new System.Windows.Forms.DataGridViewImageColumn();
            this.CancelOrder = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchProdLabel
            // 
            this.searchProdLabel.AutoSize = true;
            this.searchProdLabel.BackColor = System.Drawing.Color.White;
            this.searchProdLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProdLabel.Location = new System.Drawing.Point(11, 87);
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
            this.addDiscountLabel.Location = new System.Drawing.Point(355, 87);
            this.addDiscountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addDiscountLabel.Name = "addDiscountLabel";
            this.addDiscountLabel.Size = new System.Drawing.Size(151, 23);
            this.addDiscountLabel.TabIndex = 5;
            this.addDiscountLabel.Text = "Add Discount:";
            this.addDiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeight = 30;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.InventoryCode,
            this.Description,
            this.srp,
            this.Quantity,
            this.Discount,
            this.Total,
            this.AddQty,
            this.RemQty,
            this.CancelOrder});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.GridColor = System.Drawing.Color.Snow;
            this.dgvCart.Location = new System.Drawing.Point(19, 123);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(893, 293);
            this.dgvCart.TabIndex = 1;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            this.dgvCart.SelectionChanged += new System.EventHandler(this.dgvCart_SelectionChanged);
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
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.clrCartLabel);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnDiscount);
            this.panel2.Controls.Add(this.newTransactionLabel);
            this.panel2.Controls.Add(this.searchProdLabel);
            this.panel2.Controls.Add(this.addDiscountLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(19, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 123);
            this.panel2.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Enabled = false;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_clear_shopping_cart_30;
            this.btnClear.Location = new System.Drawing.Point(825, 81);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(34, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // clrCartLabel
            // 
            this.clrCartLabel.BackColor = System.Drawing.Color.White;
            this.clrCartLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrCartLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clrCartLabel.Location = new System.Drawing.Point(699, 87);
            this.clrCartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clrCartLabel.Name = "clrCartLabel";
            this.clrCartLabel.Size = new System.Drawing.Size(119, 23);
            this.clrCartLabel.TabIndex = 9;
            this.clrCartLabel.Text = "Clear Cart:";
            this.clrCartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_search_50__1_;
            this.btnSearch.Location = new System.Drawing.Point(184, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiscount.Enabled = false;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_discount_642;
            this.btnDiscount.Location = new System.Drawing.Point(506, 81);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(34, 35);
            this.btnDiscount.TabIndex = 7;
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 416);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbDisplayTotal);
            this.panel3.Controls.Add(this.DateTodayVal);
            this.panel3.Controls.Add(this.vatableVal);
            this.panel3.Controls.Add(this.vatVal);
            this.panel3.Controls.Add(this.discountVal);
            this.panel3.Controls.Add(this.SalesTotalVal);
            this.panel3.Controls.Add(this.TransNoVal);
            this.panel3.Controls.Add(this.transactionNoLabel);
            this.panel3.Controls.Add(this.dateLabel);
            this.panel3.Controls.Add(this.vatableLabel);
            this.panel3.Controls.Add(this.salesTotalLabel);
            this.panel3.Controls.Add(this.discountLabel);
            this.panel3.Controls.Add(this.vatLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 416);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 127);
            this.panel3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(445, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 44);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total:";
            // 
            // lbDisplayTotal
            // 
            this.lbDisplayTotal.AutoSize = true;
            this.lbDisplayTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbDisplayTotal.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.lbDisplayTotal.Location = new System.Drawing.Point(565, 41);
            this.lbDisplayTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDisplayTotal.Name = "lbDisplayTotal";
            this.lbDisplayTotal.Size = new System.Drawing.Size(113, 44);
            this.lbDisplayTotal.TabIndex = 20;
            this.lbDisplayTotal.Text = "00.00";
            // 
            // DateTodayVal
            // 
            this.DateTodayVal.AutoSize = true;
            this.DateTodayVal.BackColor = System.Drawing.Color.White;
            this.DateTodayVal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTodayVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.DateTodayVal.Location = new System.Drawing.Point(580, 4);
            this.DateTodayVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateTodayVal.Name = "DateTodayVal";
            this.DateTodayVal.Size = new System.Drawing.Size(76, 22);
            this.DateTodayVal.TabIndex = 19;
            this.DateTodayVal.Text = "000000";
            // 
            // vatableVal
            // 
            this.vatableVal.AutoSize = true;
            this.vatableVal.BackColor = System.Drawing.Color.White;
            this.vatableVal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatableVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.vatableVal.Location = new System.Drawing.Point(126, 100);
            this.vatableVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vatableVal.Name = "vatableVal";
            this.vatableVal.Size = new System.Drawing.Size(45, 20);
            this.vatableVal.TabIndex = 18;
            this.vatableVal.Text = "00.00";
            // 
            // vatVal
            // 
            this.vatVal.AutoSize = true;
            this.vatVal.BackColor = System.Drawing.Color.White;
            this.vatVal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.vatVal.Location = new System.Drawing.Point(126, 80);
            this.vatVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vatVal.Name = "vatVal";
            this.vatVal.Size = new System.Drawing.Size(45, 20);
            this.vatVal.TabIndex = 17;
            this.vatVal.Text = "00.00";
            // 
            // discountVal
            // 
            this.discountVal.AutoSize = true;
            this.discountVal.BackColor = System.Drawing.Color.White;
            this.discountVal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.discountVal.Location = new System.Drawing.Point(126, 60);
            this.discountVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountVal.Name = "discountVal";
            this.discountVal.Size = new System.Drawing.Size(45, 20);
            this.discountVal.TabIndex = 16;
            this.discountVal.Text = "00.00";
            // 
            // SalesTotalVal
            // 
            this.SalesTotalVal.AutoSize = true;
            this.SalesTotalVal.BackColor = System.Drawing.Color.White;
            this.SalesTotalVal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTotalVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.SalesTotalVal.Location = new System.Drawing.Point(126, 41);
            this.SalesTotalVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesTotalVal.Name = "SalesTotalVal";
            this.SalesTotalVal.Size = new System.Drawing.Size(45, 20);
            this.SalesTotalVal.TabIndex = 15;
            this.SalesTotalVal.Text = "00.00";
            // 
            // TransNoVal
            // 
            this.TransNoVal.AutoSize = true;
            this.TransNoVal.BackColor = System.Drawing.Color.White;
            this.TransNoVal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransNoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.TransNoVal.Location = new System.Drawing.Point(179, 4);
            this.TransNoVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransNoVal.Name = "TransNoVal";
            this.TransNoVal.Size = new System.Drawing.Size(76, 22);
            this.TransNoVal.TabIndex = 14;
            this.TransNoVal.Text = "000000";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(891, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 293);
            this.panel4.TabIndex = 18;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle2;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 55;
            this.No.Name = "No";
            this.No.Width = 55;
            // 
            // InventoryCode
            // 
            this.InventoryCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryCode.HeaderText = "Inventory Code";
            this.InventoryCode.MinimumWidth = 150;
            this.InventoryCode.Name = "InventoryCode";
            this.InventoryCode.Width = 150;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 260;
            this.Description.Name = "Description";
            // 
            // srp
            // 
            this.srp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.srp.HeaderText = "Unit Price";
            this.srp.MinimumWidth = 100;
            this.srp.Name = "srp";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.HeaderText = "Qty";
            this.Quantity.MinimumWidth = 40;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 61;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 75;
            this.Discount.Name = "Discount";
            this.Discount.Width = 95;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 100;
            this.Total.Name = "Total";
            // 
            // AddQty
            // 
            this.AddQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddQty.HeaderText = "";
            this.AddQty.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_plus_20;
            this.AddQty.MinimumWidth = 20;
            this.AddQty.Name = "AddQty";
            this.AddQty.Width = 20;
            // 
            // RemQty
            // 
            this.RemQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RemQty.HeaderText = "";
            this.RemQty.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_minus_20;
            this.RemQty.MinimumWidth = 20;
            this.RemQty.Name = "RemQty";
            this.RemQty.Width = 20;
            // 
            // CancelOrder
            // 
            this.CancelOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.CancelOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.CancelOrder.HeaderText = "";
            this.CancelOrder.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_cancel_20;
            this.CancelOrder.MinimumWidth = 20;
            this.CancelOrder.Name = "CancelOrder";
            // 
            // CartUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 543);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CartUI";
            this.Text = "Jcube Point of Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label searchProdLabel;
        private System.Windows.Forms.Label addDiscountLabel;
        private System.Windows.Forms.Label transactionNoLabel;
        private System.Windows.Forms.Label salesTotalLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label vatableLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label newTransactionLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Label vatableVal;
        private System.Windows.Forms.Label vatVal;
        private System.Windows.Forms.Label discountVal;
        private System.Windows.Forms.Label DateTodayVal;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Label TransNoVal;
        public System.Windows.Forms.DataGridView dgvCart;
        public System.Windows.Forms.Label SalesTotalVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDisplayTotal;
        private System.Windows.Forms.Label clrCartLabel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn srp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn AddQty;
        private System.Windows.Forms.DataGridViewImageColumn RemQty;
        private System.Windows.Forms.DataGridViewImageColumn CancelOrder;
    }
}