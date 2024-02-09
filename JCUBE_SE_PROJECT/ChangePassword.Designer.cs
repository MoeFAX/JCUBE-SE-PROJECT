namespace JCUBE_SE_PROJECT
{
    partial class ChangePassword
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
            this.btnNext = new System.Windows.Forms.Button();
            this.txtCurrentPass = new MetroFramework.Controls.MetroTextBox();
            this.Username = new System.Windows.Forms.Label();
            this.txtConfirmPass = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(213, 166);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtCurrentPass
            // 
            // 
            // 
            // 
            this.txtCurrentPass.CustomButton.Image = null;
            this.txtCurrentPass.CustomButton.Location = new System.Drawing.Point(442, 2);
            this.txtCurrentPass.CustomButton.Name = "";
            this.txtCurrentPass.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtCurrentPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurrentPass.CustomButton.TabIndex = 1;
            this.txtCurrentPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurrentPass.CustomButton.UseSelectable = true;
            this.txtCurrentPass.CustomButton.Visible = false;
            this.txtCurrentPass.DisplayIcon = true;
            this.txtCurrentPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCurrentPass.Icon = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_lock_30;
            this.txtCurrentPass.Lines = new string[0];
            this.txtCurrentPass.Location = new System.Drawing.Point(12, 68);
            this.txtCurrentPass.MaxLength = 32767;
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '\0';
            this.txtCurrentPass.PromptText = "Current Password";
            this.txtCurrentPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentPass.SelectedText = "";
            this.txtCurrentPass.SelectionLength = 0;
            this.txtCurrentPass.SelectionStart = 0;
            this.txtCurrentPass.ShortcutsEnabled = true;
            this.txtCurrentPass.Size = new System.Drawing.Size(480, 40);
            this.txtCurrentPass.TabIndex = 3;
            this.txtCurrentPass.UseSelectable = true;
            this.txtCurrentPass.WaterMark = "Current Password";
            this.txtCurrentPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrentPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_person_60_2;
            this.Username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Username.Location = new System.Drawing.Point(12, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(113, 56);
            this.Username.TabIndex = 2;
            this.Username.Text = "Profile";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConfirmPass
            // 
            // 
            // 
            // 
            this.txtConfirmPass.CustomButton.Image = null;
            this.txtConfirmPass.CustomButton.Location = new System.Drawing.Point(442, 2);
            this.txtConfirmPass.CustomButton.Name = "";
            this.txtConfirmPass.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtConfirmPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPass.CustomButton.TabIndex = 1;
            this.txtConfirmPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPass.CustomButton.UseSelectable = true;
            this.txtConfirmPass.CustomButton.Visible = false;
            this.txtConfirmPass.DisplayIcon = true;
            this.txtConfirmPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtConfirmPass.Icon = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_lock_30;
            this.txtConfirmPass.Lines = new string[0];
            this.txtConfirmPass.Location = new System.Drawing.Point(12, 114);
            this.txtConfirmPass.MaxLength = 32767;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '\0';
            this.txtConfirmPass.PromptText = "Confirm Password";
            this.txtConfirmPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.SelectionLength = 0;
            this.txtConfirmPass.SelectionStart = 0;
            this.txtConfirmPass.ShortcutsEnabled = true;
            this.txtConfirmPass.Size = new System.Drawing.Size(480, 40);
            this.txtConfirmPass.TabIndex = 5;
            this.txtConfirmPass.UseSelectable = true;
            this.txtConfirmPass.Visible = false;
            this.txtConfirmPass.WaterMark = "Confirm Password";
            this.txtConfirmPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(213, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.CustomButton.Image = null;
            this.txtNewPass.CustomButton.Location = new System.Drawing.Point(442, 2);
            this.txtNewPass.CustomButton.Name = "";
            this.txtNewPass.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPass.CustomButton.TabIndex = 1;
            this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPass.CustomButton.UseSelectable = true;
            this.txtNewPass.CustomButton.Visible = false;
            this.txtNewPass.DisplayIcon = true;
            this.txtNewPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNewPass.Icon = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_lock_30;
            this.txtNewPass.Lines = new string[0];
            this.txtNewPass.Location = new System.Drawing.Point(12, 68);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PromptText = "New Password";
            this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.SelectionLength = 0;
            this.txtNewPass.SelectionStart = 0;
            this.txtNewPass.ShortcutsEnabled = true;
            this.txtNewPass.Size = new System.Drawing.Size(480, 40);
            this.txtNewPass.TabIndex = 7;
            this.txtNewPass.UseSelectable = true;
            this.txtNewPass.Visible = false;
            this.txtNewPass.WaterMark = "New Password";
            this.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 202);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.btnSave);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private MetroFramework.Controls.MetroTextBox txtCurrentPass;
        private System.Windows.Forms.Button btnNext;
        private MetroFramework.Controls.MetroTextBox txtConfirmPass;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtNewPass;
    }
}