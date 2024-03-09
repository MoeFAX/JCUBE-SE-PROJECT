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
        public BrandModule(Brand br)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            brand = br;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
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
                    
                }
                else
                {
                    // for create
                    cm = new SqlCommand("INSERT INTO tbBrand(BrandName) VALUES(@BrandName)", cn);
                    cm.Parameters.AddWithValue("@BrandName", BrandNameField.Text);
                }
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "SAVE");
                Clear();
                brand.LoadBrand();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
    }
}
