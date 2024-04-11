using System;
using System.Collections;
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
    public partial class DashUI : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        DateTime month = DateTime.Now;
        
        public DashUI()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadTotalDailySales();
            LoadTotalSoldToday();
            lblPendingStocks.Text = GetTotalPendingStocks().ToString();
            LoadTopQty();
            LoadTopTotal();
            string monthName = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month.Month);
            lblTop5Qty.Text = "Top 5 Selling Items in " + monthName + " " + month.ToString("yyyy") + " (Quantity)";
            lblTop5Tot.Text = "Top 5 Selling Items in " + monthName + " " + month.ToString("yyyy") + " (Total Sales)";
        }

        private void DashUI_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadTotalDailySales()
        {
            DateTime startDate = DateTime.Now.Date;
            DateTime endDate = DateTime.Now.Date.AddDays(1);
            double total = 0;

            try
            {
                cn.Open();
                cm = new SqlCommand  ("SELECT c.id, c.transNo, p.ItemCode, p.Description, c.srp, c.qty, c.discount, c.total FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode WHERE status = 'Complete' AND date >= @DateFrom AND date < @DateTo", cn);
                cm.Parameters.AddWithValue("@DateFrom", startDate);
                cm.Parameters.AddWithValue("@DateTo", endDate);

                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    total += Convert.ToDouble(dr["total"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (dr != null)
                    dr.Close();

                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }

            lblTotalDaily.Text = total.ToString("#,##0.00");
        }

        public int GetTotalPendingStocks()
        {
            int totalPendingStockQuantity = 0;

            try
            {
                cn.Open();

                cm = new SqlCommand("SELECT Count(*) FROM tbStockEntry WHERE Status = 'Pending'", cn);

                object result = cm.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalPendingStockQuantity = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }

            return totalPendingStockQuantity;
        }

        public void LoadTotalSoldToday()
        {
            DateTime startDate = DateTime.Now.Date;
            DateTime endDate = DateTime.Now.Date.AddDays(1);
            int totalQuantitySold = 0;

            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT SUM(qty) AS TotalQuantity FROM tbCart WHERE status = 'Complete' AND date >= @DateFrom AND date < @DateTo", cn);
                cm.Parameters.AddWithValue("@DateFrom", startDate);
                cm.Parameters.AddWithValue("@DateTo", endDate);

                object result = cm.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalQuantitySold = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }

            lblTotalSold.Text = totalQuantitySold.ToString();
        }

       public void LoadTopQty()
        {
            dgvTopQty.Rows.Clear();

            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            try
            {
                cn.Open();

                cm = new SqlCommand("SELECT TOP 5 i.ItemId, i.Description, ISNULL(SUM(c.qty), 0) AS qty FROM tbCart AS c INNER JOIN tbItemList AS i ON c.inventoryCode = i.InventoryCode WHERE c.date BETWEEN @FromDate AND @ToDate AND c.status LIKE 'Complete' GROUP BY i.ItemId, i.Description ORDER BY qty DESC", cn);
                cm.Parameters.AddWithValue("@FromDate", startDate);
                cm.Parameters.AddWithValue("@ToDate", endDate);

                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    dgvTopQty.Rows.Add(dr["ItemId"].ToString(), dr["Description"].ToString(), dr["qty"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }


        }

        public void LoadTopTotal()
        {
            dgvTopTotal.Rows.Clear();

            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            try
            {
                cn.Open();

                cm = new SqlCommand("SELECT TOP 5 i.ItemId, i.Description, ISNULL(SUM(c.qty * c.srp), 0) AS totalSales FROM tbCart AS c INNER JOIN tbItemList AS i ON c.inventoryCode = i.InventoryCode WHERE c.date BETWEEN @FromDate AND @ToDate AND c.status LIKE 'Complete' GROUP BY i.ItemId, i.Description ORDER BY totalSales DESC", cn);
                cm.Parameters.AddWithValue("@FromDate", startDate);
                cm.Parameters.AddWithValue("@ToDate", endDate);

                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    dgvTopTotal.Rows.Add(dr["ItemId"].ToString(), dr["Description"].ToString(), double.Parse(dr["totalSales"].ToString()).ToString("#,##0.00"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}
