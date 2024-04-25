using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCUBE_SE_PROJECT
{
    public partial class UserAccountsUI : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string logUsername;

        public UserAccountsUI(string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            logUsername = username;

            LoadUser();

            AccountDeletion AccountAge = new AccountDeletion();
            AccountAge.AccountAge(cn);
            AccountDeletion ExpiredAccounts = new AccountDeletion();
            ExpiredAccounts.ExpiredAccounts(cn);
        }

        public void LoadUser()
        {
            dgvUser.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbUser", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvUser.Rows.Add(dr["AccountID"].ToString(), dr["username"].ToString(), dr["fullname"].ToString(), dr["emailaddress"].ToString(), dr["isactive"].ToString(), dr["role"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string colName = dgvUser.Columns[e.ColumnIndex].Name;
                    if (colName == "ArchiveAcc") //ARCHIVE FUNC
                    {
                        string _selecteduser = "";
                        int SLCTDelAccID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

                        cn.Open();
                        using (SqlCommand command = new SqlCommand("SELECT username From tbUser WHERE AccountID = @AccountID", cn))
                        {
                            command.Parameters.AddWithValue("@AccountID", SLCTDelAccID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _selecteduser = reader["username"].ToString();
                                }
                            }
                        }
                        if (String.Equals(_selecteduser, UAUserRolelbl.Text, StringComparison.Ordinal))
                        {
                            MessageBox.Show("Can not perform action: Currently logged in using this account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dr.Close();
                            cn.Close();
                        }
                        else
                        {
                            dr.Close();
                            cn.Close();
                            string _selectedrole = "";
                            cn.Open();
                            using (SqlCommand command = new SqlCommand("SELECT role From tbUser WHERE username = @username", cn))
                            {
                                command.Parameters.AddWithValue("@username", UAUserRolelbl.Text);
                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        _selectedrole = reader["role"].ToString();
                                    }
                                }
                            }
                            if (_selectedrole == "Administrator" && dgvUser[5, e.RowIndex].Value.ToString() == "Super Administrator" || _selectedrole == "Administrator" && dgvUser[5, e.RowIndex].Value.ToString() == "Administrator") //admin >> super admin or // admin >> admin
                            {
                                MessageBox.Show("You do not have permission to do this action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dr.Close();
                                cn.Close();
                                return;
                            }
                            else
                            {
                                dr.Close();
                                cn.Close();

                                if (MessageBox.Show("Are you sure you want to delete this account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    // Retrieve ItemID and Role from the DataGridView
                                    int ArchAccID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);
                                    string AccActivate = dgvUser[4, e.RowIndex].Value.ToString();

                                    if (AccActivate == "True")
                                    {
                                        MessageBox.Show("Account must be deactivated before deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        cn.Open();

                                        string myDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                        cm = new SqlCommand("INSERT INTO tbUserArchive(AccountID, username, encryptedPassword, fullname, emailaddress, isactive, role) SELECT AccountID, username, encryptedPassword, fullname, emailaddress, isactive, role FROM tbUser WHERE AccountID = @AccountID DELETE FROM tbUser WHERE AccountID = @AccountID", cn);
                                        cm.Parameters.AddWithValue("@AccountID", ArchAccID); // Add @AccountID parameter
                                        cm.ExecuteNonQuery();

                                        SqlCommand cu = new SqlCommand("UPDATE tbUserArchive SET TimeArchived = @TimeArchived WHERE AccountID = @AccountID", cn);
                                        cu.Parameters.AddWithValue("@AccountID", ArchAccID);
                                        cu.Parameters.AddWithValue("@TimeArchived", myDate);
                                        cu.ExecuteNonQuery();

                                        string logAction = "ARCHIVE";
                                        string logType = "ACCOUNTS";
                                        string logDescription = "Archived an Account"; 
                                        LogDao log = new LogDao(cn);
                                        log.AddLogs(logAction, logType, logDescription, logUsername);
                                        cn.Close();
                                        MessageBox.Show("Account has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Remove the row from the DataGridView
                                        dgvUser.Rows.RemoveAt(e.RowIndex);
                                        LoadUser();
                                    }
                                }
                                else
                                {
                                    cn.Close();
                                    return;
                                }
                            }
                        }
                    }
                    else if (colName == "EditAcc") //EDIT ACC
                    {
                        string _selectedrole = "";
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("SELECT role From tbUser WHERE username = @username", cn))
                        {
                            command.Parameters.AddWithValue("@username", UAUserRolelbl.Text);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _selectedrole = reader["role"].ToString();
                                }
                            }
                        }
                        if (_selectedrole == "Administrator" && dgvUser[5, e.RowIndex].Value.ToString() == "Super Administrator" || _selectedrole == "Administrator" && dgvUser[5, e.RowIndex].Value.ToString() == "Administrator") //admin >> super admin or // admin >> admin
                        {
                            MessageBox.Show("You do not have permission to do this action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dr.Close();
                            cn.Close();
                            return;
                        }
                        else
                        {
                            dr.Close();
                            cn.Close();
                            if (MessageBox.Show("Are you sure you want to edit this account?", "Edit Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // Retrieve AccountID from the DataGridView
                                int AccID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

                                // Open EditAccount form for editing with the AccountID
                                EditAccount editacc = new EditAccount(this, logUsername);
                                editacc.EditAccountIDlbl.Text = AccID.ToString(); // Set AccountID property

                                // Populate fields in EditAccount form
                                editacc.EditAccountIDlbl.Text = dgvUser[0, e.RowIndex].Value.ToString();
                                editacc.EditUsernameField.Text = dgvUser[1, e.RowIndex].Value.ToString();
                                editacc.EditFullnameField.Text = dgvUser[2, e.RowIndex].Value.ToString();
                                editacc.EditEmailField.Text = dgvUser[3, e.RowIndex].Value.ToString();
                                if (dgvUser[5, e.RowIndex].Value.ToString() == "Administrator")
                                {
                                    editacc.EditRoleComboBox.SelectedIndex = 0;
                                }
                                else
                                {
                                    editacc.EditRoleComboBox.SelectedIndex = 1;
                                }
                                editacc.SaveBtn.Enabled = true;
                                editacc.ShowDialog();
                            }
                        }
                    }
                    else if (colName == "ActivateAcc") //ACTIVATE ACC
                    {
                        string _selectedrole = "";
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("SELECT role From tbUser WHERE username = @username", cn))
                        {
                            command.Parameters.AddWithValue("@username", UAUserRolelbl.Text);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _selectedrole = reader["role"].ToString();
                                }
                            }
                        }
                        if (_selectedrole == "Administrator" && dgvUser[5, e.RowIndex].Value.ToString() == "Super Administrator" || _selectedrole == "Administrator" && dgvUser[5, e.RowIndex].Value.ToString() == "Administrator") //admin >> super admin or // admin >> admin
                        {
                            MessageBox.Show("You do not have permission to do this action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dr.Close();
                            cn.Close();
                            return;
                        }
                        else
                        {
                            dr.Close();
                            cn.Close();
                            if (MessageBox.Show("Are you sure you want to activate this account?", "Activate Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // Retrieve ItemID from the DataGridView
                                int ActAccID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

                                cn.Open();
                                SqlCommand cu = new SqlCommand("SELECT COUNT(*) FROM tbUser WHERE AccountID = @AccountID AND isactive = 'true'", cn);
                                cu.Parameters.AddWithValue("@AccountID", ActAccID);
                                int count = (int)cu.ExecuteScalar();

                                cn.Close();
                                if (count > 0)
                                {
                                    MessageBox.Show("The account is already activated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    cn.Close();
                                    LoadUser();
                                }
                                else
                                {
                                    cn.Open();
                                    cm = new SqlCommand("UPDATE tbUser SET isactive = @isactive WHERE AccountID = @AccountID", cn);
                                    cm.Parameters.AddWithValue("@isactive", "True");
                                    cm.Parameters.AddWithValue("@AccountID", ActAccID); // Add @AccountID parameter
                                    cm.ExecuteNonQuery();
                                    string logAction = "UPDATE";
                                    string logType = "ACCOUNTS";
                                    string logDescription = "Activated an Account";
                                    LogDao log = new LogDao(cn);
                                    log.AddLogs(logAction, logType, logDescription, logUsername);
                                    dr.Close();
                                    cn.Close();
                                    MessageBox.Show("Account has been successfully activated!", "ACTIVATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadUser();
                                }
                            }
                        }
                    }
                    else if (colName == "DeactivateAcc") //DEACTIVATE ACC
                    {
                        string _selectedrole = "";
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("SELECT role From tbUser WHERE username = @username", cn))
                        {
                            command.Parameters.AddWithValue("@username", UAUserRolelbl.Text);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _selectedrole = reader["role"].ToString();
                                }
                            }
                        }
                        if (_selectedrole == "Administrator" && dgvUser[5, e.RowIndex].Value.ToString() == "Super Administrator" || _selectedrole == "Administrator" && dgvUser[5, e.RowIndex].Value.ToString() == "Administrator") //admin >> super admin or // admin >> admin
                        {
                            MessageBox.Show("You do not have permission to do this action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dr.Close();
                            cn.Close();
                            return;
                        }
                        else
                        {
                            dr.Close();
                            cn.Close();
                            if (MessageBox.Show("Are you sure you want to deactivate this account?", "Deactivate Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                // Retrieve ItemID from the DataGridView
                                int ActAccID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

                                cn.Open();
                                SqlCommand cu = new SqlCommand("SELECT COUNT(*) FROM tbUser WHERE AccountID = @AccountID AND isactive = 'false'", cn);
                                cu.Parameters.AddWithValue("@AccountID", ActAccID);
                                int count = (int)cu.ExecuteScalar();

                                cn.Close();
                                if (count > 0)
                                {
                                    MessageBox.Show("The account is already deactivated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    cn.Close();
                                    LoadUser();
                                }
                                else
                                {
                                    cn.Open();
                                    cm = new SqlCommand("UPDATE tbUser SET isactive = @isactive WHERE AccountID = @AccountID", cn);
                                    cm.Parameters.AddWithValue("@isactive", "False");
                                    cm.Parameters.AddWithValue("@AccountID", ActAccID); // Add @AccountID parameter
                                    cm.ExecuteNonQuery();
                                    string logAction = "UPDATED";
                                    string logType = "ACCOUNTS";
                                    string logDescription = "Deactivated an Account";
                                    LogDao log = new LogDao(cn);
                                    log.AddLogs(logAction, logType, logDescription, logUsername);
                                    cn.Close();
                                    MessageBox.Show("Account has been successfully deactivated!", "DEACTIVATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadUser();
                                }
                            }
                        }
                    }
                    else if (colName == "ResetPwd") //RESET PASSWORD
                    {
                        string _selectedrole = "";
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("SELECT role From tbUser WHERE username = @username", cn))
                        {
                            command.Parameters.AddWithValue("@username", UAUserRolelbl.Text);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _selectedrole = reader["role"].ToString();
                                }
                            }
                        }
                        if (_selectedrole == "Administrator" && dgvUser[5, e.RowIndex].Value.ToString() == "Super Administrator" || _selectedrole == "Administrator" && dgvUser[5, e.RowIndex].Value.ToString() == "Administrator") //admin >> super admin or // admin >> admin
                        {
                            MessageBox.Show("You do not have permission to do this action.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dr.Close();
                            cn.Close();
                            return;
                        }
                        else
                        {
                            dr.Close();
                            cn.Close();
                            if (MessageBox.Show("Are you sure you want to reset this account's password?", "Reset Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // Retrieve AccountID from the DataGridView
                                int RPWDAccID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

                                // Open ResetPassword form for editing with the AccountID
                                ResetPassword rpwdacc = new ResetPassword(this, logUsername);
                                rpwdacc.RPWDAccIDlbl.Text = RPWDAccID.ToString(); // Set AccountID property

                                //Retrieve Password from Database in correlation with the AccountID
                                //and Populate the Current Password Field
                                cn.Open();
                                cm = new SqlCommand("SELECT username FROM tbUser WHERE AccountID = @AccountID", cn);
                                cm.Parameters.AddWithValue("@AccountID", RPWDAccID); // Add @AccountID parameter
                                dr = cm.ExecuteReader();
                                while (dr.Read())
                                {
                                    rpwdacc.RPUNlbl.Text = dr["username"].ToString();
                                }
                                dr.Close();
                                cn.Close();

                                // Populate fields in EditAccount form
                                rpwdacc.RPWDAccIDlbl.Text = dgvUser[0, e.RowIndex].Value.ToString();
                                rpwdacc.SaveBtn.Enabled = true;
                                rpwdacc.ShowDialog();
                            }
                        }
                    }
                    // Reload the item list after deletion or editing
                    LoadUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void RDBttn_Click(object sender, EventArgs e)
        {
            RecentlyDeleted moduleForm = new RecentlyDeleted(this, logUsername);
            moduleForm.ShowDialog();
        }

        private void CABttn_Click(object sender, EventArgs e)
        {
            CreateAccount moduleForm = new CreateAccount(this, logUsername);
            moduleForm.ShowDialog();
        }

        private void CPBttn_Click(object sender, EventArgs e)
        {
            UAChangePassword moduleForm = new UAChangePassword(this, logUsername);
            moduleForm.CPUNlbl.Text = UAUserRolelbl.Text;
            moduleForm.ShowDialog();
        }
    }
}
