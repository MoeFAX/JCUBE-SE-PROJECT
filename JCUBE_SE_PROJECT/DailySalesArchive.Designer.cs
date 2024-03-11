namespace JCUBE_SE_PROJECT
{
    partial class DailySalesArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySalesArchive));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DailySalesArchivesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MngItemLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.side2 = new System.Windows.Forms.Panel();
            this.dgvDailySalesArchive = new System.Windows.Forms.DataGridView();
            this.DSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySalesArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DailySalesArchivesLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 70);
            this.panel2.TabIndex = 4;
            // 
            // DailySalesArchivesLabel
            // 
            this.DailySalesArchivesLabel.AutoSize = true;
            this.DailySalesArchivesLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySalesArchivesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.DailySalesArchivesLabel.Location = new System.Drawing.Point(21, 22);
            this.DailySalesArchivesLabel.Name = "DailySalesArchivesLabel";
            this.DailySalesArchivesLabel.Size = new System.Drawing.Size(235, 27);
            this.DailySalesArchivesLabel.TabIndex = 0;
            this.DailySalesArchivesLabel.Text = "Daily Sales Archives";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MngItemLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 100);
            this.panel1.TabIndex = 5;
            // 
            // MngItemLabel
            // 
            this.MngItemLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngItemLabel.Image = ((System.Drawing.Image)(resources.GetObject("MngItemLabel.Image")));
            this.MngItemLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MngItemLabel.Location = new System.Drawing.Point(23, 14);
            this.MngItemLabel.Name = "MngItemLabel";
            this.MngItemLabel.Size = new System.Drawing.Size(266, 66);
            this.MngItemLabel.TabIndex = 0;
            this.MngItemLabel.Text = "Archived Daily Sales";
            this.MngItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 383);
            this.panel3.TabIndex = 7;
            // 
            // side2
            // 
            this.side2.Dock = System.Windows.Forms.DockStyle.Right;
            this.side2.Location = new System.Drawing.Point(961, 70);
            this.side2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(20, 383);
            this.side2.TabIndex = 8;
            // 
            // dgvDailySalesArchive
            // 
            this.dgvDailySalesArchive.AllowUserToAddRows = false;
            this.dgvDailySalesArchive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvDailySalesArchive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailySalesArchive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailySalesArchive.ColumnHeadersHeight = 46;
            this.dgvDailySalesArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDailySalesArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DSNo,
            this.DSInvoice,
            this.DSItemCode,
            this.DSDescription,
            this.DSPrice,
            this.DSQuantity,
            this.DSDiscount,
            this.DSTotal,
            this.Delete});
            this.dgvDailySalesArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDailySalesArchive.EnableHeadersVisualStyles = false;
            this.dgvDailySalesArchive.GridColor = System.Drawing.Color.Snow;
            this.dgvDailySalesArchive.Location = new System.Drawing.Point(20, 70);
            this.dgvDailySalesArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDailySalesArchive.Name = "dgvDailySalesArchive";
            this.dgvDailySalesArchive.RowHeadersVisible = false;
            this.dgvDailySalesArchive.RowHeadersWidth = 51;
            this.dgvDailySalesArchive.RowTemplate.Height = 24;
            this.dgvDailySalesArchive.Size = new System.Drawing.Size(941, 383);
            this.dgvDailySalesArchive.TabIndex = 9;
            this.dgvDailySalesArchive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDailySalesArchive_CellContentClick);
            // 
            // DSNo
            // 
            this.DSNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSNo.HeaderText = "No";
            this.DSNo.MinimumWidth = 6;
            this.DSNo.Name = "DSNo";
            this.DSNo.Width = 62;
            // 
            // DSInvoice
            // 
            this.DSInvoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSInvoice.HeaderText = "Invoice#";
            this.DSInvoice.MinimumWidth = 6;
            this.DSInvoice.Name = "DSInvoice";
            this.DSInvoice.Width = 116;
            // 
            // DSItemCode
            // 
            this.DSItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSItemCode.HeaderText = "Item Code";
            this.DSItemCode.MinimumWidth = 6;
            this.DSItemCode.Name = "DSItemCode";
            this.DSItemCode.Width = 123;
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
            this.DSPrice.Width = 80;
            // 
            // DSQuantity
            // 
            this.DSQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSQuantity.HeaderText = "Quantity";
            this.DSQuantity.MinimumWidth = 6;
            this.DSQuantity.Name = "DSQuantity";
            this.DSQuantity.Width = 115;
            // 
            // DSDiscount
            // 
            this.DSDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSDiscount.HeaderText = "Discount";
            this.DSDiscount.MinimumWidth = 6;
            this.DSDiscount.Name = "DSDiscount";
            this.DSDiscount.Width = 113;
            // 
            // DSTotal
            // 
            this.DSTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DSTotal.HeaderText = "Total";
            this.DSTotal.MinimumWidth = 6;
            this.DSTotal.Name = "DSTotal";
            this.DSTotal.Width = 79;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_cancel_20;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // DailySalesArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 553);
            this.Controls.Add(this.dgvDailySalesArchive);
            this.Controls.Add(this.side2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DailySalesArchive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailySalesArchive";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailySalesArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DailySalesArchivesLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MngItemLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel side2;
        private System.Windows.Forms.DataGridView dgvDailySalesArchive;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSTotal;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}