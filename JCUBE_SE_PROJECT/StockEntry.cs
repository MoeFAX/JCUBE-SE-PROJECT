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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace JCUBE_SE_PROJECT
{
    public partial class StockEntry : Form
    {
        private int stockID;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        StocksUI stocks;
        public StockEntry(StocksUI Se)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            stocks = Se;
            LoadItemName();
            LoadSupplier();
        }

        public int StockID
        {
            get { return stockID; }
            set { stockID = value; }
        }

        public void LoadItemName()
        {
            ItemNameField.Items.Clear();
            ItemNameField.DataSource = dbcon.getTable("SELECT * FROM tbItemList");
            ItemNameField.DisplayMember = "Description";
            ItemNameField.ValueMember = "ItemID";
        }

        public void LoadSupplier()
        {
            SuppNameField.Items.Clear();
            SuppNameField.DataSource = dbcon.getTable("SELECT * FROM tbSupplier");
            SuppNameField.DisplayMember = "SupplierName";
            SuppNameField.ValueMember = "SupplierID";
        }

        public void Clear()
        {
            ItemNameField.SelectedIndex = 0;
            SuppNameField.SelectedIndex = 0;
            stocksField.Value = 1;
            StatusField.SelectedIndex = 0;
            StockInDate.Value = DateTime.Now;
        }

        public string GenerateReferenceNumber(DateTime stockInDate)
        {
            // Convert the StockInDate to a string in the format "MMddyyyy"
            string datePart = stockInDate.ToString("MMddyyyy");

            // Count the number of records for the given StockInDate
            int recordCount = CountRecordsForDate(stockInDate);

            // Combine the record count and date part to form the reference number
            string referenceNumber = recordCount.ToString("00") + datePart;

            return referenceNumber;
        }

        public int CountRecordsForDate(DateTime stockInDate)
        {
            int recordCount = 0;
            try
            {
                cn.Open();
                // Count the number of records for the given StockInDate
                SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM tbStockEntry WHERE CONVERT(date, StockInDate) = @StockInDate", cn);
                countCmd.Parameters.AddWithValue("@StockInDate", stockInDate.Date);
                recordCount = (int)countCmd.ExecuteScalar();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error counting records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return recordCount;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (stocksField.Value == 0 || string.IsNullOrEmpty(stocksField.Text))
                {
                    MessageBox.Show("Stocks can not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToInt32(stocksField.Value) <= 0)
                {
                    MessageBox.Show("Stocks should must be a positive integer and it should not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generate the reference number based on StockInDate
                string referenceNumber = GenerateReferenceNumber(StockInDate.Value);

                using (cn = new SqlConnection(dbcon.myConnection()))
                {
                    cn.Open();

                    if (stockID != 0) // Check if itemID is set (indicating an existing record)
                    {

                        // Retrieve the old quantity value before updating
                        int oldQuantity = 0;
                        int oldItem = 0;
                        using (SqlCommand getOldDataCmd = new SqlCommand("SELECT Stocks, ilid FROM tbStockEntry WHERE StockID = @StockID", cn))
                        {
                            getOldDataCmd.Parameters.AddWithValue("@StockID", stockID);
                            using (SqlDataReader oldDataReader = getOldDataCmd.ExecuteReader())
                            {
                                if (oldDataReader.Read())
                                {
                                    oldQuantity = Convert.ToInt32(oldDataReader["Stocks"]);
                                    oldItem = Convert.ToInt32(oldDataReader["ilid"]);
                                }
                            }
                        }
                        using (SqlCommand cm = new SqlCommand("UPDATE tbStockEntry SET RefNo = @RefNo, ilid = @ilid, sid = @sid, Stocks = @Stocks, Status = @Status, StockInBy = @StockInBy, StockInDate = @StockInDate WHERE StockID = @StockID", cn))
                        {
                            cm.Parameters.AddWithValue("@RefNo", referenceNumber);
                            cm.Parameters.AddWithValue("@ilid", ItemNameField.SelectedValue);
                            cm.Parameters.AddWithValue("@sid", SuppNameField.SelectedValue);
                            cm.Parameters.AddWithValue("@Stocks", stocksField.Text);
                            cm.Parameters.AddWithValue("@Status", StatusField.SelectedItem.ToString());
                            cm.Parameters.AddWithValue("@StockInBy", StockinbyField.Text);
                            cm.Parameters.AddWithValue("@StockInDate", StockInDate.Value);
                            cm.Parameters.AddWithValue("@StockID", stockID);
                            cm.ExecuteNonQuery();
                            

                            if (oldItem != Convert.ToInt32(ItemNameField.SelectedValue))
                            {
                                using (SqlCommand updateQtyCmd = new SqlCommand("UPDATE tbItemList SET Qty = Qty - @Quantity WHERE ItemID = @ItemID", cn))
                                {
                                    updateQtyCmd.Parameters.AddWithValue("@Quantity", stocksField.Text);
                                    updateQtyCmd.Parameters.AddWithValue("@ItemID", oldItem);
                                    updateQtyCmd.ExecuteNonQuery();
                                }
                            }
                            if (StatusField.SelectedItem.ToString() == "Delivered")
                            {
                                int newQuantity = Convert.ToInt32(stocksField.Text);
                                if (oldQuantity == newQuantity)
                                {
                                    using (SqlCommand updateQtyCmd = new SqlCommand("UPDATE tbItemList SET Qty = Qty + @Quantity WHERE ItemID = @ItemID", cn))
                                    {
                                        updateQtyCmd.Parameters.AddWithValue("@Quantity", stocksField.Text);
                                        updateQtyCmd.Parameters.AddWithValue("@ItemID", ItemNameField.SelectedValue);
                                        updateQtyCmd.ExecuteNonQuery();
                                    }
                                } 
                                else if (oldQuantity != newQuantity)
                                {
                                    if(newQuantity > oldQuantity)
                                    {
                                        int quantityDifference = newQuantity - oldQuantity;
                                        using (SqlCommand updateQtyCmd = new SqlCommand("UPDATE tbItemList SET Qty = Qty + @QuantityDifference WHERE ItemID = @ItemID", cn))
                                        {
                                            updateQtyCmd.Parameters.AddWithValue("@QuantityDifference", quantityDifference);
                                            updateQtyCmd.Parameters.AddWithValue("@ItemID", ItemNameField.SelectedValue);
                                            updateQtyCmd.ExecuteNonQuery();
                                        }
                                    }
                                    else if (newQuantity < oldQuantity)
                                    {
                                        int quantityDifference = oldQuantity - newQuantity;
                                        using (SqlCommand updateQtyCmd = new SqlCommand("UPDATE tbItemList SET Qty = Qty - @QuantityDifference WHERE ItemID = @ItemID", cn))
                                        {
                                            updateQtyCmd.Parameters.AddWithValue("@QuantityDifference", quantityDifference);
                                            updateQtyCmd.Parameters.AddWithValue("@ItemID", ItemNameField.SelectedValue);
                                            updateQtyCmd.ExecuteNonQuery();
                                        }
                                    }
                                    
                                }

                                

                            }

                            if (StatusField.SelectedItem.ToString() == "Pending")
                            {
                                using (SqlCommand updateQtyCmd = new SqlCommand("UPDATE tbItemList SET Qty = Qty - @Quantity WHERE ItemID = @ItemID", cn))
                                {
                                    updateQtyCmd.Parameters.AddWithValue("@Quantity", stocksField.Text);
                                    updateQtyCmd.Parameters.AddWithValue("@ItemID", ItemNameField.SelectedValue);
                                    updateQtyCmd.ExecuteNonQuery();
                                }
                            }

                            // If the status is "Delivered" and the quantity has changed, update tbItemList
                            
                            

                        }
                        
                    }
                    else
                    {
                        // Insert operation
                        using (cm = new SqlCommand("INSERT INTO tbStockEntry(RefNo, ilid, sid, Stocks, Status, StockInBy, StockInDate) VALUES(@RefNo, @ilid, @sid, @Stocks, @Status, @StockInBy, @StockInDate)", cn))
                        {
                            // Insert the new quantity into tbItemList only if the status is "delivered"
                            if (StatusField.SelectedItem.ToString() == "Delivered")
                            {
                                using (SqlCommand updateQtyCmd = new SqlCommand("UPDATE tbItemList SET Qty = Qty + @Quantity WHERE ItemID = @ItemID", cn))
                                {
                                    updateQtyCmd.Parameters.AddWithValue("@Quantity", stocksField.Text);
                                    updateQtyCmd.Parameters.AddWithValue("@ItemID", ItemNameField.SelectedValue);
                                    updateQtyCmd.ExecuteNonQuery();
                                    
                                }
                            }

                            // Common parameters for both update and insert operations
                            cm.Parameters.AddWithValue("@RefNo", referenceNumber);
                            cm.Parameters.AddWithValue("@ilid", ItemNameField.SelectedValue);
                            cm.Parameters.AddWithValue("@sid", SuppNameField.SelectedValue);
                            cm.Parameters.AddWithValue("@Stocks", stocksField.Text);
                            cm.Parameters.AddWithValue("@Status", StatusField.SelectedItem.ToString());
                            cm.Parameters.AddWithValue("@StockInBy", StockinbyField.Text);
                            cm.Parameters.AddWithValue("@StockInDate", StockInDate.Value);
                            cm.ExecuteNonQuery();
                            
                        }
                    }
                }

                MessageBox.Show("Record has been successfully saved.", "SAVE");
                Clear();
                stocks.LoadStocks();
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
