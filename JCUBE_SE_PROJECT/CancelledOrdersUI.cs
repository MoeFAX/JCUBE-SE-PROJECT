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
        public CancelledOrdersUI()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
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
                }
                else
                {
                    while (dr.Read())
                    {
                        dgvCancel.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), DateTime.Parse(dr[6].ToString()).ToShortDateString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                    }
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnLoadCancelled_Click(object sender, EventArgs e)
        {
            LoadCancel();
        }
    }
}
