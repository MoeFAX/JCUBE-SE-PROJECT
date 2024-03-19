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
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;


namespace JCUBE_SE_PROJECT
{
    public partial class InvUI : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
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
            SoldItems soldItemsForm = new SoldItems(this); 
            openChildForm(soldItemsForm);
            hideSubmenu();
        }
        private void btnInventoryList_Click(object sender, EventArgs e)
        {
            openChildForm(new InventoryList(this));
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
                login.Show();
            }
        }

        private void JCUBELOGOIMG_Click(object sender, EventArgs e)
        {
            openChildForm(new DashUI());
            

        }

        

        private void btnLogs_Click(object sender, EventArgs e)
        {
            openChildForm(new Logs());
            hideSubmenu();
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            openChildForm(new ArchivesUI());
            hideSubmenu();
        }

        private void btnCriticalStocks_Click(object sender, EventArgs e)
        {
            openChildForm(new CriticalStocks());
        }



        //Notification Alert for critical stocks
        public void Notif()
        {
            try
            {
                int i = 0;
                using (SqlConnection cn = new SqlConnection(dbcon.myConnection()))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand("SELECT p.ItemID, p.InventoryCode, p.ItemCode, p.Description, b.BrandName, c.CategoryName, p.Price, p.Reorder, p.Qty FROM tbItemList AS p INNER JOIN tbBrand AS b ON b.BrandID = p.bid INNER JOIN tbCategory AS c ON c.CategoryID = p.cid WHERE (p.Qty <= p.Reorder)", cn))
                    {
                        using (SqlDataReader dr = cm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                i++;
                                Alert alert = new Alert();
                                alert.lblItemCode.Text = dr["ItemCode"].ToString(); 
                                alert.showAlert(i + ". " + dr["Description"].ToString() + " - " + dr["Qty"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InvUI_Load(object sender, EventArgs e)
        {
            Notif();
            UserRole = lblUserRole.Text;
        }

        
    }
}
