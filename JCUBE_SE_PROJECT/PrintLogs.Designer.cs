namespace JCUBE_SE_PROJECT
{
    partial class PrintLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintLogs));
            this.rvPrintLogs = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvPrintLogs
            // 
            this.rvPrintLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvPrintLogs.Location = new System.Drawing.Point(0, 0);
            this.rvPrintLogs.Margin = new System.Windows.Forms.Padding(4);
            this.rvPrintLogs.Name = "rvPrintLogs";
            this.rvPrintLogs.ServerReport.BearerToken = null;
            this.rvPrintLogs.Size = new System.Drawing.Size(733, 724);
            this.rvPrintLogs.TabIndex = 0;
            this.rvPrintLogs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rvPrintLogs_KeyDown);
            // 
            // PrintLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 724);
            this.Controls.Add(this.rvPrintLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Logs";
            this.Load += new System.EventHandler(this.PrintLogs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPrintLogs;
    }
}