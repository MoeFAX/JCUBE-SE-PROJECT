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

    public partial class DiscountCreds : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        CartUI cart;
        private string id;
        public DiscountCreds(CartUI cart, string id)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.id = id;
            this.cart = cart;
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                cn.Open();
                string COEncryptedPassword = AESHelper.Encrypt(txtPassword.Text);
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Username field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cm = new SqlCommand("SELECT * FROM tbUser WHERE username = @username and encryptedPassword = @COEncryptedPassword", cn);
                cm.Parameters.AddWithValue("@username", txtUsername.Text);
                cm.Parameters.AddWithValue("@COEncryptedPassword", COEncryptedPassword);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    user = dr["username"].ToString();
                    string role = dr["role"].ToString();


                    if (!String.Equals(user, txtUsername.Text, StringComparison.Ordinal))
                    {
                        MessageBox.Show("Invalid Credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dr.Close();
                        cn.Close();
                        return;
                    }

                    if (!String.Equals(dr["encryptedPassword"].ToString(), COEncryptedPassword, StringComparison.Ordinal))
                    {
                        MessageBox.Show("Invalid Credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dr.Close();
                        cn.Close();
                        return;
                    }

                    dr.Close();
                    cn.Close();
                    if (role == "Administrator")
                    {
                        try
                        {
                            //Index of the selected row in the cart
                            int selectedRowIndex = cart.dgvCart.CurrentRow.Index;

                            //Get orig price by multiplying quantity and unit price
                            double originalPrice = Convert.ToDouble(cart.dgvCart.Rows[selectedRowIndex].Cells[3].Value) * Convert.ToDouble(cart.dgvCart.Rows[selectedRowIndex].Cells[4].Value);

                            //Check if the selected item has discount
                            double existingDiscount = Convert.ToDouble(cart.dgvCart.Rows[selectedRowIndex].Cells[5].Value);

                            if (existingDiscount > 0)
                            {
                                DialogResult dialogResult = MessageBox.Show("This item already have a discount. Do you want to change it?", "Existing Discount", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    Discount discount = new Discount(cart);
                                    discount.lbid.Text = id;
                                    discount.totalPriceTB.Text = originalPrice.ToString("#,##0.00");
                                    discount.ShowDialog();
                                    this.Dispose();
                                }
                            }
                            else
                            {
                                Discount discount = new Discount(cart);
                                discount.lbid.Text = id;
                                discount.totalPriceTB.Text = originalPrice.ToString("#,##0.00");
                                discount.ShowDialog();
                                this.Dispose();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            cn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Only an Administrator can add discount. Please contact an Administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                cn.Close();
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            userAst.Visible = string.IsNullOrEmpty(txtUsername.Text);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            pasAst.Visible = string.IsNullOrEmpty(txtPassword.Text);
        }

        
    }
}
