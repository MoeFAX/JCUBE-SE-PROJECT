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
    public partial class SoldItems : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private InvUI invUIInstance;
        public SoldItems(InvUI invUIInstance)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.invUIInstance = invUIInstance;
            btnPrintSold.Enabled = false;
        }

        private void btnTopSelling_Click(object sender, EventArgs e)
        {
            TopSelling topselling = new TopSelling(invUIInstance);
            invUIInstance.openChildForm(topselling);
        }

        public void LoadSoldItems()
        {
            try
            {

                dgvSoldItems.Rows.Clear();

                DateTime startDate = dateFromSold.Value.Date;
                DateTime endDate = dateToSold.Value.Date.AddDays(1).AddSeconds(-1);

                cn.Open();
                cm = new SqlCommand("SELECT i.ItemId, c.inventoryCode, i.Description, c.srp, SUM(c.qty) AS qty, SUM(c.Discount) AS disc, SUM(c.total) AS total FROM tbCart AS c INNER JOIN tbItemList AS i ON c.inventoryCode = i.InventoryCode WHERE status LIKE 'Complete' AND date BETWEEN @StartDate AND @EndDate GROUP BY c.inventoryCode, i.ItemId, i.Description, c.srp", cn);
                cm.Parameters.AddWithValue("@StartDate", startDate);
                cm.Parameters.AddWithValue("@EndDate", endDate);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    dgvSoldItems.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), double.Parse(dr[3].ToString()).ToString("#,##0.00"), dr[4].ToString(), dr[5].ToString(), double.Parse(dr[6].ToString()).ToString("#,##0.00"));
                }

                if (!dr.HasRows)
                {
                    MessageBox.Show("No items have been sold within the specified date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dr.Close();

                cm = new SqlCommand("SELECT ISNULL(SUM(total), 0) FROM tbCart WHERE status LIKE 'Complete' AND date BETWEEN @StartDate AND @EndDate", cn);
                cm.Parameters.AddWithValue("@StartDate", startDate);
                cm.Parameters.AddWithValue("@EndDate", endDate);
                SoldTotal.Text = double.Parse(cm.ExecuteScalar().ToString()).ToString("#,##0.00");


                btnPrintSold.Enabled = dgvSoldItems.Rows.Count > 0;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadSold_Click(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        private void btnPrintSold_Click(object sender, EventArgs e)
        {
            PrintSoldItems prtSoldItems = new PrintSoldItems(invUIInstance);
            prtSoldItems.LoadSoldItems(dateFromSold.Value, dateToSold.Value);
            prtSoldItems.ShowDialog();
        }
    }
}
