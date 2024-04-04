using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCUBE_SE_PROJECT
{
    public partial class PrintStockArchives : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string _loggedInUsername;
        public PrintStockArchives(string loggedInUsername)
        {
            InitializeComponent();
            _loggedInUsername = loggedInUsername;
            cn = new SqlConnection(dbcon.myConnection());
           
        }

        private void PrintStockArchives_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void LoadPrtStockArchives()
        {
            ReportDataSource rptDtSourceStockArchives;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportStockArchives.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DtArchives dsArc = new DtArchives();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT il.Description, se.Stocks, s.SupplierName, se.Status FROM tbStockEntryArchive AS se INNER JOIN tbItemList AS il ON il.ItemID = se.ilid INNER JOIN tbSupplier AS s ON s.SupplierID = se.sid", cn);
                da.Fill(dsArc.Tables["DataStockArchives"]);
                cn.Close();
                ReportParameter iAdmin = new ReportParameter("iAdmin", _loggedInUsername);

                reportViewer1.LocalReport.SetParameters(iAdmin);


                rptDtSourceStockArchives = new ReportDataSource("DataStockArchives", dsArc.Tables["DataStockArchives"]);
                reportViewer1.LocalReport.DataSources.Add(rptDtSourceStockArchives);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.PageWidth;
                reportViewer1.ShowPrintButton = true;
                reportViewer1.ShowExportButton = true;

                // Set export formats
                reportViewer1.LocalReport.Refresh();
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.EnableHyperlinks = true;
                reportViewer1.RefreshReport();
                var extensionList = new List<string> { "WORDOPENXML", "PDF" };
                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string format = "PDF"; // or "WORDOPENXML" for Word

                byte[] bytes = reportViewer1.LocalReport.Render(
                    format,
                    null,
                    out mimeType,
                    out encoding,
                    out extension,
                    out streamIds,
                    out warnings);

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void reportViewer1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
