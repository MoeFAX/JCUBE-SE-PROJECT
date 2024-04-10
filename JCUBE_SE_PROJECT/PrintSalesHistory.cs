using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCUBE_SE_PROJECT
{
    public partial class PrintSalesHistory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        InvUI adminuser;
        public PrintSalesHistory(InvUI aduser)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            adminuser = aduser;
        }

        private void PrintSalesHistory_Load(object sender, EventArgs e)
        {

            this.rvSalesHistory.RefreshReport();
        }

        public void LoadPrintSalesHistory(DateTime startDate, DateTime endDate, string clerk)
        {
            try
            {
                ReportDataSource rptSH;
                this.rvSalesHistory.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportSalesHistory.rdlc";
                this.rvSalesHistory.LocalReport.DataSources.Clear();

                cn.Open();
                string query = "SELECT c.id, c.transNo, c.InventoryCode, p.Description, c.srp, c.qty, c.discount, c.total, c.clerk, c.OcNum, c.TinNum, c.mode, c.customer FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode WHERE status = 'Complete' AND date >= @DateFrom AND date < @DateTo";
                if (clerk != "All Clerk")
                {
                    query += " AND Clerk = @Clerk";
                }
                query += " ORDER BY c.transNo ASC";
                
                SqlCommand cm = new SqlCommand(query, cn);
                cm.Parameters.AddWithValue("@DateFrom", startDate.Date);
                cm.Parameters.AddWithValue("@DateTo", endDate.Date);
                if (clerk != "All Clerk")
                {
                    cm.Parameters.AddWithValue("@Clerk", clerk);
                }

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(ds.Tables["DtSalesHistory"]);
                cn.Close();

                ReportParameter shAdmin = new ReportParameter("shAdmin", "Admin: " + adminuser.lblUserRole.Text);
                rvSalesHistory.LocalReport.SetParameters(shAdmin);

                ReportParameter shClerk = new ReportParameter("shClerk", "Sold by: " + clerk);
                rvSalesHistory.LocalReport.SetParameters(shClerk);

                ReportParameter shDate = new ReportParameter("shDate", $"Date From: {startDate.ToShortDateString()} To: {endDate.ToShortDateString()}");
                rvSalesHistory.LocalReport.SetParameters(shDate);

                rptSH = new ReportDataSource("DataSet1", ds.Tables["DtSalesHistory"]);

                rvSalesHistory.LocalReport.DataSources.Add(rptSH);
                rvSalesHistory.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rvSalesHistory.ZoomMode = ZoomMode.PageWidth;
                rvSalesHistory.ShowPrintButton = true;
                rvSalesHistory.ShowExportButton = true;

                // Set export formats
                rvSalesHistory.LocalReport.Refresh();
                rvSalesHistory.LocalReport.EnableExternalImages = true;
                rvSalesHistory.LocalReport.EnableHyperlinks = true;
                rvSalesHistory.RefreshReport();
                var extensionList = new List<string> { "WORDOPENXML", "PDF" };

                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string format = "PDF"; // or "WORDOPENXML" for Word

                byte[] bytes = rvSalesHistory.LocalReport.Render(
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
