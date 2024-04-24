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
    public partial class SalesHistory : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public string soldUser;
        SqlDataReader dr;
        private InvUI invUIInstance;
        public SalesHistory(InvUI invUIInstance)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadClerk();
            if (comboClrk.Items.Count > 0) //Set ComboBox Clerk to Select All Clerk
            {
                comboClrk.SelectedIndex = 0;
            }
            LoadSalesHistory();
            this.invUIInstance = invUIInstance;
            if (dgvSalesHistory.Rows.Count > 0)
            {
                btnPrintSalesHistory.Enabled = true;
            }
            else btnPrintSalesHistory.Enabled = false;

            int currentYear = DateTime.Now.Year;
            dateFrom.MinDate = new DateTime(currentYear, 1, 1);
            dateFrom.MaxDate = new DateTime(currentYear, 12, 31);
            dateTo.MinDate = new DateTime(currentYear, 1, 1);
            dateTo.MaxDate = new DateTime(currentYear, 12, 31);

        }

        public void LoadClerk()
        {
            comboClrk.Items.Clear();
            comboClrk.Items.Add("All Clerk");
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbUser WHERE role LIKE 'Sales Clerk'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                comboClrk.Items.Add(dr["username"].ToString());
            }

            dr.Close();
            cn.Close();
        }

        public void LoadSalesHistory()
        {
            double total = 0;
            dgvSalesHistory.Rows.Clear();
            cn.Open();
            string query = "";

            //dateFrom value set to midnight
            DateTime startDate = dateFrom.Value.Date;

            //dateTo value set to nextday midnight
            DateTime endDate = dateTo.Value.Date.AddDays(1);

            if (comboClrk.Text == "All Clerk")
            {
                query = "SELECT c.id, c.transNo, c.InventoryCode, p.Description, c.srp, c.qty, c.discount, c.total, c.clerk, c.OcNum, c.TinNum, c.mode, c.customer FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode WHERE status = 'Complete' AND c.date >= @DateFrom AND c.date < @DateTo ORDER BY c.transNo ASC";
            }
            else
            {
                query = "SELECT c.id, c.transNo, c.InventoryCode, p.Description, c.srp, c.qty, c.discount, c.total, c.clerk, c.OcNum, c.TinNum, c.mode, c.customer FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode WHERE status = 'Complete' AND c.date >= @DateFrom AND c.date < @DateTo AND Clerk = @Clerk ORDER BY c.transNo ASC";
            }

            cm = new SqlCommand(query, cn);
            cm.Parameters.AddWithValue("@DateFrom", startDate.Date);
            cm.Parameters.AddWithValue("@DateTo", endDate.Date);

            if (comboClrk.Text != "All Clerk")
            {
                cm.Parameters.AddWithValue("@Clerk", comboClrk.Text);
            }

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                total += double.Parse(dr["total"].ToString());
                dgvSalesHistory.Rows.Add(dr["id"].ToString(), dr["transNo"].ToString(), dr["InventoryCode"].ToString(), dr["Description"].ToString(), dr["srp"].ToString(), dr["qty"].ToString(), dr["discount"].ToString(), dr["total"].ToString(), dr["clerk"].ToString(), dr["OcNum"].ToString(), dr["TinNum"].ToString(), dr["mode"].ToString(), dr["customer"].ToString());
            }
            dr.Close();
            cn.Close();
            lblTotal.Text = total.ToString("#,##0.00");
        }

        private void comboClrk_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSalesHistory();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesHistory();
            ShowNoSalesMessage();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesHistory();
            ShowNoSalesMessage() ;
        }

        private void ShowNoSalesMessage()
        {
            if (dgvSalesHistory.Rows.Count == 0)
            {
                MessageBox.Show("No sales recorded for the selected period.", "No Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPrintSalesHistory.Enabled = false;
            }
            else
            {
                btnPrintSalesHistory.Enabled = true;
            }
        }
        private void btnPrintSalesHistory_Click_1(object sender, EventArgs e)
        {
            PrintSalesHistory printSalesHistory = new PrintSalesHistory(invUIInstance);
            DateTime startDate = dateFrom.Value.Date;
            DateTime endDate = dateTo.Value.Date.AddDays(1);
            printSalesHistory.LoadPrintSalesHistory(startDate, endDate, comboClrk.Text);
            printSalesHistory.ShowDialog();
        }
    }
}
