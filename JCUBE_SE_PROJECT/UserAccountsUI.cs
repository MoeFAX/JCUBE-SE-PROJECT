using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        }

        public void LoadUser()
        {
            dgvUser.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbUser", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvUser.Rows.Add(dr["AccountID"].ToString(), dr["username"].ToString(), dr["fullname"].ToString(), dr["isactive"].ToString(), dr["role"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void CABttn_Click(object sender, EventArgs e)
        {
            CreateAccount moduleForm = new CreateAccount(logUsername);
            moduleForm.ShowDialog();
        }

        private void CPBttn_Click(object sender, EventArgs e)
        {
            UAChangePassword moduleForm = new UAChangePassword(this);
            moduleForm.CPUNlbl.Text = UAUserRolelbl.Text;
            cn.Open();
            cm = new SqlCommand("SELECT password FROM tbUser WHERE username = @username", cn);
            cm.Parameters.AddWithValue("@username", moduleForm.CPUNlbl.Text); // Add @username parameter
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                moduleForm.CPCurrPasswordField.Text = dr["password"].ToString();
            }

            dr.Close();
            cn.Close();

            moduleForm.ShowDialog();
        }

        public void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvUser.Columns[e.ColumnIndex].Name;
                if (colName == "ArchiveAcc") //ARCHIVE FUNC
                {
                    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Retrieve ItemID from the DataGridView
                        int ArchAccID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tbUser WHERE AccountID = @AccountID", cn);
                        cm.Parameters.AddWithValue("@AccountID", ArchAccID); // Add @AccountID parameter
                        cm.ExecuteNonQuery();
                        string logAction = "DELETE";
                        string logType = "ACCOUNTS";
                        string logDescription = "Deleted an Account";
                        LogDao log = new LogDao(cn);
                        log.AddLogs(logAction, logType, logDescription, logUsername);
                        cn.Close();
                        MessageBox.Show("Item has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Remove the row from the DataGridView
                        dgvUser.Rows.RemoveAt(e.RowIndex);
                        LoadUser();
                    }
                }
                else if (colName == "EditAcc") //EDIT ACC
                {
                    if (MessageBox.Show("Are you sure you want to edit this account?", "Edit Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Retrieve AccountID from the DataGridView
                        int AccID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

                        // Open EditAccount form for editing with the AccountID
                        EditAccount editacc = new EditAccount(this, logUsername);
                        editacc.EditAccountIDField.Text = AccID.ToString(); // Set AccountID property

                        // Populate fields in EditAccount form
                        editacc.EditAccountIDField.Text = dgvUser[0, e.RowIndex].Value.ToString();
                        editacc.EditUsernameField.Text = dgvUser[1, e.RowIndex].Value.ToString();
                        editacc.EditFullnameField.Text = dgvUser[2, e.RowIndex].Value.ToString();
                        editacc.EditRoleComboBox.Text = dgvUser[4, e.RowIndex].Value.ToString();
                        editacc.SaveBtn.Enabled = true;
                        editacc.ShowDialog();
                    }
                }
                else if (colName == "ActivateAcc") //ACTIVATE ACC
                {
                    if (MessageBox.Show("Are you sure you want to activate this account?", "Activate Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Retrieve ItemID from the DataGridView
                        int ActAccID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

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
                        cn.Close();
                        MessageBox.Show("Account has been successfully activated", "ACTIVATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (colName == "DeactivateAcc") //DEACTIVATE ACC
                {
                    if (MessageBox.Show("Are you sure you want to deactivate this account?", "Deactivate Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Retrieve ItemID from the DataGridView
                        int ActAccID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

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
                        MessageBox.Show("Account has been successfully deactivated", "DEACTIVATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (colName == "ResetPwd") //RESET PASSWORD
                {
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
                        cm = new SqlCommand("SELECT password, username FROM tbUser WHERE AccountID = @AccountID", cn);
                        cm.Parameters.AddWithValue("@AccountID",RPWDAccID); // Add @AccountID parameter
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            rpwdacc.RPCurrPasswordField.Text = dr["password"].ToString();
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
                // Reload the item list after deletion or editing
                LoadUser();
            }
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadUser();
        }

        
    }
}
