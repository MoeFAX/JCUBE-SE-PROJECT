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
            PrintItemListArchives.Enabled = false;
            LoadItemList();

            AccountDeletion AccountAge = new AccountDeletion();
            AccountAge.AccountAge(cn);
            AccountDeletion ExpiredAccounts = new AccountDeletion();
            ExpiredAccounts.ExpiredAccounts(cn);
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

            PrintItemListArchives.Enabled = dgvItemListArchive.Rows.Count > 0;
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
                            string inventorycode = Convert.ToString(dgvItemListArchive.Rows[e.RowIndex].Cells["InventoryCode"].Value);

                            cn.Open();
                            cm = new SqlCommand("DELETE FROM tbItemListArchive WHERE InventoryCode = @InventoryCode", cn);
                            cm.Parameters.AddWithValue("@InventoryCode", inventorycode); // Add @ItemID parameter
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
                            string archivedRecordID = Convert.ToString(dgvItemListArchive.Rows[e.RowIndex].Cells["InventoryCode"].Value);


                            RestoreRecord(archivedRecordID);
                            

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


        // Method to restore a record by its archivedRecordID
        private void RestoreRecord(string archivedRecordID)
        {
            try
            {
                // Open the connection
                cn.Open();

                // Insert the record into tbItemList
                cm = new SqlCommand("INSERT INTO tbItemList(InventoryCode, ItemCode, Description, AcquiredCost, bid, cid, Price, Qty, Reorder) SELECT InventoryCode, ItemCode, Description, AcquiredCost, bid, cid, Price, Qty, Reorder FROM tbItemListArchive WHERE InventoryCode = @InventoryCode; DELETE FROM tbItemListArchive WHERE InventoryCode = @InventoryCode", cn);
                cm.Parameters.AddWithValue("@InventoryCode", archivedRecordID);
                cm.ExecuteNonQuery();

               

                // Log the restoration action
                string logAction = "UPDATE";
                string logType = "ITEMS";
                string logDescription = "Restored an Item";
                LogDao log = new LogDao(cn);
                log.AddLogs(logAction, logType, logDescription, logUsername);

                // Close the connection
                cn.Close();

                MessageBox.Show("Item has been successfully restored.", "RESTORE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error restoring item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally handle the exception or log it
            }
        }

        private void PrintItemListArchives_Click(object sender, EventArgs e)
        {
            PrintItemListArchives prtitemlistarchives = new PrintItemListArchives(logUsername);
            prtitemlistarchives.LoadPrtItemListArchives();
            prtitemlistarchives.ShowDialog();
        }

     
    }
}
