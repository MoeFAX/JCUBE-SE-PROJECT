using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace JCUBE_SE_PROJECT
{
    public partial class InvUI : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();

        public InvUI()
        {
            InitializeComponent();
            customizeDesign();
            cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
            MessageBox.Show("Database is Connected");
  
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void customizeDesign()
        {
            panelSubItem.Visible = false;
            panelSubRecord.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubItem.Visible == true)
                pictureBox1.Location = new Point(67, 36);
                panelSubItem.Visible = false;
            if (panelSubRecord.Visible == true)
                pictureBox1.Location = new Point(67, 36);
                panelSubRecord.Visible = false;
        }

        
        public void ShowDashboard()
        {
            DashUI frm = new DashUI();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
                pictureBox1.Location = new Point(57, 36);
            }
            else
            {
                submenu.Visible = false;
                pictureBox1.Location = new Point(67, 36);
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
            hideSubmenu();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubItem);
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            openChildForm(new StocksUI());
            hideSubmenu();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubRecord);
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            openChildForm(new ItemList());
            hideSubmenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand());
            hideSubmenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
            hideSubmenu();
        }

        private void btnSaleHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesHistory());
            hideSubmenu();
        }

        private void btnSoldItem_Click(object sender, EventArgs e)
        {
            openChildForm(new SoldItems());
            hideSubmenu();
        }
        private void btnInventoryList_Click(object sender, EventArgs e)
        {
            openChildForm(new InventoryList());
            hideSubmenu();
        }

        private void btnCancelledOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new CancelledOrdersUI());
        }

        private void btnStockHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new StockInHistoryUI());
           
        }

        private void btnUserAcc_Click(object sender, EventArgs e)
        {
            openChildForm(new UserAccountsUI());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            openChildForm(new DashUI());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }
    }
}
