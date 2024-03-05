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

      

        private void txtQty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {
               
                if (e.KeyChar == (char)Keys.Enter && txtQty.Text != string.Empty)
                {
                    cm = new SqlCommand("SELECT Qty FROM tbItemList WHERE inventoryCode = @inventoryCode", cn);
                    cm.Parameters.AddWithValue("@inventoryCode", inventoryCode);
                    cn.Open();
                    int qtyOnHand = (int)cm.ExecuteScalar();

                    cm = new SqlCommand("SELECT qty FROM tbCart WHERE transNo = @transNo AND inventoryCode = @inventoryCode", cn);
                    cm.Parameters.AddWithValue("@transNo", transNo);
                    cm.Parameters.AddWithValue("@inventoryCode", inventoryCode);
                    object result = cm.ExecuteScalar();
                    int currentQty = result != null ? (int)result : 0;

                    if (int.Parse(txtQty.Text) + currentQty > qtyOnHand)
                    {
                        MessageBox.Show("Unable to proceed. Qty on hand is only " + qtyOnHand, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQty.Clear();
                        txtQty.Text = "1";
                        cn.Close();
                        return;
                    }

                    if (int.Parse(txtQty.Text) == 0)
                    {
                        MessageBox.Show("Qty cannot be 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtQty.Clear();
                        txtQty.Text = "1";
                        cn.Close();
                        return;
                    }

                    cm = new SqlCommand("UPDATE tbCart SET qty = qty + @qty WHERE transNo = @transNo AND inventoryCode = @inventoryCode", cn);
                    cm.Parameters.AddWithValue("@transNo", transNo);
                    cm.Parameters.AddWithValue("@inventoryCode", inventoryCode);
                    cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));

                    if (cm.ExecuteNonQuery() == 0)
                    {
                        // If no record was updated, insert a new record into tbCart
                        cm = new SqlCommand("INSERT INTO tbCart(transNo, inventoryCode, srp, qty, date, clerk)VALUES(@transNo, @inventoryCode, @srp, @qty, @date, @clerk)", cn);
                        cm.Parameters.AddWithValue("@transNo", transNo);
                        cm.Parameters.AddWithValue("@inventoryCode", inventoryCode);
                        cm.Parameters.AddWithValue("@srp", srp);
                        cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                        cm.Parameters.AddWithValue("@date", DateTime.Now);
                        cm.Parameters.AddWithValue("@clerk", clerk.lblUserRolePOS.Text);
                        cm.ExecuteNonQuery();
                    }

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
