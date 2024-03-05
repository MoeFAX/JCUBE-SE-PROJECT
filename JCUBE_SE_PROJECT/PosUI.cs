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
    public partial class PosUI : Form
    {
        CartUI clerk;
        public PosUI()
        {
            InitializeComponent();
            clerk = new CartUI(this);
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            clerk = new CartUI(this);
            openChildForm(clerk);
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            clerk.LoadCart();
            SettlePayment settle = new SettlePayment(clerk);
            settle.txtSale.Text = clerk.TotalSales.ToString("#,##0.00");
            settle.Show();
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            DailySales moduleForm = new DailySales();
            moduleForm.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword moduleForm = new ChangePassword();
            moduleForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {           
            if (MessageBox.Show("Logout Application?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }
    }
}
