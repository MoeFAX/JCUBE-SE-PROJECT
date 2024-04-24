using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCUBE_SE_PROJECT
{
    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        private string _loggedInUsername;
        public Category(string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            _loggedInUsername = username;
            LoadCategory();
        }






        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT * FROM tbCategory ORDER BY CategoryName", cn);
                dr = cm.ExecuteReader();

                List<object[]> categoryData = new List<object[]>();

                while (dr.Read())
                {
                    i++;
                    categoryData.Add(new object[] { i, dr["CategoryID"].ToString(), dr["CategoryName"].ToString() });
                }
                dr.Close();

                foreach (object[] row in categoryData)
                {
                    dgvCategory.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CategoryModule moduleForm = new CategoryModule(this, _loggedInUsername);
            moduleForm.lblUname.Text = _loggedInUsername;
            moduleForm.ShowDialog();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgvCategory.Columns[e.ColumnIndex].Name;
                if (colName == "Delete")
                {
                    string categoryId = dgvCategory[1, e.RowIndex].Value.ToString();

                    // Check if the category is used in tbItemList
                    bool isUsed = false;
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbItemList WHERE cid = @CategoryId", cn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                        cn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        cn.Close();
                        isUsed = (count > 0);
                    }

                    if (isUsed)
                    {
                        //MessageBox.Show("Cannot delete the category as it is used in other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvCategory.Rows[e.RowIndex].Cells["Delete"].ReadOnly = true;
                        return;
                    }
                    else
                    {
                        dgvCategory.Rows[e.RowIndex].Cells["Delete"].ReadOnly = false;
                        if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cn.Open();
                            cm = new SqlCommand("DELETE FROM tbCategory WHERE CategoryID LIKE '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            LogDao log = new LogDao(cn);
                            string logAction = "DELETE";
                            string logType = "CATEGORY";
                            string logDescription = "Deleted a Category";
                            string logUsername = _loggedInUsername;
                            log.AddLogs(logAction, logType, logDescription, logUsername);
                            cn.Close();
                            MessageBox.Show("Category has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCategory();
                        }
                    }

                }
                else if (colName == "Edit")
                {
                    CategoryModule categoryModule = new CategoryModule(this, _loggedInUsername);
                    categoryModule.lblUname.Text = _loggedInUsername;
                    categoryModule.lblid.Text = dgvCategory[1, e.RowIndex].Value.ToString();
                    categoryModule.CtgryNameField.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                    categoryModule.SaveBtn.Enabled = true;
                    categoryModule.ShowDialog();
                    LoadCategory();
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

        private void dgvCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvCategory.Columns[e.ColumnIndex].Name == "Delete")
                    {

                        string categoryId = dgvCategory[1, e.RowIndex].Value.ToString();

                        // Check if the category is used in tbItemList
                        bool isUsed = false;
                        using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbItemList WHERE cid = @CategoryId", cn))
                        {
                            cmd.Parameters.AddWithValue("@CategoryId", categoryId);
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
