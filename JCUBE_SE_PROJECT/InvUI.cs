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
        private string role;

        public InvUI(string username, string role)
        {
            InitializeComponent();
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true); 
            //SetStyle(ControlStyles.ResizeRedraw, true);
            //UpdateStyles();
            loggedInUsername = username;
            this.role = role;
            customizeDesign();
            cn = new SqlConnection(dbcon.myConnection());
            MessageBox.Show("Database is Connected");

            AccountDeletion AccountAge = new AccountDeletion();
            AccountAge.AccountAge(cn);
            AccountDeletion ExpiredAccounts = new AccountDeletion();
            ExpiredAccounts.ExpiredAccounts(cn);
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
            openChildForm(new Category(loggedInUsername));
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
            openChildForm(new ItemList(loggedInUsername));
            hideSubmenu();
            
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand(loggedInUsername));
            hideSubmenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier(loggedInUsername));
            hideSubmenu();
        }

        private void btnSaleHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesHistory(this));
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
            openChildForm(new CancelledOrdersUI(this));
            hideSubmenu();
        }

        private void btnStockHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new StockInHistoryUI(this));
            hideSubmenu();
        }

        private void btnUserAcc_Click(object sender, EventArgs e)
        {
            UserAccountsUI childForm = new UserAccountsUI(loggedInUsername);
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
                cn.Open();
                if (cn.State == ConnectionState.Open)
                {
                    LogDao log = new LogDao(cn);
                    string logAction = "LOGOUT";
                    string logType = "ACCOUNTS";
                    string logDescription = role + " logged out";
                    log.AddLogs(logAction, logType, logDescription, loggedInUsername);
                    Console.WriteLine("Log added successfully. Connection is Open");
                }
                else
                {
                    Console.WriteLine("Connection is Closed. Cannot add log.");
                }
                cn.Close();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            openChildForm(new Logs(loggedInUsername));
            hideSubmenu();
        }

        private void btnArchives_Click(object sender, EventArgs e)
        {
            openChildForm(new ArchivesUI(loggedInUsername));
            hideSubmenu();
        }

        private void btnCriticalStocks_Click(object sender, EventArgs e)
        {
            openChildForm(new CriticalStocks());
            hideSubmenu();
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new DashUI());
            hideSubmenu();
        }
    }
}
