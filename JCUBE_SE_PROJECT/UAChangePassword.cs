using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JCUBE_SE_PROJECT
{
    public partial class UAChangePassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        UserAccountsUI useracc;

        string  _decryptedPassword = "", _encryptedPassword = "";

        public UAChangePassword(UserAccountsUI user)
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

        public void Clear()
        {
            CPNewPasswordField.Clear();
            CPRTPasswordField.Clear();
            CPCurrPasswordField.Clear();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                using (SqlCommand command = new SqlCommand("SELECT encryptedPassword From tbUser WHERE username = @username", cn))
                {
                    command.Parameters.AddWithValue("@username", CPUNlbl.Text);
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

                if (_decryptedPassword != CPCurrPasswordField.Text)
                {
                    MessageBox.Show("Current Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                    dr.Close();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Current Password match!", "Matched Current Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (string.IsNullOrWhiteSpace(CPNewPasswordField.Text))
                    {
                        MessageBox.Show("Fields can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (CPNewPasswordField.Text.Length < 8)
                    {
                        MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (!Regex.IsMatch(CPNewPasswordField.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+=-]).{8,}$"))
                    {
                        MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (CPNewPasswordField.Text != CPRTPasswordField.Text)
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
                        string CPNewEncryptedPassword = "";

                        using (SqlCommand command = new SqlCommand("UPDATE tbUser SET encryptedPassword = @encryptedPassword WHERE username = @username", cn))
                        {

                            command.Parameters.AddWithValue("@username", CPUNlbl.Text);
                            CPNewEncryptedPassword = AESHelper.Encrypt(CPNewPasswordField.Text);
                            command.Parameters.AddWithValue("@encryptedPassword", CPNewEncryptedPassword);
                            command.ExecuteNonQuery();
                        }
                        cn.Close();
                        Clear();
                        MessageBox.Show("New password has been successfully saved for account: " + CPUNlbl.Text, "Save New Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void NPEyeBtn_MouseDown(object sender, EventArgs e)
        {
            CPNewPasswordField.PasswordChar = '\0';
            CPNewPasswordField.UseSystemPasswordChar = false;
        }

        public void NPEyeBtn_MouseUp(object sender, EventArgs e)
        {
            CPNewPasswordField.PasswordChar = '●';
            CPNewPasswordField.UseSystemPasswordChar = true;
        }
        public void RTEyeBtn_MouseDown(object sender, EventArgs e)
        {
            CPRTPasswordField.PasswordChar = '\0';
            CPRTPasswordField.UseSystemPasswordChar = false;
        }

        public void RTEyeBtn_MouseUp(object sender, EventArgs e)
        {
            CPRTPasswordField.PasswordChar = '●';
            CPRTPasswordField.UseSystemPasswordChar = true;
        }
        public void CPEyeBtn_MouseDown(object sender, EventArgs e)
        {
            CPCurrPasswordField.PasswordChar = '\0';
            CPCurrPasswordField.UseSystemPasswordChar = false;
        }

        public void CPEyeBtn_MouseUp(object sender, EventArgs e)
        {
            CPCurrPasswordField.PasswordChar = '●';
            CPCurrPasswordField.UseSystemPasswordChar = true;
        }
    }
}
