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
    public partial class SupplierModule : Form
    {
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                if (!string.IsNullOrEmpty(SupplierNameField.Text) && int.TryParse(lblid.Text, out int supplierID))
                {
                    // for update

                    cm = new SqlCommand("UPDATE tbSupplier SET SupplierName = @SupplierName WHERE SupplierID = @SupplierID", cn);
                    cm.Parameters.AddWithValue("@SupplierName", SupplierNameField.Text);
                    cm.Parameters.AddWithValue("@SupplierID", supplierID);
                    cm.Parameters.AddWithValue("@Address", AddressField.Text);
                    cm.Parameters.AddWithValue("@ContactPerson", ContactField.Text);
                    cm.Parameters.AddWithValue("@PhoneNo", PhoneField.Text);
                    cm.Parameters.AddWithValue("@EmailAddress", EmailAddField.Text);
                    this.Dispose();

                }
                else
                {
                    // for create
                    cm = new SqlCommand("INSERT INTO tbSupplier(SupplierName, Address, ContactPerson, PhoneNo, EmailAddress) VALUES(@SupplierName, @Address, @ContactPerson, @PhoneNo, @EmailAddress)", cn);
                    cm.Parameters.AddWithValue("@SupplierName", SupplierNameField.Text);
                    cm.Parameters.AddWithValue("@Address", AddressField.Text);
                    cm.Parameters.AddWithValue("@ContactPerson", ContactField.Text);
                    cm.Parameters.AddWithValue("@PhoneNo", PhoneField.Text);
                    cm.Parameters.AddWithValue("@EmailAddress", EmailAddField.Text);
                }
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "SAVE");
                Clear();
                supplier.LoadSupplier();

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
            SupplierNameField.Clear();
            AddressField.Clear();
            ContactField.Clear();
            PhoneField.Clear();
            EmailAddField.Clear();
        }
    }
}
