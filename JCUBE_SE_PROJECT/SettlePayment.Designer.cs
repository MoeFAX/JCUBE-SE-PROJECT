namespace JCUBE_SE_PROJECT
{
    partial class SettlePayment
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
            this.txtSale = new MetroFramework.Controls.MetroTextBox();
            this.txtCash = new MetroFramework.Controls.MetroTextBox();
            this.txtChange = new MetroFramework.Controls.MetroTextBox();
            this.btn1 = new MetroFramework.Controls.MetroButton();
            this.btnEnter = new MetroFramework.Controls.MetroButton();
            this.btn2 = new MetroFramework.Controls.MetroButton();
            this.btn3 = new MetroFramework.Controls.MetroButton();
            this.btn00 = new MetroFramework.Controls.MetroButton();
            this.btn4 = new MetroFramework.Controls.MetroButton();
            this.btn5 = new MetroFramework.Controls.MetroButton();
            this.btn6 = new MetroFramework.Controls.MetroButton();
            this.btn0 = new MetroFramework.Controls.MetroButton();
            this.btn7 = new MetroFramework.Controls.MetroButton();
            this.btn8 = new MetroFramework.Controls.MetroButton();
            this.btn9 = new MetroFramework.Controls.MetroButton();
            this.btnc = new MetroFramework.Controls.MetroButton();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new MetroFramework.Controls.MetroTextBox();
            this.lblTin = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtTin = new MetroFramework.Controls.MetroTextBox();
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSale
            // 
            this.txtSale.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtSale.CustomButton.Image = null;
            this.txtSale.CustomButton.Location = new System.Drawing.Point(234, 2);
            this.txtSale.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSale.CustomButton.Name = "";
            this.txtSale.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.txtSale.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSale.CustomButton.TabIndex = 1;
            this.txtSale.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSale.CustomButton.UseSelectable = true;
            this.txtSale.CustomButton.Visible = false;
            this.txtSale.Enabled = false;
            this.txtSale.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSale.Lines = new string[0];
            this.txtSale.Location = new System.Drawing.Point(107, 8);
            this.txtSale.Margin = new System.Windows.Forms.Padding(4);
            this.txtSale.MaxLength = 32767;
            this.txtSale.Multiline = true;
            this.txtSale.Name = "txtSale";
            this.txtSale.PasswordChar = '\0';
            this.txtSale.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSale.SelectedText = "";
            this.txtSale.SelectionLength = 0;
            this.txtSale.SelectionStart = 0;
            this.txtSale.ShortcutsEnabled = true;
            this.txtSale.Size = new System.Drawing.Size(262, 30);
            this.txtSale.TabIndex = 1;
            this.txtSale.UseCustomBackColor = true;
            this.txtSale.UseSelectable = true;
            this.txtSale.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSale.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCash
            // 
            // 
            // 
            // 
            this.txtCash.CustomButton.Image = null;
            this.txtCash.CustomButton.Location = new System.Drawing.Point(234, 2);
            this.txtCash.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCash.CustomButton.Name = "";
            this.txtCash.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.txtCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCash.CustomButton.TabIndex = 1;
            this.txtCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCash.CustomButton.UseSelectable = true;
            this.txtCash.CustomButton.Visible = false;
            this.txtCash.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCash.Lines = new string[0];
            this.txtCash.Location = new System.Drawing.Point(107, 51);
            this.txtCash.Margin = new System.Windows.Forms.Padding(4);
            this.txtCash.MaxLength = 32767;
            this.txtCash.Multiline = true;
            this.txtCash.Name = "txtCash";
            this.txtCash.PasswordChar = '\0';
            this.txtCash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCash.SelectedText = "";
            this.txtCash.SelectionLength = 0;
            this.txtCash.SelectionStart = 0;
            this.txtCash.ShortcutsEnabled = true;
            this.txtCash.ShowClearButton = true;
            this.txtCash.Size = new System.Drawing.Size(262, 30);
            this.txtCash.TabIndex = 0;
            this.txtCash.UseSelectable = true;
            this.txtCash.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCash.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.txtChange.CustomButton.Image = null;
            this.txtChange.CustomButton.Location = new System.Drawing.Point(234, 2);
            this.txtChange.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtChange.CustomButton.Name = "";
            this.txtChange.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.txtChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChange.CustomButton.TabIndex = 1;
            this.txtChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChange.CustomButton.UseSelectable = true;
            this.txtChange.CustomButton.Visible = false;
            this.txtChange.Enabled = false;
            this.txtChange.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtChange.Lines = new string[0];
            this.txtChange.Location = new System.Drawing.Point(107, 94);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4);
            this.txtChange.MaxLength = 32767;
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChange.SelectedText = "";
            this.txtChange.SelectionLength = 0;
            this.txtChange.SelectionStart = 0;
            this.txtChange.ShortcutsEnabled = true;
            this.txtChange.Size = new System.Drawing.Size(262, 30);
            this.txtChange.TabIndex = 2;
            this.txtChange.UseCustomBackColor = true;
            this.txtChange.UseSelectable = true;
            this.txtChange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.DisplayFocus = true;
            this.btn1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1.Location = new System.Drawing.Point(16, 419);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseSelectable = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEnter.Location = new System.Drawing.Point(16, 500);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(265, 52);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseSelectable = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2.Location = new System.Drawing.Point(107, 419);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseSelectable = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.Location = new System.Drawing.Point(197, 419);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseSelectable = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn00.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn00.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn00.Location = new System.Drawing.Point(289, 419);
            this.btn00.Margin = new System.Windows.Forms.Padding(4);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(60, 60);
            this.btn00.TabIndex = 7;
            this.btn00.Text = "00";
            this.btn00.UseSelectable = true;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.DisplayFocus = true;
            this.btn4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.Location = new System.Drawing.Point(16, 338);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseSelectable = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.DisplayFocus = true;
            this.btn5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5.Location = new System.Drawing.Point(107, 338);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseSelectable = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.DisplayFocus = true;
            this.btn6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn6.Location = new System.Drawing.Point(197, 338);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseSelectable = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.DisplayFocus = true;
            this.btn0.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn0.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn0.Location = new System.Drawing.Point(289, 338);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 60);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseSelectable = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.DisplayFocus = true;
            this.btn7.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn7.Location = new System.Drawing.Point(16, 257);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseSelectable = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.DisplayFocus = true;
            this.btn8.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn8.Location = new System.Drawing.Point(107, 257);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseSelectable = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.DisplayFocus = true;
            this.btn9.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn9.Location = new System.Drawing.Point(197, 257);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseSelectable = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnc.DisplayFocus = true;
            this.btnc.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnc.Location = new System.Drawing.Point(289, 257);
            this.btnc.Margin = new System.Windows.Forms.Padding(4);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(60, 60);
            this.btnc.TabIndex = 15;
            this.btnc.Text = "C";
            this.btnc.UseSelectable = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(13, 100);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(72, 18);
            this.lblChange.TabIndex = 16;
            this.lblChange.Text = "Change:";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(13, 57);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(76, 18);
            this.lblPayment.TabIndex = 17;
            this.lblPayment.Text = "Payment:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(13, 14);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(87, 18);
            this.lblTotalPrice.TabIndex = 18;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblCustName
            // 
            this.lblCustName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(12, 134);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(87, 39);
            this.lblCustName.TabIndex = 19;
            this.lblCustName.Text = "Customer Name:";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustName
            // 
            // 
            // 
            // 
            this.txtCustName.CustomButton.Image = null;
            this.txtCustName.CustomButton.Location = new System.Drawing.Point(234, 2);
            this.txtCustName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustName.CustomButton.Name = "";
            this.txtCustName.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.txtCustName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustName.CustomButton.TabIndex = 1;
            this.txtCustName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustName.CustomButton.UseSelectable = true;
            this.txtCustName.CustomButton.Visible = false;
            this.txtCustName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCustName.Lines = new string[0];
            this.txtCustName.Location = new System.Drawing.Point(106, 138);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustName.MaxLength = 32767;
            this.txtCustName.Multiline = true;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.PasswordChar = '\0';
            this.txtCustName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustName.SelectedText = "";
            this.txtCustName.SelectionLength = 0;
            this.txtCustName.SelectionStart = 0;
            this.txtCustName.ShortcutsEnabled = true;
            this.txtCustName.ShowClearButton = true;
            this.txtCustName.Size = new System.Drawing.Size(262, 30);
            this.txtCustName.TabIndex = 20;
            this.txtCustName.UseSelectable = true;
            this.txtCustName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustName_KeyPress);
            // 
            // lblTin
            // 
            this.lblTin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTin.Location = new System.Drawing.Point(13, 173);
            this.lblTin.Name = "lblTin";
            this.lblTin.Size = new System.Drawing.Size(87, 39);
            this.lblTin.TabIndex = 21;
            this.lblTin.Text = "TIN#";
            this.lblTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMode
            // 
            this.lblMode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(12, 212);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(153, 39);
            this.lblMode.TabIndex = 22;
            this.lblMode.Text = "Mode of Payment:";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTin
            // 
            // 
            // 
            // 
            this.txtTin.CustomButton.Image = null;
            this.txtTin.CustomButton.Location = new System.Drawing.Point(234, 2);
            this.txtTin.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTin.CustomButton.Name = "";
            this.txtTin.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTin.CustomButton.TabIndex = 1;
            this.txtTin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTin.CustomButton.UseSelectable = true;
            this.txtTin.CustomButton.Visible = false;
            this.txtTin.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTin.Lines = new string[0];
            this.txtTin.Location = new System.Drawing.Point(106, 177);
            this.txtTin.Margin = new System.Windows.Forms.Padding(4);
            this.txtTin.MaxLength = 32767;
            this.txtTin.Multiline = true;
            this.txtTin.Name = "txtTin";
            this.txtTin.PasswordChar = '\0';
            this.txtTin.PromptText = "(000-000-000-000)";
            this.txtTin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTin.SelectedText = "";
            this.txtTin.SelectionLength = 0;
            this.txtTin.SelectionStart = 0;
            this.txtTin.ShortcutsEnabled = true;
            this.txtTin.ShowClearButton = true;
            this.txtTin.Size = new System.Drawing.Size(262, 30);
            this.txtTin.TabIndex = 24;
            this.txtTin.UseSelectable = true;
            this.txtTin.WaterMark = "(000-000-000-000)";
            this.txtTin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTin_KeyPress);
            // 
            // comboMode
            // 
            this.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Gcash",
            "Bank"});
            this.comboMode.Location = new System.Drawing.Point(156, 219);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(212, 24);
            this.comboMode.TabIndex = 25;
            // 
            // SettlePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 575);
            this.Controls.Add(this.comboMode);
            this.Controls.Add(this.txtTin);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblTin);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtSale);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettlePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettlePayment";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettlePayment_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn1;
        private MetroFramework.Controls.MetroButton btnEnter;
        private MetroFramework.Controls.MetroButton btn2;
        private MetroFramework.Controls.MetroButton btn3;
        private MetroFramework.Controls.MetroButton btn00;
        private MetroFramework.Controls.MetroButton btn4;
        private MetroFramework.Controls.MetroButton btn5;
        private MetroFramework.Controls.MetroButton btn6;
        private MetroFramework.Controls.MetroButton btn0;
        private MetroFramework.Controls.MetroButton btn7;
        private MetroFramework.Controls.MetroButton btn8;
        private MetroFramework.Controls.MetroButton btn9;
        private MetroFramework.Controls.MetroButton btnc;
        public MetroFramework.Controls.MetroTextBox txtSale;
        public MetroFramework.Controls.MetroTextBox txtCash;
        public MetroFramework.Controls.MetroTextBox txtChange;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblCustName;
        public MetroFramework.Controls.MetroTextBox txtCustName;
        private System.Windows.Forms.Label lblTin;
        private System.Windows.Forms.Label lblMode;
        public MetroFramework.Controls.MetroTextBox txtTin;
        private System.Windows.Forms.ComboBox comboMode;
    }
}