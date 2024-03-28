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
    public partial class StocksArchive : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string _loggedInUsername;
        public StocksArchive(string loggedInUsername)
        {
            InitializeComponent();
            _loggedInUsername = loggedInUsername;
            cn = new SqlConnection(dbcon.myConnection());
            LoadStocks();
        }
        public void LoadStocks()
        {
            dgvStockEntryArchive.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT se.StockID, il.Description, se.Stocks, s.SupplierName, se.Status FROM tbStockEntryArchive AS se INNER JOIN tbItemList AS il ON il.ItemID = se.ilid INNER JOIN tbSupplier AS s ON s.SupplierID = se.sid", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvStockEntryArchive.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvStockEntryArchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvStockEntryArchive.Columns[e.ColumnIndex].Name;
                if (colName == "Delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        try
                        {
                            int stockID = Convert.ToInt32(dgvStockEntryArchive.Rows[e.RowIndex].Cells["StockID"].Value);

                            cn.Open();
                            cm = new SqlCommand("DELETE FROM tbStockEntryArchive WHERE StockID = @StockID", cn);
                            cm.Parameters.AddWithValue("@StockID", stockID); // Add @StockID parameter
                            cm.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Item has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Remove the row from the DataGridView
                            dgvStockEntryArchive.Rows.RemoveAt(e.RowIndex);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        // Retrieve ItemID from the DataGridView

                    }
                }
                LoadStocks();
            }
        }
    }
}
