using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Category category;
        private string logUsername;
        public CategoryModule(Category ctgry, string loggedInUsername)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            category = ctgry;
            logUsername = loggedInUsername;
        }

       

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string logAction;
                string logDescription;
                string logType = "CATEGORY";
                if (string.IsNullOrWhiteSpace(CtgryNameField.Text))
                {
                    MessageBox.Show("Category name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cn.Open();
                string categoryName = CtgryNameField.Text.Trim();
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbCategory WHERE CategoryName = @CategoryName", cn);
                checkCmd.Parameters.AddWithValue("@CategoryName", categoryName);
                int categoryCount = (int)checkCmd.ExecuteScalar();

                if (categoryCount > 0)
                {
                    MessageBox.Show("Category name already exists. Please enter a unique category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!string.IsNullOrEmpty(CtgryNameField.Text) && int.TryParse(lblid.Text, out int categoryID))
                {
                    // for update

                    cm = new SqlCommand("UPDATE tbCategory SET CategoryName = @CategoryName WHERE CategoryID = @CategoryID", cn);
                    cm.Parameters.AddWithValue("@CategoryName", CtgryNameField.Text);
                    cm.Parameters.AddWithValue("@CategoryID", categoryID);
                    this.Dispose();
                    logAction = "UPDATE";
                    logDescription = "Updated a Category";
                }
                else
                {
                    // for create
                    cm = new SqlCommand("INSERT INTO tbCategory(CategoryName) VALUES(@CategoryName)", cn);
                    cm.Parameters.AddWithValue("@CategoryName", CtgryNameField.Text);
                    logAction = "CREATE";
                    logDescription = "Created a new Category";
                }
                cm.ExecuteNonQuery();
                LogDao log = new LogDao(cn);               
                log.AddLogs(logAction, logType, logDescription, logUsername);
                MessageBox.Show("Record has been successfully saved.", "SAVE");
                Clear();
                category.LoadCategory();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } finally
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
            CtgryNameField.Clear();
        }

        private void CtgryNameField_TextChanged(object sender, EventArgs e)
        {
            if (CtgryNameField.Text.Length > 0)
            { 
                Asterisk.Visible = false; 
            }
            else
            { 
                Asterisk.Visible = true; 
            }
        }
    }
    
}
