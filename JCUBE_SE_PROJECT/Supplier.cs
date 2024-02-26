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
    public partial class Supplier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Supplier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadSupplier();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            SupplierModule moduleForm = new SupplierModule(this);
            moduleForm.ShowDialog();
        }

        public void LoadSupplier()
        {
            int i = 0;
            dgvSupplier.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbSupplier", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvSupplier.Rows.Add(i, dr["SupplierID"].ToString(), dr["SupplierName"].ToString(), dr["Address"].ToString(), dr["ContactPerson"].ToString(), dr["PhoneNo"].ToString(), dr["EmailAddress"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSupplier.Columns[e.ColumnIndex].Name;
            if (colName == "Archive")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbSupplier WHERE SupplierID LIKE '" + dgvSupplier[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Supplier has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                SupplierModule supplierModule = new SupplierModule(this);
                supplierModule.lblid.Text = dgvSupplier[1, e.RowIndex].Value.ToString();
                supplierModule.SupplierNameField.Text = dgvSupplier[2, e.RowIndex].Value.ToString();
                supplierModule.AddressField.Text = dgvSupplier[3, e.RowIndex].Value.ToString();
                supplierModule.ContactField.Text = dgvSupplier[4, e.RowIndex].Value.ToString();
                supplierModule.PhoneField.Text = dgvSupplier[5, e.RowIndex].Value.ToString();
                supplierModule.EmailAddField.Text = dgvSupplier[6, e.RowIndex].Value.ToString();
                supplierModule.SaveBtn.Enabled = true;
                supplierModule.ShowDialog();

            }
            LoadSupplier();
        }
    }
}
