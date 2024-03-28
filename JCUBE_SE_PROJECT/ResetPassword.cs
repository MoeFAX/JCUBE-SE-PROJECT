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

        string _decryptedPassword = "", _encryptedPassword = "";

        public ResetPassword(UserAccountsUI user)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            useracc = user;
            NPEyeBtn.MouseDown += new MouseEventHandler(NPEyeBtn_MouseDown);
            NPEyeBtn.MouseUp += new MouseEventHandler(NPEyeBtn_MouseUp);
            RTEyeBtn.MouseDown += new MouseEventHandler(RTEyeBtn_MouseDown);
            RTEyeBtn.MouseUp += new MouseEventHandler(RTEyeBtn_MouseUp);
            CPEyeBtn.MouseDown += new MouseEventHandler(CPEyeBtn_MouseDown);
            CPEyeBtn.MouseUp += new MouseEventHandler(CPEyeBtn_MouseUp);
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
                using (SqlCommand command = new SqlCommand("SELECT encryptedPassword From tbUser WHERE username = @username", cn))
                {
                    command.Parameters.AddWithValue("@username", RPUNlbl.Text);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _encryptedPassword = reader["encryptedPassword"].ToString();

                            _decryptedPassword = AESHelper.Decrypt(_encryptedPassword);

                        }
                    }
                }

                cm = new SqlCommand("SELECT * FROM tbUser WHERE encryptedPassword = @encryptedPassword", cn);
                cm.Parameters.AddWithValue("@encryptedPassword", _encryptedPassword);
                dr = cm.ExecuteReader();

                if (_decryptedPassword != RPCurrPasswordField.Text)
                {
                    MessageBox.Show("Current Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dr.Close();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Current Password match!", "Matched Current Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (string.IsNullOrWhiteSpace(RPNewPasswordField.Text))
                    {
                        MessageBox.Show("Fields can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dr.Close();
                        cn.Close();
                    }
                    else if (RPNewPasswordField.Text.Length < 8)
                    {
                        MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (!Regex.IsMatch(RPNewPasswordField.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+=-]).{8,}$"))
                    {
                        MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (RPNewPasswordField.Text != RPRTPasswordField.Text)
                    {
                        MessageBox.Show("Passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (dr.Read())
                    {
                        MessageBox.Show("Password already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else
                    {
                        dr.Close();
                        string RPNewEncryptedPassword = "";

                        using (SqlCommand command = new SqlCommand("UPDATE tbUser SET encryptedPassword = @encryptedPassword WHERE username = @username", cn))
                        {

                            command.Parameters.AddWithValue("@username", RPUNlbl.Text);
                            RPNewEncryptedPassword = AESHelper.Encrypt(RPNewPasswordField.Text);
                            command.Parameters.AddWithValue("@encryptedPassword", RPNewEncryptedPassword);
                            command.ExecuteNonQuery();
                        }
                        cn.Close();
                        Clear();
                        MessageBox.Show("New password has been successfully saved for account: " + RPUNlbl.Text, "Save New Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        useracc.LoadUser();
                    }
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

        public void CPEyeBtn_MouseDown(object sender, EventArgs e)
        {
            RPCurrPasswordField.PasswordChar = '\0';
            RPCurrPasswordField.UseSystemPasswordChar = false;
        }

        public void CPEyeBtn_MouseUp(object sender, EventArgs e)
        {
            RPCurrPasswordField.PasswordChar = '●';
            RPCurrPasswordField.UseSystemPasswordChar = true;
        }
    }
}
