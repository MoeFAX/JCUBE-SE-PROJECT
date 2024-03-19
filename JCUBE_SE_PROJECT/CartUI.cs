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
    public partial class CartUI : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string id;
        string price;
        private double originalPrice = 0.0;
        SqlDataReader dr;
        PosUI clerk;
        Qty qty;
        public CartUI(PosUI clerk)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            getDate();
            getTransNo();
            this.clerk = clerk;
            clerkLbl = clerk.lblUserRolePOS;
        }

        

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                //Index of the selected row in the cart
                int selectedRowIndex = dgvCart.CurrentRow.Index;

                //Get orig price by multiplying quantity and unit price
                double originalPrice = Convert.ToDouble(dgvCart.Rows[selectedRowIndex].Cells[3].Value) * Convert.ToDouble(dgvCart.Rows[selectedRowIndex].Cells[4].Value);

                //Check if the selected item has discount
                double existingDiscount = Convert.ToDouble(dgvCart.Rows[selectedRowIndex].Cells[5].Value);

                if (existingDiscount > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("This item already have a discount. Do you want to change it?", "Existing Discount", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Discount discount = new Discount(this);
                        discount.lbid.Text = id;
                        discount.totalPriceTB.Text = originalPrice.ToString("#,##0.00"); 
                        discount.ShowDialog();
                    }
                }
                else
                {
                    Discount discount = new Discount(this);
                    discount.lbid.Text = id;
                    discount.totalPriceTB.Text = originalPrice.ToString("#,##0.00");
                    discount.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProduct searchProduct = new SearchProduct(this.clerk, this);
            searchProduct.LoadItemList();
            searchProduct.ShowDialog();
        }

        public double TotalSales { get; set; }

        public void LoadCart()
        {
            Boolean hasCart = false;
            double total = 0;
            double discount = 0;
            
            dgvCart.Rows.Clear();
            cn.Open();

            cm = new SqlCommand("SELECT c.id, c.inventoryCode, p.Description, c.srp, c.qty, c.discount, c.total FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode WHERE c.transNo LIKE @transNo and c.status LIKE 'Pending'", cn);
            cm.Parameters.AddWithValue("@transNo", TransNoVal.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                originalPrice = Convert.ToDouble(dr["srp"].ToString()) * Convert.ToDouble(dr["qty"].ToString());
                total += Convert.ToDouble(dr["total"].ToString());
                discount += Convert.ToDouble(dr["discount"].ToString());
                dgvCart.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), double.Parse(dr[6].ToString()).ToString("#,##0.00"));
                hasCart = true;
            }
            dr.Close();
            cn.Close();

            SalesTotalVal.Text = total.ToString("#,##0.00");
            discountVal.Text = discount.ToString("#,##0.00");

            GetCartTotal();
            if (hasCart)
            {
               btnClear.Enabled = true;
               clerk.btnSettlePayment.Enabled = true;
               btnDiscount.Enabled = true;
            }
            else
            {
                btnClear.Enabled = false;
                clerk.btnSettlePayment.Enabled = false;
                btnDiscount.Enabled = false;
            }
        }

        public void GetCartTotal()
        {
           /* double discount = double.Parse(discountVal.Text);
            double sales = double.Parse(SalesTotalVal.Text) - discount;*/
            double total = double.Parse(SalesTotalVal.Text);
            double vatable = total / 1.12;
            double vat = vatable * 0.12; // Change Vat accordingly
           

            vatVal.Text = vat.ToString("#,##0.00");
            vatableVal.Text = vatable.ToString("#,##0.00");
            lbDisplayTotal.Text = total.ToString("#,##0.00");
            TotalSales = total;

        }

        public void StartNewTransaction()
        {
            try
            {
                getTransNo();
                LoadCart(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Generate Transaction No.
        public void getTransNo()
        {
            try
            {
                string sDate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transNo;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transNo FROM tbCart WHERE transNo LIKE '" + sDate + "%' ORDER BY id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transNo = dr[0].ToString();
                    count = int.Parse(transNo.Substring(8, 4));
                    TransNoVal.Text = sDate + (count + 1);
                }
                else
                {
                    transNo = sDate + "1001";
                    TransNoVal.Text = transNo;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
               
            }
            
        }

        //Get the Date Today
        public void getDate()
        {
            string sDate = DateTime.Now.ToString("dd/MM/yyyy");
            DateTodayVal.Text = sDate;
        }

        private void dgvCart_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgvCart.CurrentRow.Index;
            id = dgvCart[0,i].Value.ToString();
            price = dgvCart[6,i].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove all items from the cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm= new SqlCommand("Delete from tbCart where transNo LIKE'"+ TransNoVal.Text+"'",cn);
                cm.ExecuteNonQuery();
                cn.Close();
                LoadCart();
                MessageBox.Show("All items has been successfully removed", "Clear Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCart.Columns[e.ColumnIndex].Name;
            if(colName == "CancelOrder")
            {
                if (MessageBox.Show("Remove this item from the cart?", "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.ExecuteQuery("Delete from tbCart where id LIKE'" + dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Item has been successfully removed", "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
            }
            else if (colName == "AddQty")
            {
                qty = new Qty(clerk, this);
                int i = 0;
                cn.Open();
                cm = new SqlCommand("SELECT SUM(Qty) as Qty FROM tbItemList WHERE InventoryCode LIKE'" + dgvCart.Rows[e.RowIndex].Cells[1].Value.ToString() + "' GROUP BY InventoryCode", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();

                if (int.Parse(dgvCart.Rows[e.RowIndex].Cells[4].Value.ToString()) < i)
                {
                    // Reset the discount to 0
                    cn.Open();
                    cm = new SqlCommand("UPDATE tbCart SET qty = qty + @qty, disc_percent = 0 WHERE transNo LIKE @transNo AND InventoryCode LIKE @inventoryCode", cn);
                    cm.Parameters.AddWithValue("@qty", int.Parse(qty.txtQty.Text));
                    cm.Parameters.AddWithValue("@transNo", TransNoVal.Text);
                    cm.Parameters.AddWithValue("@inventoryCode", dgvCart.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Remaining quantity on hand is " + i + "!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (colName == "RemQty")
            {
                qty = new Qty(clerk, this);
                int currentQtyInCart = int.Parse(dgvCart.Rows[e.RowIndex].Cells[4].Value.ToString());
                int qtyToSubtract = int.Parse(qty.txtQty.Text);

                //if item qty reaches 0 delete the item from the cart
                if (currentQtyInCart <= 1 || currentQtyInCart - qtyToSubtract <= 0)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbCart WHERE id = @id", cn);
                    cm.Parameters.AddWithValue("@id", dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();


                    LoadCart();
                }
                else
                {
                    cn.Open();
                    
                    cm = new SqlCommand("UPDATE tbCart SET qty = qty - @qty, disc_percent = 0 WHERE transNo LIKE @transNo AND inventoryCode LIKE @inventoryCode", cn);
                    cm.Parameters.AddWithValue("@qty", qtyToSubtract);
                    cm.Parameters.AddWithValue("@transNo", TransNoVal.Text);
                    cm.Parameters.AddWithValue("@inventoryCode", dgvCart.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.ExecuteNonQuery();
                    cn.Close();

                    LoadCart();
                }
            }
        }
    }
}

