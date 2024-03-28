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
        public StockInHistoryUI()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            
        }

        public void LoadStockHistory()
        {
            dgvStockHistory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand(@"SELECT se.StockID, se.RefNo, il.InventoryCode, il.Description, il.Qty, se.StockInDate, se.StockInBy, se.Status, s.SupplierName 
                          FROM tbStockEntry AS se 
                          INNER JOIN tbItemList AS il ON il.ItemID = se.ilid 
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
            cn.Close();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            LoadStockHistory();
        }
    }
}
