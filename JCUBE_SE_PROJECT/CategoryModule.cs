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
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Category category;
        public CategoryModule(Category ctgry)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            category = ctgry;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CtgryNameField.Text))
                {
                    MessageBox.Show("Brand name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cn.Open();
                if (!string.IsNullOrEmpty(CtgryNameField.Text) && int.TryParse(lblid.Text, out int categoryID))
                {
                    // for update

                    cm = new SqlCommand("UPDATE tbCategory SET CategoryName = @CategoryName WHERE CategoryID = @CategoryID", cn);
                    cm.Parameters.AddWithValue("@CategoryName", CtgryNameField.Text);
                    cm.Parameters.AddWithValue("@CategoryID", categoryID);
                    this.Dispose();

                }
                else
                {
                    // for create
                    cm = new SqlCommand("INSERT INTO tbCategory(CategoryName) VALUES(@CategoryName)", cn);
                    cm.Parameters.AddWithValue("@CategoryName", CtgryNameField.Text);
                }
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "SAVE");
                Clear();
                category.LoadCategory();

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
            CtgryNameField.Clear();
        }
    }
    
}
