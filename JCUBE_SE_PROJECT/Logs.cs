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
    public partial class Logs : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Logs()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadLogs();
        }

        public void LoadLogs() 
        {
            dgvLogs.Rows.Clear();
            cn.Open();
            if (string.IsNullOrEmpty(actionComboBox.Text) && string.IsNullOrEmpty(typeComboBox.Text))
            {
                cm = new SqlCommand("SELECT LogID, Action, Type, Description, Username, Date FROM tbLogs WHERE CAST(Date AS date) BETWEEN @StartDate AND @EndDate", cn);

            }
            else if (!string.IsNullOrEmpty(actionComboBox.Text) && string.IsNullOrEmpty(typeComboBox.Text))
            {
                cm = new SqlCommand("SELECT LogID, Action, Type, Description, Username, Date FROM tbLogs WHERE Action = @Action AND CAST(Date AS date) BETWEEN @StartDate AND @EndDate", cn);
                cm.Parameters.AddWithValue("@Action", actionComboBox.Text);
            }
            else if (string.IsNullOrEmpty(actionComboBox.Text) && !string.IsNullOrEmpty(typeComboBox.Text))
            {
                cm = new SqlCommand("SELECT LogID, Action, Type, Description, Username, Date FROM tbLogs WHERE Type = @Type AND CAST(Date AS date) BETWEEN @StartDate AND @EndDate", cn);
                cm.Parameters.AddWithValue("@Type", typeComboBox.Text);
            }
            else 
            {
                cm = new SqlCommand("SELECT LogID, Action, Type, Description, Username, Date FROM tbLogs WHERE Action = @Action AND Type = @Type AND CAST(Date AS date) BETWEEN @StartDate AND @EndDate", cn);
                cm.Parameters.AddWithValue("@Action", actionComboBox.Text);
                cm.Parameters.AddWithValue("@Type", typeComboBox.Text);
            }
            cm.Parameters.AddWithValue("@StartDate", dateFrom.Value.Date);
            cm.Parameters.AddWithValue("@EndDate", dateTo.Value.Date);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvLogs.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToString("yyyy-MM-dd HH:mm:ss"));
            }
            dr.Close();
            cn.Close();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void actionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLogs();
        }

       
    }
}
