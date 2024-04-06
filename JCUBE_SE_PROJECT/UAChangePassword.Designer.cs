namespace JCUBE_SE_PROJECT
{
    partial class UAChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UAChangePassword));
            this.CPNewPasswordlbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CPUNlbl = new System.Windows.Forms.Label();
            this.CPPersonIMG = new System.Windows.Forms.PictureBox();
            this.CPRTPasswordField = new System.Windows.Forms.TextBox();
            this.CPRTPasswordlbl = new System.Windows.Forms.Label();
            this.CPNewPasswordField = new System.Windows.Forms.TextBox();
            this.NPEyeBtn = new System.Windows.Forms.PictureBox();
            this.RTEyeBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CPPersonIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPEyeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTEyeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // CPNewPasswordlbl
            // 
            this.CPNewPasswordlbl.AutoSize = true;
            this.CPNewPasswordlbl.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPNewPasswordlbl.Location = new System.Drawing.Point(52, 89);
            this.CPNewPasswordlbl.Name = "CPNewPasswordlbl";
            this.CPNewPasswordlbl.Size = new System.Drawing.Size(133, 26);
            this.CPNewPasswordlbl.TabIndex = 54;
            this.CPNewPasswordlbl.Text = "New Password:";
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
            this.CancelBtn.Location = new System.Drawing.Point(377, 186);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 35);
            this.CancelBtn.TabIndex = 53;
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
            this.SaveBtn.Location = new System.Drawing.Point(260, 186);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 35);
            this.SaveBtn.TabIndex = 52;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CPUNlbl
            // 
            this.CPUNlbl.AutoSize = true;
            this.CPUNlbl.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNlbl.Location = new System.Drawing.Point(190, 30);
            this.CPUNlbl.Name = "CPUNlbl";
            this.CPUNlbl.Size = new System.Drawing.Size(68, 27);
            this.CPUNlbl.TabIndex = 51;
            this.CPUNlbl.Text = "Admin";
            // 
            // CPPersonIMG
            // 
            this.CPPersonIMG.Image = ((System.Drawing.Image)(resources.GetObject("CPPersonIMG.Image")));
            this.CPPersonIMG.Location = new System.Drawing.Point(134, 18);
            this.CPPersonIMG.Name = "CPPersonIMG";
            this.CPPersonIMG.Size = new System.Drawing.Size(50, 50);
            this.CPPersonIMG.TabIndex = 50;
            this.CPPersonIMG.TabStop = false;
            // 
            // CPRTPasswordField
            // 
            this.CPRTPasswordField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPRTPasswordField.Location = new System.Drawing.Point(188, 136);
            this.CPRTPasswordField.Name = "CPRTPasswordField";
            this.CPRTPasswordField.PasswordChar = '●';
            this.CPRTPasswordField.Size = new System.Drawing.Size(459, 32);
            this.CPRTPasswordField.TabIndex = 48;
            // 
            // CPRTPasswordlbl
            // 
            this.CPRTPasswordlbl.AutoSize = true;
            this.CPRTPasswordlbl.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPRTPasswordlbl.Location = new System.Drawing.Point(27, 141);
            this.CPRTPasswordlbl.Name = "CPRTPasswordlbl";
            this.CPRTPasswordlbl.Size = new System.Drawing.Size(158, 26);
            this.CPRTPasswordlbl.TabIndex = 49;
            this.CPRTPasswordlbl.Text = "Re-type Password:";
            // 
            // CPNewPasswordField
            // 
            this.CPNewPasswordField.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPNewPasswordField.Location = new System.Drawing.Point(188, 86);
            this.CPNewPasswordField.Name = "CPNewPasswordField";
            this.CPNewPasswordField.PasswordChar = '●';
            this.CPNewPasswordField.Size = new System.Drawing.Size(459, 32);
            this.CPNewPasswordField.TabIndex = 47;
            // 
            // NPEyeBtn
            // 
            this.NPEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.NPEyeBtn.Image = ((System.Drawing.Image)(resources.GetObject("NPEyeBtn.Image")));
            this.NPEyeBtn.Location = new System.Drawing.Point(623, 91);
            this.NPEyeBtn.Name = "NPEyeBtn";
            this.NPEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.NPEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.NPEyeBtn.TabIndex = 55;
            this.NPEyeBtn.TabStop = false;
            // 
            // RTEyeBtn
            // 
            this.RTEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.RTEyeBtn.Image = ((System.Drawing.Image)(resources.GetObject("RTEyeBtn.Image")));
            this.RTEyeBtn.Location = new System.Drawing.Point(623, 141);
            this.RTEyeBtn.Name = "RTEyeBtn";
            this.RTEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.RTEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RTEyeBtn.TabIndex = 56;
            this.RTEyeBtn.TabStop = false;
            // 
            // UAChangePassword
            // 
            this.AcceptButton = this.SaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(727, 236);
            this.Controls.Add(this.RTEyeBtn);
            this.Controls.Add(this.NPEyeBtn);
            this.Controls.Add(this.CPNewPasswordlbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CPUNlbl);
            this.Controls.Add(this.CPPersonIMG);
            this.Controls.Add(this.CPRTPasswordField);
            this.Controls.Add(this.CPRTPasswordlbl);
            this.Controls.Add(this.CPNewPasswordField);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UAChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.CPPersonIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPEyeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTEyeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CPNewPasswordlbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.PictureBox CPPersonIMG;
        private System.Windows.Forms.TextBox CPRTPasswordField;
        private System.Windows.Forms.Label CPRTPasswordlbl;
        private System.Windows.Forms.TextBox CPNewPasswordField;
        public System.Windows.Forms.Label CPUNlbl;
        private System.Windows.Forms.PictureBox NPEyeBtn;
        private System.Windows.Forms.PictureBox RTEyeBtn;
    }
}