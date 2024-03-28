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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.ResetPasswordlbl = new System.Windows.Forms.Label();
            this.RPRTPasswordField = new System.Windows.Forms.TextBox();
            this.RPRTPasswordlbl = new System.Windows.Forms.Label();
            this.RPNewPasswordField = new System.Windows.Forms.TextBox();
            this.RPCurrPasswordField = new System.Windows.Forms.TextBox();
            this.RPCurrPasswordlbl = new System.Windows.Forms.Label();
            this.RPPersonIMG = new System.Windows.Forms.PictureBox();
            this.RPUNlbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.RPNewPasswordlbl = new System.Windows.Forms.Label();
            this.RPWDAccIDlbl = new System.Windows.Forms.Label();
            this.NPEyeBtn = new System.Windows.Forms.PictureBox();
            this.RTEyeBtn = new System.Windows.Forms.PictureBox();
            this.CPEyeBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPPersonIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPEyeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTEyeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPEyeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.ResetPasswordlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 50);
            this.panel1.TabIndex = 4;
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
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ResetPasswordlbl
            // 
            this.ResetPasswordlbl.AutoSize = true;
            this.ResetPasswordlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPasswordlbl.Location = new System.Drawing.Point(12, 18);
            this.ResetPasswordlbl.Name = "ResetPasswordlbl";
            this.ResetPasswordlbl.Size = new System.Drawing.Size(159, 23);
            this.ResetPasswordlbl.TabIndex = 1;
            this.ResetPasswordlbl.Text = "Reset Password";
            // 
            // RPRTPasswordField
            // 
            this.RPRTPasswordField.Location = new System.Drawing.Point(188, 223);
            this.RPRTPasswordField.Name = "RPRTPasswordField";
            this.RPRTPasswordField.PasswordChar = '●';
            this.RPRTPasswordField.Size = new System.Drawing.Size(459, 30);
            this.RPRTPasswordField.TabIndex = 38;
            // 
            // RPRTPasswordlbl
            // 
            this.RPRTPasswordlbl.AutoSize = true;
            this.RPRTPasswordlbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPRTPasswordlbl.Location = new System.Drawing.Point(24, 229);
            this.RPRTPasswordlbl.Name = "RPRTPasswordlbl";
            this.RPRTPasswordlbl.Size = new System.Drawing.Size(163, 21);
            this.RPRTPasswordlbl.TabIndex = 39;
            this.RPRTPasswordlbl.Text = "Re-type Password:";
            // 
            // RPNewPasswordField
            // 
            this.RPNewPasswordField.Location = new System.Drawing.Point(188, 173);
            this.RPNewPasswordField.Name = "RPNewPasswordField";
            this.RPNewPasswordField.PasswordChar = '●';
            this.RPNewPasswordField.Size = new System.Drawing.Size(459, 30);
            this.RPNewPasswordField.TabIndex = 36;
            // 
            // RPCurrPasswordField
            // 
            this.RPCurrPasswordField.Location = new System.Drawing.Point(188, 124);
            this.RPCurrPasswordField.Name = "RPCurrPasswordField";
            this.RPCurrPasswordField.PasswordChar = '●';
            this.RPCurrPasswordField.Size = new System.Drawing.Size(459, 30);
            this.RPCurrPasswordField.TabIndex = 34;
            // 
            // RPCurrPasswordlbl
            // 
            this.RPCurrPasswordlbl.AutoSize = true;
            this.RPCurrPasswordlbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPCurrPasswordlbl.Location = new System.Drawing.Point(25, 130);
            this.RPCurrPasswordlbl.Name = "RPCurrPasswordlbl";
            this.RPCurrPasswordlbl.Size = new System.Drawing.Size(160, 21);
            this.RPCurrPasswordlbl.TabIndex = 35;
            this.RPCurrPasswordlbl.Text = "Current Password:";
            // 
            // RPPersonIMG
            // 
            this.RPPersonIMG.Image = ((System.Drawing.Image)(resources.GetObject("RPPersonIMG.Image")));
            this.RPPersonIMG.Location = new System.Drawing.Point(51, 66);
            this.RPPersonIMG.Name = "RPPersonIMG";
            this.RPPersonIMG.Size = new System.Drawing.Size(50, 50);
            this.RPPersonIMG.TabIndex = 40;
            this.RPPersonIMG.TabStop = false;
            // 
            // RPUNlbl
            // 
            this.RPUNlbl.AutoSize = true;
            this.RPUNlbl.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPUNlbl.Location = new System.Drawing.Point(107, 81);
            this.RPUNlbl.Name = "RPUNlbl";
            this.RPUNlbl.Size = new System.Drawing.Size(75, 21);
            this.RPUNlbl.TabIndex = 41;
            this.RPUNlbl.Text = "Cashier";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(377, 278);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 30);
            this.CancelBtn.TabIndex = 43;
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
            this.SaveBtn.Location = new System.Drawing.Point(260, 278);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 30);
            this.SaveBtn.TabIndex = 42;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RPNewPasswordlbl
            // 
            this.RPNewPasswordlbl.AutoSize = true;
            this.RPNewPasswordlbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPNewPasswordlbl.Location = new System.Drawing.Point(49, 179);
            this.RPNewPasswordlbl.Name = "RPNewPasswordlbl";
            this.RPNewPasswordlbl.Size = new System.Drawing.Size(136, 21);
            this.RPNewPasswordlbl.TabIndex = 44;
            this.RPNewPasswordlbl.Text = "New Password:";
            // 
            // RPWDAccIDlbl
            // 
            this.RPWDAccIDlbl.AutoSize = true;
            this.RPWDAccIDlbl.Location = new System.Drawing.Point(188, 81);
            this.RPWDAccIDlbl.Name = "RPWDAccIDlbl";
            this.RPWDAccIDlbl.Size = new System.Drawing.Size(62, 21);
            this.RPWDAccIDlbl.TabIndex = 45;
            this.RPWDAccIDlbl.Text = "label1";
            this.RPWDAccIDlbl.Visible = false;
            // 
            // NPEyeBtn
            // 
            this.NPEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.NPEyeBtn.Image = ((System.Drawing.Image)(resources.GetObject("NPEyeBtn.Image")));
            this.NPEyeBtn.Location = new System.Drawing.Point(623, 178);
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
            this.RTEyeBtn.Location = new System.Drawing.Point(623, 228);
            this.RTEyeBtn.Name = "RTEyeBtn";
            this.RTEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.RTEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RTEyeBtn.TabIndex = 58;
            this.RTEyeBtn.TabStop = false;
            // 
            // CPEyeBtn
            // 
            this.CPEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.CPEyeBtn.Image = ((System.Drawing.Image)(resources.GetObject("CPEyeBtn.Image")));
            this.CPEyeBtn.Location = new System.Drawing.Point(623, 129);
            this.CPEyeBtn.Name = "CPEyeBtn";
            this.CPEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.CPEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CPEyeBtn.TabIndex = 59;
            this.CPEyeBtn.TabStop = false;
            // 
            // ResetPassword
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(727, 329);
            this.Controls.Add(this.CPEyeBtn);
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
            this.Controls.Add(this.RPCurrPasswordField);
            this.Controls.Add(this.RPCurrPasswordlbl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPPersonIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPEyeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTEyeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPEyeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label ResetPasswordlbl;
        private System.Windows.Forms.TextBox RPRTPasswordField;
        private System.Windows.Forms.Label RPRTPasswordlbl;
        private System.Windows.Forms.TextBox RPNewPasswordField;
        private System.Windows.Forms.Label RPCurrPasswordlbl;
        private System.Windows.Forms.PictureBox RPPersonIMG;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label RPNewPasswordlbl;
        public System.Windows.Forms.Label RPWDAccIDlbl;
        public System.Windows.Forms.Button SaveBtn;
        public System.Windows.Forms.TextBox RPCurrPasswordField;
        public System.Windows.Forms.Label RPUNlbl;
        private System.Windows.Forms.PictureBox NPEyeBtn;
        private System.Windows.Forms.PictureBox RTEyeBtn;
        private System.Windows.Forms.PictureBox CPEyeBtn;
    }
}