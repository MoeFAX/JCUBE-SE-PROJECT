using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace JCUBE_SE_PROJECT
{
    public partial class RecentlyDeleted : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        UserAccountsUI useracc;
        private string logUsername;
        private string selecteduser;
        public RecentlyDeleted(UserAccountsUI user, string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            logUsername = username;
            selecteduser = username;
            useracc = user;
            AccountDeletion AccountAge = new AccountDeletion();
            AccountAge.AccountAge(cn);
            LoadAccounts();
            AccountDeletion ExpiredAccounts = new AccountDeletion();
            ExpiredAccounts.ExpiredAccounts(cn);
        }
        
        public void LoadAccounts()
        {
            dgvUserArchive.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbUserArchive", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvUserArchive.Rows.Add(dr["AccountID"].ToString(), dr["username"].ToString(), dr["fullname"].ToString(), dr["emailaddress"].ToString(), dr["role"].ToString(), dr["TimeArchived"].ToString(), dr["accountAge"].ToString() + " days");
            }
            dr.Close();
            cn.Close();
        }

        private void dgvUserArchive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string colName = dgvUserArchive.Columns[e.ColumnIndex].Name;
                    if (colName == "RestoreAcc")
                    {
                        string _selectedrole = "";
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("SELECT role From tbUser WHERE username = @username", cn))
                        {
                            command.Parameters.AddWithValue("@username", selecteduser);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _selectedrole = reader["role"].ToString();
                                }
                            }
                        }
                        if (_selectedrole == "Administrator" && dgvUserArchive[4, e.RowIndex].Value.ToString() == "Super Administrator" || _selectedrole == "Administrator" && dgvUserArchive[4, e.RowIndex].Value.ToString() == "Administrator") //admin >> super admin or // admin >> admin
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
                            if (MessageBox.Show("Are you sure you want to restore this account?", "Restore Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cn.Open();
                                int ArchRDID = Convert.ToInt32(dgvUserArchive.Rows[e.RowIndex].Cells["AccountID"].Value);

                                cm = new SqlCommand("SET IDENTITY_INSERT tbUser ON INSERT INTO tbUser(AccountID, username, encryptedPassword, fullname, emailaddress, isactive, role) SELECT AccountID, username, encryptedPassword, fullname, emailaddress, isactive, role FROM tbUserArchive WHERE AccountID = @AccountID DELETE FROM tbUserArchive WHERE AccountID = @AccountID SET IDENTITY_INSERT tbUser OFF", cn);
                                cm.Parameters.AddWithValue("@AccountID", ArchRDID); // Add @AccountID parameter
                                cm.ExecuteNonQuery();
                                string logAction = "RESTORE";
                                string logType = "ACCOUNTS";
                                string logDescription = "Restored an Account";
                                LogDao log = new LogDao(cn);
                                log.AddLogs(logAction, logType, logDescription, logUsername);
                                cn.Close();
                                MessageBox.Show("Account has been successfully restored", "RESTORE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Remove the row from the DataGridView
                                dgvUserArchive.Rows.RemoveAt(e.RowIndex);
                                LoadAccounts();
                                useracc.LoadUser();
                            }
                            else
                            {
                                cn.Close();
                                return;
                            }
                        }
                        
                    }
                    if (colName == "DeleteAcc")
                    {
                        string _selectedrole = "";
                        cn.Open();
                        using (SqlCommand command = new SqlCommand("SELECT role From tbUser WHERE username = @username", cn))
                        {
                            command.Parameters.AddWithValue("@username", selecteduser);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    _selectedrole = reader["role"].ToString();
                                }
                            }
                        }
                        if (_selectedrole == "Administrator" && dgvUserArchive[4, e.RowIndex].Value.ToString() == "Super Administrator" || _selectedrole == "Administrator" && dgvUserArchive[4, e.RowIndex].Value.ToString() == "Administrator") //admin >> super admin or // admin >> admin
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
                                int ActRDID = Convert.ToInt32(dgvUserArchive.Rows[e.RowIndex].Cells["AccountID"].Value);

                                cn.Open();
                                cm = new SqlCommand("DELETE FROM tbUserArchive WHERE AccountID = @AccountID", cn);
                                cm.Parameters.AddWithValue("@AccountID", ActRDID); // Add @StockID parameter
                                cm.ExecuteNonQuery();
                                string logAction = "DELETE";
                                string logType = "ACCOUNTS";
                                string logDescription = "Deleted an Account";
                                LogDao log = new LogDao(cn);
                                log.AddLogs(logAction, logType, logDescription, logUsername);
                                cn.Close();
                                MessageBox.Show("Account has successfully been deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Remove the row from the DataGridView
                                dgvUserArchive.Rows.RemoveAt(e.RowIndex);
                                LoadAccounts();
                            }
                            else
                            {
                                cn.Close();
                                return;
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

        private void dgvUserArchive_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvUserArchive.Columns[e.ColumnIndex].Name == "UAAccAgeCol")
            {
                if (e.Value != null)
                {
                    // Check for the string "pink" in the cell.


                    string stringValue = (string)e.Value;
                    string newValue = stringValue.Substring(0,2);
                    int daysValue = Convert.ToInt32(newValue);

                    if (daysValue > 14)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                }
            }
        }
    }
}
