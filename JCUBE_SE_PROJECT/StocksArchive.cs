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
            PrintStockArchives.Enabled = false;
            LoadStocks();
        }
        public void LoadStocks()
        {
            try
            {
                dgvStockEntryArchive.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("SELECT se.StockID, il.Description, se.Stocks, s.SupplierName, se.Status, il.InventoryCode FROM tbStockEntryArchive AS se INNER JOIN tbItemListArchive AS il ON il.InventoryCode = se.ilid INNER JOIN tbSupplier AS s ON s.SupplierID = se.sid", cn);
                dr = cm.ExecuteReader();

                List<object[]> StocksArchiveData = new List<object[]>();
                while (dr.Read())
                {
                    StocksArchiveData.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() });

                }
                dr.Close();

                cm = new SqlCommand("SELECT se.StockID, il.Description, se.Stocks, s.SupplierName, se.Status, il.InventoryCode FROM tbStockEntryArchive AS se INNER JOIN tbItemList AS il ON il.InventoryCode = se.ilid INNER JOIN tbSupplier AS s ON s.SupplierID = se.sid", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    StocksArchiveData.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() });

                }
                dr.Close();

                foreach (object[] row in StocksArchiveData)
                {
                    dgvStockEntryArchive.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock archives: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the data reader and connection in the finally block
                /*if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }*/
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            PrintStockArchives.Enabled = dgvStockEntryArchive.Rows.Count > 0;
            
        }


        private int GetItemIDByDescriptionFromSQL(string invcode)
        {
            int ilid = -1;
            try
            {
                cn.Open();
                // Execute a SQL query to retrieve the ItemID based on the provided description
                cm = new SqlCommand("SELECT ItemID FROM tbItemList WHERE InventoryCode = @InventoryCode", cn);
                cm.Parameters.AddWithValue("@InventoryCode", invcode);
                var result = cm.ExecuteScalar();
                if (result != null)
                {
                    ilid = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving ItemID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return ilid;
        }

        private void PrintStockArchives_Click(object sender, EventArgs e)
        {
            PrintStockArchives prtstockarchives = new PrintStockArchives(_loggedInUsername);
            prtstockarchives.LoadPrtStockArchives();
            prtstockarchives.ShowDialog();
        }

        private void dgvStockEntryArchive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                                string logAction = "DELETE";
                                string logType = "STOCKS";
                                string logDescription = "Deleted a Stock";
                                LogDao log = new LogDao(cn);
                                log.AddLogs(logAction, logType, logDescription, _loggedInUsername);
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
                    else if (colName == "Restore")
                    {
                        string invcode = dgvStockEntryArchive.Rows[e.RowIndex].Cells[5].Value?.ToString();
                        int ilid = GetItemIDByDescriptionFromSQL(invcode);
                        if (ilid == -1)
                        {
                            //MessageBox.Show("Corresponding item not found. Please restore the item first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvStockEntryArchive.Rows[e.RowIndex].Cells["Restore"].ReadOnly = true;
                            return;
                        }
                        else
                        {
                            dgvStockEntryArchive.Rows[e.RowIndex].Cells["Restore"].ReadOnly = false;


                            if (MessageBox.Show("Are you sure you want to restore this item?", "Restore Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    int stockID = Convert.ToInt32(dgvStockEntryArchive.Rows[e.RowIndex].Cells["StockID"].Value);
                                    cn.Open();
                                    cm = new SqlCommand("INSERT INTO tbStockEntry(RefNo, ilid, sid, Stocks, Status, StockInBy, StockInDate) SELECT RefNo, ilid, sid, Stocks, Status, StockInBy, StockInDate FROM tbStockEntryArchive WHERE StockID = @StockID DELETE FROM tbStockEntryArchive WHERE StockID = @StockID", cn);
                                    cm.Parameters.AddWithValue("@StockID", stockID); // Add @StockID parameter
                                    cm.ExecuteNonQuery();
                                    string logAction = "UPDATE";
                                    string logType = "STOCKS";
                                    string logDescription = "Restored a Stock";
                                    LogDao log = new LogDao(cn);
                                    log.AddLogs(logAction, logType, logDescription, _loggedInUsername);
                                    cn.Close();
                                    MessageBox.Show("Item has been successfully restored.", "RESTORE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Remove the row from the DataGridView
                                    dgvStockEntryArchive.Rows.RemoveAt(e.RowIndex);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    LoadStocks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void dgvStockEntryArchive_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvStockEntryArchive.Columns[e.ColumnIndex].Name == "Restore")
                    {

                        string invcode = dgvStockEntryArchive.Rows[e.RowIndex].Cells[5].Value?.ToString();
                        int ilid = GetItemIDByDescriptionFromSQL(invcode);
                        if (ilid == -1)
                        {

                            e.Value = Properties.Resources.restore_gray;
                            return;
                        }
                        else
                        {
                            // Change the image of the delete icon to the default icon
                            e.Value = Properties.Resources.restore;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
