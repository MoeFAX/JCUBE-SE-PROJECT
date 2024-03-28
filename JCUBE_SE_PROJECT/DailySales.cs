using System;
using System.Collections;
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
    public partial class DailySales : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public string soldUser;
        SqlDataReader dr;
        public DailySales()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadClerk();
            if (comboClerk.Items.Count > 0) //Set ComboBox Clerk to Select All Clerk
            {
                comboClerk.SelectedIndex = 0; 
            }
            LoadSoldItems();

            if (dgvSoldItems.Rows.Count > 0)
            {
                btnPrint.Enabled = true;
            }
            else btnPrint.Enabled = false;
            
            
        }

        public void LoadClerk()
        {
            comboClerk.Items.Clear();
            comboClerk.Items.Add("All Clerk");
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbUser WHERE role LIKE 'Sales Clerk'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                comboClerk.Items.Add(dr["username"].ToString());
            }

            dr.Close();
            cn.Close();
        }
        public void LoadSoldItems()
        {
            double total = 0;
            dgvSoldItems.Rows.Clear();
            cn.Open();
            string query = "";

            //dateFrom value set to midnight
            DateTime startDate = dateFrom.Value.Date;

            //dateTo value set to nextday midnight
            DateTime endDate = dateTo.Value.Date.AddDays(1);

            if (comboClerk.Text == "All Clerk")
            {
                query = "SELECT c.id, c.transNo, p.ItemCode, p.Description, c.srp, c.qty, c.discount, c.total FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode WHERE status = 'Complete' AND date >= @DateFrom AND date < @DateTo";
            }
            else
            {
                query = "SELECT c.id, c.transNo, p.ItemCode, p.Description, c.srp, c.qty, c.discount, c.total FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode WHERE status = 'Complete' AND date >= @DateFrom AND date < @DateTo AND Clerk = @Clerk";
            }

            cm = new SqlCommand(query, cn);
            cm.Parameters.AddWithValue("@DateFrom", startDate);
            cm.Parameters.AddWithValue("@DateTo", endDate);

            if (comboClerk.Text != "All Clerk")
            {
                cm.Parameters.AddWithValue("@Clerk", comboClerk.Text);
            }

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                total += double.Parse(dr["total"].ToString());
                dgvSoldItems.Rows.Add(dr["id"].ToString(), dr["transNo"].ToString(), dr["ItemCode"].ToString(), dr["Description"].ToString(), dr["srp"].ToString(), dr["qty"].ToString(), dr["discount"].ToString(), dr["total"].ToString());
            }
            dr.Close();
            cn.Close();
            totalVal.Text = total.ToString("#,##0.00");

  


        }

        private void comboClerk_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
            ShowNoSalesMessage();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
            ShowNoSalesMessage();
        }

        private void ShowNoSalesMessage()
        {
            if (dgvSoldItems.Rows.Count == 0)
            {
                MessageBox.Show("No sales recorded for the selected period.", "No Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPrint.Enabled = false;
            }
            else
            {
                btnPrint.Enabled = true;
            }
        }

        private void DailySales_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) 
            {
                this.Dispose();
            }
        }

        private void dgvSoldItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSoldItems.Columns[e.ColumnIndex].Name;
            if (colName == "CancelOrder")
            {
                CancelOrder cancelOrder = new CancelOrder(this);
                cancelOrder.idTxtbox.Text = dgvSoldItems.Rows[e.RowIndex].Cells[0].Value.ToString();
                cancelOrder.InvTxtBox.Text = dgvSoldItems.Rows[e.RowIndex].Cells[1].Value.ToString();
                cancelOrder.itemCodeTxtbox.Text = dgvSoldItems.Rows[e.RowIndex].Cells[2].Value.ToString();
                cancelOrder.descriptionTxtBox.Text = dgvSoldItems.Rows[e.RowIndex].Cells[3].Value.ToString();
                cancelOrder.PrcTxtBox.Text = dgvSoldItems.Rows[e.RowIndex].Cells[4].Value.ToString();
                cancelOrder.QtyTxtBox.Text = dgvSoldItems.Rows[e.RowIndex].Cells[5].Value.ToString();
                cancelOrder.DiscTxtBox.Text = dgvSoldItems.Rows[e.RowIndex].Cells[6].Value.ToString();
                cancelOrder.TtlTxtBox.Text = dgvSoldItems.Rows[e.RowIndex].Cells[7].Value.ToString();
                cancelOrder.CnclByTxtBox.Text = "";
                cancelOrder.ShowDialog();

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDailyReport printDaily = new PrintDailyReport();

            DateTime startDate = dateFrom.Value.Date;
            DateTime endDate = dateTo.Value.Date.AddDays(1);

            string param = "Date From:" + startDate.ToShortDateString() + " To: " + dateTo.Value.ToShortDateString();

            if (comboClerk.Text == "All Clerk")
            {
                printDaily.LoadDailyReport("SELECT c.id, c.transNo, p.ItemCode, p.Description, c.srp, c.qty, c.discount, c.total FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode WHERE status = 'Complete' AND date >= '" + startDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND date < '" + endDate.ToString("yyyy-MM-dd HH:mm:ss") + "'", param, comboClerk.Text);
            }
            else
            {
                printDaily.LoadDailyReport("SELECT c.id, c.transNo, p.ItemCode, p.Description, c.srp, c.qty, c.discount, c.total FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode WHERE status = 'Complete' AND date >= '" + startDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND date < '" + endDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND Clerk = '" + comboClerk.Text + "'", param, comboClerk.Text);
            }

            printDaily.ShowDialog();
        }
    }
}
