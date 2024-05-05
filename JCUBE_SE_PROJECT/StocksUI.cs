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
    public partial class StocksUI : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        

        private string _loggedInUsername;
        public StocksUI(string loggedInUsername)
        {
            InitializeComponent();
            _loggedInUsername = loggedInUsername;
            cn = new SqlConnection(dbcon.myConnection());
            LoadStocks();
            int currentYear = DateTime.Now.Year;
            dtpStockStartDate.MinDate = new DateTime(currentYear, 1, 1);
            dtpStockStartDate.MaxDate = new DateTime(currentYear, 12, 31);
            dtpStockEndDate.MinDate = new DateTime(currentYear, 1, 1);
            dtpStockEndDate.MaxDate = new DateTime(currentYear, 12, 31);

            AccountDeletion AccountAge = new AccountDeletion();
            AccountAge.AccountAge(cn);
            AccountDeletion ExpiredAccounts = new AccountDeletion();
            ExpiredAccounts.ExpiredAccounts(cn);
        }




        public void LoadStocks()
        {
            if (dtpStockStartDate.Value.Date > dtpStockEndDate.Value.Date)
            {
                MessageBox.Show("Start date must be earlier than end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the validation fails
            }
            dgvStockEntry.Rows.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT se.StockID, se.RefNo, il.Description, se.Stocks, s.SupplierName, se.StockInDate, se.Status FROM tbStockEntry AS se INNER JOIN tbItemList AS il ON il.InventoryCode = se.ilid INNER JOIN tbSupplier AS s ON s.SupplierID = se.sid WHERE CAST(se.StockInDate AS date) BETWEEN @StartDate AND @EndDate", cn);
                cm.Parameters.AddWithValue("@StartDate", dtpStockStartDate.Value.Date);
                cm.Parameters.AddWithValue("@EndDate", dtpStockEndDate.Value.Date);
                using (dr = cm.ExecuteReader())
                {
                    List<object[]> StocksData = new List<object[]>();

                    while (dr.Read())
                    {

                        StocksData.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString() });
                    }


                    foreach (object[] row in StocksData)
                    {
                        dgvStockEntry.Rows.Add(row);
                    }
                }
                



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stocks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            StockEntry moduleForm = new StockEntry(this, _loggedInUsername);
            moduleForm.StockinbyField.Text = _loggedInUsername;
            moduleForm.StatusField.SelectedItem = "Pending";
            moduleForm.ShowDialog();
        }

        private void dgvStockEntry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cn.Open();
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string colName = dgvStockEntry.Columns[e.ColumnIndex].Name;
                    if (colName == "Delete")
                    {
                        if (MessageBox.Show("Are you sure you want to archive this record?", "Archive Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {


                            string stockID = dgvStockEntry.Rows[e.RowIndex].Cells["StockID"].Value.ToString();
                            string status = dgvStockEntry.Rows[e.RowIndex].Cells["Status"].Value.ToString();


                            cm = new SqlCommand(@"INSERT INTO tbStockEntryArchive(StockID, RefNo, ilid, sid, Stocks, Status, StockInBy, StockInDate, InventoryCode) 
                      SELECT se.StockID, se.RefNo, se.ilid, se.sid, se.Stocks, se.Status, se.StockInBy, se.StockInDate, il.InventoryCode
                      FROM tbStockEntry AS se
                      INNER JOIN tbItemList AS il ON il.InventoryCode = se.ilid
                      WHERE StockID = @StockID DELETE FROM tbStockEntry WHERE StockID = @StockID", cn);
                            cm.Parameters.AddWithValue("@StockID", stockID);
                            cm.ExecuteNonQuery();
                            string logAction = "ARCHIVE";
                            string logType = "STOCKS";
                            string logDescription = "Archived a Stock";
                            LogDao log = new LogDao(cn);
                            log.AddLogs(logAction, logType, logDescription, _loggedInUsername);

                            MessageBox.Show("Stock Entry record has been successfully archived.", "ARCHIVE", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            dgvStockEntry.Rows.RemoveAt(e.RowIndex);
                            
                        }
                        cn.Close();
                    }

                    else if (colName == "Edit")
                    {
                        // Get the InventoryCode from the current row
                        int stockID = Convert.ToInt32(dgvStockEntry.Rows[e.RowIndex].Cells["StockID"].Value);


                        try
                        {

                            SqlCommand cmd = new SqlCommand(@"SELECT c.date, s.StockInDate, s.Status, c.status  
                                FROM tbCart c
                                INNER JOIN tbStockEntry s ON c.inventoryCode = s.ilid
                                WHERE s.StockID = @StockID
                                AND s.Status = 'Delivered'
                                AND c.status = 'Complete'
                                AND c.date > s.StockInDate", cn);
                            cmd.Parameters.AddWithValue("@StockID", stockID);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {



                                if (reader.Read())
                                {
                                    // Get the values of the date and time columns from the reader
                                    Console.WriteLine("Inside reader.Read() block");
                                    DateTime cartDate = reader.GetDateTime(0);
                                    DateTime StockDate = reader.GetDateTime(1);
                                    string StockStatus = reader.GetString(2);
                                    string CartStatus = reader.GetString(3);
                                    Console.WriteLine(cartDate.ToString() + " - " + StockDate.ToString() + "-" + StockStatus.ToString() + "-" + CartStatus.ToString());





                                    if (!string.IsNullOrEmpty(cartDate.ToString()) && StockStatus.ToString() == "Delivered" && CartStatus.ToString() == "Complete")
                                    {
                                        Console.WriteLine(cartDate.ToString() + " - " + StockDate.ToString());
                                        if (cartDate > StockDate)
                                        {
                                            //MessageBox.Show("Cannot edit the stock record since a transaction has been made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            //If the cartDateTime date and time are later than StockInDate and StockTime, disable the cell
                                            dgvStockEntry.Rows[e.RowIndex].Cells["Edit"].ReadOnly = true;
                                             
                                        }

                                    }


                                }
                            

                                else
                                {
                                    
                                    dgvStockEntry.Rows[e.RowIndex].Cells["Edit"].ReadOnly = false;
                                    StockEntry moduleForm = new StockEntry(this, _loggedInUsername);
                                    moduleForm.StockID = stockID; // Set SupplierID property
                                    moduleForm.ItemNameField.Text = dgvStockEntry[2, e.RowIndex].Value.ToString();
                                    moduleForm.stocksField.Text = dgvStockEntry[3, e.RowIndex].Value.ToString();
                                    moduleForm.SuppNameField.Text = dgvStockEntry[4, e.RowIndex].Value.ToString();
                                    moduleForm.StatusField.Text = dgvStockEntry[6, e.RowIndex].Value.ToString();
                                    moduleForm.StockinbyField.Text = _loggedInUsername;
                                    reader.Close();
                                    try
                                    {

                                        using (SqlCommand getStockInDateCmd = new SqlCommand("SELECT StockInDate FROM tbStockEntry WHERE StockID = @StockID", cn))
                                        {
                                            getStockInDateCmd.Parameters.AddWithValue("@StockID", stockID);

                                            object stockInDateObj = getStockInDateCmd.ExecuteScalar();
                                            if (stockInDateObj != null && stockInDateObj != DBNull.Value)
                                            {
                                                DateTime stockInDate = Convert.ToDateTime(stockInDateObj);
                                                moduleForm.StockInDate.Value = stockInDate;
                                            }
                                        }
                                        

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    finally
                                    {
                                        reader.Close();
                                        if (cn.State == ConnectionState.Open)
                                        {
                                            cn.Close();
                                        }
                                    }

                                    moduleForm.savebtn.Enabled = true;
                                    moduleForm.ShowDialog();
                                }


                            
                            }
                            if (cn.State == ConnectionState.Open)
                            {
                                cn.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error in edit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                        

                            if (cn.State == ConnectionState.Open)
                            {
                                cn.Close();
                            }
                        }

                    }

                }



                cn.Close();
                LoadStocks();


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

       

        private void dgvStockEntry_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SqlConnection formatcn = new SqlConnection(dbcon.myConnection());
            formatcn.Open();
            try
            {
                
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dgvStockEntry.Columns[e.ColumnIndex].Name == "Edit")
                    {
                        int stockID = Convert.ToInt32(dgvStockEntry.Rows[e.RowIndex].Cells["StockID"].Value);
                        SqlCommand cmd = new SqlCommand(@"SELECT c.date, s.StockInDate, s.Status, c.status  
                                FROM tbCart c
                                INNER JOIN tbStockEntry s ON c.inventoryCode = s.ilid
                                WHERE s.StockID = @StockID
                                AND s.Status = 'Delivered'
                                AND c.status = 'Complete'
                                AND c.date > s.StockInDate", formatcn);
                        
                        cmd.Parameters.AddWithValue("@StockID", stockID);
                        using (SqlDataReader Formatreader = cmd.ExecuteReader())
                        {
                            if (Formatreader.Read())
                            {
                                // Get the values of the date and time columns from the reader
                                Console.WriteLine("Inside reader.Read() block");
                                DateTime cartDate = Formatreader.GetDateTime(0);
                                DateTime StockDate = Formatreader.GetDateTime(1);
                                string StockStatus = Formatreader.GetString(2);
                                string CartStatus = Formatreader.GetString(3);
                                Console.WriteLine(cartDate.ToString() + " - " + StockDate.ToString() + "-" + StockStatus.ToString() + "-" + CartStatus.ToString());


                                formatcn.Close();
                                

                                if (!string.IsNullOrEmpty(cartDate.ToString()) && StockStatus.ToString() == "Delivered" && CartStatus.ToString() == "Complete")
                                {
                                    Console.WriteLine(cartDate.ToString() + " - " + StockDate.ToString());
                                    if (cartDate > StockDate)
                                    {
                                        
                                        e.Value = Properties.Resources.gray_edit;

                                    }

                                }


                            }
                            else
                            {
                                // Change the image of the edit icon to the default icon
                                e.Value = Properties.Resources.edit_icon;
                            }

                        }
                        if (cn.State == ConnectionState.Open)
                        {

                            formatcn.Close();
                        }
                    }
                }
                formatcn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (formatcn.State == ConnectionState.Open)
                {
                    formatcn.Close();
                }
            }
        }

        private void SIERefreshBttn_Click(object sender, EventArgs e)
        {
            LoadStocks();
        }
    }
}
