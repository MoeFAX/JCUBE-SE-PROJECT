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

        // UI INITIALZATION

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
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
