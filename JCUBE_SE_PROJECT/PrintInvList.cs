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
using System.IO;

namespace JCUBE_SE_PROJECT
{
    public partial class PrintInvList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        InvUI adminuser;
        public PrintInvList(InvUI aduser)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            adminuser = aduser;
        }

        private void PrintInvList_Load(object sender, EventArgs e)
        {

            this.rvInvList.RefreshReport();
        }

        public void LoadPrtInvList()
        {
            ReportDataSource rptDtSourceInvList;
            try
            {
                this.rvInvList.LocalReport.ReportPath = Application.StartupPath + @"\Reports\ReportInvList.rdlc";
                this.rvInvList.LocalReport.DataSources.Clear();

                DtInvList dsInv = new DtInvList();
                SqlDataAdapter da = new SqlDataAdapter();
                
                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT p.InventoryCode, p.ItemCode, p.Description, b.BrandName, c.CategoryName, p.Price, p.Qty, p.Reorder FROM tbItemList AS p INNER JOIN tbBrand AS b ON b.BrandID = p.bid INNER JOIN tbCategory AS c ON c.CategoryID = p.cid", cn);
                da.Fill(dsInv.Tables["DataInvList"]);
                cn.Close();
                ReportParameter iAdmin = new ReportParameter("iAdmin", adminuser.lblUserRole.Text);

                rvInvList.LocalReport.SetParameters(iAdmin);


                rptDtSourceInvList = new ReportDataSource("DtInvList", dsInv.Tables["DataInvList"]);
                rvInvList.LocalReport.DataSources.Add(rptDtSourceInvList);
                rvInvList.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rvInvList.ZoomMode = ZoomMode.PageWidth;
                rvInvList.ShowPrintButton = true;
                rvInvList.ShowExportButton = true;

                // Set export formats
                rvInvList.LocalReport.Refresh();
                rvInvList.LocalReport.EnableExternalImages = true;
                rvInvList.LocalReport.EnableHyperlinks = true;
                rvInvList.RefreshReport();
                var extensionList = new List<string> { "WORDOPENXML", "PDF" };
                Warning[] warnings;
                string[] streamIds;
                string mimeType = string.Empty;
                string encoding = string.Empty;
                string extension = string.Empty;
                string format = "PDF"; // or "WORDOPENXML" for Word

                byte[] bytes = rvInvList.LocalReport.Render(
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

        private void PrintInvList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) 
            { 
                this.Dispose();
            }
        }
    }
}
