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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordField.Text != RTPasswordField.Text)
                {
                    MessageBox.Show("Passwords does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("Insert into tbUser(username, password, fullname, role) Values (@username, @password, @fullname, @role)", cn);
                cm.Parameters.AddWithValue("@username", UsernameField.Text);
                cm.Parameters.AddWithValue("@password", PasswordField.Text);
                cm.Parameters.AddWithValue("@fullname", FullnameField.Text);
                cm.Parameters.AddWithValue("@role", RoleComboBox.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New account has been successfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
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
    }
}
