namespace JCUBE_SE_PROJECT
{
    partial class ArchivesUI
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
            this.btnItemList = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItemList
            // 
            this.btnItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnItemList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItemList.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemList.ForeColor = System.Drawing.Color.White;
            this.btnItemList.Location = new System.Drawing.Point(211, 250);
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.Size = new System.Drawing.Size(278, 169);
            this.btnItemList.TabIndex = 2;
            this.btnItemList.Text = "ITEM LIST ARCHIVES";
            this.btnItemList.UseVisualStyleBackColor = false;
            this.btnItemList.Click += new System.EventHandler(this.btnItemList_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 40);
            this.label9.TabIndex = 6;
            this.label9.Text = "ARCHIVES";
            // 
            // btnDailySales
            // 
            this.btnDailySales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnDailySales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDailySales.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySales.ForeColor = System.Drawing.Color.White;
            this.btnDailySales.Location = new System.Drawing.Point(374, 61);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Size = new System.Drawing.Size(278, 169);
            this.btnDailySales.TabIndex = 7;
            this.btnDailySales.Text = "DAILY SALES ARCHIVES";
            this.btnDailySales.UseVisualStyleBackColor = false;
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnStocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStocks.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocks.ForeColor = System.Drawing.Color.White;
            this.btnStocks.Location = new System.Drawing.Point(49, 61);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(278, 169);
            this.btnStocks.TabIndex = 8;
            this.btnStocks.Text = "STOCKS ARCHIVES";
            this.btnStocks.UseVisualStyleBackColor = false;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // ArchivesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 449);
            this.Controls.Add(this.btnStocks);
            this.Controls.Add(this.btnDailySales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnItemList);
            this.Name = "ArchivesUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchivesUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItemList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDailySales;
        private System.Windows.Forms.Button btnStocks;
    }
}