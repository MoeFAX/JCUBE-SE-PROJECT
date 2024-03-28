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
        public ItemList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadItemList();
        }

        public void LoadItemList()
        {
            dgvItem.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.ItemID, p.InventoryCode, p.ItemCode, p.Description, p.AcquiredCost, b.BrandName, c.CategoryName, p.Price, p.Reorder FROM tbItemList AS p INNER JOIN tbBrand AS b ON b.BrandID = p.bid INNER JOIN tbCategory AS c ON c.CategoryID = p.cid WHERE CONCAT (p.Description, p.InventoryCode, b.BrandName, c.CategoryName) LIKE '%" + txtSearch.Text + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {


                dgvItem.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddItem moduleForm = new AddItem(this);
            moduleForm.ShowDialog();
        }
        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvItem.Columns[e.ColumnIndex].Name;
                if (colName == "Archive")
                {
                    if (MessageBox.Show("Are you sure you want to archive this item?", "Archive Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Retrieve ItemID from the DataGridView
                        int itemID = Convert.ToInt32(dgvItem.Rows[e.RowIndex].Cells["ItemID"].Value);

                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tbItemListArchive(ItemID, InventoryCode, ItemCode, Description, AcquiredCost, bid, cid, Price, Qty, Reorder) SELECT ItemID, InventoryCode, ItemCode, Description, AcquiredCost, bid, cid, Price, Qty, Reorder FROM tbItemList WHERE ItemID = @ItemID DELETE FROM tbItemList WHERE ItemID = @ItemID", cn);
                        cm.Parameters.AddWithValue("@ItemID", itemID); // Add @ItemID parameter
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Item has been successfully archived.", "ARCHIVE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Remove the row from the DataGridView
                        dgvItem.Rows.RemoveAt(e.RowIndex);
                    }
                }
                else if (colName == "Edit")
                {
                    // Retrieve ItemID from the DataGridView
                    int itemID = Convert.ToInt32(dgvItem.Rows[e.RowIndex].Cells["ItemID"].Value);

                    // Open AddItem form for editing with the ItemID
                    AddItem additem = new AddItem(this);
                    additem.ItemID = itemID; // Set ItemID property
                                             // Populate fields in AddItem form
                    additem.InvCodeField.Text = dgvItem[1, e.RowIndex].Value.ToString();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadItemList();
        }

        /*
        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvItem.Columns[e.ColumnIndex].Name;
                if (colName == "Archive")
                {
                    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Null check before accessing the "ItemID" cell value
                        if (dgvItem.Rows[e.RowIndex].Cells["ItemID"].Value != null)
                        {
                            string itemID = dgvItem.Rows[e.RowIndex].Cells["ItemID"].Value.ToString();
                            cn.Open();
                            cm = new SqlCommand("DELETE FROM tbItemList WHERE ItemID = @ItemID", cn);
                            cm.Parameters.AddWithValue("@ItemID", itemID);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show("Item has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dgvItem.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
                else if (colName == "Edit")
                {
                    int itemID = Convert.ToInt32(dgvItem.Rows[e.RowIndex].Cells["ItemID"].Value);
                    AddItem additem = new AddItem(this);
                    additem.ItemID = itemID; // Set ItemID property
                    additem.InvCodeField.Text = dgvItem[1, e.RowIndex].Value.ToString();
                    additem.ItemCodeField.Text = dgvItem[2, e.RowIndex].Value.ToString();
                    additem.DescField.Text = dgvItem[3, e.RowIndex].Value.ToString();
                    additem.BrandField.Text = dgvItem[4, e.RowIndex].Value.ToString();
                    additem.CategoryField.Text = dgvItem[5, e.RowIndex].Value.ToString();
                    additem.PriceField.Text = dgvItem[6, e.RowIndex].Value.ToString();
                    additem.reorderField.Text = dgvItem[7, e.RowIndex].Value.ToString();
                    additem.SaveBtn.Enabled = true;
                    additem.ShowDialog();
                }
                LoadItemList();
            }

        }
        */
    }
}
