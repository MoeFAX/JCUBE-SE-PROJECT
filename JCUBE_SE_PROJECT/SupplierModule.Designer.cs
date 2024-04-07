namespace JCUBE_SE_PROJECT
{
    partial class SupplierModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierModule));
            this.SupplierNameField = new System.Windows.Forms.TextBox();
            this.AddressField = new System.Windows.Forms.TextBox();
            this.ContactField = new System.Windows.Forms.TextBox();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.EmailAddField = new System.Windows.Forms.TextBox();
            this.SupplierNamelbl = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.Contactlbl = new System.Windows.Forms.Label();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.EmailAddlbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SupplierNameField
            // 
            this.SupplierNameField.Location = new System.Drawing.Point(170, 51);
            this.SupplierNameField.Name = "SupplierNameField";
            this.SupplierNameField.Size = new System.Drawing.Size(384, 30);
            this.SupplierNameField.TabIndex = 8;
            // 
            // AddressField
            // 
            this.AddressField.Location = new System.Drawing.Point(170, 99);
            this.AddressField.Name = "AddressField";
            this.AddressField.Size = new System.Drawing.Size(384, 30);
            this.AddressField.TabIndex = 9;
            // 
            // ContactField
            // 
            this.ContactField.Location = new System.Drawing.Point(170, 144);
            this.ContactField.Name = "ContactField";
            this.ContactField.Size = new System.Drawing.Size(384, 30);
            this.ContactField.TabIndex = 10;
            // 
            // PhoneField
            // 
            this.PhoneField.Location = new System.Drawing.Point(170, 193);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(384, 30);
            this.PhoneField.TabIndex = 11;
            // 
            // EmailAddField
            // 
            this.EmailAddField.Location = new System.Drawing.Point(170, 240);
            this.EmailAddField.Name = "EmailAddField";
            this.EmailAddField.Size = new System.Drawing.Size(384, 30);
            this.EmailAddField.TabIndex = 12;
            // 
            // SupplierNamelbl
            // 
            this.SupplierNamelbl.AutoSize = true;
            this.SupplierNamelbl.Location = new System.Drawing.Point(23, 54);
            this.SupplierNamelbl.Name = "SupplierNamelbl";
            this.SupplierNamelbl.Size = new System.Drawing.Size(141, 21);
            this.SupplierNamelbl.TabIndex = 13;
            this.SupplierNamelbl.Text = "Supplier Name:";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Location = new System.Drawing.Point(79, 102);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(85, 21);
            this.Addresslbl.TabIndex = 14;
            this.Addresslbl.Text = "Address:";
            // 
            // Contactlbl
            // 
            this.Contactlbl.AutoSize = true;
            this.Contactlbl.Location = new System.Drawing.Point(10, 147);
            this.Contactlbl.Name = "Contactlbl";
            this.Contactlbl.Size = new System.Drawing.Size(154, 21);
            this.Contactlbl.TabIndex = 15;
            this.Contactlbl.Text = "Contact Person:";
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Location = new System.Drawing.Point(62, 196);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(102, 21);
            this.Phonelbl.TabIndex = 16;
            this.Phonelbl.Text = "Phone No:";
            // 
            // EmailAddlbl
            // 
            this.EmailAddlbl.AutoSize = true;
            this.EmailAddlbl.Location = new System.Drawing.Point(29, 243);
            this.EmailAddlbl.Name = "EmailAddlbl";
            this.EmailAddlbl.Size = new System.Drawing.Size(135, 21);
            this.EmailAddlbl.TabIndex = 17;
            this.EmailAddlbl.Text = "Email Address:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(155)))), ((int)(((byte)(97)))));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(198, 299);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 30);
            this.SaveBtn.TabIndex = 18;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(68)))), ((int)(((byte)(54)))));
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(315, 299);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 30);
            this.CancelBtn.TabIndex = 19;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(29, 342);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(25, 21);
            this.lblid.TabIndex = 20;
            this.lblid.Text = "id";
            this.lblid.Visible = false;
            // 
            // SupplierModule
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(608, 370);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EmailAddField);
            this.Controls.Add(this.EmailAddlbl);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.Phonelbl);
            this.Controls.Add(this.ContactField);
            this.Controls.Add(this.Contactlbl);
            this.Controls.Add(this.AddressField);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.SupplierNameField);
            this.Controls.Add(this.SupplierNamelbl);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Module";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SupplierNamelbl;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Label Contactlbl;
        private System.Windows.Forms.Label Phonelbl;
        private System.Windows.Forms.Label EmailAddlbl;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.TextBox SupplierNameField;
        public System.Windows.Forms.TextBox AddressField;
        public System.Windows.Forms.TextBox ContactField;
        public System.Windows.Forms.TextBox PhoneField;
        public System.Windows.Forms.TextBox EmailAddField;
        public System.Windows.Forms.Button SaveBtn;
        public System.Windows.Forms.Button CancelBtn;
    }
}