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
    public partial class printReceipt : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        CartUI cart;
        public printReceipt(CartUI cart)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.cart = cart;
        }

        private void printReceipt_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }

        public void LoadReceipt(string cash, string change, string custName, string TinNum, string mode)
        {
            ReportDataSource prtDataSource;
            try
            {
                this.reportViewer2.LocalReport.ReportPath = Application.StartupPath + @"\Reports\Receipt.rdlc";
                this.reportViewer2.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();

                cn.Open();
                da.SelectCommand = new SqlCommand("SELECT c.id, c.transNo, c.inventoryCode, c.srp, c.qty, c.Discount, c.total, c.date, c.status, c.TinNum, c.OcNum, c.mode, i.Description FROM tbCart AS c INNER JOIN tbItemList AS i ON i.InventoryCode=c.inventoryCode WHERE c.transNo LIKE '"+cart.TransNoVal.Text+"'", cn);
                da.Fill(ds.Tables["DtReceipt"]);
                cn.Close();

                ReportParameter pVatable = new ReportParameter("pVatable", cart.vatableVal.Text);
                ReportParameter pVat = new ReportParameter("pVat", cart.vatVal.Text);
                ReportParameter pDiscount = new ReportParameter("pDiscount", cart.discountVal.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", cart.SalesTotalVal.Text);
                ReportParameter pCash = new ReportParameter("pCash", cash);
                ReportParameter pChange = new ReportParameter("pChange", change);
                ReportParameter pTransaction = new ReportParameter("pTransaction", "Invoice #: " + cart.TransNoVal.Text);
                ReportParameter pClerk = new ReportParameter("pClerk", "Clerk: "+ cart.clerkLbl.Text);
                ReportParameter pCustName = new ReportParameter("pCustName", "Customer: "+ custName);
                ReportParameter pTinNum = new ReportParameter("pTinNum", "Tin #: "+ TinNum);
                ReportParameter pOcNum = new ReportParameter("pOcNum", "OC#:" + cart.lblOcNum.Text);
                ReportParameter pMode = new ReportParameter("pMode", "Mode of Payment: " + mode);

                reportViewer2.LocalReport.SetParameters(pVatable);

                reportViewer2.LocalReport.SetParameters(pVat);

                reportViewer2.LocalReport.SetParameters(pDiscount);

                reportViewer2.LocalReport.SetParameters(pTotal);

                reportViewer2.LocalReport.SetParameters(pCash);

                reportViewer2.LocalReport.SetParameters(pChange);

                reportViewer2.LocalReport.SetParameters(pTransaction);

                reportViewer2.LocalReport.SetParameters(pClerk);

                reportViewer2.LocalReport.SetParameters(pCustName);

                reportViewer2.LocalReport.SetParameters(pTinNum);

                reportViewer2.LocalReport.SetParameters(pOcNum);

                reportViewer2.LocalReport.SetParameters(pMode);

                prtDataSource = new ReportDataSource("DataSet1", ds.Tables["DtReceipt"]);
                reportViewer2.LocalReport.DataSources.Add(prtDataSource);
                reportViewer2.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer2.ZoomMode = ZoomMode.PageWidth;
               
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void printReceipt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
