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
        public EditAccount(UserAccountsUI user)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            useracc = user;
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear ()
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
                cn.Open();
                if (string.IsNullOrEmpty(EditUsernameField.Text) || string.IsNullOrEmpty(EditFullnameField.Text) || string.IsNullOrEmpty(EditRoleComboBox.Text))
                {
                    MessageBox.Show("Fields can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cn.Close();
                }
                else /* FIELD VALIDATIONS CHECK */
                {
                    /* USERNAME VALIDATION CHECK */
                    cm = new SqlCommand("SELECT * FROM tbUser WHERE username = @username", cn);
                    cm.Parameters.AddWithValue("@username", EditUsernameField.Text);
                    dr = cm.ExecuteReader();

                    if (HasUnicode(EditUsernameField.Text))
                    {
                        MessageBox.Show("Username can not contain a unicode or emoji.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EditUsernameField.Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (EditUsernameField.Text.Length < 8)
                    {
                        MessageBox.Show("Username must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EditUsernameField.Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (Regex.IsMatch(EditUsernameField.Text, @"^(?=.*[,~`!#$%^&*()+={}\[\]:;'\<>?/\\|])"))
                    {
                        MessageBox.Show("Username contains invalid characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EditUsernameField.Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else if (dr.Read())
                    {
                        MessageBox.Show("This Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EditUsernameField.Clear();
                        dr.Close();
                        cn.Close();
                    }
                    else
                    {
                        dr.Close();
                        /* USERNAME IS VALID - NEXT TO CHECK IS FULL NAME */
                        cm = new SqlCommand("SELECT * FROM tbUser WHERE fullname = @fullname", cn);
                        cm.Parameters.AddWithValue("@fullname", EditFullnameField.Text);
                        dr = cm.ExecuteReader();

                        if (!Regex.IsMatch(EditFullnameField.Text, "^[a-zA-Z\\s]+$"))
                        {
                            MessageBox.Show("Full name must only contain letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            EditFullnameField.Clear();
                            dr.Close();
                            cn.Close();
                        }

                        else if (dr.Read())
                        {
                            MessageBox.Show("This Full name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            EditFullnameField.Clear();
                            dr.Close();
                            cn.Close();
                        }
                        else
                        {
                            dr.Close();
                            cm = new SqlCommand("UPDATE tbUser SET username = @username, fullname = @fullname, role = @role WHERE AccountID = @AccountID", cn);
                            cm.Parameters.AddWithValue("@AccountID", int.Parse(EditAccountIDField.Text));
                            cm.Parameters.AddWithValue("@username", EditUsernameField.Text);
                            cm.Parameters.AddWithValue("@fullname", EditFullnameField.Text);
                            cm.Parameters.AddWithValue("@role", EditRoleComboBox.Text);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            Clear();
                            MessageBox.Show("Account has been successfully saved! Please Reload.", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                            useracc.LoadUser();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
                cn.Close();
            }
        }
    }
}
