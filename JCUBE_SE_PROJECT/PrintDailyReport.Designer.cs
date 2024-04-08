namespace JCUBE_SE_PROJECT
{
    partial class PrintDailyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintDailyReport));
            this.dailySaleRprtView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // dailySaleRprtView
            // 
            this.dailySaleRprtView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dailySaleRprtView.Location = new System.Drawing.Point(0, 0);
            this.dailySaleRprtView.Name = "dailySaleRprtView";
            this.dailySaleRprtView.ServerReport.BearerToken = null;
            this.dailySaleRprtView.Size = new System.Drawing.Size(733, 724);
            this.dailySaleRprtView.TabIndex = 0;
            // 
            // PrintDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 724);
            this.Controls.Add(this.dailySaleRprtView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintDailyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Sales Print Preview";
            this.Load += new System.EventHandler(this.PrintDailyReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer dailySaleRprtView;
    }
}