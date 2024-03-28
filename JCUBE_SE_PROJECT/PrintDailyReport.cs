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
using Microsoft.Reporting.WinForms;

namespace JCUBE_SE_PROJECT
{
    public partial class PrintDailyReport : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        CartUI cart;

        public PrintDailyReport()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
       
        }

        private void PrintDailyReport_Load(object sender, EventArgs e)
        {

            this.dailySaleRprtView.RefreshReport();
        }

        public void LoadDailyReport(string sql, string param, string clerk)
        {
            try
            {
                ReportDataSource rptDS;
                this.dailySaleRprtView.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportDailySales.rdlc";
                this.dailySaleRprtView.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand(sql, cn);
                da.Fill(ds.Tables["DtDailySales"]);
                cn.Close();
                
                ReportParameter pDate = new ReportParameter("pDate", param);
                ReportParameter pClerk = new ReportParameter("pClerk", "Clerk: " + clerk);
                
                dailySaleRprtView.LocalReport.SetParameters(pDate);
                dailySaleRprtView.LocalReport.SetParameters(pClerk);

                rptDS = new ReportDataSource("DataSet1", ds.Tables["DtDailySales"]);
                dailySaleRprtView.LocalReport.DataSources.Add(rptDS);
                dailySaleRprtView.SetDisplayMode(DisplayMode.PrintLayout);
                dailySaleRprtView.ZoomMode = ZoomMode.PageWidth;

                dailySaleRprtView.ShowPrintButton = true;
                dailySaleRprtView.ShowExportButton = true;

                // Set export formats
                dailySaleRprtView.LocalReport.Refresh();
                dailySaleRprtView.LocalReport.EnableExternalImages = true;
                dailySaleRprtView.LocalReport.EnableHyperlinks = true;
                dailySaleRprtView.RefreshReport();
                var extensionList = new List<string> { "WORDOPENXML", "PDF" };
                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string format = "PDF"; // or "WORDOPENXML" for Word

                byte[] bytes = dailySaleRprtView.LocalReport.Render(
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
