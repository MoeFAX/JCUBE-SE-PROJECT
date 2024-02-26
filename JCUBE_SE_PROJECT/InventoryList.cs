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
    public partial class InventoryList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public InventoryList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadItemList();
        }

        public void LoadItemList()
        {
            dgvInventory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT p.ItemID, p.InventoryCode, p.ItemCode, p.Description, b.BrandName, c.CategoryName, p.Price, p.Qty, p.Reorder FROM tbItemList AS p INNER JOIN tbBrand AS b ON b.BrandID = p.bid INNER JOIN tbCategory AS c ON c.CategoryID = p.cid", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {


                dgvInventory.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
