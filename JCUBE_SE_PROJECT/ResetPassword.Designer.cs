namespace JCUBE_SE_PROJECT
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.RPRTPasswordField = new System.Windows.Forms.TextBox();
            this.RPRTPasswordlbl = new System.Windows.Forms.Label();
            this.RPNewPasswordField = new System.Windows.Forms.TextBox();
            this.RPPersonIMG = new System.Windows.Forms.PictureBox();
            this.RPUNlbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.RPNewPasswordlbl = new System.Windows.Forms.Label();
            this.RPWDAccIDlbl = new System.Windows.Forms.Label();
            this.NPEyeBtn = new System.Windows.Forms.PictureBox();
            this.RTEyeBtn = new System.Windows.Forms.PictureBox();
            this.ARPNewPasswordlbl = new System.Windows.Forms.Label();
            this.ARPRTPasswordlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RPPersonIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPEyeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTEyeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // RPRTPasswordField
            // 
            this.RPRTPasswordField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPRTPasswordField.Location = new System.Drawing.Point(188, 140);
            this.RPRTPasswordField.MaxLength = 255;
            this.RPRTPasswordField.Name = "RPRTPasswordField";
            this.RPRTPasswordField.PasswordChar = '●';
            this.RPRTPasswordField.Size = new System.Drawing.Size(459, 32);
            this.RPRTPasswordField.TabIndex = 38;
            this.RPRTPasswordField.TextChanged += new System.EventHandler(this.RPRTPasswordField_TextChanged);
            // 
            // RPRTPasswordlbl
            // 
            this.RPRTPasswordlbl.AutoSize = true;
            this.RPRTPasswordlbl.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPRTPasswordlbl.Location = new System.Drawing.Point(24, 143);
            this.RPRTPasswordlbl.Name = "RPRTPasswordlbl";
            this.RPRTPasswordlbl.Size = new System.Drawing.Size(162, 26);
            this.RPRTPasswordlbl.TabIndex = 39;
            this.RPRTPasswordlbl.Text = "Confirm Password:";
            // 
            // RPNewPasswordField
            // 
            this.RPNewPasswordField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPNewPasswordField.Location = new System.Drawing.Point(188, 90);
            this.RPNewPasswordField.MaxLength = 255;
            this.RPNewPasswordField.Name = "RPNewPasswordField";
            this.RPNewPasswordField.PasswordChar = '●';
            this.RPNewPasswordField.Size = new System.Drawing.Size(459, 32);
            this.RPNewPasswordField.TabIndex = 36;
            this.RPNewPasswordField.TextChanged += new System.EventHandler(this.RPNewPasswordField_TextChanged);
            // 
            // RPPersonIMG
            // 
            this.RPPersonIMG.Image = ((System.Drawing.Image)(resources.GetObject("RPPersonIMG.Image")));
            this.RPPersonIMG.Location = new System.Drawing.Point(135, 23);
            this.RPPersonIMG.Name = "RPPersonIMG";
            this.RPPersonIMG.Size = new System.Drawing.Size(50, 50);
            this.RPPersonIMG.TabIndex = 40;
            this.RPPersonIMG.TabStop = false;
            // 
            // RPUNlbl
            // 
            this.RPUNlbl.AutoSize = true;
            this.RPUNlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPUNlbl.Location = new System.Drawing.Point(191, 37);
            this.RPUNlbl.Name = "RPUNlbl";
            this.RPUNlbl.Size = new System.Drawing.Size(75, 27);
            this.RPUNlbl.TabIndex = 41;
            this.RPUNlbl.Text = "Cashier";
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
            this.CancelBtn.Location = new System.Drawing.Point(377, 190);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 35);
            this.CancelBtn.TabIndex = 43;
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
            this.SaveBtn.Location = new System.Drawing.Point(260, 190);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 35);
            this.SaveBtn.TabIndex = 42;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RPNewPasswordlbl
            // 
            this.RPNewPasswordlbl.AutoSize = true;
            this.RPNewPasswordlbl.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPNewPasswordlbl.Location = new System.Drawing.Point(52, 94);
            this.RPNewPasswordlbl.Name = "RPNewPasswordlbl";
            this.RPNewPasswordlbl.Size = new System.Drawing.Size(133, 26);
            this.RPNewPasswordlbl.TabIndex = 44;
            this.RPNewPasswordlbl.Text = "New Password:";
            // 
            // RPWDAccIDlbl
            // 
            this.RPWDAccIDlbl.AutoSize = true;
            this.RPWDAccIDlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPWDAccIDlbl.Location = new System.Drawing.Point(452, 37);
            this.RPWDAccIDlbl.Name = "RPWDAccIDlbl";
            this.RPWDAccIDlbl.Size = new System.Drawing.Size(63, 27);
            this.RPWDAccIDlbl.TabIndex = 45;
            this.RPWDAccIDlbl.Text = "label1";
            this.RPWDAccIDlbl.Visible = false;
            // 
            // NPEyeBtn
            // 
            this.NPEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.NPEyeBtn.Image = ((System.Drawing.Image)(resources.GetObject("NPEyeBtn.Image")));
            this.NPEyeBtn.Location = new System.Drawing.Point(623, 95);
            this.NPEyeBtn.Name = "NPEyeBtn";
            this.NPEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.NPEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NPEyeBtn.TabIndex = 57;
            this.NPEyeBtn.TabStop = false;
            // 
            // RTEyeBtn
            // 
            this.RTEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.RTEyeBtn.Image = ((System.Drawing.Image)(resources.GetObject("RTEyeBtn.Image")));
            this.RTEyeBtn.Location = new System.Drawing.Point(623, 145);
            this.RTEyeBtn.Name = "RTEyeBtn";
            this.RTEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.RTEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RTEyeBtn.TabIndex = 58;
            this.RTEyeBtn.TabStop = false;
            // 
            // ARPNewPasswordlbl
            // 
            this.ARPNewPasswordlbl.AutoSize = true;
            this.ARPNewPasswordlbl.BackColor = System.Drawing.Color.Transparent;
            this.ARPNewPasswordlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARPNewPasswordlbl.ForeColor = System.Drawing.Color.Red;
            this.ARPNewPasswordlbl.Location = new System.Drawing.Point(647, 91);
            this.ARPNewPasswordlbl.Name = "ARPNewPasswordlbl";
            this.ARPNewPasswordlbl.Size = new System.Drawing.Size(22, 27);
            this.ARPNewPasswordlbl.TabIndex = 59;
            this.ARPNewPasswordlbl.Text = "*";
            this.ARPNewPasswordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ARPRTPasswordlbl
            // 
            this.ARPRTPasswordlbl.AutoSize = true;
            this.ARPRTPasswordlbl.BackColor = System.Drawing.Color.Transparent;
            this.ARPRTPasswordlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARPRTPasswordlbl.ForeColor = System.Drawing.Color.Red;
            this.ARPRTPasswordlbl.Location = new System.Drawing.Point(647, 141);
            this.ARPRTPasswordlbl.Name = "ARPRTPasswordlbl";
            this.ARPRTPasswordlbl.Size = new System.Drawing.Size(22, 27);
            this.ARPRTPasswordlbl.TabIndex = 60;
            this.ARPRTPasswordlbl.Text = "*";
            this.ARPRTPasswordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetPassword
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(727, 240);
            this.Controls.Add(this.ARPRTPasswordlbl);
            this.Controls.Add(this.ARPNewPasswordlbl);
            this.Controls.Add(this.RTEyeBtn);
            this.Controls.Add(this.NPEyeBtn);
            this.Controls.Add(this.RPWDAccIDlbl);
            this.Controls.Add(this.RPNewPasswordlbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.RPUNlbl);
            this.Controls.Add(this.RPPersonIMG);
            this.Controls.Add(this.RPRTPasswordField);
            this.Controls.Add(this.RPRTPasswordlbl);
            this.Controls.Add(this.RPNewPasswordField);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            ((System.ComponentModel.ISupportInitialize)(this.RPPersonIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPEyeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTEyeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RPRTPasswordField;
        private System.Windows.Forms.Label RPRTPasswordlbl;
        private System.Windows.Forms.TextBox RPNewPasswordField;
        private System.Windows.Forms.PictureBox RPPersonIMG;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label RPNewPasswordlbl;
        public System.Windows.Forms.Label RPWDAccIDlbl;
        public System.Windows.Forms.Button SaveBtn;
        public System.Windows.Forms.Label RPUNlbl;
        private System.Windows.Forms.PictureBox NPEyeBtn;
        private System.Windows.Forms.PictureBox RTEyeBtn;
        private System.Windows.Forms.Label ARPNewPasswordlbl;
        private System.Windows.Forms.Label ARPRTPasswordlbl;
    }
}