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
using System.Text.RegularExpressions;

namespace JCUBE_SE_PROJECT
{
    public partial class AddItem : Form
    {
        private int itemID;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        ItemList itemList;
        public AddItem(ItemList iL)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            itemList = iL; 
            LoadBrand();
            LoadCategory();
        }



        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        public void LoadCategory()
        {
            CategoryField.Items.Clear();
            CategoryField.DataSource = dbcon.getTable("SELECT * FROM tbCategory");
            CategoryField.DisplayMember = "CategoryName";
            CategoryField.ValueMember = "CategoryID";
        }

        public void LoadBrand()
        {
            BrandField.Items.Clear();
            BrandField.DataSource = dbcon.getTable("SELECT * FROM tbBrand");
            BrandField.DisplayMember = "BrandName";
            BrandField.ValueMember = "BrandID";
        }

        public void Clear()
        {
            InvCodeField.Clear();
            ItemCodeField.Clear();
            DescriptionField.Clear();
            AcquiredCostField.Clear();
            BrandField.SelectedIndex = 0;
            CategoryField.SelectedIndex = 0;
            PriceField.Clear();
            reorderField.Value = 1;
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


                if (string.IsNullOrWhiteSpace(InvCodeField.Text) ||
                    string.IsNullOrWhiteSpace(ItemCodeField.Text) ||
                    string.IsNullOrWhiteSpace(DescriptionField.Text) ||
                    string.IsNullOrWhiteSpace(AcquiredCostField.Text) ||
                    string.IsNullOrWhiteSpace(PriceField.Text))
                {
                    MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string invCode = InvCodeField.Text.ToUpper();
                string pattern = @"^INVC-[A-Z]{6}-\d{4}$";
                bool isValidInvCode = Regex.IsMatch(invCode, pattern);

                if (!isValidInvCode)
                {
                    MessageBox.Show("Invalid Inventory Code format. Please follow the format: INVC-XXXXXX-XXXX", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!double.TryParse(AcquiredCostField.Text, out double acquiredCost) ||
                    !double.TryParse(PriceField.Text, out double price))
                {
                    MessageBox.Show("Acquired Cost and SRP should be numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string reorderString = reorderField.Value.ToString();
                foreach (char c in reorderString)
                {
                    if (!char.IsDigit(c))
                    {
                        if (c == '-')
                        {
                            MessageBox.Show("Reorder should contain only numbers and not a single '-' character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Reorder should contain only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }

                if  (Convert.ToInt32(reorderField.Value) <= 0)
                {
                    MessageBox.Show("Reorder should must be a positive integer and it should not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                if (itemID != 0) // Check if itemID is set (indicating an existing record)
                {
                    string InvCode = InvCodeField.Text.Trim(); 
                    SqlCommand checkinv = new SqlCommand("SELECT COUNT(*) FROM tbItemList WHERE InventoryCode = @InventoryCode", cn);
                    checkinv.Parameters.AddWithValue("@InventoryCode", InvCode);
                    int invcodeCount = (int)checkinv.ExecuteScalar();

                    

                    // Update operation
                    cm = new SqlCommand("UPDATE tbItemList SET InventoryCode = @InventoryCode, ItemCode = @ItemCode, Description = @Description, AcquiredCost = @AcquiredCost, bid = @bid, cid = @cid, Price = @Price, Reorder = @Reorder WHERE ItemID = @ItemID", cn);
                    cm.Parameters.AddWithValue("@ItemID", itemID);
                    
                }
                else
                {
                    string InvCode2 = InvCodeField.Text.Trim();
                    SqlCommand checkinv = new SqlCommand("SELECT COUNT(*) FROM tbItemList WHERE InventoryCode = @InventoryCode", cn);
                    checkinv.Parameters.AddWithValue("@InventoryCode", InvCode2);
                    int invcodeCount = (int)checkinv.ExecuteScalar();

                    if (invcodeCount > 0)
                    {
                        MessageBox.Show("Inventory Code already exists. Please enter a unique inventory code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string itemCode = ItemCodeField.Text.Trim();
                    SqlCommand checkitem = new SqlCommand("SELECT COUNT(*) FROM tbItemList WHERE ItemCode = @ItemCode", cn);
                    checkitem.Parameters.AddWithValue("@ItemCode", itemCode);
                    int itemcodeCount = (int)checkitem.ExecuteScalar();

                    if (itemcodeCount > 0)
                    {
                        MessageBox.Show("Item Code already exists. Please enter a unique item code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string desc = ItemCodeField.Text.Trim();
                    SqlCommand checkdesc = new SqlCommand("SELECT COUNT(*) FROM tbItemList WHERE Description = @Description", cn);
                    checkdesc.Parameters.AddWithValue("@Description", desc);
                    int descCount = (int)checkdesc.ExecuteScalar();

                    if (descCount > 0)
                    {
                        MessageBox.Show("Description already exists. Please enter a unique desciption.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Insert operation
                    cm = new SqlCommand("INSERT INTO tbItemList(InventoryCode, ItemCode, Description, AcquiredCost, bid, cid, Price, Reorder) VALUES(@InventoryCode, @ItemCode, @Description, @AcquiredCost, @bid, @cid, @Price, @Reorder)", cn);
                    
                }

                // Common parameters for both update and insert operations
                cm.Parameters.AddWithValue("@InventoryCode", InvCodeField.Text);
                cm.Parameters.AddWithValue("@ItemCode", ItemCodeField.Text);
                cm.Parameters.AddWithValue("@Description", DescriptionField.Text);
                cm.Parameters.AddWithValue("@AcquiredCost", acquiredCost);
                cm.Parameters.AddWithValue("@bid", BrandField.SelectedValue);
                cm.Parameters.AddWithValue("@cid", CategoryField.SelectedValue);
                cm.Parameters.AddWithValue("@Price", price);
                cm.Parameters.AddWithValue("@Reorder", reorderField.Value);

                cm.ExecuteNonQuery();
                MessageBox.Show("Record has been successfully saved.", "SAVE");
                Clear();
                itemList.LoadItemList();
                this.Close();
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


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        
    }
}
