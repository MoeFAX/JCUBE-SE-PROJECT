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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivesUI));
            this.btnItemList = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnItemList
            // 
            this.btnItemList.BackColor = System.Drawing.Color.Transparent;
            this.btnItemList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItemList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemList.FlatAppearance.BorderSize = 0;
            this.btnItemList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnItemList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemList.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemList.ForeColor = System.Drawing.Color.White;
            this.btnItemList.Location = new System.Drawing.Point(548, 299);
            this.btnItemList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.Size = new System.Drawing.Size(311, 134);
            this.btnItemList.TabIndex = 2;
            this.btnItemList.Text = "ITEM LIST ARCHIVES";
            this.btnItemList.UseVisualStyleBackColor = false;
            this.btnItemList.Click += new System.EventHandler(this.btnItemList_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.BackColor = System.Drawing.Color.Transparent;
            this.btnStocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStocks.FlatAppearance.BorderSize = 0;
            this.btnStocks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocks.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocks.ForeColor = System.Drawing.Color.White;
            this.btnStocks.Location = new System.Drawing.Point(71, 304);
            this.btnStocks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(303, 129);
            this.btnStocks.TabIndex = 8;
            this.btnStocks.Text = "STOCKS ARCHIVES";
            this.btnStocks.UseVisualStyleBackColor = false;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // ArchivesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 553);
            this.Controls.Add(this.btnStocks);
            this.Controls.Add(this.btnItemList);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ArchivesUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchivesUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnItemList;
        private System.Windows.Forms.Button btnStocks;
    }
}