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
    public partial class PrintLogs : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string _loggedInUsername;
        public PrintLogs(string loggedInUsername)
        {
            InitializeComponent();
            _loggedInUsername = loggedInUsername;
            cn = new SqlConnection(dbcon.myConnection());

        }
        private void PrintLogs_Load(object sender, EventArgs e)
        {
            this.rvPrintLogs.RefreshReport();
        }

        public void LoadPrtLogs(DateTime dateFrom, DateTime dateTo, string Action, string Type)
        {
            ReportDataSource rptDtSourcePrintLogs;
            try
            {
                this.rvPrintLogs.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportLogs.rdlc";
                this.rvPrintLogs.LocalReport.DataSources.Clear();

                cn.Open();
                if (string.IsNullOrEmpty(Action) && string.IsNullOrEmpty(Type))
                {
                    cm = new SqlCommand("SELECT LogID, Action, Type, Description, Username, Date FROM tbLogs WHERE CAST(Date AS date) BETWEEN @StartDate AND @EndDate", cn);
                } 
                
                else if (!string.IsNullOrEmpty(Action) && string.IsNullOrEmpty(Type))
                {
                    cm = new SqlCommand("SELECT LogID, Action, Type, Description, Username, Date FROM tbLogs WHERE Action = @Action AND CAST(Date AS date) BETWEEN @StartDate AND @EndDate", cn);
                    cm.Parameters.AddWithValue("@Action", Action);
                } 

                else if(string.IsNullOrEmpty(Action) && !string.IsNullOrEmpty(Type))
                {
                    cm = new SqlCommand("SELECT LogID, Action, Type, Description, Username, Date FROM tbLogs WHERE Type = @Type AND CAST(Date AS date) BETWEEN @StartDate AND @EndDate", cn);
                    cm.Parameters.AddWithValue("@Type", Type);
                } 

                else
                {
                    cm = new SqlCommand("SELECT LogID, Action, Type, Description, Username, Date FROM tbLogs WHERE Action = @Action AND Type = @Type AND CAST(Date AS date) BETWEEN @StartDate AND @EndDate", cn);
                    cm.Parameters.AddWithValue("@Action", Action);
                    cm.Parameters.AddWithValue("@Type", Type);
                }
                cm.Parameters.AddWithValue("@StartDate", dateFrom.Date);
                cm.Parameters.AddWithValue("@EndDate", dateTo.Date);
                DtLogs dtLogs = new DtLogs();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dtLogs.Tables["DtLogs"]);
                cn.Close();

                ReportParameter iAdmin = new ReportParameter("iAdmin", _loggedInUsername);
                rvPrintLogs.LocalReport.SetParameters(iAdmin);

                rptDtSourcePrintLogs = new ReportDataSource("DtLogs", dtLogs.Tables["DtLogs"]);
                rvPrintLogs.LocalReport.DataSources.Add(rptDtSourcePrintLogs);
                rvPrintLogs.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rvPrintLogs.ZoomMode = ZoomMode.PageWidth;
                rvPrintLogs.ShowPrintButton = true;
                rvPrintLogs.ShowExportButton = true;

                //Set export formats
                rvPrintLogs.LocalReport.Refresh();
                rvPrintLogs.LocalReport.EnableExternalImages = true;
                rvPrintLogs.LocalReport.EnableHyperlinks = true;
                rvPrintLogs.RefreshReport();
                var extensionList = new List<string> { "WORDOPENXML", "PDF" };
                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string format = "PDF";

                byte[] bytes = rvPrintLogs.LocalReport.Render(
                    format,
                    null,
                    out mimeType,
                    out encoding,
                    out extension,
                    out streamIds,
                    out warnings);

            } catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void rvPrintLogs_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
