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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace JCUBE_SE_PROJECT
{
    public partial class InvUI : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        private string loggedInUsername;

        public InvUI(string username)
        {
            InitializeComponent();
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true); 
            //SetStyle(ControlStyles.ResizeRedraw, true);
            //UpdateStyles();
            loggedInUsername = username;
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

        public string UserRole { get; set; }

        private void hideSubmenu()
        {
            if (panelSubItem.Visible == true)
                JCUBELOGOIMG.Location = new Point(67, 36);
                panelSubItem.Visible = false;
            if (panelSubRecord.Visible == true)
                JCUBELOGOIMG.Location = new Point(67, 36);
                panelSubRecord.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
                JCUBELOGOIMG.Location = new Point(57, 36);
            }
            else
            {
                submenu.Visible = false;
                JCUBELOGOIMG.Location = new Point(67, 36);
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
            openChildForm(new StocksUI(loggedInUsername));
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
            UserAccountsUI childForm = new UserAccountsUI();
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.UAUserRolelbl.Text = UserRole;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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

        private void JCUBELOGOIMG_Click(object sender, EventArgs e)
        {
            openChildForm(new DashUI());
        }

        private void InvUI_Load(object sender, EventArgs e)
        {
            UserRole = lblUserRole.Text;
        }

        private void btnCriticalStocks_Click(object sender, EventArgs e)
        {
            openChildForm(new CriticalStocks());
        }
    }
}
