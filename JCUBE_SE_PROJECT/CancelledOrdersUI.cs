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
    public partial class CancelledOrdersUI : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        InvUI adminuser;
        public CancelledOrdersUI(InvUI aduser)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            adminuser = aduser;
            PrintCnclOrders.Enabled = false;

        }

        public void LoadCancel()
        {
            dgvCancel.Rows.Clear();

            DateTime startDate = dateFromCancelled.Value.Date;
            DateTime endDate = dateToCancelled.Value.Date.AddDays(1).AddSeconds(-1);

            try
            {
                cn.Open();

                cm = new SqlCommand("SELECT * FROM tbCancelOrder WHERE date BETWEEN @StartDate AND @EndDate", cn);
                cm.Parameters.AddWithValue("@StartDate", startDate);
                cm.Parameters.AddWithValue("@EndDate", endDate);

                dr = cm.ExecuteReader();
             
                if (!dr.HasRows)
                {
                    MessageBox.Show("No cancelled orders found for the specified date range.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrintCnclOrders.Enabled = false;
                }
                else
                {
                    while (dr.Read())
                    {
                        dgvCancel.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), DateTime.Parse(dr[6].ToString()).ToShortDateString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                    }
                    PrintCnclOrders.Enabled = true;
                }
               
                dr.Close();

                

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvCancel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCancel.Columns[e.ColumnIndex].Name;

            /*if (colName == "Restore")
            {
                string action = dgvCancel.Rows[e.RowIndex].Cells["COActionCol"].Value.ToString();

                // Check if the action is 'Yes' to allow restoration
                if (action == "Yes")
                {
                    if (MessageBox.Show("Are you sure you want to restore this item?", "Restore Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            // Get the values of price, qty, and total from the selected row
                            string price = dgvCancel.Rows[e.RowIndex].Cells["COPriceCol"].Value.ToString();
                            string qty = dgvCancel.Rows[e.RowIndex].Cells["COQuantCol"].Value.ToString();
                            string total = dgvCancel.Rows[e.RowIndex].Cells["COTotalCol"].Value.ToString();
                            string transNo = dgvCancel.Rows[e.RowIndex].Cells["COTransacCol"].Value.ToString();
                            string itemCode = dgvCancel.Rows[e.RowIndex].Cells["COInvCodeCol"].Value.ToString();

                          
                            cn.Open();
                            cm = new SqlCommand("SELECT COUNT(*) FROM tbCart WHERE transNo = @transNo", cn);
                            cm.Parameters.AddWithValue("@transNo", transNo);
                            int transactionCount = (int)cm.ExecuteScalar();
                            cn.Close();

                            cn.Open();

                            if (transactionCount > 0)
                            {

                                cm = new SqlCommand("UPDATE tbCart SET qty = qty + co.qty, status = 'Complete' FROM tbCart c INNER JOIN tbCancelOrder co ON c.transNo = co.transNo AND c.inventoryCode = co.itemCode WHERE c.transNo = @transNo AND co.itemCode = @itemCode", cn);
                                cm.Parameters.AddWithValue("@transNo", transNo);
                                cm.Parameters.AddWithValue("@itemCode", itemCode);
                                cm.ExecuteNonQuery();

                                cm = new SqlCommand("UPDATE tbItemList SET Qty = Qty - @qty WHERE InventoryCode = (SELECT inventoryCode FROM tbCart WHERE transNo = @transNo AND itemCode = @itemCode)", cn);
                                cm.Parameters.AddWithValue("@qty", qty);
                                cm.Parameters.AddWithValue("@transNo", transNo);
                                cm.Parameters.AddWithValue("@itemCode", itemCode);
                                cm.ExecuteNonQuery();
                            }

                            // Delete restored item in tbCancelOrder
                            cm = new SqlCommand("DELETE FROM tbCancelOrder WHERE transNo = @transNo AND itemCode = @itemCode", cn);
                            cm.Parameters.AddWithValue("@transNo", transNo);
                            cm.Parameters.AddWithValue("@itemCode", itemCode);
                            cm.ExecuteNonQuery();

                            cn.Close();

                            MessageBox.Show("Item has been successfully restored.", "RESTORE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadCancel();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            cn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("This item cannot be restored because the item was not added back to the inventory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }*/
            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string transNo = dgvCancel.Rows[e.RowIndex].Cells["COTransacCol"].Value.ToString();
                        string itemCode = dgvCancel.Rows[e.RowIndex].Cells["COInvCodeCol"].Value.ToString();

                        cn.Open();

                        // Delete item from tbCancelOrder
                        cm = new SqlCommand("DELETE FROM tbCancelOrder WHERE transNo = @transNo AND itemCode = @itemCode", cn);
                        cm.Parameters.AddWithValue("@transNo", transNo);
                        cm.Parameters.AddWithValue("@itemCode", itemCode);
                        cm.ExecuteNonQuery();

                        cn.Close();

                        MessageBox.Show("Item has been successfully deleted.", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadCancel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }

        private void PrintCnclOrders_Click_1(object sender, EventArgs e)
        {
            PrintCancelledOrders printCancelledOrders = new PrintCancelledOrders(adminuser);
            printCancelledOrders.LoadPrtCncldOrders(dateFromCancelled.Value, dateToCancelled.Value);
            printCancelledOrders.ShowDialog();
        }

        private void btnLoadCancelled_Click_1(object sender, EventArgs e)
        {
            LoadCancel();
        }
    }
}
