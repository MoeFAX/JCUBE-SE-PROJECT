using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
            LoadCriticalStocks();
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("Qty");
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf("Bar");
            chartTopSelling.Series["Item"]["PieLabelStyle"] = "Disabled";


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

       public void LoadCriticalStocks()
        {
            dgvTopQty.Rows.Clear();

            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            try
            {
                cn.Open();

                cm = new SqlCommand("SELECT ItemId, Description, Qty FROM tbItemList  WHERE (Qty <= Reorder) ORDER BY Qty DESC", cn);
                cm.Parameters.AddWithValue("@FromDate", startDate);
                cm.Parameters.AddWithValue("@ToDate", endDate);

                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    dgvTopQty.Rows.Add(dr["ItemId"].ToString(), dr["Description"].ToString(), dr["Qty"].ToString());
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


        private void btnLoad_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedChartType = comboBox2.Text;
            string selectedFilter = comboBox1.Text;

            if (selectedChartType == "Bar")
            {
                chartTopSelling.Series["Item"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chartTopSelling.Series["Item"].IsVisibleInLegend = false;
                // Reset label formatting for Bar chart
                chartTopSelling.Series["Item"].Label = ""; // Set label to empty string
            }
            else if (selectedChartType == "Pie")


            {
                chartTopSelling.Series["Item"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                chartTopSelling.Series["Item"].IsVisibleInLegend = true;

                if (selectedFilter == "Qty")
                {
                    chartTopSelling.Series["Item"]["PieLabelStyle"] = "Inside";
                    chartTopSelling.Series["Item"].Label = "";
                }
                else
                {
                    chartTopSelling.Series["Item"]["PieLabelStyle"] = "Disabled";
                    chartTopSelling.Series["Item"].Label = "#VALX | #VAL{C}";
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox1.Text;

            // Clear existing points in the series
            chartTopSelling.Series["Item"].Points.Clear();

            try
            {
                cn.Open();

                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);
                string monthName = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(month.Month);

                if (selectedFilter == "Total Sales")
                {
                    cm = new SqlCommand("SELECT TOP 5 p.Description, SUM(c.qty * c.srp) AS TotalSales " +
                                        "FROM tbCart AS c " +
                                        "INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode " +
                                        "WHERE c.status = 'Complete' " +
                                        "AND c.date >= @StartDate AND c.date <= @EndDate " +
                                        "GROUP BY p.Description " +
                                        "ORDER BY TotalSales DESC", cn);

                    chartTopSelling.Titles.Clear();
                    chartTopSelling.Titles.Add("Top 5 Selling Items By Total Sales " + "(" + monthName + ")");

                }
                else
                {
                    cm = new SqlCommand("SELECT TOP 5 p.Description, SUM(c.qty) AS TotalQty " +
                                        "FROM tbCart AS c " +
                                        "INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode " +
                                        "WHERE c.status = 'Complete' " +
                                        "AND c.date >= @StartDate AND c.date <= @EndDate " +
                                        "GROUP BY p.Description " +
                                        "ORDER BY TotalQty DESC", cn);

                    chartTopSelling.Titles.Clear();
                    chartTopSelling.Titles.Add("Top 5 Selling Items By Qty " + "(" + monthName + ")");

                }

                cm.Parameters.AddWithValue("@StartDate", startDate);
                cm.Parameters.AddWithValue("@EndDate", endDate);

                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    if (selectedFilter == "Total Sales")
                    {
                        var dataPoint = chartTopSelling.Series["Item"].Points.AddXY(dr["Description"].ToString(), Convert.ToDouble(dr["TotalSales"]));
                    }
                    else
                    {
                        var dataPoint = chartTopSelling.Series["Item"].Points.AddXY(dr["Description"].ToString(), Convert.ToDouble(dr["TotalQty"]));
                    }
                }
                chartTopSelling.Series["Item"].IsValueShownAsLabel = true;
                chartTopSelling.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartTopSelling.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                if (selectedFilter == "Total Sales" && chartTopSelling.Series["Item"].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie)
                {
                    chartTopSelling.Series["Item"]["PieLabelStyle"] = "Disabled";
                    chartTopSelling.Series["Item"].Label = "#VALX | #VAL{C}";
                }
                else
                {
                    chartTopSelling.Series["Item"]["PieLabelStyle"] = "Inside";
                    chartTopSelling.Series["Item"].Label = ""; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();

                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
        }
    }
}
