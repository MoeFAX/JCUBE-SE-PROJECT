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
    public partial class StocksUI : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string _loggedInUsername;
        public StocksUI(string loggedInUsername)
        {
            InitializeComponent();
            _loggedInUsername = loggedInUsername;
            cn = new SqlConnection(dbcon.myConnection());
            LoadStocks();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            StockEntry moduleForm = new StockEntry(this);
            moduleForm.StockinbyField.Text = _loggedInUsername;
            moduleForm.StatusField.SelectedItem = "Pending";
            moduleForm.ShowDialog();
        }

        public void LoadStocks()
        {
            dgvStockEntry.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT se.StockID, il.Description, se.Stocks, s.SupplierName, se.StockInDate, se.Status FROM tbStockEntry AS se INNER JOIN tbItemList AS il ON il.ItemID = se.ilid INNER JOIN tbSupplier AS s ON s.SupplierID = se.sid WHERE CAST(se.StockInDate AS date) BETWEEN @StartDate AND @EndDate", cn);
            cm.Parameters.AddWithValue("@StartDate", dtpStockStartDate.Value.Date);
            cm.Parameters.AddWithValue("@EndDate", dtpStockEndDate.Value.Date);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {


                dgvStockEntry.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateTime.Parse(dr[4].ToString()).ToShortDateString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvStockEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvStockEntry.Columns[e.ColumnIndex].Name;
                if (colName == "Delete")
                {
                    if (MessageBox.Show("Are you sure you want to archive this record?", "Archive Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       

                        string stockID = dgvStockEntry.Rows[e.RowIndex].Cells["StockID"].Value.ToString();
                        string status = dgvStockEntry.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                        if (status == "Delivered")
                        {
                            // Retrieve the current value of the stocks from the StockEntry form
                            int currentStocks = Convert.ToInt32(dgvStockEntry.Rows[e.RowIndex].Cells["Stocks"].Value);

                            // Subtract the quantity from the products table
                            using (SqlCommand updateQtyCmd = new SqlCommand("UPDATE tbItemList SET Qty = Qty - @Quantity WHERE ItemID = (SELECT ilid FROM tbStockEntry WHERE StockID = @StockID)", cn))
                            {
                                updateQtyCmd.Parameters.AddWithValue("@Quantity", currentStocks);
                                updateQtyCmd.Parameters.AddWithValue("@StockID", stockID);
                                cn.Open();
                                updateQtyCmd.ExecuteNonQuery();
                                cn.Close();
                            }
                        }
                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tbStockEntryArchive(StockID, RefNo, ilid, sid, Stocks, Status, StockInBy, StockInDate) SELECT StockID, RefNo, ilid, sid, Stocks, Status, StockInBy, StockInDate FROM tbStockEntry WHERE StockID = @StockID DELETE FROM tbStockEntry WHERE StockID = @StockID", cn);
                        cm.Parameters.AddWithValue("@StockID", stockID);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Stock Entry record has been successfully archived.", "ARCHIVE", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        dgvStockEntry.Rows.RemoveAt(e.RowIndex);
                    }
                }
                
                else if (colName == "Edit")
                {

                    //supplierModule.lblid.Text = dgvSupplier[1, e.RowIndex].Value.ToString();
                    int stockID = Convert.ToInt32(dgvStockEntry.Rows[e.RowIndex].Cells["StockID"].Value);
                    StockEntry moduleForm = new StockEntry(this);
                    moduleForm.StockID = stockID; // Set SupplierID property
                    moduleForm.ItemNameField.Text = dgvStockEntry[1, e.RowIndex].Value.ToString();
                    moduleForm.stocksField.Text = dgvStockEntry[2, e.RowIndex].Value.ToString();
                    moduleForm.SuppNameField.Text = dgvStockEntry[3, e.RowIndex].Value.ToString();
                    moduleForm.StatusField.Text = dgvStockEntry[4, e.RowIndex].Value.ToString();
                    string stockInBy = "";
                    try
                    {
                        cn.Open();
                        SqlCommand getStockInByCmd = new SqlCommand("SELECT StockInBy FROM tbStockEntry WHERE StockID = @StockID", cn);
                        getStockInByCmd.Parameters.AddWithValue("@StockID", stockID);
                        object stockInByObj = getStockInByCmd.ExecuteScalar();
                        if (stockInByObj != null)
                        {
                            stockInBy = stockInByObj.ToString();
                        }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    moduleForm.StockinbyField.Text = _loggedInUsername;
                    DateTime stockInDate = DateTime.MinValue;
                    try
                    {
                        cn.Open();
                        SqlCommand getStockInDateCmd = new SqlCommand("SELECT StockInDate FROM tbStockEntry WHERE StockID = @StockID", cn);
                        getStockInDateCmd.Parameters.AddWithValue("@StockID", stockID);
                        object stockInDateObj = getStockInDateCmd.ExecuteScalar();
                        if (stockInDateObj != null && stockInDateObj != DBNull.Value)
                        {
                            stockInDate = Convert.ToDateTime(stockInDateObj);
                        }
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    moduleForm.StockInDate.Value = stockInDate;
                    moduleForm.savebtn.Enabled = true;
                    moduleForm.ShowDialog();

                }
                LoadStocks();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadStocks();
        }
    }
}
