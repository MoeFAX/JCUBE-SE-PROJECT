using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        private string logUsername;
        public Supplier(string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            logUsername = username;
            LoadSupplier();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            SupplierModule moduleForm = new SupplierModule(this, logUsername);
            moduleForm.ShowDialog();
        }

        public void LoadSupplier()
        {
            
            dgvSupplier.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbSupplier", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                

                dgvSupplier.Rows.Add(dr["SupplierID"].ToString(), dr["SupplierName"].ToString(), dr["Address"].ToString(), dr["ContactPerson"].ToString(), dr["PhoneNo"].ToString(), dr["EmailAddress"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgvSupplier.Columns[e.ColumnIndex].Name;
                if (colName == "Archive")
                {
                    string supplierID = dgvSupplier.Rows[e.RowIndex].Cells["SupplierID"].Value.ToString();

                    // Check if the supplier is used in other records
                    bool isUsed = false;
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbStockEntry WHERE sid = @SupplierID", cn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                        cn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        cn.Close();
                        isUsed = (count > 0);
                    }

                    if (isUsed)
                    {
                        MessageBox.Show("Cannot delete the supplier as it is used in other records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Perform deletion of the supplier record
                            cn.Open();
                            cm = new SqlCommand("DELETE FROM tbSupplier WHERE SupplierID = @SupplierID", cn);
                            cm.Parameters.AddWithValue("@SupplierID", supplierID);
                            cm.ExecuteNonQuery();
                            string logAction = "DELETE";
                            string logType = "SUPPLIER";
                            string logDescription = "Deleted a Brand";
                            LogDao log = new LogDao(cn);
                            log.AddLogs(logAction, logType, logDescription, logUsername);
                            cn.Close();
                            MessageBox.Show("Supplier has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Remove the supplier from the DataGridView
                            dgvSupplier.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }

                else if (colName == "Edit")
                {
                    
                    //supplierModule.lblid.Text = dgvSupplier[1, e.RowIndex].Value.ToString();
                    int supplierID = Convert.ToInt32(dgvSupplier.Rows[e.RowIndex].Cells["SupplierID"].Value);
                    SupplierModule supplierModule = new SupplierModule(this, logUsername);
                    supplierModule.SupplierID = supplierID; // Set SupplierID property
                    supplierModule.SupplierNameField.Text = dgvSupplier[1, e.RowIndex].Value.ToString();
                    supplierModule.AddressField.Text = dgvSupplier[2, e.RowIndex].Value.ToString();
                    supplierModule.ContactField.Text = dgvSupplier[3, e.RowIndex].Value.ToString();
                    supplierModule.PhoneField.Text = dgvSupplier[4, e.RowIndex].Value.ToString();
                    supplierModule.EmailAddField.Text = dgvSupplier[5, e.RowIndex].Value.ToString();
                    supplierModule.SaveBtn.Enabled = true;
                    supplierModule.ShowDialog();

                }
                LoadSupplier();
            }
        }
    }
}
