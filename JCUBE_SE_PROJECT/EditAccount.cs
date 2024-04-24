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
    public partial class EditAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        UserAccountsUI useracc;
        private string logUsername;
        public EditAccount(UserAccountsUI user, string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            useracc = user;
            logUsername = username;
        }

        public int AccountID
        {
            get { return AccountID; }
            set { AccountID = value; }
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
            return regex.IsMatch(EditUsernameField.Text);
        }

        private bool IsFullnameValid(string fullname)
        {
            //check if the full name only contains letters
            Regex regex = new Regex("^[a-zA-Z\\s]+$");
            return regex.IsMatch(fullname);
        }
        
        private bool IsEmailValid(string emailaddress)
        {
            //check if the email address is valid
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,5}$");
            return regex.IsMatch(emailaddress);
        }

        private bool DoesUsernameExist(string username)
        {
            //check if the username already exists in the database
            using (SqlConnection cn = new SqlConnection(dbcon.myConnection()))
            {
                cn.Open();
                SqlCommand cu = new SqlCommand("SELECT username FROM tbUser WHERE AccountID = @AccountID", cn);
                cu.Parameters.AddWithValue("@AccountID", Convert.ToInt32(EditAccountIDlbl.Text));
                string existingUsername = cu.ExecuteScalar() as string;

                SqlCommand cm = new SqlCommand("SELECT COUNT(*) FROM tbUser WHERE username = @username AND username != @existingUsername", cn);
                cm.Parameters.AddWithValue("@username", username);
                cm.Parameters.AddWithValue("@existingUsername", existingUsername);
                int count = (int)cm.ExecuteScalar();
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
                SqlCommand cu = new SqlCommand("SELECT fullname FROM tbUser WHERE AccountID = @AccountID", cn);
                cu.Parameters.AddWithValue("@AccountID", Convert.ToInt32(EditAccountIDlbl.Text));
                string existingFullname = cu.ExecuteScalar() as string;

                SqlCommand cm = new SqlCommand("SELECT COUNT(*) FROM tbUser WHERE fullname = @fullname AND fullname != @existingFullname", cn);
                cm.Parameters.AddWithValue("@fullname", fullname);
                cm.Parameters.AddWithValue("@existingFullname", existingFullname);
                int count = (int)cm.ExecuteScalar();
                cn.Close();
                return count > 0;
            }
        }

        private bool DoesEmailExist(string emailaddress)
        {
            //check if the full name already exists in the database
            using (SqlConnection cn = new SqlConnection(dbcon.myConnection()))
            {
                cn.Open();
                SqlCommand cu = new SqlCommand("SELECT emailaddress FROM tbUser WHERE AccountID = @AccountID", cn);
                cu.Parameters.AddWithValue("@AccountID", Convert.ToInt32(EditAccountIDlbl.Text));
                string existingEmail = cu.ExecuteScalar() as string; 
                
                SqlCommand cm = new SqlCommand("SELECT COUNT(*) FROM tbUser WHERE emailaddress = @emailaddress AND emailaddress != @existingEmail", cn);
                cm.Parameters.AddWithValue("@emailaddress", emailaddress);
                cm.Parameters.AddWithValue("@existingEmail", existingEmail);
                int count = (int)cm.ExecuteScalar();
                cn.Close();
                return count > 0;
            }
        }

        public void Clear()
        {
            EditUsernameField.Clear();
            EditFullnameField.Clear();
            EditRoleComboBox.Text = "";

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string logAction = "UPDATE";
                string logType = "ACCOUNTS";
                string logDescription = "Updated an Account";

                if (string.IsNullOrEmpty(EditUsernameField.Text) || string.IsNullOrEmpty(EditFullnameField.Text) || string.IsNullOrEmpty(EditRoleComboBox.Text))
                {
                    MessageBox.Show("Fields can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (HasUnicode(EditUsernameField.Text))
                {
                    MessageBox.Show("User ID can not contain a unicode or emoji.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EditUsernameField.Clear();
                    return;
                }

                if (EditUsernameField.Text.Length < 8)
                {
                    MessageBox.Show("User ID must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EditUsernameField.Clear();
                    return;
                }

                if (IsUsernameValid(EditUsernameField.Text))
                {
                    MessageBox.Show("User ID contains invalid characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EditUsernameField.Clear();
                    return;
                }

                if (!IsFullnameValid(EditFullnameField.Text))
                {
                    MessageBox.Show("Full name is invalid. It must only contain letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EditFullnameField.Clear();
                    return;
                }

                if (!IsEmailValid(EditEmailField.Text))
                {
                    MessageBox.Show("This Email is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EditEmailField.Clear();
                    return;
                }

                if (DoesUsernameExist(EditUsernameField.Text))
                {
                    MessageBox.Show("This User ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EditUsernameField.Clear();
                    return;
                }

                if (DoesFullnameExist(EditFullnameField.Text))
                {
                    MessageBox.Show("This Full name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EditFullnameField.Clear();
                    return;
                }
                
                if (DoesEmailExist(EditEmailField.Text))
                {
                    MessageBox.Show("This Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EditEmailField.Clear();
                    return;
                }

                using (SqlConnection cn = new SqlConnection(dbcon.myConnection()))
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("UPDATE tbUser SET username = @username, fullname = @fullname, emailaddress = @emailaddress, role = @role WHERE AccountID = @AccountID", cn);
                    cm.Parameters.AddWithValue("@AccountID", int.Parse(EditAccountIDlbl.Text));
                    cm.Parameters.AddWithValue("@username", EditUsernameField.Text);
                    cm.Parameters.AddWithValue("@fullname", EditFullnameField.Text);
                    cm.Parameters.AddWithValue("@emailaddress", EditEmailField.Text);
                    cm.Parameters.AddWithValue("@role", EditRoleComboBox.Text);
                    cm.ExecuteNonQuery();
                    LogDao log = new LogDao(cn);
                    log.AddLogs(logAction, logType, logDescription, logUsername);
                }

                MessageBox.Show("Account has been successfully saved! Please Reload.", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                cn.Close();
                Close();
                useracc.LoadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void EditUsernameField_TextChanged(object sender, EventArgs e)
        {
            if (EditUsernameField.Text.Length > 0)
            {
                AEditUsernamelbl.Visible = false;
            }
            else
            {
                AEditUsernamelbl.Visible = true;
            }
        }

        private void EditFullnameField_TextChanged(object sender, EventArgs e)
        {
            if (EditFullnameField.Text.Length > 0)
            {
                AEditFullnamelbl.Visible = false;
            }
            else
            {
                AEditFullnamelbl.Visible = true;
            }
        }

        private void EditRoleComboBox_TextChanged(object sender, EventArgs e)
        {
            if (EditRoleComboBox.Text.Length > 0)
            {
                AEditRolelbl.Visible = false;
            }
            else
            {
                AEditRolelbl.Visible = true;
            }
        }

        private void EditEmailField_TextChanged(object sender, EventArgs e)
        {
            if (EditEmailField.Text.Length > 0)
            {
                AEditEmaillbl.Visible = false;
            }
            else
            {
                AEditEmaillbl.Visible = true;
            }
        }
    }
}