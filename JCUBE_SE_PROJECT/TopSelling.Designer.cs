using System.Drawing;

namespace JCUBE_SE_PROJECT
{
    partial class TopSelling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopSelling));
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTopSell = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrintTop = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTopSell = new System.Windows.Forms.ComboBox();
            this.dateToTopSell = new System.Windows.Forms.DateTimePicker();
            this.dateFromTopSell = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.flterLbl = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSell)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(719, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 30);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOP SELLING ITEMS";
            // 
            // dgvTopSell
            // 
            this.dgvTopSell.AllowUserToAddRows = false;
            this.dgvTopSell.AllowUserToDeleteRows = false;
            this.dgvTopSell.AllowUserToResizeColumns = false;
            this.dgvTopSell.AllowUserToResizeRows = false;
            this.dgvTopSell.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvTopSell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopSell.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTopSell.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 9);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopSell.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTopSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.InventoryCode,
            this.Description,
            this.Qty,
            this.Total});
            this.dgvTopSell.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopSell.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTopSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopSell.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTopSell.EnableHeadersVisualStyles = false;
            this.dgvTopSell.Location = new System.Drawing.Point(20, 70);
            this.dgvTopSell.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTopSell.Name = "dgvTopSell";
            this.dgvTopSell.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTopSell.RowHeadersVisible = false;
            this.dgvTopSell.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvTopSell.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTopSell.RowTemplate.Height = 24;
            this.dgvTopSell.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTopSell.Size = new System.Drawing.Size(871, 407);
            this.dgvTopSell.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnPrintTop);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 70);
            this.panel2.TabIndex = 14;
            // 
            // btnPrintTop
            // 
            this.btnPrintTop.BackColor = System.Drawing.Color.White;
            this.btnPrintTop.FlatAppearance.BorderSize = 0;
            this.btnPrintTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTop.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTop.ForeColor = System.Drawing.Color.Black;
            this.btnPrintTop.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_print_30;
            this.btnPrintTop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintTop.Location = new System.Drawing.Point(321, 19);
            this.btnPrintTop.Name = "btnPrintTop";
            this.btnPrintTop.Size = new System.Drawing.Size(173, 35);
            this.btnPrintTop.TabIndex = 13;
            this.btnPrintTop.Text = "Print Preview";
            this.btnPrintTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintTop.UseVisualStyleBackColor = false;
            this.btnPrintTop.Click += new System.EventHandler(this.btnPrintTop_Click_1);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.Location = new System.Drawing.Point(549, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(115, 35);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(891, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 477);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 477);
            this.panel3.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbTopSell);
            this.panel1.Controls.Add(this.dateToTopSell);
            this.panel1.Controls.Add(this.dateFromTopSell);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.flterLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 67);
            this.panel1.TabIndex = 13;
            // 
            // cbTopSell
            // 
            this.cbTopSell.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTopSell.FormattingEnabled = true;
            this.cbTopSell.Items.AddRange(new object[] {
            "Qty",
            "Total"});
            this.cbTopSell.Location = new System.Drawing.Point(695, 21);
            this.cbTopSell.Name = "cbTopSell";
            this.cbTopSell.Size = new System.Drawing.Size(149, 29);
            this.cbTopSell.TabIndex = 9;
            this.cbTopSell.Text = "Sort By";
            // 
            // dateToTopSell
            // 
            this.dateToTopSell.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToTopSell.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToTopSell.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToTopSell.Location = new System.Drawing.Point(366, 20);
            this.dateToTopSell.Name = "dateToTopSell";
            this.dateToTopSell.Size = new System.Drawing.Size(141, 30);
            this.dateToTopSell.TabIndex = 5;
            // 
            // dateFromTopSell
            // 
            this.dateFromTopSell.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromTopSell.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromTopSell.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromTopSell.Location = new System.Drawing.Point(152, 20);
            this.dateFromTopSell.Name = "dateFromTopSell";
            this.dateFromTopSell.Size = new System.Drawing.Size(143, 30);
            this.dateFromTopSell.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "To:";
            // 
            // flterLbl
            // 
            this.flterLbl.AutoSize = true;
            this.flterLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flterLbl.Location = new System.Drawing.Point(29, 24);
            this.flterLbl.Name = "flterLbl";
            this.flterLbl.Size = new System.Drawing.Size(113, 23);
            this.flterLbl.TabIndex = 2;
            this.flterLbl.Text = "Filter From:";
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Visible = false;
            this.No.Width = 63;
            // 
            // InventoryCode
            // 
            this.InventoryCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InventoryCode.HeaderText = "Inventory Code";
            this.InventoryCode.MinimumWidth = 6;
            this.InventoryCode.Name = "InventoryCode";
            this.InventoryCode.Width = 138;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 90;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "Total Sales";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 114;
            // 
            // TopSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 544);
            this.Controls.Add(this.dgvTopSell);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "TopSelling";
            this.Text = "TopSelling";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSell)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTopSell;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DateTimePicker dateToTopSell;
        private System.Windows.Forms.DateTimePicker dateFromTopSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label flterLbl;
        private System.Windows.Forms.ComboBox cbTopSell;
        private System.Windows.Forms.Button btnPrintTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}