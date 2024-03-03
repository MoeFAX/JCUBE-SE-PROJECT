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
        SqlDataReader dr;
        PosUI clerk;
        public CartUI(PosUI clerk)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            getDate();
            getTransNo();
            this.clerk = clerk;
        }
        private void btnDiscount_Click(object sender, EventArgs e)
        {
           Discount discount= new Discount(this);
            discount.lbid.Text = id;
            discount.totalPriceTB.Text = price;
            discount.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProduct searchProduct = new SearchProduct(this.clerk, this);
            searchProduct.LoadItemList();
            searchProduct.ShowDialog();
        }

        public void LoadCart()
        {
            double total = 0;
            double discount = 0;
            
            dgvCart.Rows.Clear();
            cn.Open();

            cm = new SqlCommand("SELECT c.id, c.inventoryCode, p.Description, c.srp, c.qty, c.discount, c.total FROM tbCart AS c INNER JOIN tbItemList AS p ON c.inventoryCode = p.InventoryCode WHERE c.transNo LIKE @transNo and c.status LIKE 'Pending'", cn);
            cm.Parameters.AddWithValue("@transNo", TransNoVal.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
               
                total += Convert.ToDouble(dr["total"].ToString());
                discount += Convert.ToDouble(dr["discount"].ToString());
                dgvCart.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), double.Parse(dr[6].ToString()).ToString("#,##0.00"));

            }
            dr.Close();
            cn.Close();

            SalesTotalVal.Text = total.ToString("#,##0.00");
            discountVal.Text = discount.ToString("#,##0.00");
            GetCartTotal();

        }

        public void GetCartTotal()
        {
            double discount = double.Parse(discountVal.Text);
            double sales = double.Parse(SalesTotalVal.Text) - discount;
            double vat = sales * 0.12; // change accordingly
            double vatable = sales - vat;

            vatVal.Text = vat.ToString("#,##0.00");
            vatableVal.Text = vatable.ToString("#,##0.00");
            SalesTotalVal.Text = sales.ToString("#,##0.00");
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
    }
}

