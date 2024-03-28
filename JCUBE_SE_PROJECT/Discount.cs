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
    public partial class Discount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Discount";
        CartUI clerk;
        public Discount(CartUI clerk)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.clerk = clerk;
            this.KeyPreview = true;
            percentageTB.Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnClose.PerformClick();
            else if (e.KeyCode == Keys.Enter) btnConfirm.PerformClick();
        }

        private void percentageTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double disc = double.Parse(totalPriceTB.Text) * double.Parse(percentageTB.Text) * 0.01;
                amountTB.Text= disc.ToString("#,##0.00");

                if (double.Parse(percentageTB.Text) > 100)
                {
                    MessageBox.Show("Discount percent cannot exceed 100%.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    percentageTB.Clear();
                    return;
                }

            }
            catch (Exception)
            {
                amountTB.Text = "0.00";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(percentageTB.Text))
                {
                    MessageBox.Show("Discount percent cannot be empty.", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if percentageTB is empty
                }

                if (MessageBox.Show("Add discount? Select Yes to confirm", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tbCart SET disc_percent=@disc_percent WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@disc_percent", double.Parse(percentageTB.Text));
                    cm.Parameters.AddWithValue("@id", int.Parse(lbid.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();
                    clerk.LoadCart();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close() ;
                MessageBox.Show(ex.Message, stitle);
            }
        }

        private void percentageTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
