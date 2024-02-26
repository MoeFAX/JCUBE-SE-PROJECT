using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCUBE_SE_PROJECT
{
    
    public partial class SupplierModule : Form
    {
        private int supplierID;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Supplier supplier;
        public SupplierModule(Supplier supp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            supplier = supp;
        }
        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                if (string.IsNullOrWhiteSpace(SupplierNameField.Text) ||
                    string.IsNullOrWhiteSpace(AddressField.Text) ||
                    string.IsNullOrWhiteSpace(ContactField.Text) ||
                    string.IsNullOrWhiteSpace(PhoneField.Text) ||
                    string.IsNullOrWhiteSpace(EmailAddField.Text))
                {
                    MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Phone No. follows the format "09XXXXXXXXX"
                if (!Regex.IsMatch(PhoneField.Text, @"^09\d{9}$"))
                {
                    MessageBox.Show("Phone No. should follow the format 09XXXXXXXXX.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if Email Address contains the "@" character
                if (!EmailAddField.Text.Contains("@"))
                {
                    MessageBox.Show("Email Address should contain the '@' character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (supplierID != 0) // Check if SupplierID is set (indicating an existing record)
                {
                    // Update operation
                    cm = new SqlCommand("UPDATE tbSupplier SET SupplierName = @SupplierName, Address = @Address, ContactPerson = @ContactPerson, PhoneNo = @PhoneNo, EmailAddress = @EmailAddress WHERE SupplierID = @SupplierID", cn);
                    cm.Parameters.AddWithValue("@SupplierID", supplierID);
                }
                else
                {
                    // Insert operation
                    cm = new SqlCommand("INSERT INTO tbSupplier(SupplierName, Address, ContactPerson, PhoneNo, EmailAddress) VALUES(@SupplierName, @Address, @ContactPerson, @PhoneNo, @EmailAddress)", cn);
                }

                // Common parameters for both update and insert operations
                cm.Parameters.AddWithValue("@SupplierName", SupplierNameField.Text);
                cm.Parameters.AddWithValue("@Address", AddressField.Text);
                cm.Parameters.AddWithValue("@ContactPerson", ContactField.Text);
                cm.Parameters.AddWithValue("@PhoneNo", PhoneField.Text);
                cm.Parameters.AddWithValue("@EmailAddress", EmailAddField.Text);

                cm.ExecuteNonQuery();
                MessageBox.Show("Record has been successfully saved.", "SAVE");
                Clear();
                supplier.LoadSupplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure connection is closed in all cases
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }





        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }


        public void Clear()
        {
            SupplierNameField.Clear();
            AddressField.Clear();
            ContactField.Clear();
            PhoneField.Clear();
            EmailAddField.Clear();
        }
    }
}
