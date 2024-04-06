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
        private string logUsername;

        public CreateAccount(string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            NPEyeBtn.MouseDown += new MouseEventHandler(NPEyeBtn_MouseDown);
            NPEyeBtn.MouseUp += new MouseEventHandler(NPEyeBtn_MouseUp);
            RTEyeBtn.MouseDown += new MouseEventHandler(RTEyeBtn_MouseDown);
            RTEyeBtn.MouseUp += new MouseEventHandler(RTEyeBtn_MouseUp);
            logUsername = username;
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

        private bool IsUsernameValid(string username)
        {
            //check if the username contains any invalid characters
            //will match any string that contains a whitespace, a comma, or any control characters
            Regex regex = new Regex(@"[,~`!#$%^&*()+={}\[\]:;'<>?/\\|]");
            return regex.IsMatch(UsernameField.Text);
        }

        private bool IsFullnameValid(string fullname)
        {
            //check if the full name only contains letters
            Regex regex = new Regex("^[a-zA-Z\\s]+$");
            return regex.IsMatch(fullname);
        }

        private bool DoesUsernameExist(string username)
        {
            //check if the username already exists in the database
            using (SqlConnection cn = new SqlConnection(dbcon.myConnection()))
            {
                cn.Open();
                SqlCommand cu = new SqlCommand("SELECT COUNT(*) FROM tbUser WHERE username = @username", cn);
                cu.Parameters.AddWithValue("@username", UsernameField.Text);
                int count = (int)cu.ExecuteScalar();
                cn.Close();
                return count > 0;
            }
        }

        private bool DoesFullnameExist(string fullname)
        {
            //check if the full name already exists in the database
            using (SqlConnection cn = new SqlConnection(dbcon.myConnection()))
            {
                cn.Open();
                SqlCommand cu = new SqlCommand("SELECT COUNT(*) FROM tbUser WHERE fullname = @fullname", cn);
                cu.Parameters.AddWithValue("@fullname", FullnameField.Text);
                int count = (int)cu.ExecuteScalar();
                cn.Close();
                return count > 0;
            }
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
                }
                else /* FIELD VALIDATIONS CHECK */
                {
                    /* USERNAME VALIDATION CHECK */

                    if (HasUnicode(UsernameField.Text))
                    {
                        MessageBox.Show("User ID can not contain a unicode or emoji.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UsernameField.Clear();
                        return;
                    }
                    else if (UsernameField.Text.Length < 8)
                    {
                        MessageBox.Show("User ID must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UsernameField.Clear();
                        return;
                    }
                    else if (IsUsernameValid(UsernameField.Text))
                    {
                        MessageBox.Show("User ID contains invalid characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UsernameField.Clear();
                        return;
                    }
                    if (DoesUsernameExist(UsernameField.Text))
                    {
                        MessageBox.Show("This User ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UsernameField.Clear();
                        return;
                    }
                    else
                    {
                        /* USERNAME IS VALID - NEXT TO CHECK IS PASSWORD */
                        if (PasswordField.Text != RTPasswordField.Text)
                        {
                            MessageBox.Show("Passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            PasswordField.Clear();
                            RTPasswordField.Clear();
                        }
                        else if (PasswordField.Text.Length < 8)
                        {
                            MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            PasswordField.Clear();
                            RTPasswordField.Clear();
                        }
                        else if (!Regex.IsMatch(PasswordField.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+=-]).{8,}$"))
                        {
                            MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            PasswordField.Clear();
                            RTPasswordField.Clear();
                        }
                        
                        else
                        {
                            /* PASSWORD IS VALID - NEXT TO CHECK IS FULL NAME */

                            if (!IsFullnameValid(FullnameField.Text))
                            {
                                MessageBox.Show("Full name is invalid. It must only contain letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                FullnameField.Clear();
                                return;
                            }
                            else if (DoesFullnameExist(FullnameField.Text))
                            {
                                MessageBox.Show("This Full name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                FullnameField.Clear();
                                return;
                            }
                            else
                            {
                                string encryptedPassword = AESHelper.Encrypt(PasswordField.Text);
                                cm = new SqlCommand("INSERT INTO tbUser (username, encryptedPassword, fullname, role) VALUES (@username, @encryptedPassword, @fullname, @role)", cn);
                                cm.Parameters.AddWithValue("username", UsernameField.Text);
                                cm.Parameters.AddWithValue("@encryptedPassword", encryptedPassword);
                                cm.Parameters.AddWithValue("@fullname", FullnameField.Text);
                                cm.Parameters.AddWithValue("@role", RoleComboBox.Text);
                                cm.ExecuteNonQuery();
                                string logAction = "CREATE";
                                string logType = "ACCOUNTS";
                                string logDescription = "Created a new Account";
                                LogDao log = new LogDao(cn);
                                log.AddLogs(logAction, logType, logDescription, logUsername);
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
            finally
            { 
                cn.Close(); 
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
