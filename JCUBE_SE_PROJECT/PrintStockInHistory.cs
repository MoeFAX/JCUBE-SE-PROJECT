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
    public partial class PrintStockInHistory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        InvUI adminuser;
        public PrintStockInHistory(InvUI aduser)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            adminuser = aduser;
        }

        private void PrintStockInHistory_Load(object sender, EventArgs e)
        {

            
            this.rvStockHistory.RefreshReport();
        }

        public void LoadPrtStockHistory(DateTime startDate, DateTime endDate)
        {
            ReportDataSource rptDtSourceStockHistory;
            try
            {
                this.rvStockHistory.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportStockInHistory.rdlc";
                this.rvStockHistory.LocalReport.DataSources.Clear();

                
                cn.Open();
                string sql = "SELECT se.RefNo, il.InventoryCode, il.Description, il.Qty, se.StockInDate, se.StockInBy, se.Status, s.SupplierName " +
                    "FROM tbStockEntry AS se " +
                    "INNER JOIN tbItemList AS il ON il.ItemID = se.ilid " +
                    "INNER JOIN tbSupplier AS s ON s.SupplierID = se.sid " +
                    "WHERE CONVERT(date, se.StockInDate) BETWEEN @StartDate AND @EndDate " +
                    "AND se.Status LIKE 'Delivered'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                DtInvList dsSto = new DtInvList();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsSto.Tables["DataStockHistory"]);
                cn.Close();
                
                ReportParameter iAdmin = new ReportParameter("iAdmin", adminuser.lblUserRole.Text);
                rvStockHistory.LocalReport.SetParameters(iAdmin);

                ReportParameter Date = new ReportParameter("Date", $"Date From: {startDate.ToShortDateString()} To: {endDate.ToShortDateString()}");
                this.rvStockHistory.LocalReport.SetParameters(Date);

                rptDtSourceStockHistory = new ReportDataSource("StockHistory", dsSto.Tables["DataStockHistory"]);
                rvStockHistory.LocalReport.DataSources.Add(rptDtSourceStockHistory);
                rvStockHistory.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rvStockHistory.ZoomMode = ZoomMode.PageWidth;
                rvStockHistory.ShowPrintButton = true;
                rvStockHistory.ShowExportButton = true;

                // Set export formats
                rvStockHistory.LocalReport.Refresh();
                rvStockHistory.LocalReport.EnableExternalImages = true;
                rvStockHistory.LocalReport.EnableHyperlinks = true;
                rvStockHistory.RefreshReport();
                var extensionList = new List<string> { "WORDOPENXML", "PDF" };
                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string format = "PDF"; // or "WORDOPENXML" for Word

                byte[] bytes = rvStockHistory.LocalReport.Render(
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

        private void PrintStockInHistory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
