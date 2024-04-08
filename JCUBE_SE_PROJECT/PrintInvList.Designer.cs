namespace JCUBE_SE_PROJECT
{
    partial class PrintInvList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintInvList));
            this.rvInvList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvInvList
            // 
            this.rvInvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvInvList.Location = new System.Drawing.Point(0, 0);
            this.rvInvList.Name = "rvInvList";
            this.rvInvList.ServerReport.BearerToken = null;
            this.rvInvList.Size = new System.Drawing.Size(733, 724);
            this.rvInvList.TabIndex = 0;
            // 
            // PrintInvList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 724);
            this.Controls.Add(this.rvInvList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintInvList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Inventory List";
            this.Load += new System.EventHandler(this.PrintInvList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrintInvList_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rvInvList;
    }
}