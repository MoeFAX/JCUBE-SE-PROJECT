using System;
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

namespace JCUBE_SE_PROJECT
{
    public partial class CreateAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public CreateAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            NPEyeBtn.MouseDown += new MouseEventHandler(NPEyeBtn_MouseDown);
            NPEyeBtn.MouseUp += new MouseEventHandler(NPEyeBtn_MouseUp);
            RTEyeBtn.MouseDown += new MouseEventHandler(RTEyeBtn_MouseDown);
            RTEyeBtn.MouseUp += new MouseEventHandler(RTEyeBtn_MouseUp);
        }

        public bool HasUnicode(string nText)
        {
            foreach (char c in nText)
            {
                uint u = Convert.ToUInt32(c);
                if (u > 0xFFFF)
                {
                    return true;
                }
            }
            return false;
        }

        public void Clear()
        {
            UsernameField.Clear();
            PasswordField.Clear();
            RTPasswordField.Clear();
            FullnameField.Clear();
            RoleComboBox.Text = "";
            UsernameField.Focus();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                if (string.IsNullOrWhiteSpace(UsernameField.Text) || string.IsNullOrWhiteSpace(PasswordField.Text) || string.IsNullOrWhiteSpace(RTPasswordField.Text) || string.IsNullOrWhiteSpace(FullnameField.Text) || string.IsNullOrWhiteSpace(RoleComboBox.Text))
                {
                    MessageBox.Show("Fields can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                    cn.Close();
                }
                else /* FIELD VALIDATIONS CHECK */
                {
                    /* USERNAME VALIDATION CHECK */
                    cm = new SqlCommand("SELECT * FROM tbUser WHERE username = @username", cn);
                    cm.Parameters.AddWithValue("@username", UsernameField.Text);
                    dr = cm.ExecuteReader();

                    if(HasUnicode(UsernameField.Text))
                    {
                        MessageBox.Show("Username can not contain a unicode or emoji.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UsernameField.Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (UsernameField.Text.Length < 8)
                    {
                        MessageBox.Show("Username must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UsernameField.Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (Regex.IsMatch(UsernameField.Text, @"^(?=.*[,~`!#$%^&*()+={}\[\]:;'\<>?/\\|])"))
                    {
                        MessageBox.Show("Username contains invalid characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UsernameField.Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (dr.Read())
                    {
                        MessageBox.Show("This Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UsernameField.Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else
                    {
                        dr.Close();
                        /* USERNAME IS VALID - NEXT TO CHECK IS PASSWORD */
                        string encryptedPassword = AESHelper.Encrypt(PasswordField.Text);

                        cm = new SqlCommand("SELECT * FROM tbUser WHERE encryptedPassword = @encryptedPassword", cn);
                        cm.Parameters.AddWithValue("@encryptedPassword", encryptedPassword);
                        dr = cm.ExecuteReader();

                        if (PasswordField.Text != RTPasswordField.Text)
                        {
                            MessageBox.Show("Passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            PasswordField.Clear();
                            RTPasswordField.Clear();
                            dr.Close();
                            cn.Close();
                        }
                        else if (PasswordField.Text.Length < 8)
                        {
                            MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            PasswordField.Clear();
                            RTPasswordField.Clear();
                            dr.Close();
                            cn.Close();
                        }
                        else if (!Regex.IsMatch(PasswordField.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+=-]).{8,}$"))
                        {
                            MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            PasswordField.Clear();
                            RTPasswordField.Clear();
                            dr.Close();
                            cn.Close();
                        }
                        else if (dr.Read())
                        {
                            MessageBox.Show("This Password already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            PasswordField.Clear();
                            RTPasswordField.Clear();
                            dr.Close();
                            cn.Close();
                        }
                        else
                        {
                            dr.Close();
                            /* PASSWORD IS VALID - NEXT TO CHECK IS FULL NAME */
                            cm = new SqlCommand("SELECT * FROM tbUser WHERE fullname = @fullname", cn);
                            cm.Parameters.AddWithValue("@fullname", FullnameField.Text);
                            dr = cm.ExecuteReader();

                            if (!Regex.IsMatch(FullnameField.Text, "^[a-zA-Z\\s]+$"))
                            {
                                MessageBox.Show("Full name must only contain letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                FullnameField.Clear();
                                dr.Close();
                                cn.Close();
                            }
                            
                            else if (dr.Read())
                            {
                                MessageBox.Show("This Full name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                FullnameField.Clear();
                                dr.Close();
                                cn.Close();
                            }
                            else
                            {
                                dr.Close();
                                cm = new SqlCommand("INSERT INTO tbUser (username, encryptedPassword, fullname, role) VALUES (@username, @encryptedPassword, @fullname, @role)", cn);
                                cm.Parameters.AddWithValue("username", UsernameField.Text);
                                cm.Parameters.AddWithValue("@encryptedPassword", encryptedPassword);
                                cm.Parameters.AddWithValue("@fullname", FullnameField.Text);
                                cm.Parameters.AddWithValue("@role", RoleComboBox.Text);
                                cm.ExecuteNonQuery();
                                cn.Close();
                                Clear();
                                MessageBox.Show("New account has been successfully saved! Please Reload.", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                        }
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
            PasswordField.PasswordChar = '\0';
            PasswordField.UseSystemPasswordChar = false;
        }

        public void NPEyeBtn_MouseUp(object sender, EventArgs e)
        {
            PasswordField.PasswordChar = '●';
            PasswordField.UseSystemPasswordChar = true;
        }
        public void RTEyeBtn_MouseDown(object sender, EventArgs e)
        {
            RTPasswordField.PasswordChar = '\0';
            RTPasswordField.UseSystemPasswordChar = false;
        }

        public void RTEyeBtn_MouseUp(object sender, EventArgs e)
        {
            RTPasswordField.PasswordChar = '●';
            RTPasswordField.UseSystemPasswordChar = true;
        }
    }
}
