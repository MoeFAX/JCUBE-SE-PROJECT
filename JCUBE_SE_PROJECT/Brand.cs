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
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tbBrand ORDER BY BrandName", cn);
                dr = cm.ExecuteReader();
                
                List<object[]> brandData = new List<object[]>();

                while (dr.Read())
                {
                    i++;
                    brandData.Add(new object[] { i, dr["BrandID"].ToString(), dr["BrandName"].ToString() });
                }
                dr.Close();

                foreach (object[] row in brandData)
                {
                    dgvBrand.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading brands: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the data reader and connection in the finally block
                /*if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }*/
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }


        private void addbtn_Click(object sender, EventArgs e)
        {
            BrandModule moduleForm = new BrandModule(this, logUsername);
            moduleForm.ShowDialog();
        }


        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                        //MessageBox.Show("Cannot delete the brand as it is used in other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvBrand.Rows[e.RowIndex].Cells["Archive"].ReadOnly = true;
                        return;
                    }
                    else
                    {
                        dgvBrand.Rows[e.RowIndex].Cells["Archive"].ReadOnly = false;
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
                            LoadBrand();
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
                    LoadBrand();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void dgvBrand_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvBrand.Columns[e.ColumnIndex].Name == "Archive")
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
                        // Check if the cell is disabled
                        if (isUsed)
                        {
                            // Change the image of the delete icon to a gray icon

                            e.Value = Properties.Resources.delete_gray;

                        }
                        else
                        {
                            // Change the image of the delete icon to the default icon
                            e.Value = Properties.Resources.delete_item;
                        }
                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}
