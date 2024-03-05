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
    public partial class SettlePayment : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
       private CartUI clerk;
        public SettlePayment(CartUI clerk)
        {
            InitializeComponent();
            this.clerk = clerk;
            cn = new SqlConnection(dbcon.myConnection());
            this.KeyPreview = true;
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn0.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn00.Text;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
            txtCash.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(txtChange.Text)<0) || (txtCash.Text.Equals("")))
                {
                    MessageBox.Show("Insufficient amount, Please enter the correct amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for(int i = 0; i < clerk.dgvCart.Rows.Count; i++) 
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tbItemList SET Qty = Qty - " + int.Parse(clerk.dgvCart.Rows[i].Cells[4].Value.ToString()) + "WHERE inventoryCode= '" + clerk.dgvCart.Rows[i].Cells[1].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("UPDATE tbCart SET status = 'Complete' WHERE id= '" + clerk.dgvCart.Rows[i].Cells[0].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    
                    MessageBox.Show("Payment Complete!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clerk.StartNewTransaction();
                    this.Dispose();

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        
        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = double.Parse(txtSale.Text);
                double cash = double.Parse(txtCash.Text);
                double change = cash - sale;
                txtChange.Text = change.ToString("#,##0.00");
            }
            catch (Exception)
            {
                txtChange.Text = "0.00";
            }
        }
        
        

        private void SettlePayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Dispose();
            else if (e.KeyCode == Keys.Enter) btnEnter.PerformClick();
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
