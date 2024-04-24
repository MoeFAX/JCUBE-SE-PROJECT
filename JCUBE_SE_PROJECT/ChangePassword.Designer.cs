using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.newPassEyeBtn = new System.Windows.Forms.PictureBox();
            this.confirmEyeBtn = new System.Windows.Forms.PictureBox();
            this.CurEyeBtn = new System.Windows.Forms.PictureBox();
            this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
            this.txtConfirmPass = new MetroFramework.Controls.MetroTextBox();
            this.txtCurrentPass = new MetroFramework.Controls.MetroTextBox();
            this.picAvatar = new System.Windows.Forms.Label();
            this.curAst = new System.Windows.Forms.Label();
            this.newAst = new System.Windows.Forms.Label();
            this.confAst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.newPassEyeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmEyeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurEyeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(288, 168);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 40);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(287, 168);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Noto Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(91, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(117, 50);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "label1";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(548, 186);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(44, 16);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "label1";
            this.lblUsername.Visible = false;
            // 
            // newPassEyeBtn
            // 
            this.newPassEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.newPassEyeBtn.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_eye_20;
            this.newPassEyeBtn.Location = new System.Drawing.Point(626, 90);
            this.newPassEyeBtn.Name = "newPassEyeBtn";
            this.newPassEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.newPassEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.newPassEyeBtn.TabIndex = 59;
            this.newPassEyeBtn.TabStop = false;
            this.newPassEyeBtn.Visible = false;
            this.newPassEyeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPassEyeBtn_MouseDown);
            this.newPassEyeBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newPassEyeBtn_MouseUp);
            // 
            // confirmEyeBtn
            // 
            this.confirmEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmEyeBtn.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_eye_20;
            this.confirmEyeBtn.Location = new System.Drawing.Point(626, 131);
            this.confirmEyeBtn.Name = "confirmEyeBtn";
            this.confirmEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.confirmEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.confirmEyeBtn.TabIndex = 58;
            this.confirmEyeBtn.TabStop = false;
            this.confirmEyeBtn.Visible = false;
            this.confirmEyeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.confirmEyeBtn_MouseDown);
            this.confirmEyeBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.confirmEyeBtn_MouseUp);
            // 
            // CurEyeBtn
            // 
            this.CurEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.CurEyeBtn.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_eye_20;
            this.CurEyeBtn.Location = new System.Drawing.Point(626, 90);
            this.CurEyeBtn.Name = "CurEyeBtn";
            this.CurEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.CurEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CurEyeBtn.TabIndex = 57;
            this.CurEyeBtn.TabStop = false;
            this.CurEyeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CurEyeBtn_MouseDown);
            this.CurEyeBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CurEyeBtn_MouseUp);
            // 
            // txtNewPass
            // 
            // 
            // 
            // 
            this.txtNewPass.CustomButton.Image = null;
            this.txtNewPass.CustomButton.Location = new System.Drawing.Point(610, 2);
            this.txtNewPass.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.CustomButton.Name = "";
            this.txtNewPass.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPass.CustomButton.TabIndex = 1;
            this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPass.CustomButton.UseSelectable = true;
            this.txtNewPass.CustomButton.Visible = false;
            this.txtNewPass.DisplayIcon = true;
            this.txtNewPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNewPass.Icon = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_password_20;
            this.txtNewPass.Lines = new string[0];
            this.txtNewPass.Location = new System.Drawing.Point(16, 84);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.MaxLength = 255;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.PromptText = "New Password";
            this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.SelectionLength = 0;
            this.txtNewPass.SelectionStart = 0;
            this.txtNewPass.ShortcutsEnabled = true;
            this.txtNewPass.Size = new System.Drawing.Size(640, 32);
            this.txtNewPass.TabIndex = 7;
            this.txtNewPass.UseSelectable = true;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.Visible = false;
            this.txtNewPass.WaterMark = "New Password";
            this.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Noto Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // txtConfirmPass
            // 
            // 
            // 
            // 
            this.txtConfirmPass.CustomButton.Image = null;
            this.txtConfirmPass.CustomButton.Location = new System.Drawing.Point(610, 2);
            this.txtConfirmPass.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPass.CustomButton.Name = "";
            this.txtConfirmPass.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtConfirmPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPass.CustomButton.TabIndex = 1;
            this.txtConfirmPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPass.CustomButton.UseSelectable = true;
            this.txtConfirmPass.CustomButton.Visible = false;
            this.txtConfirmPass.DisplayIcon = true;
            this.txtConfirmPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtConfirmPass.Icon = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_password_20;
            this.txtConfirmPass.Lines = new string[0];
            this.txtConfirmPass.Location = new System.Drawing.Point(16, 125);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPass.MaxLength = 255;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '●';
            this.txtConfirmPass.PromptText = "Confirm Password";
            this.txtConfirmPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.SelectionLength = 0;
            this.txtConfirmPass.SelectionStart = 0;
            this.txtConfirmPass.ShortcutsEnabled = true;
            this.txtConfirmPass.Size = new System.Drawing.Size(640, 32);
            this.txtConfirmPass.TabIndex = 5;
            this.txtConfirmPass.UseSelectable = true;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            this.txtConfirmPass.Visible = false;
            this.txtConfirmPass.WaterMark = "Confirm Password";
            this.txtConfirmPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPass.WaterMarkFont = new System.Drawing.Font("Noto Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // txtCurrentPass
            // 
            // 
            // 
            // 
            this.txtCurrentPass.CustomButton.Image = null;
            this.txtCurrentPass.CustomButton.Location = new System.Drawing.Point(610, 2);
            this.txtCurrentPass.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentPass.CustomButton.Name = "";
            this.txtCurrentPass.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCurrentPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurrentPass.CustomButton.TabIndex = 1;
            this.txtCurrentPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurrentPass.CustomButton.UseSelectable = true;
            this.txtCurrentPass.CustomButton.Visible = false;
            this.txtCurrentPass.DisplayIcon = true;
            this.txtCurrentPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCurrentPass.Icon = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_password_20;
            this.txtCurrentPass.Lines = new string[0];
            this.txtCurrentPass.Location = new System.Drawing.Point(16, 84);
            this.txtCurrentPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentPass.MaxLength = 255;
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '●';
            this.txtCurrentPass.PromptText = "Current Password";
            this.txtCurrentPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentPass.SelectedText = "";
            this.txtCurrentPass.SelectionLength = 0;
            this.txtCurrentPass.SelectionStart = 0;
            this.txtCurrentPass.ShortcutsEnabled = true;
            this.txtCurrentPass.Size = new System.Drawing.Size(640, 32);
            this.txtCurrentPass.TabIndex = 3;
            this.txtCurrentPass.UseSelectable = true;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            this.txtCurrentPass.WaterMark = "Current Password";
            this.txtCurrentPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrentPass.WaterMarkFont = new System.Drawing.Font("Noto Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.TextChanged += new System.EventHandler(this.txtCurrentPass_TextChanged);
            // 
            // picAvatar
            // 
            this.picAvatar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picAvatar.Image = global::JCUBE_SE_PROJECT.Properties.Resources.User_Label;
            this.picAvatar.Location = new System.Drawing.Point(16, 11);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(71, 69);
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // curAst
            // 
            this.curAst.AutoSize = true;
            this.curAst.BackColor = System.Drawing.Color.Transparent;
            this.curAst.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curAst.ForeColor = System.Drawing.Color.Red;
            this.curAst.Location = new System.Drawing.Point(655, 87);
            this.curAst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curAst.Name = "curAst";
            this.curAst.Size = new System.Drawing.Size(22, 27);
            this.curAst.TabIndex = 60;
            this.curAst.Text = "*";
            // 
            // newAst
            // 
            this.newAst.AutoSize = true;
            this.newAst.BackColor = System.Drawing.Color.Transparent;
            this.newAst.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAst.ForeColor = System.Drawing.Color.Red;
            this.newAst.Location = new System.Drawing.Point(655, 87);
            this.newAst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newAst.Name = "newAst";
            this.newAst.Size = new System.Drawing.Size(22, 27);
            this.newAst.TabIndex = 61;
            this.newAst.Text = "*";
            // 
            // confAst
            // 
            this.confAst.AutoSize = true;
            this.confAst.BackColor = System.Drawing.Color.Transparent;
            this.confAst.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confAst.ForeColor = System.Drawing.Color.Red;
            this.confAst.Location = new System.Drawing.Point(657, 127);
            this.confAst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confAst.Name = "confAst";
            this.confAst.Size = new System.Drawing.Size(22, 27);
            this.confAst.TabIndex = 62;
            this.confAst.Text = "*";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 214);
            this.Controls.Add(this.confAst);
            this.Controls.Add(this.newAst);
            this.Controls.Add(this.curAst);
            this.Controls.Add(this.newPassEyeBtn);
            this.Controls.Add(this.confirmEyeBtn);
            this.Controls.Add(this.CurEyeBtn);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePassword_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.newPassEyeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmEyeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurEyeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label picAvatar;
        private MetroFramework.Controls.MetroTextBox txtCurrentPass;
        private System.Windows.Forms.Button btnNext;
        private MetroFramework.Controls.MetroTextBox txtConfirmPass;
        private System.Windows.Forms.Button btnSave;
        private MetroFramework.Controls.MetroTextBox txtNewPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox CurEyeBtn;
        private System.Windows.Forms.PictureBox confirmEyeBtn;
        private System.Windows.Forms.PictureBox newPassEyeBtn;
        private System.Windows.Forms.Label curAst;
        private System.Windows.Forms.Label newAst;
        private System.Windows.Forms.Label confAst;
    }
}