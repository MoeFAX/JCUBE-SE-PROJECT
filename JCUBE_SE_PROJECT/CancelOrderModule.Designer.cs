namespace JCUBE_SE_PROJECT
{
    partial class CancelOrderModule
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
            this.discountPanel1 = new System.Windows.Forms.Panel();
            this.cancelOrderLbl = new System.Windows.Forms.Label();
            this.passwordEyeBtn = new System.Windows.Forms.PictureBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.discountPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEyeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // discountPanel1
            // 
            this.discountPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.discountPanel1.Controls.Add(this.cancelOrderLbl);
            this.discountPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.discountPanel1.Location = new System.Drawing.Point(0, 0);
            this.discountPanel1.Name = "discountPanel1";
            this.discountPanel1.Size = new System.Drawing.Size(672, 42);
            this.discountPanel1.TabIndex = 5;
            // 
            // cancelOrderLbl
            // 
            this.cancelOrderLbl.AutoSize = true;
            this.cancelOrderLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderLbl.Location = new System.Drawing.Point(12, 9);
            this.cancelOrderLbl.Name = "cancelOrderLbl";
            this.cancelOrderLbl.Size = new System.Drawing.Size(143, 23);
            this.cancelOrderLbl.TabIndex = 0;
            this.cancelOrderLbl.Text = "Cancel Order";
            // 
            // passwordEyeBtn
            // 
            this.passwordEyeBtn.BackColor = System.Drawing.Color.Transparent;
            this.passwordEyeBtn.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_eye_20;
            this.passwordEyeBtn.Location = new System.Drawing.Point(626, 183);
            this.passwordEyeBtn.Name = "passwordEyeBtn";
            this.passwordEyeBtn.Size = new System.Drawing.Size(20, 20);
            this.passwordEyeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passwordEyeBtn.TabIndex = 64;
            this.passwordEyeBtn.TabStop = false;
            this.passwordEyeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordEyeBtn_MouseDown);
            this.passwordEyeBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.passwordEyeBtn_MouseUp);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(447, 2);
            this.txtUsername.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(179, 134);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Username";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(477, 32);
            this.txtUsername.TabIndex = 62;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Username";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(447, 2);
            this.txtPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(179, 177);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(477, 32);
            this.txtPassword.TabIndex = 61;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnCancelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelOrder.Location = new System.Drawing.Point(245, 226);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(192, 40);
            this.btnCancelOrder.TabIndex = 60;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picAvatar.Image = global::JCUBE_SE_PROJECT.Properties.Resources.icons8_person_60_2;
            this.picAvatar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.picAvatar.Location = new System.Drawing.Point(41, 58);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(66, 69);
            this.picAvatar.TabIndex = 59;
            this.picAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(41, 140);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(103, 21);
            this.lblUsername.TabIndex = 65;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(41, 183);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 21);
            this.lblPassword.TabIndex = 66;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelOrderModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 279);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.passwordEyeBtn);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.discountPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelOrderModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelOrderModule";
            this.discountPanel1.ResumeLayout(false);
            this.discountPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEyeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel discountPanel1;
        private System.Windows.Forms.Label cancelOrderLbl;
        private System.Windows.Forms.PictureBox passwordEyeBtn;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Label picAvatar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        public MetroFramework.Controls.MetroTextBox txtUsername;
    }
}