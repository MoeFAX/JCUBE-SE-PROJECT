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
    public partial class ResetPassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        UserAccountsUI useracc;
        private string logUsername;
        
        string _decryptedPassword = "", _encryptedPassword = "";

        public ResetPassword(UserAccountsUI user, string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            logUsername = username; 
            useracc = user;
            NPEyeBtn.MouseDown += new MouseEventHandler(NPEyeBtn_MouseDown);
            NPEyeBtn.MouseUp += new MouseEventHandler(NPEyeBtn_MouseUp);
            RTEyeBtn.MouseDown += new MouseEventHandler(RTEyeBtn_MouseDown);
            RTEyeBtn.MouseUp += new MouseEventHandler(RTEyeBtn_MouseUp);
        }

        public int AccountID
        {
            get { return AccountID; }
            set { AccountID = value; }
        }

        public void Clear()
        {
            RPNewPasswordField.Clear();
            RPRTPasswordField.Clear();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                if (string.IsNullOrWhiteSpace(RPNewPasswordField.Text) || string.IsNullOrWhiteSpace(RPRTPasswordField.Text))
                {
                    MessageBox.Show("Fields can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cn.Close();
                }
                else if (RPNewPasswordField.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                    cn.Close();
                }
                else if (!Regex.IsMatch(RPNewPasswordField.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+=-]).{8,}$"))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                    cn.Close();
                }
                else if (RPNewPasswordField.Text != RPRTPasswordField.Text)
                {
                    MessageBox.Show("Passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                    cn.Close();
                }
                else
                {
                    string RPNewEncryptedPassword = "";

                    using (SqlCommand command = new SqlCommand("UPDATE tbUser SET encryptedPassword = @encryptedPassword WHERE username = @username", cn))
                    {

                        command.Parameters.AddWithValue("@username", RPUNlbl.Text);
                        RPNewEncryptedPassword = AESHelper.Encrypt(RPNewPasswordField.Text);
                        command.Parameters.AddWithValue("@encryptedPassword", RPNewEncryptedPassword);
                        command.ExecuteNonQuery();
                        string logAction = "UPDATE";
                        string logType = "ACCOUNTS";
                        string logDescription = "Reset a Password";
                        LogDao log = new LogDao(cn);
                        log.AddLogs(logAction, logType, logDescription, logUsername);
                    }
                    cn.Close();
                    Clear();
                    MessageBox.Show("New password has been successfully saved for account: " + RPUNlbl.Text, "Save New Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    useracc.LoadUser();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        public void NPEyeBtn_MouseDown(object sender, EventArgs e)
        {
            RPNewPasswordField.PasswordChar = '\0';
            RPNewPasswordField.UseSystemPasswordChar = false;
        }

        public void NPEyeBtn_MouseUp(object sender, EventArgs e)
        {
            RPNewPasswordField.PasswordChar = '●';
            RPNewPasswordField.UseSystemPasswordChar = true;
        }
        public void RTEyeBtn_MouseDown(object sender, EventArgs e)
        {
            RPRTPasswordField.PasswordChar = '\0';
            RPRTPasswordField.UseSystemPasswordChar = false;
        }

        public void RTEyeBtn_MouseUp(object sender, EventArgs e)
        {
            RPRTPasswordField.PasswordChar = '●';
            RPRTPasswordField.UseSystemPasswordChar = true;
        }

        private void RPNewPasswordField_TextChanged(object sender, EventArgs e)
        {
            if (RPNewPasswordField.Text.Length > 0)
            {
                ARPNewPasswordlbl.Visible = false;
            }
            else
            {
                ARPNewPasswordlbl.Visible = true;
            }
        }

        private void RPRTPasswordField_TextChanged(object sender, EventArgs e)
        {
            if (RPRTPasswordField.Text == RPNewPasswordField.Text)
            {
                ARPRTPasswordlbl.Visible = false;
            }
            else
            {
                ARPRTPasswordlbl.Visible = true;
            }
        }

    }
}
