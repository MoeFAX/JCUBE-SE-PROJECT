using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        public UserAccountsUI()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
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
            CreateAccount moduleForm = new CreateAccount();
            moduleForm.ShowDialog();
        }

        private void ResetPasswordBttn_Click(object sender, EventArgs e)
        {
            ResetPassword moduleForm = new ResetPassword();
            moduleForm.ShowDialog();
        }

        private void CPBttn_Click(object sender, EventArgs e)
        {
            UAChangePassword moduleForm = new UAChangePassword();
            moduleForm.ShowDialog();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvUser.Columns[e.ColumnIndex].Name;
                if (colName == "ArchiveAcc") //ARCHIVE FUNC
                {
                    if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Retrieve ItemID from the DataGridView
                        int AccountID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tbUser WHERE AccountID = @AccountID", cn);
                        cm.Parameters.AddWithValue("@AccountID", AccountID); // Add @AccountID parameter
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Item has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Remove the row from the DataGridView
                        dgvUser.Rows.RemoveAt(e.RowIndex);
                        LoadUser();
                    }
                }
                else if (colName == "EditAcc") //EDIT ACC
                {
                    // Retrieve ItemID from the DataGridView
                    int accountID = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["AccountID"].Value);

                    // Open EditAccount form for editing with the ItemID
                    EditAccount additem = new EditAccount(this);
                    additem.EditAccountIDField.Text = accountID.ToString(); // Set ItemID property
                                                                 // Populate fields in AddItem form
                    additem.EditAccountIDField.Text = dgvUser[0, e.RowIndex].Value.ToString();
                    additem.EditUsernameField.Text = dgvUser[1, e.RowIndex].Value.ToString();
                    additem.EditFullnameField.Text = dgvUser[2, e.RowIndex].Value.ToString();
                    additem.EditRoleComboBox.Text = dgvUser[4, e.RowIndex].Value.ToString();
                    additem.SaveBtn.Enabled = true;
                    additem.ShowDialog();
                }
                // Reload the item list after deletion or editing
                LoadUser();
            }
        }
    }
}
