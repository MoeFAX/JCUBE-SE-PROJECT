namespace JCUBE_SE_PROJECT
{
    partial class PrintStockInHistory
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
            this.rvStockHistory = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvStockHistory
            // 
            this.rvStockHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvStockHistory.Location = new System.Drawing.Point(0, 0);
            this.rvStockHistory.Name = "rvStockHistory";
            this.rvStockHistory.ServerReport.BearerToken = null;
            this.rvStockHistory.Size = new System.Drawing.Size(733, 724);
            this.rvStockHistory.TabIndex = 0;
            // 
            // PrintStockInHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 724);
            this.Controls.Add(this.rvStockHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintStockInHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintStockInHistory";
            this.Load += new System.EventHandler(this.PrintStockInHistory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintStockInHistory_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvStockHistory;
    }
}