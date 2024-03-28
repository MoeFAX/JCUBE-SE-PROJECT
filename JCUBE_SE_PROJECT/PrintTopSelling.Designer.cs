namespace JCUBE_SE_PROJECT
{
    partial class PrintTopSelling
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
            this.rvTopSelling = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvTopSelling
            // 
            this.rvTopSelling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvTopSelling.Location = new System.Drawing.Point(0, 0);
            this.rvTopSelling.Name = "rvTopSelling";
            this.rvTopSelling.ServerReport.BearerToken = null;
            this.rvTopSelling.Size = new System.Drawing.Size(733, 724);
            this.rvTopSelling.TabIndex = 0;
            // 
            // PrintTopSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 724);
            this.Controls.Add(this.rvTopSelling);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintTopSelling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top Selling Items Print Preview";
            this.Load += new System.EventHandler(this.PrintTopSelling_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvTopSelling;
    }
}