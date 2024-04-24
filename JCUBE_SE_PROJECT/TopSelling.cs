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

    public partial class TopSelling : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private InvUI invUIInstance;

        public TopSelling(InvUI invUIInstance)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.invUIInstance = invUIInstance;
            btnPrintTop.Enabled = false;
            int currentYear = DateTime.Now.Year;
            dateFromTopSell.MinDate = new DateTime(currentYear, 1, 1);
            dateFromTopSell.MaxDate = new DateTime(currentYear, 12, 31);
            dateToTopSell.MinDate = new DateTime(currentYear, 1, 1);
            dateToTopSell.MaxDate = new DateTime(currentYear, 12, 31);
        }
        public void LoadTopSelling()
        {

            dgvTopSell.Rows.Clear();
            cn.Open();

            //dateFrom value set to midnight
            DateTime startDate = dateFromTopSell.Value.Date;

            //dateTo value set to nextday midnight
            DateTime endDate = dateToTopSell.Value.Date.AddDays(1).AddSeconds(-1);

            if (cbTopSell.Text == "Qty")
            {
                cm = new SqlCommand("SELECT TOP 10 i.ItemId, c.inventoryCode, i.Description, ISNULL(SUM(c.qty), 0) AS qty, ISNULL(SUM(c.qty * c.srp), 0) AS total FROM tbCart AS c INNER JOIN tbItemList AS i ON c.inventoryCode = i.InventoryCode WHERE c.date BETWEEN @FromDate AND @ToDate AND c.status LIKE 'Complete' GROUP BY c.inventoryCode, i.Description, i.ItemId ORDER BY qty DESC", cn);
            }
            else if (cbTopSell.Text == "Total")
            {
                cm = new SqlCommand("SELECT TOP 10 i.ItemId, c.inventoryCode, i.Description, ISNULL(SUM(c.qty), 0) AS qty, ISNULL(SUM(c.qty * c.srp), 0) AS total FROM tbCart AS c INNER JOIN tbItemList AS i ON c.inventoryCode = i.InventoryCode WHERE c.date BETWEEN @FromDate AND @ToDate AND c.status LIKE 'Complete' GROUP BY c.inventoryCode, i.Description, i.ItemId ORDER BY total DESC", cn);
            }

            cm.Parameters.AddWithValue("@FromDate", startDate);
            cm.Parameters.AddWithValue("@ToDate", endDate);

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvTopSell.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), double.Parse(dr[4].ToString()).ToString("#,##0.00"));
            }

            if (!dr.HasRows)
            {
                MessageBox.Show("No items have been sold within the specified date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPrintTop.Enabled = false;
            }
            else
            {
                btnPrintTop.Enabled = true;
            }

            dr?.Close();
            cn?.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(cbTopSell.Text == "")
            {
                MessageBox.Show("Please select sort type from the dropdown list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTopSell.Focus();
                return;
            }
            LoadTopSelling();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SoldItems soldItemsForm = new SoldItems(invUIInstance); 
            invUIInstance.openChildForm(soldItemsForm);
            this.Close(); 
        }
        private void btnPrintTop_Click_1(object sender, EventArgs e)
        {
            PrintTopSelling prtTopSelling = new PrintTopSelling(invUIInstance);
            prtTopSelling.LoadPrintTopSelling(dateFromTopSell.Value, dateToTopSell.Value, cbTopSell.Text);
            prtTopSelling.ShowDialog();
        }
    }
}
