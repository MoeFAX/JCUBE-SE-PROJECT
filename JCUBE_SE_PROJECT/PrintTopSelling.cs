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
    public partial class PrintTopSelling : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        InvUI adminuser;
        public PrintTopSelling(InvUI aduser)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            adminuser = aduser;
        }

        private void PrintTopSelling_Load(object sender, EventArgs e)
        {

            this.rvTopSelling.RefreshReport();
        }

        public void LoadPrintTopSelling(DateTime startDate, DateTime endDate, string sortBy)
        {
            try
            {
                ReportDataSource rptTopSelling;
                this.rvTopSelling.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportTopSelling.rdlc";
                this.rvTopSelling.LocalReport.DataSources.Clear();
                cn.Open();
                if (sortBy == "Qty")
                {
                    cm = new SqlCommand("SELECT TOP 10 i.ItemId, c.inventoryCode, i.Description, ISNULL(SUM(c.qty), 0) AS qty, ISNULL(SUM(c.qty * c.srp), 0) AS total FROM tbCart AS c INNER JOIN tbItemList AS i ON c.inventoryCode = i.InventoryCode WHERE c.date BETWEEN DATEADD(DAY, DATEDIFF(DAY, 0, @FromDate), 0) AND DATEADD(SECOND, -1, DATEADD(DAY, DATEDIFF(DAY, 0, @ToDate) + 1, 0)) AND c.status LIKE 'Complete' GROUP BY c.inventoryCode, i.Description, i.ItemId ORDER BY qty DESC", cn);
                }
                else if (sortBy == "Total")
                {
                    cm = new SqlCommand("SELECT TOP 10 i.ItemId, c.inventoryCode, i.Description, ISNULL(SUM(c.qty), 0) AS qty, ISNULL(SUM(c.qty * c.srp), 0) AS total FROM tbCart AS c INNER JOIN tbItemList AS i ON c.inventoryCode = i.InventoryCode WHERE c.date BETWEEN DATEADD(DAY, DATEDIFF(DAY, 0, @FromDate), 0) AND DATEADD(SECOND, -1, DATEADD(DAY, DATEDIFF(DAY, 0, @ToDate) + 1, 0)) AND c.status LIKE 'Complete' GROUP BY c.inventoryCode, i.Description, i.ItemId ORDER BY total DESC", cn);
                }

                cm.Parameters.AddWithValue("@FromDate", startDate);
                cm.Parameters.AddWithValue("@ToDate", endDate);

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(ds.Tables["DtTopSelling"]);
                cn.Close();

                ReportParameter iAdmin = new ReportParameter("tsAdmin", "Admin: " + adminuser.lblUserRole.Text);
                rvTopSelling.LocalReport.SetParameters(iAdmin);

                ReportParameter tsHeader = new ReportParameter("tsHeader", "Top Selling Items By: " + sortBy);
                rvTopSelling.LocalReport.SetParameters(tsHeader);

                ReportParameter Date = new ReportParameter("tsDate", $"Date From: {startDate.ToShortDateString()} To: {endDate.ToShortDateString()}");
                this.rvTopSelling.LocalReport.SetParameters(Date);

                rptTopSelling = new ReportDataSource("DataSet1", ds.Tables["DtTopSelling"]);

                rvTopSelling.LocalReport.DataSources.Add(rptTopSelling);
                rvTopSelling.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rvTopSelling.ZoomMode = ZoomMode.PageWidth;
                rvTopSelling.ShowPrintButton = true;
                rvTopSelling.ShowExportButton = true;

                // Set export formats
                rvTopSelling.LocalReport.Refresh();
                rvTopSelling.LocalReport.EnableExternalImages = true;
                rvTopSelling.LocalReport.EnableHyperlinks = true;
                rvTopSelling.RefreshReport();
                var extensionList = new List<string> { "WORDOPENXML", "PDF" };

                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string format = "PDF"; // or "WORDOPENXML" for Word

                byte[] bytes = rvTopSelling.LocalReport.Render(
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
    }
}
