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
    public partial class PrintCancelledOrders : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        InvUI adminuser;
        public PrintCancelledOrders(InvUI aduser)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            adminuser = aduser;
        }

        private void PrintCancelledOrders_Load(object sender, EventArgs e)
        {

            this.cnclOrdrRptView.RefreshReport();
        }

        public void LoadPrtCncldOrders(DateTime startDate, DateTime endDate)
        {
            try
            {
                ReportDataSource rptCO;
                this.cnclOrdrRptView.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportCancelledOrders.rdlc";
                this.cnclOrdrRptView.LocalReport.DataSources.Clear();

                cn.Open();
                string sql = "SELECT * FROM tbCancelOrder WHERE date BETWEEN @StartDate AND @EndDate";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                cmd.Parameters.AddWithValue("@EndDate", endDate.Date);

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds.Tables["DtCancelledOrders"]);
                cn.Close();

                ReportParameter iAdmin = new ReportParameter("cAdmin", "Admin: " + adminuser.lblUserRole.Text);
                cnclOrdrRptView.LocalReport.SetParameters(iAdmin);

                ReportParameter Date = new ReportParameter("cDate", $"Date From: {startDate.ToShortDateString()} To: {endDate.ToShortDateString()}");
                this.cnclOrdrRptView.LocalReport.SetParameters(Date);

                rptCO = new ReportDataSource("DataSet1", ds.Tables["DtCancelledOrders"]);

                cnclOrdrRptView.LocalReport.DataSources.Add(rptCO);
                cnclOrdrRptView.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                cnclOrdrRptView.ZoomMode = ZoomMode.PageWidth;
                cnclOrdrRptView.ShowPrintButton = true;
                cnclOrdrRptView.ShowExportButton = true;

                // Set export formats
                cnclOrdrRptView.LocalReport.Refresh();
                cnclOrdrRptView.LocalReport.EnableExternalImages = true;
                cnclOrdrRptView.LocalReport.EnableHyperlinks = true;
                cnclOrdrRptView.RefreshReport();
                var extensionList = new List<string> { "WORDOPENXML", "PDF" };
                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string format = "PDF"; // or "WORDOPENXML" for Word

                byte[] bytes = cnclOrdrRptView.LocalReport.Render(
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
