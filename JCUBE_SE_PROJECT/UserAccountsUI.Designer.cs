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
            this.label9 = new System.Windows.Forms.Label();
            this.CABttn = new MetroFramework.Controls.MetroButton();
            this.CPBttn = new MetroFramework.Controls.MetroButton();
            this.RPBttn = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumbCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AACol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "USER ACCOUNTS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // CABttn
            // 
            this.CABttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.CABttn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CABttn.ForeColor = System.Drawing.SystemColors.Control;
            this.CABttn.Location = new System.Drawing.Point(12, 44);
            this.CABttn.Name = "CABttn";
            this.CABttn.Size = new System.Drawing.Size(112, 23);
            this.CABttn.TabIndex = 8;
            this.CABttn.Text = "Create Account";
            this.CABttn.UseCustomBackColor = true;
            this.CABttn.UseCustomForeColor = true;
            this.CABttn.UseSelectable = true;
            // 
            // CPBttn
            // 
            this.CPBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.CPBttn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.CPBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.CPBttn.Location = new System.Drawing.Point(142, 44);
            this.CPBttn.Name = "CPBttn";
            this.CPBttn.Size = new System.Drawing.Size(112, 23);
            this.CPBttn.TabIndex = 9;
            this.CPBttn.Text = "Change Password";
            this.CPBttn.UseCustomBackColor = true;
            this.CPBttn.UseCustomForeColor = true;
            this.CPBttn.UseSelectable = true;
            // 
            // RPBttn
            // 
            this.RPBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.RPBttn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.RPBttn.ForeColor = System.Drawing.SystemColors.Control;
            this.RPBttn.Location = new System.Drawing.Point(273, 44);
            this.RPBttn.Name = "RPBttn";
            this.RPBttn.Size = new System.Drawing.Size(112, 23);
            this.RPBttn.TabIndex = 10;
            this.RPBttn.Text = "Reset Password";
            this.RPBttn.UseCustomBackColor = true;
            this.RPBttn.UseCustomForeColor = true;
            this.RPBttn.UseSelectable = true;
            this.RPBttn.Click += new System.EventHandler(this.RPBttn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumbCol,
            this.UNCol,
            this.FNCol,
            this.AACol,
            this.RoleCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(672, 334);
            this.dataGridView1.TabIndex = 11;
            // 
            // NumbCol
            // 
            this.NumbCol.HeaderText = "No";
            this.NumbCol.Name = "NumbCol";
            // 
            // UNCol
            // 
            this.UNCol.HeaderText = "Username";
            this.UNCol.Name = "UNCol";
            // 
            // FNCol
            // 
            this.FNCol.HeaderText = "Full Name";
            this.FNCol.Name = "FNCol";
            // 
            // AACol
            // 
            this.AACol.HeaderText = "Account Activate";
            this.AACol.Name = "AACol";
            // 
            // RoleCol
            // 
            this.RoleCol.HeaderText = "Role";
            this.RoleCol.Name = "RoleCol";
            // 
            // UserAccountsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RPBttn);
            this.Controls.Add(this.CPBttn);
            this.Controls.Add(this.CABttn);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserAccountsUI";
            this.Text = "User Accounts";
            this.Load += new System.EventHandler(this.UserAccountsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroButton CABttn;
        private MetroFramework.Controls.MetroButton CPBttn;
        private MetroFramework.Controls.MetroButton RPBttn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumbCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AACol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleCol;
    }
}