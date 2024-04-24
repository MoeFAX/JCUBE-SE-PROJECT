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
    public partial class CancelOrder : Form
    {
        DailySales dailySales;
        private string logUsername;
        public CancelOrder(DailySales dailySales, string username)
        {
            InitializeComponent();
            this.dailySales = dailySales;
            logUsername = username;
          

        }

        private void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(AddInvCbox.Text != string.Empty && udQty.Value > 0 && RsnTxtBox.Text != string.Empty)
                {
                    if(int.Parse(QtyTxtBox.Text) >= udQty.Value)
                    {
                        CancelOrderModule cancelOrderModule = new CancelOrderModule(this, logUsername);
                        cancelOrderModule.txtUsername.Focus();
                        cancelOrderModule.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Cancellation quantity cannot be greater than available quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void ReloadSoldList()
        {
            dailySales.LoadSoldItems();
        }

        private void AddInvCbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddInvCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addAst.Visible = string.IsNullOrEmpty(AddInvCbox.Text);
        }

        private void udQty_ValueChanged(object sender, EventArgs e)
        {
            if (udQty.Value > 0)
            {
                cancelAst.Visible = false;
            }
            else { cancelAst.Visible = true; }
        }

        private void RsnTxtBox_TextChanged(object sender, EventArgs e)
        {
            reasonAst.Visible = string.IsNullOrEmpty(RsnTxtBox.Text);
        }
    }
}
