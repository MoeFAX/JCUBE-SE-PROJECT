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
    public partial class Qty : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string inventoryCode;
        private double srp;
        private string transNo;
        private int qty;
        PosUI clerk;
        CartUI cart;
        public Qty(PosUI clerk, CartUI cart)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.clerk = clerk;
            this.cart = cart;
        }

        public void ProductDetails(string inventoryCode, double srp, string transNo, int qty)
        {
            this.inventoryCode = inventoryCode;
            this.srp = srp;
            this.transNo = transNo;
            this.qty = qty;

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (txtQty.Text != string.Empty))
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tbCart(transNo, inventoryCode, srp, qty, date, clerk)VALUES(@transNo, @inventoryCode, @srp, @qty, @date, @clerk)", cn);
                cm.Parameters.AddWithValue("@transNo", transNo);
                cm.Parameters.AddWithValue("@inventoryCode", inventoryCode);
                cm.Parameters.AddWithValue("@srp", srp);
                cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                cm.Parameters.AddWithValue("@date", DateTime.Now);
                cm.Parameters.AddWithValue("@clerk", clerk.lblUserRolePOS.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                cart.LoadCart();
                this.Dispose();
            }
        }

        private void txtQty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {
                // Only Allow digits, backspace, and enter key
                if (e.KeyChar == (char)Keys.Enter && txtQty.Text != string.Empty)
                {
                   
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbCart(transNo, inventoryCode, srp, qty, date, clerk)VALUES(@transNo, @inventoryCode, @srp, @qty, @date, @clerk)", cn);
                    cm.Parameters.AddWithValue("@transNo", transNo);
                    cm.Parameters.AddWithValue("@inventoryCode", inventoryCode);
                    cm.Parameters.AddWithValue("@srp", srp);
                    cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                    cm.Parameters.AddWithValue("@date", DateTime.Now);
                    cm.Parameters.AddWithValue("@clerk", clerk.lblUserRolePOS.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    cart.LoadCart();
                    this.Dispose();
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
