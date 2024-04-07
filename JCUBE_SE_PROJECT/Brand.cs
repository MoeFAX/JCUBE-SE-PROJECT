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
    public partial class Brand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string logUsername;
        public Brand(string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            logUsername = username;
            LoadBrand();
        }

        

        public void LoadBrand()
        {
            int i = 0;
            dgvBrand.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbBrand ORDER BY BrandName", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvBrand.Rows.Add(i, dr["BrandID"].ToString(), dr["BrandName"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBrand.Columns[e.ColumnIndex].Name;
            if (colName == "Archive")
            {
                string BrandId = dgvBrand[1, e.RowIndex].Value.ToString();

                // Check if the category is used in tbItemList
                bool isUsed = false;
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbItemList WHERE bid = @BrandId", cn))
                {
                    cmd.Parameters.AddWithValue("@BrandId", BrandId);
                    cn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    cn.Close();
                    isUsed = (count > 0);
                }

                if (isUsed)
                {
                    MessageBox.Show("Cannot delete the brand as it is used in other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tbBrand WHERE BrandID LIKE '" + dgvBrand[1, e.RowIndex].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        LogDao log = new LogDao(cn);
                        string logAction = "DELETE";
                        string logType = "BRAND";
                        string logDescription = "Deleted a Brand";
                        log.AddLogs(logAction, logType, logDescription, logUsername);
                        cn.Close();
                        MessageBox.Show("Brand has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            else if (colName == "Edit")
            {
                BrandModule brandModule = new BrandModule(this, logUsername);
                brandModule.lblid.Text = dgvBrand[1, e.RowIndex].Value.ToString();
                brandModule.BrandNameField.Text = dgvBrand[2, e.RowIndex].Value.ToString();
                brandModule.SaveBtn.Enabled = true;
                brandModule.ShowDialog();

            }
            LoadBrand();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            BrandModule moduleForm = new BrandModule(this, logUsername);
            moduleForm.ShowDialog();
        }
    }
}
