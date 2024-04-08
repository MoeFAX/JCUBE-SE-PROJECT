namespace JCUBE_SE_PROJECT
{
    partial class PrintCancelledOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintCancelledOrders));
            this.cnclOrdrRptView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // cnclOrdrRptView
            // 
            this.cnclOrdrRptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnclOrdrRptView.Location = new System.Drawing.Point(0, 0);
            this.cnclOrdrRptView.Name = "cnclOrdrRptView";
            this.cnclOrdrRptView.ServerReport.BearerToken = null;
            this.cnclOrdrRptView.Size = new System.Drawing.Size(733, 724);
            this.cnclOrdrRptView.TabIndex = 0;
            // 
            // PrintCancelledOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 724);
            this.Controls.Add(this.cnclOrdrRptView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintCancelledOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelled Orders Print Preview";
            this.Load += new System.EventHandler(this.PrintCancelledOrders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer cnclOrdrRptView;
    }
}