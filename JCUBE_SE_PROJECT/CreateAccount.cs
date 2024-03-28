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
                cm = new SqlCommand("Insert into tbUser(username, password, fullname, role) Values (@username, @password, @fullname, @role)", cn);
                cm.Parameters.AddWithValue("@username", UsernameField.Text);

                if (string.IsNullOrWhiteSpace(PasswordField.Text))
                {
                    MessageBox.Show("Fields can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cn.Close();
                }
                else if (PasswordField.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PasswordField.Clear();
                    RTPasswordField.Clear();
                    cn.Close();
                }
                else if (!Regex.IsMatch(PasswordField.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+=-]).{8,}$"))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PasswordField.Clear();
                    RTPasswordField.Clear();
                    cn.Close();
                }
                else if (PasswordField.Text != RTPasswordField.Text)
                {
                    MessageBox.Show("Passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    cm.Parameters.AddWithValue("@password", PasswordField.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            } finally
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
