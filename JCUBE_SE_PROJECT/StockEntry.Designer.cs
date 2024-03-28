namespace JCUBE_SE_PROJECT
{
    partial class StockEntry
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StockinbyField = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stocksField = new System.Windows.Forms.NumericUpDown();
            this.SuppNameField = new System.Windows.Forms.ComboBox();
            this.ItemNameField = new System.Windows.Forms.ComboBox();
            this.StockInDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusField = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.stocksField)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock In By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock In Date:";
            // 
            // StockinbyField
            // 
            this.StockinbyField.BackColor = System.Drawing.SystemColors.Window;
            this.StockinbyField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StockinbyField.Location = new System.Drawing.Point(132, 121);
            this.StockinbyField.Name = "StockinbyField";
            this.StockinbyField.ReadOnly = true;
            this.StockinbyField.Size = new System.Drawing.Size(362, 23);
            this.StockinbyField.TabIndex = 9;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savebtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(178, 259);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 12;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.cancelbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelbtn.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(287, 259);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 13;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stocks:";
            // 
            // stocksField
            // 
            this.stocksField.BackColor = System.Drawing.SystemColors.Window;
            this.stocksField.Location = new System.Drawing.Point(387, 204);
            this.stocksField.Name = "stocksField";
            this.stocksField.Size = new System.Drawing.Size(107, 23);
            this.stocksField.TabIndex = 38;
            this.stocksField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stocksField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SuppNameField
            // 
            this.SuppNameField.BackColor = System.Drawing.SystemColors.Window;
            this.SuppNameField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SuppNameField.FormattingEnabled = true;
            this.SuppNameField.Location = new System.Drawing.Point(132, 76);
            this.SuppNameField.Name = "SuppNameField";
            this.SuppNameField.Size = new System.Drawing.Size(362, 25);
            this.SuppNameField.TabIndex = 39;
            // 
            // ItemNameField
            // 
            this.ItemNameField.BackColor = System.Drawing.SystemColors.Window;
            this.ItemNameField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemNameField.FormattingEnabled = true;
            this.ItemNameField.Location = new System.Drawing.Point(132, 35);
            this.ItemNameField.Name = "ItemNameField";
            this.ItemNameField.Size = new System.Drawing.Size(362, 25);
            this.ItemNameField.TabIndex = 40;
            // 
            // StockInDate
            // 
            this.StockInDate.CustomFormat = "MM/dd/yyyy";
            this.StockInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StockInDate.Location = new System.Drawing.Point(132, 162);
            this.StockInDate.Name = "StockInDate";
            this.StockInDate.Size = new System.Drawing.Size(362, 23);
            this.StockInDate.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Status:";
            // 
            // StatusField
            // 
            this.StatusField.BackColor = System.Drawing.SystemColors.Window;
            this.StatusField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusField.FormattingEnabled = true;
            this.StatusField.Items.AddRange(new object[] {
            "Pending",
            "Delivered"});
            this.StatusField.Location = new System.Drawing.Point(132, 202);
            this.StatusField.Name = "StatusField";
            this.StatusField.Size = new System.Drawing.Size(184, 25);
            this.StatusField.TabIndex = 43;
            // 
            // StockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(542, 312);
            this.Controls.Add(this.StatusField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StockInDate);
            this.Controls.Add(this.ItemNameField);
            this.Controls.Add(this.SuppNameField);
            this.Controls.Add(this.stocksField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.StockinbyField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StockEntry";
            ((System.ComponentModel.ISupportInitialize)(this.stocksField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown stocksField;
        public System.Windows.Forms.ComboBox SuppNameField;
        public System.Windows.Forms.ComboBox ItemNameField;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox StatusField;
        public System.Windows.Forms.TextBox StockinbyField;
        public System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.Button cancelbtn;
        public System.Windows.Forms.DateTimePicker StockInDate;
    }
}