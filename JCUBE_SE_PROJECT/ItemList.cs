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
    public partial class ItemList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string logUsername;
        public ItemList(string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            logUsername = username;
            LoadItemList();
            AccountDeletion AccountAge = new AccountDeletion();
            AccountAge.AccountAge(cn);
            AccountDeletion ExpiredAccounts = new AccountDeletion();
            ExpiredAccounts.ExpiredAccounts(cn);
        }

        public void LoadItemList()
        {
            dgvItem.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.ItemID, p.InventoryCode, p.ItemCode, p.Description, p.AcquiredCost, b.BrandName, c.CategoryName, p.Price, p.Reorder FROM tbItemList AS p INNER JOIN tbBrand AS b ON b.BrandID = p.bid INNER JOIN tbCategory AS c ON c.CategoryID = p.cid WHERE CONCAT (p.Description, p.ItemCode, p.InventoryCode, b.BrandName, c.CategoryName) LIKE '%" + txtSearch.Text + "%' ORDER BY p.InventoryCode ASC", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {


                dgvItem.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }


        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvItem.Columns[e.ColumnIndex].Name;
                if (colName == "Archive")
                {
                    if (MessageBox.Show("Are you sure you want to archive this item? All associated stock records to this item will also be archived.", "Archive Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Retrieve ItemID from the DataGridView
                        string inventorycode = Convert.ToString(dgvItem.Rows[e.RowIndex].Cells["InventoryCode"].Value);

                         ArchiveRecord(inventorycode);

                        // Remove the row from the DataGridView
                        dgvItem.Rows.RemoveAt(e.RowIndex);
                    }
                }
                else if (colName == "Edit")
                {
                    // Retrieve ItemID from the DataGridView
                    string inventorycode = Convert.ToString(dgvItem.Rows[e.RowIndex].Cells["InventoryCode"].Value);

                    // Open AddItem form for editing with the ItemID
                    AddItem additem = new AddItem(this, logUsername);
                    additem.ItemID = Convert.ToInt32(dgvItem[0, e.RowIndex].Value); // Set ItemID property
                                                                                    // Populate fields in AddItem form
                    additem.InvCodeField.Text = inventorycode;
                    additem.ItemCodeField.Text = dgvItem[2, e.RowIndex].Value.ToString();
                    additem.DescriptionField.Text = dgvItem[3, e.RowIndex].Value.ToString();
                    additem.AcquiredCostField.Text = dgvItem[4, e.RowIndex].Value.ToString();
                    additem.BrandField.Text = dgvItem[5, e.RowIndex].Value.ToString();
                    additem.CategoryField.Text = dgvItem[6, e.RowIndex].Value.ToString();
                    additem.PriceField.Text = dgvItem[7, e.RowIndex].Value.ToString();
                    additem.reorderField.Text = dgvItem[8, e.RowIndex].Value.ToString();
                    additem.SaveBtn.Enabled = true;
                    additem.ShowDialog();
                }
                // Reload the item list after deletion or editing
                LoadItemList();
            }
        }

        private void ArchiveRecord(string inventorycode)
        {
            try
            {
                // Open the connection
                cn.Open();


                // Archive associated stock records
                cm = new SqlCommand(@"INSERT INTO tbStockEntryArchive(StockID, RefNo, ilid, sid, Stocks, Status, StockInBy, StockInDate, InventoryCode) 
                      SELECT se.StockID, se.RefNo, se.ilid, se.sid, se.Stocks, se.Status, se.StockInBy, se.StockInDate, il.InventoryCode
                      FROM tbStockEntry AS se
                      INNER JOIN tbItemList AS il ON il.InventoryCode = se.ilid
                      WHERE il.InventoryCode = @InventoryCode", cn);
                cm.Parameters.AddWithValue("@InventoryCode", inventorycode);
                cm.ExecuteNonQuery();

                // Delete associated stock records
                cm = new SqlCommand("DELETE FROM tbStockEntry WHERE ilid = @InventoryCode", cn);
                cm.Parameters.AddWithValue("@InventoryCode", inventorycode);
                cm.ExecuteNonQuery();

                // Insert the record into tbItemListArchive
                cm = new SqlCommand("INSERT INTO tbItemListArchive(ItemID, InventoryCode, ItemCode, Description, AcquiredCost, bid, cid, Price, Qty, Reorder) SELECT ItemID, InventoryCode, ItemCode, Description, AcquiredCost, bid, cid, Price, Qty, Reorder FROM tbItemList WHERE InventoryCode = @InventoryCode", cn);
                cm.Parameters.AddWithValue("@InventoryCode", inventorycode);
                cm.ExecuteNonQuery();


                // Delete the record from tbItemList
                cm = new SqlCommand("DELETE FROM tbItemList WHERE InventoryCode = @InventoryCode", cn);
                cm.Parameters.AddWithValue("@InventoryCode", inventorycode);
                cm.ExecuteNonQuery();


                // Log the archiving action
                string logAction = "ARCHIVE";
                string logType = "ITEMS";
                string logDescription = "Archived an Item";
                LogDao log = new LogDao(cn);
                log.AddLogs(logAction, logType, logDescription, logUsername);

                // Close the connection
                cn.Close();

                MessageBox.Show("Item has been successfully archived.", "ARCHIVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error archiving item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally handle the exception or log it
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadItemList();
        }



        private void addbtn_Click(object sender, EventArgs e)
        {
            AddItem moduleForm = new AddItem(this, logUsername);
            moduleForm.ShowDialog();
        }


    }
}
