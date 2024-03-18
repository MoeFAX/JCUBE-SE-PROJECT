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
    public partial class SearchProduct : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        PosUI clerk;
        CartUI transac;
        public SearchProduct(PosUI clerk, CartUI transac)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.clerk = clerk;
            this.transac = transac;
            this.KeyPreview = true;
            LoadItemList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadItemList()
        {
            dgvItem.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.ItemID, p.InventoryCode, p.Description, b.BrandName, c.CategoryName, p.Price, p.Qty FROM tbItemList AS p INNER JOIN tbBrand AS b ON b.BrandID = p.bid INNER JOIN tbCategory AS c ON c.CategoryID = p.cid WHERE CONCAT(p.inventoryCode, p.Description, b.BrandName, c.CategoryName) LIKE '%" + metroSearch.Text+ "%' ", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvItem.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvItem.Columns["AddToCart"].Index && e.RowIndex >= 0)
            {
                Qty qty = new Qty(clerk, transac);
                qty.ProductDetails(dgvItem.Rows[e.RowIndex].Cells[1].Value.ToString(), double.Parse(dgvItem.Rows[e.RowIndex].Cells[5].Value.ToString()), transac.TransNoVal.Text, int.Parse(dgvItem.Rows[e.RowIndex].Cells[6].Value.ToString()));
                qty.ShowDialog();
            }
        }

        private void SearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void metroSearch_TextChanged(object sender, EventArgs e)
        {
            LoadItemList();
        }
    }
    }


