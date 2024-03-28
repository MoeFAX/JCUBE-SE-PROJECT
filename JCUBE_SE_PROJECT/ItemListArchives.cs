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
    public partial class ItemListArchives : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string logUsername;
        public ItemListArchives(string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            logUsername = username;
            LoadItemList();
        }

        public void LoadItemList()
        {
            dgvItemListArchive.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.ItemID, p.InventoryCode, p.ItemCode, p.Description, p.AcquiredCost, b.BrandName, c.CategoryName, p.Price, p.Reorder FROM tbItemListArchive AS p INNER JOIN tbBrand AS b ON b.BrandID = p.bid INNER JOIN tbCategory AS c ON c.CategoryID = p.cid", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvItemListArchive.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvItemListArchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvItemListArchive.Columns[e.ColumnIndex].Name;
                if (colName == "Delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        try
                        {
                            int itemID = Convert.ToInt32(dgvItemListArchive.Rows[e.RowIndex].Cells["ItemID"].Value);

                            cn.Open();
                            cm = new SqlCommand("DELETE FROM tbItemListArchive WHERE ItemID = @ItemID", cn);
                            cm.Parameters.AddWithValue("@ItemID", itemID); // Add @ItemID parameter
                            cm.ExecuteNonQuery();
                            string logAction = "DELETE";
                            string logType = "ITEMS";
                            string logDescription = "Deleted an Item";
                            LogDao log = new LogDao(cn);
                            log.AddLogs(logAction, logType, logDescription, logUsername);
                            cn.Close();
                            MessageBox.Show("Item has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Remove the row from the DataGridView
                            dgvItemListArchive.Rows.RemoveAt(e.RowIndex);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        // Retrieve ItemID from the DataGridView

                    }
                } else if (colName == "Restore") 
                {
                    if (MessageBox.Show("Are you sure you want to restore this item?", "Restore Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int itemID = Convert.ToInt32(dgvItemListArchive.Rows[e.RowIndex].Cells["ItemID"].Value);

                            cn.Open();
                            cm = new SqlCommand("INSERT INTO tbItemList(InventoryCode, ItemCode, Description, AcquiredCost, bid, cid, Price, Qty, Reorder) SELECT InventoryCode, ItemCode, Description, AcquiredCost, bid, cid, Price, Qty, Reorder FROM tbItemListArchive WHERE ItemID = @ItemID DELETE FROM tbItemListArchive WHERE ItemID = @ItemID", cn);
                            cm.Parameters.AddWithValue("@ItemID", itemID); // Add @ItemID parameter
                            cm.ExecuteNonQuery();
                            string logAction = "UPDATE";
                            string logType = "ITEMS";
                            string logDescription = "Restored an Item";
                            LogDao log = new LogDao(cn);
                            log.AddLogs(logAction, logType, logDescription, logUsername);
                            cn.Close();
                            MessageBox.Show("Item has been successfully restored.", "RESTORE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Remove the row from the DataGridView
                            dgvItemListArchive.Rows.RemoveAt(e.RowIndex);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // Reload the item list after deletion or editing
                LoadItemList();
            }
        }

        /*private void dgvItemListArchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }*/
    }
}
