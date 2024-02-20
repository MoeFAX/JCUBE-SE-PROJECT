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
    public partial class EditAccount : Form
    {
        private int accountID;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        UserAccountsUI user;
        
        public EditAccount(UserAccountsUI user)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear ()
        {
            EditUsernameField.Clear();
            EditFullnameField.Clear();

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                if (!string.IsNullOrEmpty(EditUsernameField.Text))
                {
                    if (AccountID != 0) // Check if AccountID is set (indicating an existing record)
                    {
                        // Update operation
                        cm = new SqlCommand("UPDATE tbUser SET username = @username, fullname = @fullname,  role = @role, WHERE AccountID = @AccountID", cn);
                        cm.Parameters.AddWithValue("@AccountID", AccountID);
                    }
                    else
                    {
                        // Insert operation
                        cm = new SqlCommand("INSERT INTO tbUser(username, fullname, role) VALUES(@username, @fullname, @role)", cn);
                    }

                    // Common parameters for both update and insert operations
                    cm.Parameters.AddWithValue("@username", EditUsernameField.Text);
                    cm.Parameters.AddWithValue("@fullname", EditFullnameField.Text);
                    cm.Parameters.AddWithValue("@role", EditRoleComboBox.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Account has been successfully saved!", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    user.LoadUser();
                }
                else
                {
                    MessageBox.Show("Account name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
