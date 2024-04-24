using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class StockInHistoryUI : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        InvUI adminuser;
        public StockInHistoryUI(InvUI aduser)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            adminuser = aduser;
            PrintStockHistory.Enabled = false;
            LoadStockHistory();
            int currentYear = DateTime.Now.Year;
            dtpStartDate.MinDate = new DateTime(currentYear, 1, 1);
            dtpStartDate.MaxDate = new DateTime(currentYear, 12, 31);
            dtpEndDate.MinDate = new DateTime(currentYear, 1, 1);
            dtpEndDate.MaxDate = new DateTime(currentYear, 12, 31);

            AccountDeletion AccountAge = new AccountDeletion();
            AccountAge.AccountAge(cn);
            AccountDeletion ExpiredAccounts = new AccountDeletion();
            ExpiredAccounts.ExpiredAccounts(cn);
        }

        public void LoadStockHistory()
        {
            dgvStockHistory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand(@"SELECT se.StockID, se.RefNo, il.InventoryCode, il.Description, se.Stocks, se.StockInDate, se.StockInBy, se.Status, s.SupplierName 
                          FROM tbStockEntry AS se 
                          INNER JOIN tbItemList AS il ON il.InventoryCode = se.ilid 
                          INNER JOIN tbSupplier AS s ON s.SupplierID = se.sid 
                          WHERE CAST(se.StockInDate AS date) BETWEEN @StartDate AND @EndDate 
                          AND se.Status LIKE 'Delivered'", cn);
            cm.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
            cm.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvStockHistory.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();

            PrintStockHistory.Enabled = dgvStockHistory.Rows.Count > 0;
            cn.Close();
        }

       

        private void PrintStockHistory_Click(object sender, EventArgs e)
        {
            PrintStockInHistory prtStock = new PrintStockInHistory(adminuser);
            prtStock.LoadPrtStockHistory(dtpStartDate.Value, dtpEndDate.Value);
            prtStock.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadStockHistory();
        }
    }
}
