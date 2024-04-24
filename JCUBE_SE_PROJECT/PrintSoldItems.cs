using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCUBE_SE_PROJECT
{
    public partial class PrintSoldItems : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        InvUI adminuser;
        public PrintSoldItems(InvUI aduser)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            adminuser = aduser;
        }

        private void PrintSoldItems_Load(object sender, EventArgs e)
        {

            this.rvSoldItems.RefreshReport();
        }

        public void LoadSoldItems(DateTime startDate, DateTime endDate)
        {
            try
            {
                ReportDataSource rptSI;
                this.rvSoldItems.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportSoldItems.rdlc";
                this.rvSoldItems.LocalReport.DataSources.Clear();
                cn.Open();
                string sql = "SELECT i.ItemID, c.inventoryCode, i.Description, c.srp, SUM(c.qty) AS qty, SUM(c.Discount) AS disc, SUM(c.total) AS total FROM tbCart AS c INNER JOIN tbItemList AS i ON c.inventoryCode = i.InventoryCode WHERE status LIKE 'Complete' AND c.date BETWEEN DATEADD(DAY, DATEDIFF(DAY, 0, @StartDate), 0) AND DATEADD(SECOND, -1, DATEADD(DAY, DATEDIFF(DAY, 0, @EndDate) + 1, 0)) GROUP BY i.ItemId, c.inventoryCode, i.Description, c.srp";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds.Tables["DtSoldItems"]);
                cn.Close();

                ReportParameter iAdmin = new ReportParameter("siAdmin", "Admin: " + adminuser.lblUserRole.Text);
                rvSoldItems.LocalReport.SetParameters(iAdmin);

                ReportParameter Date = new ReportParameter("siDate", $"Date From: {startDate.ToShortDateString()} To: {endDate.ToShortDateString()}");
                this.rvSoldItems.LocalReport.SetParameters(Date);

                rptSI = new ReportDataSource("DataSet1", ds.Tables["DtSoldItems"]);

                rvSoldItems.LocalReport.DataSources.Add(rptSI);
                rvSoldItems.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rvSoldItems.ZoomMode = ZoomMode.PageWidth;
                rvSoldItems.ShowPrintButton = true;
                rvSoldItems.ShowExportButton = true;

                // Set export formats
                rvSoldItems.LocalReport.Refresh();
                rvSoldItems.LocalReport.EnableExternalImages = true;
                rvSoldItems.LocalReport.EnableHyperlinks = true;
                rvSoldItems.RefreshReport();
                var extensionList = new List<string> { "WORDOPENXML", "PDF" };

                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string format = "PDF"; // or "WORDOPENXML" for Word

                byte[] bytes = rvSoldItems.LocalReport.Render(
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
