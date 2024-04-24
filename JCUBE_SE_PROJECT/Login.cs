using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        string _username = "", _fullname = "", _role = "", _decryptedPassword = "", _encryptedPassword;
        bool _isactive;
        bool found;

        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            NPEyeBtn.MouseDown += new MouseEventHandler(NPEyeBtn_MouseDown);
            NPEyeBtn.MouseUp += new MouseEventHandler(NPEyeBtn_MouseUp);
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
            if (string.IsNullOrWhiteSpace(UserIDtxtbox.Text) || string.IsNullOrWhiteSpace(Passwordtxtbox.Text))
            {
                MessageBox.Show("Fields can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserIDtxtbox.Clear();
                Passwordtxtbox.Clear();
                return;
            }

            if (!string.IsNullOrEmpty(_username))
            {
                StocksUI stocksForm = new StocksUI(_username);
                stocksForm.ShowDialog();
            }
            try
            {

                cn.Open();
                cm = new SqlCommand("Select * From tbUser WHERE username = @username", cn);
                cm.Parameters.AddWithValue("@username", UserIDtxtbox.Text);
                dr = cm.ExecuteReader();
                dr.Read();

                _encryptedPassword = dr["encryptedPassword"].ToString();

                _decryptedPassword = AESHelper.Decrypt(_encryptedPassword);

                if (_decryptedPassword == Passwordtxtbox.Text)
                {
                    if (dr.HasRows)
                    {
                        if (!String.Equals(dr["username"].ToString(), UserIDtxtbox.Text, StringComparison.Ordinal))
                        {
                            MessageBox.Show("Invalid credentials!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            UserIDtxtbox.Clear();
                            Passwordtxtbox.Clear();
                            dr.Close();
                            cn.Close();
                            return;
                        }
                        else
                        {
                            found = true;
                            _username = dr["username"].ToString();
                            _fullname = dr["fullname"].ToString();
                            _role = dr["role"].ToString();
                            _isactive = bool.Parse(dr["isactive"].ToString());
                            dr.Close();
                            cn.Close();
                        }
                    }
                }
                else
                {
                    found = false;
                    dr.Close();
                    cn.Close();
                }

                if (found)
                {
                    if (!_isactive)
                    {
                        MessageBox.Show("Account is inactive. Unable to login", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        UserIDtxtbox.Clear();
                        Passwordtxtbox.Clear();
                        dr.Close();
                        cn.Close();
                        return;
                    }
                    if (_role == "Sales Clerk")
                    {
                        cn.Open();
                        if (cn.State == ConnectionState.Open)
                        {
                            LogDao log = new LogDao(cn);
                            string logAction = "LOGIN";
                            string logType = "ACCOUNTS";
                            string logDescription = "A Sales Clerk logged in";
                            log.AddLogs(logAction, logType, logDescription, _username);
                            Console.WriteLine("Log added successfully. Connection is Open");
                        }
                        else
                        {
                            Console.WriteLine("Connection is Closed. Cannot add log.");
                        }
                        MessageBox.Show("Welcome " + _fullname + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserIDtxtbox.Clear();
                        Passwordtxtbox.Clear();                      
                        dr.Close();
                        cn.Close();
                        this.Hide();
                        PosUI main = new PosUI(_username);
                        CartUI cart = new CartUI(main);                       
                        main.clerk = cart;
                        main.POSNamelbl.Text = _fullname;
                        main.lblUserRolePOS.Text = _username;
                        cart.clerkLbl.Text = _username;
                        main.ShowDialog();
                        //Sales Clerk salesclerk = new Sales Clerk();
                        //Sales Clerk

                    }
                    if (_role == "Administrator")
                    {
                        cn.Open();
                        if (cn.State == ConnectionState.Open)
                        {
                            LogDao log = new LogDao(cn);
                            string logAction = "LOGIN";
                            string logType = "ACCOUNTS";
                            string logDescription = "An Administrator logged in";
                            log.AddLogs(logAction, logType, logDescription, _username);
                            Console.WriteLine("Log added successfully. Connection is Open");
                        }
                        else
                        {
                            Console.WriteLine("Connection is Closed. Cannot add log.");
                        }
                        MessageBox.Show("Welcome " + _fullname + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserIDtxtbox.Clear();
                        Passwordtxtbox.Clear();                      
                        dr.Close();
                        cn.Close();
                        this.Hide();
                        InvUI main = new InvUI(_username);
                        main.INVNamelbl.Text = _fullname;
                        main.lblUserRole.Text = _username;
                        main.UserRole = _username;
                        main.ShowDialog();
                        //Sales Clerk salesclerk = new Sales Clerk();
                        //Sales Clerk

                    }
                }
                else
                {
                    MessageBox.Show("Invalid credentials!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserIDtxtbox.Clear();
                    Passwordtxtbox.Clear();
                    dr.Close();
                    cn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Invalid credentials!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserIDtxtbox.Clear();
                Passwordtxtbox.Clear();
                cn.Close();
            }
        }

        public void NPEyeBtn_MouseDown(object sender, EventArgs e)
        {
            Passwordtxtbox.PasswordChar = '\0';
            Passwordtxtbox.UseSystemPasswordChar = false;
        }

        public void NPEyeBtn_MouseUp(object sender, EventArgs e)
        {
            Passwordtxtbox.PasswordChar = '●';
            Passwordtxtbox.UseSystemPasswordChar = true;
        }
    }
}
