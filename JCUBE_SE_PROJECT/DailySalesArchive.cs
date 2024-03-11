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
    public partial class DailySalesArchive : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public DailySalesArchive()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadDailySales();
        }
        public void LoadDailySales()
        {
            dgvDailySalesArchive.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT c.id, c.transNo, p.ItemCode, p.Description, c.srp, c.qty, c.discount, c.total FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvDailySalesArchive.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvDailySalesArchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
