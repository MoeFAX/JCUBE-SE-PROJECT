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
    public partial class PosUI : Form
    {
        public CartUI clerk;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string _loggedInUsername;
        public PosUI(string loggedInUsername)
        {
            InitializeComponent();
            clerk = new CartUI(this);
            _loggedInUsername = loggedInUsername;
            cn = new SqlConnection(dbcon.myConnection());
            clerk = CartUI.GetInstance(this);
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null && activeForm.GetType() == typeof(CartUI))
            {
                activeForm.BringToFront();
            }
            else
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
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            openChildForm(clerk);
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            clerk.LoadCart();
            SettlePayment settle = new SettlePayment(clerk, _loggedInUsername);
      
            settle.txtSale.Text = clerk.TotalSales.ToString("#,##0.00");
            settle.Show();
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            DailySales dailySales = new DailySales(_loggedInUsername);
            dailySales.soldUser = lblUserRolePOS.Text;
            dailySales.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword moduleForm = new ChangePassword(this, _loggedInUsername);
            moduleForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {    
            if (clerk.dgvCart.Rows.Count > 0) //The cart should not have an item to logout
            {
                MessageBox.Show("Please cancel transaction, before logging out!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Logout Application?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                if (cn.State == ConnectionState.Open)
                {
                    LogDao log = new LogDao(cn);
                    string logAction = "LOGOUT";
                    string logType = "ACCOUNTS";
                    string logDescription = "A Sales Clerk Logged Out";
                    log.AddLogs(logAction, logType, logDescription, _loggedInUsername);
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
        private DialogResult ConfirmExit()
        {
            return MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        private void PosUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (clerk.dgvCart.Rows.Count > 0) //User can only exit when the cart is empty
                {
                    e.Cancel = true;
                    MessageBox.Show("Please cancel transaction, before you exit!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ConfirmExit() == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

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

        private void PosUI_Load(object sender, EventArgs e)
        {
            Notif();
        }
    }
}
