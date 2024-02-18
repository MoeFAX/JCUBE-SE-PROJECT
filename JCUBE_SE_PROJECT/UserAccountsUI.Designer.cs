namespace JCUBE_SE_PROJECT
{
    partial class UserAccountsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountsUI));
            this.label9 = new System.Windows.Forms.Label();
            this.CABttn = new MetroFramework.Controls.MetroButton();
            this.CPBttn = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.UANoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAUserNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAFullNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAAccActCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UARoleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResetPasswordBttn = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPasswordBttn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label9.Location = new System.Drawing.Point(16, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "USER ACCOUNTS";
            // 
            // CABttn
            // 
            this.CABttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.CABttn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CABttn.ForeColor = System.Drawing.SystemColors.Control;
            this.CABttn.Location = new System.Drawing.Point(16, 54);
            this.CABttn.Margin = new System.Windows.Forms.Padding(4);
            this.CABttn.Name = "CABttn";
            this.CABttn.Size = new System.Drawing.Size(149, 28);
            this.CABttn.TabIndex = 8;
            this.CABttn.Text = "Create Account";
            this.CABttn.UseCustomBackColor = true;
            this.CABttn.UseCustomForeColor = true;
            this.CABttn.UseSelectable = true;
            this.CABttn.Click += new System.EventHandler(this.CABttn_Click);
            // 
            // CPBttn
            // 
            this.CPBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.CPBttn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CPBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.CPBttn.Location = new System.Drawing.Point(189, 54);
            this.CPBttn.Margin = new System.Windows.Forms.Padding(4);
            this.CPBttn.Name = "CPBttn";
            this.CPBttn.Size = new System.Drawing.Size(149, 28);
            this.CPBttn.TabIndex = 9;
            this.CPBttn.Text = "Change Password";
            this.CPBttn.UseCustomBackColor = true;
            this.CPBttn.UseCustomForeColor = true;
            this.CPBttn.UseSelectable = true;
            this.CPBttn.Click += new System.EventHandler(this.CPBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Settings";
            // 
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 9);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UANoCol,
            this.UAUserNameCol,
            this.UAFullNameCol,
            this.UAAccActCol,
            this.UARoleCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(16, 107);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(896, 411);
            this.dgvUser.TabIndex = 18;
            // 
            // UANoCol
            // 
            this.UANoCol.HeaderText = "No";
            this.UANoCol.MinimumWidth = 6;
            this.UANoCol.Name = "UANoCol";
            this.UANoCol.Width = 50;
            // 
            // UAUserNameCol
            // 
            this.UAUserNameCol.HeaderText = "Username";
            this.UAUserNameCol.MinimumWidth = 6;
            this.UAUserNameCol.Name = "UAUserNameCol";
            this.UAUserNameCol.Width = 200;
            // 
            // UAFullNameCol
            // 
            this.UAFullNameCol.HeaderText = "Full Name";
            this.UAFullNameCol.MinimumWidth = 6;
            this.UAFullNameCol.Name = "UAFullNameCol";
            this.UAFullNameCol.Width = 400;
            // 
            // UAAccActCol
            // 
            this.UAAccActCol.HeaderText = "Account Activate";
            this.UAAccActCol.MinimumWidth = 6;
            this.UAAccActCol.Name = "UAAccActCol";
            this.UAAccActCol.Width = 175;
            // 
            // UARoleCol
            // 
            this.UARoleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UARoleCol.HeaderText = "Role";
            this.UARoleCol.MinimumWidth = 6;
            this.UARoleCol.Name = "UARoleCol";
            // 
            // ResetPasswordBttn
            // 
            this.ResetPasswordBttn.Image = ((System.Drawing.Image)(resources.GetObject("ResetPasswordBttn.Image")));
            this.ResetPasswordBttn.Location = new System.Drawing.Point(733, 537);
            this.ResetPasswordBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetPasswordBttn.Name = "ResetPasswordBttn";
            this.ResetPasswordBttn.Size = new System.Drawing.Size(40, 39);
            this.ResetPasswordBttn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResetPasswordBttn.TabIndex = 20;
            this.ResetPasswordBttn.TabStop = false;
            this.ResetPasswordBttn.Click += new System.EventHandler(this.ResetPasswordBttn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(688, 537);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(872, 537);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(827, 537);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(780, 537);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 530);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // UserAccountsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(928, 592);
            this.Controls.Add(this.ResetPasswordBttn);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CPBttn);
            this.Controls.Add(this.CABttn);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserAccountsUI";
            this.Text = "User Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPasswordBttn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroButton CABttn;
        private MetroFramework.Controls.MetroButton CPBttn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UANoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAUserNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAFullNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UAAccActCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UARoleCol;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox ResetPasswordBttn;
    }
}