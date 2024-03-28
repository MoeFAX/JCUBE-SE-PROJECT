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
    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Category()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadCategory();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            CategoryModule moduleForm = new CategoryModule(this);
            moduleForm.ShowDialog();
        }

        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbCategory ORDER BY CategoryName", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr["CategoryID"].ToString(), dr["CategoryName"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Archive")
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
                    MessageBox.Show("Cannot delete the category as it is used in other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tbCategory WHERE CategoryID LIKE '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Category has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
            else if (colName == "Edit")
            {
                CategoryModule categoryModule = new CategoryModule(this);
                categoryModule.lblid.Text = dgvCategory[1, e.RowIndex].Value.ToString();
                categoryModule.CtgryNameField.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                categoryModule.SaveBtn.Enabled = true;
                categoryModule.ShowDialog();

            }
            LoadCategory();
        }
    }
}
