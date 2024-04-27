using Microsoft.Reporting.Map.WebForms.BingMaps;
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
        private string logUsername;
        public SupplierModule(Supplier supp, string username)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            supplier = supp;
            logUsername = username;
        }
        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }

        

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string logAction;
                string logType = "SUPPLIER";
                string logDescription;
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
                    logAction = "UPDATE";
                    logDescription = "Updated a Supplier";
                }
                else
                {
                    string supplierName = SupplierNameField.Text.Trim();
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM tbSupplier WHERE SupplierName = @SupplierName", cn);
                    checkCmd.Parameters.AddWithValue("@SupplierName", supplierName);
                    int supplierCount = (int)checkCmd.ExecuteScalar();

                    if (supplierCount > 0)
                    {
                        MessageBox.Show("Supplier name already exists. Please enter a unique supplier name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Insert operation
                    cm = new SqlCommand("INSERT INTO tbSupplier(SupplierName, Address, ContactPerson, PhoneNo, EmailAddress) VALUES(@SupplierName, @Address, @ContactPerson, @PhoneNo, @EmailAddress)", cn);
                    logAction = "CREATE";
                    logDescription = "Created a new Supplier";
                }

                // Common parameters for both update and insert operations
                cm.Parameters.AddWithValue("@SupplierName", SupplierNameField.Text);
                cm.Parameters.AddWithValue("@Address", AddressField.Text);
                cm.Parameters.AddWithValue("@ContactPerson", ContactField.Text);
                cm.Parameters.AddWithValue("@PhoneNo", PhoneField.Text);
                cm.Parameters.AddWithValue("@EmailAddress", EmailAddField.Text);

                cm.ExecuteNonQuery();
                LogDao log = new LogDao(cn);
                log.AddLogs(logAction, logType, logDescription, logUsername);
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

        private void SupplierNameField_TextChanged(object sender, EventArgs e)
        {
            if (SupplierNameField.Text.Length > 0)
            {
                AsteriskSupp.Visible = false;
            }
            else
            {
                AsteriskSupp.Visible = true;
            }
        }

        private void AddressField_TextChanged(object sender, EventArgs e)
        {
            if (AddressField.Text.Length > 0)
            {
                AsteriskAdd.Visible = false;
            }
            else
            {
                AsteriskAdd.Visible = true;
            }
        }

        private void ContactField_TextChanged(object sender, EventArgs e)
        {
            if (ContactField.Text.Length > 0)
            {
                AsteriskContact.Visible = false;
            }
            else
            {
                AsteriskContact.Visible = true;
            }
        }

        private void PhoneField_TextChanged(object sender, EventArgs e)
        {
            if (PhoneField.Text.Length > 0)
            {
                AsteriskPhone.Visible = false;
            }
            else
            {
                AsteriskPhone.Visible = true;
            }
        }

        private void EmailAddField_TextChanged(object sender, EventArgs e)
        {
            if (EmailAddField.Text.Length > 0)
            {
                AsteriskEmailAdd.Visible = false;
            }
            else
            {
                AsteriskEmailAdd.Visible = true;
            }
        }
        private HashSet<char> specialChar = new HashSet<char>
        {
             '.', '-', '_', '@'
        };

        private HashSet<char> CharForAdd = new HashSet<char>
        {
             '.', '-', '_', '@', ','
        };
        private void SupplierNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) ||
          char.IsWhiteSpace(e.KeyChar) || specialChar.Contains(e.KeyChar) ||
          char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void ContactField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) ||
          char.IsWhiteSpace(e.KeyChar) || specialChar.Contains(e.KeyChar) ||
          char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void EmailAddField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) ||
          char.IsWhiteSpace(e.KeyChar) || specialChar.Contains(e.KeyChar) ||
          char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void AddressField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) ||
          char.IsWhiteSpace(e.KeyChar) || CharForAdd.Contains(e.KeyChar) ||
          char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void PhoneField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
