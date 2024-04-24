namespace JCUBE_SE_PROJECT
{
    partial class Discount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discount));
            this.discTotalPriceLabel = new System.Windows.Forms.Label();
            this.discPercentage = new System.Windows.Forms.Label();
            this.discAmount = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.totalPriceTB = new MetroFramework.Controls.MetroTextBox();
            this.percentageTB = new MetroFramework.Controls.MetroTextBox();
            this.amountTB = new MetroFramework.Controls.MetroTextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // discTotalPriceLabel
            // 
            this.discTotalPriceLabel.AutoSize = true;
            this.discTotalPriceLabel.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discTotalPriceLabel.Location = new System.Drawing.Point(30, 24);
            this.discTotalPriceLabel.Name = "discTotalPriceLabel";
            this.discTotalPriceLabel.Size = new System.Drawing.Size(105, 27);
            this.discTotalPriceLabel.TabIndex = 0;
            this.discTotalPriceLabel.Text = "Total Price:";
            // 
            // discPercentage
            // 
            this.discPercentage.AutoSize = true;
            this.discPercentage.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discPercentage.Location = new System.Drawing.Point(30, 64);
            this.discPercentage.Name = "discPercentage";
            this.discPercentage.Size = new System.Drawing.Size(122, 27);
            this.discPercentage.TabIndex = 1;
            this.discPercentage.Text = "Discount (%):";
            // 
            // discAmount
            // 
            this.discAmount.AutoSize = true;
            this.discAmount.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discAmount.Location = new System.Drawing.Point(30, 104);
            this.discAmount.Name = "discAmount";
            this.discAmount.Size = new System.Drawing.Size(165, 27);
            this.discAmount.TabIndex = 2;
            this.discAmount.Text = "Discount Amount:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(155)))), ((int)(((byte)(97)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Noto Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(154, 143);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(80, 33);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(29)))), ((int)(((byte)(43)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Noto Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(244, 143);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // totalPriceTB
            // 
            // 
            // 
            // 
            this.totalPriceTB.CustomButton.Image = null;
            this.totalPriceTB.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.totalPriceTB.CustomButton.Name = "";
            this.totalPriceTB.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.totalPriceTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalPriceTB.CustomButton.TabIndex = 1;
            this.totalPriceTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalPriceTB.CustomButton.UseSelectable = true;
            this.totalPriceTB.CustomButton.Visible = false;
            this.totalPriceTB.Enabled = false;
            this.totalPriceTB.Lines = new string[0];
            this.totalPriceTB.Location = new System.Drawing.Point(141, 24);
            this.totalPriceTB.MaxLength = 32767;
            this.totalPriceTB.Name = "totalPriceTB";
            this.totalPriceTB.PasswordChar = '\0';
            this.totalPriceTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalPriceTB.SelectedText = "";
            this.totalPriceTB.SelectionLength = 0;
            this.totalPriceTB.SelectionStart = 0;
            this.totalPriceTB.ShortcutsEnabled = true;
            this.totalPriceTB.Size = new System.Drawing.Size(310, 25);
            this.totalPriceTB.TabIndex = 6;
            this.totalPriceTB.UseSelectable = true;
            this.totalPriceTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalPriceTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // percentageTB
            // 
            // 
            // 
            // 
            this.percentageTB.CustomButton.Image = null;
            this.percentageTB.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.percentageTB.CustomButton.Name = "";
            this.percentageTB.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.percentageTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.percentageTB.CustomButton.TabIndex = 1;
            this.percentageTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.percentageTB.CustomButton.UseSelectable = true;
            this.percentageTB.CustomButton.Visible = false;
            this.percentageTB.Lines = new string[0];
            this.percentageTB.Location = new System.Drawing.Point(154, 64);
            this.percentageTB.MaxLength = 3;
            this.percentageTB.Name = "percentageTB";
            this.percentageTB.PasswordChar = '\0';
            this.percentageTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.percentageTB.SelectedText = "";
            this.percentageTB.SelectionLength = 0;
            this.percentageTB.SelectionStart = 0;
            this.percentageTB.ShortcutsEnabled = true;
            this.percentageTB.Size = new System.Drawing.Size(297, 25);
            this.percentageTB.TabIndex = 7;
            this.percentageTB.UseSelectable = true;
            this.percentageTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.percentageTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.percentageTB.TextChanged += new System.EventHandler(this.percentageTB_TextChanged);
            this.percentageTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.percentageTB_KeyPress);
            // 
            // amountTB
            // 
            // 
            // 
            // 
            this.amountTB.CustomButton.Image = null;
            this.amountTB.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.amountTB.CustomButton.Name = "";
            this.amountTB.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.amountTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountTB.CustomButton.TabIndex = 1;
            this.amountTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountTB.CustomButton.UseSelectable = true;
            this.amountTB.CustomButton.Visible = false;
            this.amountTB.Enabled = false;
            this.amountTB.Lines = new string[0];
            this.amountTB.Location = new System.Drawing.Point(205, 104);
            this.amountTB.MaxLength = 32767;
            this.amountTB.Name = "amountTB";
            this.amountTB.PasswordChar = '\0';
            this.amountTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountTB.SelectedText = "";
            this.amountTB.SelectionLength = 0;
            this.amountTB.SelectionStart = 0;
            this.amountTB.ShortcutsEnabled = true;
            this.amountTB.Size = new System.Drawing.Size(246, 25);
            this.amountTB.TabIndex = 8;
            this.amountTB.UseSelectable = true;
            this.amountTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amountTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(30, 150);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(25, 21);
            this.lbid.TabIndex = 9;
            this.lbid.Text = "id";
            this.lbid.Visible = false;
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 186);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.percentageTB);
            this.Controls.Add(this.totalPriceTB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.discAmount);
            this.Controls.Add(this.discPercentage);
            this.Controls.Add(this.discTotalPriceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Discount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Discount";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Discount_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label discTotalPriceLabel;
        private System.Windows.Forms.Label discPercentage;
        private System.Windows.Forms.Label discAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lbid;
        public MetroFramework.Controls.MetroTextBox totalPriceTB;
        public MetroFramework.Controls.MetroTextBox percentageTB;
        public MetroFramework.Controls.MetroTextBox amountTB;
    }
}