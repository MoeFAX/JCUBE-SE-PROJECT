using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCUBE_SE_PROJECT
{
    public partial class InvUI : Form
    {
        public InvUI()
        {
            InitializeComponent();
            customizeDesign();
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

        public void ShowCancelledOrders()
        {
            CancelledOrdersUI COWindow = new CancelledOrdersUI();
            COWindow.TopLevel = false;
            COWindow.Dock = DockStyle.Fill;
            COWindow.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(COWindow);
            COWindow.Show();
        }

        public void ShowStockInHistory()
        {
            StockInHistoryUI SIHWindow = new StockInHistoryUI();
            SIHWindow.TopLevel = false;
            SIHWindow.Dock = DockStyle.Fill;
            SIHWindow.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(SIHWindow);
            SIHWindow.Show();
        }

        public void ShowUserAccounts()
        {
            UserAccountsUI UAWindow = new UserAccountsUI();
            UAWindow.TopLevel = false;
            UAWindow.Dock = DockStyle.Fill;
            UAWindow.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(UAWindow);
            UAWindow.Show();
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
            hideSubmenu();
        }

        

        private void btnItem_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubItem);
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubRecord);
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSaleHistory_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSoldItem_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void btnInventoryList_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnCancelledOrder_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ShowCancelledOrders();
        }

        private void btnStockHistory_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ShowStockInHistory();
           
        }

        private void btnUserAcc_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ShowUserAccounts();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            ShowDashboard();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }
    }
}
