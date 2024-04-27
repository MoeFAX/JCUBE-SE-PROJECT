using Microsoft.Reporting.Map.WebForms.BingMaps;
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
    public partial class BrandModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Brand brand;
        private string logUsername;
        public BrandModule(Brand br, string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            logUsername = username;
            brand = br;
        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string logAction;
                string logType = "BRAND";
                string logDescription;
                if (string.IsNullOrWhiteSpace(BrandNameField.Text))
                {
                    MessageBox.Show("Brand name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cn.Open();
                string brandName = BrandNameField.Text.Trim();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbBrand WHERE BrandName = @BrandName", cn);
                checkCmd.Parameters.AddWithValue("@BrandName", brandName);
                int brandCount = (int)checkCmd.ExecuteScalar();

                if (brandCount > 0)
                {
                    MessageBox.Show("Brand name already exists. Please enter a unique brand name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!string.IsNullOrEmpty(BrandNameField.Text) && int.TryParse(lblid.Text, out int brandID))
                {
                    // for update

                    cm = new SqlCommand("UPDATE tbBrand SET BrandName = @BrandName WHERE BrandID = @BrandID", cn);
                    cm.Parameters.AddWithValue("@BrandName", BrandNameField.Text);
                    cm.Parameters.AddWithValue("@BrandID", brandID);
                    this.Dispose();
                    logAction = "UPDATE";
                    logDescription = "Updated a Brand";

                }
                else
                {
                    // for create
                    cm = new SqlCommand("INSERT INTO tbBrand(BrandName) VALUES(@BrandName)", cn);
                    cm.Parameters.AddWithValue("@BrandName", BrandNameField.Text);
                    logAction = "CREATE";
                    logDescription = "Created a new Brand";
                }
                cm.ExecuteNonQuery();
                LogDao log = new LogDao(cn);
                log.AddLogs(logAction, logType, logDescription, logUsername);
                MessageBox.Show("Record has been successfully saved.", "SAVE");
                Clear();
                brand.LoadBrand();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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

        public void Clear()
        {
            BrandNameField.Clear();
        }

        private void BrandNameField_TextChanged(object sender, EventArgs e)
        {
            if (BrandNameField.Text.Length > 0)
            {
                Asterisk.Visible = false;
            }
            else
            {
                Asterisk.Visible = true;
            }
        }

        private HashSet<char> specialChar = new HashSet<char>
        {
             '.', '-', '_', '@'
        };
        private void BrandNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) ||
           char.IsWhiteSpace(e.KeyChar) || specialChar.Contains(e.KeyChar) ||
           char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
