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
    public partial class PrintItemListArchives : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string _loggedInUsername;
        public PrintItemListArchives(string loggedInUsername)
        {
            InitializeComponent();
            _loggedInUsername = loggedInUsername;
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void PrintItemListArchives_Load(object sender, EventArgs e)
        {

            this.rvItemListArchives.RefreshReport();
        }

        public void LoadPrtItemListArchives()
        {
            ReportDataSource rptDtSourceItemListArchives;
            try
            {
                this.rvItemListArchives.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportItemListArchives.rdlc";
                this.rvItemListArchives.LocalReport.DataSources.Clear();

                DtArchives dsArc = new DtArchives();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT p.InventoryCode, p.ItemCode, p.Description, p.AcquiredCost, b.BrandName, c.CategoryName, p.Price, p.Reorder FROM tbItemListArchive AS p INNER JOIN tbBrand AS b ON b.BrandID = p.bid INNER JOIN tbCategory AS c ON c.CategoryID = p.cid", cn);
                da.Fill(dsArc.Tables["DataItemListArchives"]);
                cn.Close();
                ReportParameter iAdmin = new ReportParameter("iAdmin", _loggedInUsername);

                rvItemListArchives.LocalReport.SetParameters(iAdmin);


                rptDtSourceItemListArchives = new ReportDataSource("DataItemListArchives", dsArc.Tables["DataItemListArchives"]);
                rvItemListArchives.LocalReport.DataSources.Add(rptDtSourceItemListArchives);
                rvItemListArchives.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rvItemListArchives.ZoomMode = ZoomMode.PageWidth;
                rvItemListArchives.ShowPrintButton = true;
                rvItemListArchives.ShowExportButton = true;

                // Set export formats
                rvItemListArchives.LocalReport.Refresh();
                rvItemListArchives.LocalReport.EnableExternalImages = true;
                rvItemListArchives.LocalReport.EnableHyperlinks = true;
                rvItemListArchives.RefreshReport();
                var extensionList = new List<string> { "WORDOPENXML", "PDF" };
                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string format = "PDF"; // or "WORDOPENXML" for Word

                byte[] bytes = rvItemListArchives.LocalReport.Render(
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

        private void rvItemListArchives_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
