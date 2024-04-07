namespace JCUBE_SE_PROJECT
{
    partial class CancelledOrdersUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelledOrdersUI));
            this.dgvCancel = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintCnclOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadCancelled = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateToCancelled = new System.Windows.Forms.DateTimePicker();
            this.dateFromCancelled = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.flterLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CONoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COTransacCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COInvCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COQuantCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COTotalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COCancByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COReasonCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COActionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancel)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCancel
            // 
            this.dgvCancel.AllowUserToAddRows = false;
            this.dgvCancel.AllowUserToDeleteRows = false;
            this.dgvCancel.AllowUserToResizeColumns = false;
            this.dgvCancel.AllowUserToResizeRows = false;
            this.dgvCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvCancel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCancel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCancel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 9);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCancel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONoCol,
            this.COTransacCol,
            this.COInvCodeCol,
            this.COPriceCol,
            this.COQuantCol,
            this.COTotalCol,
            this.CODateCol,
            this.COCancByCol,
            this.COReasonCol,
            this.COActionCol,
            this.Delete});
            this.dgvCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCancel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCancel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCancel.EnableHeadersVisualStyles = false;
            this.dgvCancel.Location = new System.Drawing.Point(20, 63);
            this.dgvCancel.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCancel.Name = "dgvCancel";
            this.dgvCancel.ReadOnly = true;
            this.dgvCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCancel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCancel.RowHeadersVisible = false;
            this.dgvCancel.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCancel.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCancel.RowTemplate.Height = 24;
            this.dgvCancel.Size = new System.Drawing.Size(888, 462);
            this.dgvCancel.TabIndex = 22;
            this.dgvCancel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCancel_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PrintCnclOrders);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLoadCancelled);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 63);
            this.panel1.TabIndex = 35;
            // 
            // PrintCnclOrders
            // 
            this.PrintCnclOrders.BackColor = System.Drawing.Color.White;
            this.PrintCnclOrders.FlatAppearance.BorderSize = 0;
            this.PrintCnclOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintCnclOrders.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintCnclOrders.ForeColor = System.Drawing.Color.Black;
            this.PrintCnclOrders.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_print_30;
            this.PrintCnclOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintCnclOrders.Location = new System.Drawing.Point(361, 13);
            this.PrintCnclOrders.Name = "PrintCnclOrders";
            this.PrintCnclOrders.Size = new System.Drawing.Size(173, 35);
            this.PrintCnclOrders.TabIndex = 39;
            this.PrintCnclOrders.Text = "Print Preview";
            this.PrintCnclOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintCnclOrders.UseVisualStyleBackColor = false;
            this.PrintCnclOrders.Click += new System.EventHandler(this.PrintCnclOrders_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "CANCELLED ORDERS";
            // 
            // btnLoadCancelled
            // 
            this.btnLoadCancelled.BackColor = System.Drawing.Color.White;
            this.btnLoadCancelled.FlatAppearance.BorderSize = 0;
            this.btnLoadCancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadCancelled.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCancelled.ForeColor = System.Drawing.Color.Black;
            this.btnLoadCancelled.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCancelled.Image")));
            this.btnLoadCancelled.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadCancelled.Location = new System.Drawing.Point(588, 13);
            this.btnLoadCancelled.Name = "btnLoadCancelled";
            this.btnLoadCancelled.Size = new System.Drawing.Size(131, 35);
            this.btnLoadCancelled.TabIndex = 38;
            this.btnLoadCancelled.Text = "Refresh";
            this.btnLoadCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadCancelled.UseVisualStyleBackColor = false;
            this.btnLoadCancelled.Click += new System.EventHandler(this.btnLoadCancelled_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dateToCancelled);
            this.panel2.Controls.Add(this.dateFromCancelled);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.flterLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 67);
            this.panel2.TabIndex = 36;
            // 
            // dateToCancelled
            // 
            this.dateToCancelled.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToCancelled.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToCancelled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToCancelled.Location = new System.Drawing.Point(360, 19);
            this.dateToCancelled.Name = "dateToCancelled";
            this.dateToCancelled.Size = new System.Drawing.Size(144, 30);
            this.dateToCancelled.TabIndex = 41;
            // 
            // dateFromCancelled
            // 
            this.dateFromCancelled.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromCancelled.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromCancelled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromCancelled.Location = new System.Drawing.Point(139, 18);
            this.dateFromCancelled.Name = "dateFromCancelled";
            this.dateFromCancelled.Size = new System.Drawing.Size(146, 30);
            this.dateFromCancelled.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "To:";
            // 
            // flterLbl
            // 
            this.flterLbl.AutoSize = true;
            this.flterLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flterLbl.Location = new System.Drawing.Point(20, 21);
            this.flterLbl.Name = "flterLbl";
            this.flterLbl.Size = new System.Drawing.Size(113, 23);
            this.flterLbl.TabIndex = 37;
            this.flterLbl.Text = "Filter From:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 462);
            this.panel3.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(908, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 462);
            this.panel4.TabIndex = 38;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_restore_30;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::JCUBE_SE_PROJECT.Properties.Resources.Delete_Icon;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // CONoCol
            // 
            this.CONoCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CONoCol.HeaderText = "No";
            this.CONoCol.MinimumWidth = 6;
            this.CONoCol.Name = "CONoCol";
            this.CONoCol.ReadOnly = true;
            this.CONoCol.Visible = false;
            this.CONoCol.Width = 31;
            // 
            // COTransacCol
            // 
            this.COTransacCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COTransacCol.HeaderText = "Transaction No.";
            this.COTransacCol.MinimumWidth = 6;
            this.COTransacCol.Name = "COTransacCol";
            this.COTransacCol.ReadOnly = true;
            this.COTransacCol.Width = 144;
            // 
            // COInvCodeCol
            // 
            this.COInvCodeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COInvCodeCol.HeaderText = "Item Code";
            this.COInvCodeCol.MinimumWidth = 6;
            this.COInvCodeCol.Name = "COInvCodeCol";
            this.COInvCodeCol.ReadOnly = true;
            this.COInvCodeCol.Width = 104;
            // 
            // COPriceCol
            // 
            this.COPriceCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COPriceCol.HeaderText = "Price";
            this.COPriceCol.MinimumWidth = 6;
            this.COPriceCol.Name = "COPriceCol";
            this.COPriceCol.ReadOnly = true;
            this.COPriceCol.Width = 70;
            // 
            // COQuantCol
            // 
            this.COQuantCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COQuantCol.HeaderText = "Qty";
            this.COQuantCol.MinimumWidth = 6;
            this.COQuantCol.Name = "COQuantCol";
            this.COQuantCol.ReadOnly = true;
            this.COQuantCol.Width = 57;
            // 
            // COTotalCol
            // 
            this.COTotalCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COTotalCol.HeaderText = "Total";
            this.COTotalCol.MinimumWidth = 6;
            this.COTotalCol.Name = "COTotalCol";
            this.COTotalCol.ReadOnly = true;
            this.COTotalCol.Width = 70;
            // 
            // CODateCol
            // 
            this.CODateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODateCol.HeaderText = "Date";
            this.CODateCol.MinimumWidth = 6;
            this.CODateCol.Name = "CODateCol";
            this.CODateCol.ReadOnly = true;
            this.CODateCol.Width = 67;
            // 
            // COCancByCol
            // 
            this.COCancByCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COCancByCol.HeaderText = "Cancelled By";
            this.COCancByCol.MinimumWidth = 6;
            this.COCancByCol.Name = "COCancByCol";
            this.COCancByCol.ReadOnly = true;
            this.COCancByCol.Width = 126;
            // 
            // COReasonCol
            // 
            this.COReasonCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COReasonCol.HeaderText = "Reason";
            this.COReasonCol.MinimumWidth = 6;
            this.COReasonCol.Name = "COReasonCol";
            this.COReasonCol.ReadOnly = true;
            // 
            // COActionCol
            // 
            this.COActionCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COActionCol.HeaderText = "Action";
            this.COActionCol.MinimumWidth = 6;
            this.COActionCol.Name = "COActionCol";
            this.COActionCol.ReadOnly = true;
            this.COActionCol.Width = 77;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::JCUBE_SE_PROJECT.Properties.Resources.Delete_Icon;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 21;
            // 
            // CancelledOrdersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 592);
            this.Controls.Add(this.dgvCancel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CancelledOrdersUI";
            this.Text = "Cancelled Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCancel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoadCancelled;
        private System.Windows.Forms.DateTimePicker dateToCancelled;
        private System.Windows.Forms.DateTimePicker dateFromCancelled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label flterLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintCnclOrders;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COTransacCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COInvCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COQuantCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COTotalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COCancByCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COReasonCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn COActionCol;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}