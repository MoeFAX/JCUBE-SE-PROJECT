using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCUBE_SE_PROJECT
{
    public partial class ChangePassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        PosUI posUI;
        private string logUsername;
        public ChangePassword(PosUI posUI, string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.posUI = posUI;
            logUsername = username;
            lblUser.Text = posUI.POSNamelbl.Text;
            lblUsername.Text = posUI.lblUserRolePOS.Text;
            CurEyeBtn.Visible= true;
            this.KeyPreview = true;
            curAst.Visible= true;
            confAst.Visible= false;
            newAst.Visible= false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCurrentPass.Text))
                {
                    MessageBox.Show("Current Password field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string currentEncryptedPass = dbcon.getPassword(lblUsername.Text);

                string currentDecryptPassword = AESHelper.Decrypt(currentEncryptedPass);

                if (currentDecryptPassword != txtCurrentPass.Text) 
                {
                    MessageBox.Show("Wrong Password! Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.Equals(currentDecryptPassword, txtCurrentPass.Text, StringComparison.Ordinal))
                {
                    MessageBox.Show("Wrong Password! Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

     
                if (!string.Equals(lblUsername.Text, posUI.lblUserRolePOS.Text, StringComparison.Ordinal))
                {
                    MessageBox.Show("Wrong Username! Please try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    txtNewPass.Visible = true;
                    newPassEyeBtn.Visible = true;
                    confirmEyeBtn.Visible = true;
                    CurEyeBtn.Visible = false;
                    curAst.Visible = false;
                    txtConfirmPass.Visible = true;
                    txtCurrentPass.Visible = false;
                    btnSave.Visible = true;
                    btnNext.Visible = false;
                    confAst.Visible = true;
                    newAst.Visible = true;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNewPass.Text) || string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                MessageBox.Show("New Password and Confirm Password fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentEncryptedPass = dbcon.getPassword(lblUsername.Text);

            string currentDecryptPassword = AESHelper.Decrypt(currentEncryptedPass);
            try
            {
                cn.Open();
                if (string.IsNullOrWhiteSpace(txtNewPass.Text))
                {
                    MessageBox.Show("New Password field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtNewPass.Text == currentDecryptPassword)
                {
                    MessageBox.Show("New password cannot be the same as the current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNewPass.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!Regex.IsMatch(txtNewPass.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+=-]).{8,}$"))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtNewPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Passwords do not match, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Change Password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string NewEncryptPassword = AESHelper.Encrypt(txtNewPass.Text);
                        dbcon.ExecuteQuery("UPDATE tbUser set encryptedPassword = '" + NewEncryptPassword+ "' WHERE username ='" + lblUsername.Text + "'");
                        string logAction = "UPDATE";
                        string logType = "ACCOUNTS";
                        string logDescription = "Reset a Password";
                        LogDao log = new LogDao(cn);
                        log.AddLogs(logAction, logType, logDescription, logUsername);
                        MessageBox.Show("Password has been successfully updated.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
            finally 
            {
                cn.Close();
            }
        }

        private void CurEyeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtCurrentPass.PasswordChar = '\0';
                txtCurrentPass.UseSystemPasswordChar = false;
            }
        }

        private void CurEyeBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtCurrentPass.PasswordChar = '●';
                txtCurrentPass.UseSystemPasswordChar = true;
            }
        }

        private void confirmEyeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtConfirmPass.PasswordChar = '\0';
                txtConfirmPass.UseSystemPasswordChar = false;
            }
        }

        private void confirmEyeBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtConfirmPass.PasswordChar = '●';
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void newPassEyeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtNewPass.PasswordChar = '\0';
                txtNewPass.UseSystemPasswordChar = false;
            }
        }

        private void newPassEyeBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtNewPass.PasswordChar = '●';
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void ChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (btnNext.Visible)
                {
                    btnNext.PerformClick();
                }
                else if (btnSave.Visible)
                {
                    btnSave.PerformClick();
                }
            }

        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            newAst.Visible = string.IsNullOrEmpty(txtNewPass.Text);
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            confAst.Visible = string.IsNullOrEmpty(txtConfirmPass.Text);
        }

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {
            curAst.Visible = string.IsNullOrEmpty(txtCurrentPass.Text);
        }
    }
}
