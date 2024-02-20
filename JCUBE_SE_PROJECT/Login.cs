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
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public string _pass = "";
        public bool _isactive;
        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void LoginBtn_Click(object sender, EventArgs e)
        {
            string _username = "", _fullname = "", _role = "";
            try
            {
                bool found;
                cn.Open();
                cm = new SqlCommand("Select * From tbUser Where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", UserIDtxtbox.Text);
                cm.Parameters.AddWithValue("@password", Passwordtxtbox.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _fullname = dr["fullname"].ToString();
                    _role = dr["role"].ToString();
                    _pass = dr["password"].ToString();
                    _isactive = bool.Parse(dr["isactive"].ToString());
                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();

                if(found)
                {
                    if (!_isactive)
                    {
                        MessageBox.Show("Account is inactive. Unable to login", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UserIDtxtbox.Clear();
                        Passwordtxtbox.Clear();
                        return;
                    }
                    if(_role == "Sales Clerk")
                    {
                        MessageBox.Show("Welcome " + _fullname + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserIDtxtbox.Clear();
                        Passwordtxtbox.Clear();
                        this.Hide();
                        PosUI main = new PosUI();
                        main.POSNamelbl.Text = _fullname;
                        main.ShowDialog();
                        //Sales Clerk salesclerk = new Sales Clerk();
                        //Sales Clerk

                    }
                    if (_role == "Administrator")
                    {
                        MessageBox.Show("Welcome " + _fullname + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserIDtxtbox.Clear();
                        Passwordtxtbox.Clear();
                        this.Hide();
                        InvUI main = new InvUI();
                        main.INVNamelbl.Text = _fullname;

                        main.ShowDialog();
                        //Sales Clerk salesclerk = new Sales Clerk();
                        //Sales Clerk

                    }

                }
                else
                {
                    MessageBox.Show("Invalid username and password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UserIDtxtbox.Clear();
            Passwordtxtbox.Clear();
        }
    }
}
