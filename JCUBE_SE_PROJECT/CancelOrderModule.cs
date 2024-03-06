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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JCUBE_SE_PROJECT
{
    public partial class CancelOrderModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        CancelOrder cancelOrder;
        DailySales dailySales;
        public CancelOrderModule(CancelOrder cancelOrder)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.cancelOrder = cancelOrder;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    user = dr["username"].ToString();
                    string role = dr["role"].ToString();
                    dr.Close();
                    cn.Close();
                    if (role == "Administrator")
                    {
                        SaveCancelOrder(user);
                        if (cancelOrder.AddInvCbox.Text == "Yes")
                        {
                            dbcon.ExecuteQuery("UPDATE tbItemList SET Qty = Qty + " + cancelOrder.udQty.Value + " WHERE ItemCode= '" + cancelOrder.itemCodeTxtbox.Text + "'");
                        }
                        dbcon.ExecuteQuery("UPDATE tbItemList SET Qty = Qty + " + cancelOrder.udQty.Value + " WHERE ItemID LIKE'" + cancelOrder.idTxtbox.Text + "'");
                        dbcon.ExecuteQuery("UPDATE tbCart SET qty = qty - " + cancelOrder.udQty.Value + ", status = CASE WHEN (qty - " + cancelOrder.udQty.Value + ") <= 0 THEN 'Cancelled' ELSE status END WHERE transNo = '" + cancelOrder.InvTxtBox.Text + "'");
                        MessageBox.Show("Order successfully cancelled!", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        cancelOrder.ReloadSoldList();
                        cancelOrder.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("You do not have the necessary permissions to cancel orders. Please contact an Administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveCancelOrder(string user)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("INSERT into tbCancelOrder (transNo, itemCode, price, qty, total, date, cancelledBy, reason, action) values (@transNo, @itemCode, @price, @qty, @total, @date, @cancelledBy, @reason, @action)", cn);
                cm.Parameters.AddWithValue("@transNo", cancelOrder.InvTxtBox.Text);
                cm.Parameters.AddWithValue("@itemCode", cancelOrder.itemCodeTxtbox.Text);
                cm.Parameters.AddWithValue("@price", double.Parse(cancelOrder.PrcTxtBox.Text));
                cm.Parameters.AddWithValue("@qty", int.Parse(cancelOrder.udQty.Text));
                cm.Parameters.AddWithValue("@total", double.Parse(cancelOrder.TtlTxtBox.Text));
                cm.Parameters.AddWithValue("@date", DateTime.Now);
                cm.Parameters.AddWithValue("@cancelledBy", user);
                cm.Parameters.AddWithValue("@reason", cancelOrder.RsnTxtBox.Text);
                cm.Parameters.AddWithValue("@action", cancelOrder.AddInvCbox.Text);
                cm.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void passwordEyeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void passwordEyeBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtPassword.PasswordChar = '●';
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
