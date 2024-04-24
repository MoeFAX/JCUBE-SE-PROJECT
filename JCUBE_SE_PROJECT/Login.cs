using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
        public int loginAttempt = 0;
        string _decryptedPassword = "", _encryptedPassword;
        bool _isactive;
        bool found;

        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            NPEyeBtn.MouseDown += new MouseEventHandler(NPEyeBtn_MouseDown);
            NPEyeBtn.MouseUp += new MouseEventHandler(NPEyeBtn_MouseUp);
            loginTimer.Tag = 0;
            AccountDeletion AccountAge = new AccountDeletion();
            AccountAge.AccountAge(cn);
            AccountDeletion ExpiredAccounts = new AccountDeletion();
            ExpiredAccounts.ExpiredAccounts(cn);
        }

        private void loginTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (loginAttempt == 5)
                {
                    int secondsLeft = 60 - (int)loginTimer.Tag; 
                    if (secondsLeft > 0)
                    {
                        TimeSpan ts = TimeSpan.FromSeconds(secondsLeft);
                        string timeLeft = ts.ToString(@"hh\:mm\:ss");
                        Timelbl.Text = timeLeft;
                        loginTimer.Tag = (int)loginTimer.Tag + 1;
                    }
                    else
                    {
                        loginTimer.Stop();
                        LoginBtn.Enabled = true;
                        UserIDtxtbox.Enabled = true;
                        Passwordtxtbox.Enabled = true;
                        LoginCloseBttn.Enabled = true;
                        Timerlbl.Visible = false;
                        Timelbl.Visible = false;
                        MessageBox.Show("You may now login again.", "Login Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (loginAttempt == 8)
                {
                    int secondsLeft = 300 - (int)loginTimer.Tag; 
                    if (secondsLeft > 0)
                    {
                        TimeSpan ts = TimeSpan.FromSeconds(secondsLeft);
                        string timeLeft = ts.ToString(@"hh\:mm\:ss");
                        Timelbl.Text = timeLeft;
                        loginTimer.Tag = (int)loginTimer.Tag + 1;
                    }
                    else
                    {
                        loginTimer.Stop();
                        LoginBtn.Enabled = true;
                        UserIDtxtbox.Enabled = true;
                        Passwordtxtbox.Enabled = true;
                        LoginCloseBttn.Enabled = true;
                        Timerlbl.Visible = false;
                        Timelbl.Visible = false;
                        MessageBox.Show("You may now login again.", "Login Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (loginAttempt == 10)
                {
                    int secondsLeft = 900 - (int)loginTimer.Tag; 
                    if (secondsLeft > 0)
                    {
                        TimeSpan ts = TimeSpan.FromSeconds(secondsLeft);
                        string timeLeft = ts.ToString(@"hh\:mm\:ss");
                        Timelbl.Text = timeLeft;
                        loginTimer.Tag = (int)loginTimer.Tag + 1;
                    }
                    else
                    {
                        loginTimer.Stop();
                        LoginBtn.Enabled = true;
                        UserIDtxtbox.Enabled = true;
                        Passwordtxtbox.Enabled = true;
                        LoginCloseBttn.Enabled = true;
                        Timerlbl.Visible = false;
                        Timelbl.Visible = false;
                        MessageBox.Show("You may now login again.", "Login Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (loginAttempt == 15)
                {
                    int secondsLeft = 1800 - (int)loginTimer.Tag; 
                    if (secondsLeft > 0)
                    {
                        TimeSpan ts = TimeSpan.FromSeconds(secondsLeft);
                        string timeLeft = ts.ToString(@"hh\:mm\:ss");
                        Timelbl.Text = timeLeft;
                        loginTimer.Tag = (int)loginTimer.Tag + 1;
                    }
                    else
                    {
                        loginTimer.Stop();
                        LoginBtn.Enabled = true;
                        UserIDtxtbox.Enabled = true;
                        Passwordtxtbox.Enabled = true;
                        LoginCloseBttn.Enabled = true;
                        Timerlbl.Visible = false;
                        Timelbl.Visible = false;
                        MessageBox.Show("You may now login again.", "Login Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (loginAttempt >= 16)
                {
                    int secondsLeft = 3600 - (int)loginTimer.Tag;
                    if (secondsLeft > 0)
                    {
                        TimeSpan ts = TimeSpan.FromSeconds(secondsLeft);
                        string timeLeft = ts.ToString(@"hh\:mm\:ss");
                        Timelbl.Text = timeLeft;
                        loginTimer.Tag = (int)loginTimer.Tag + 1;
                    }
                    else
                    {
                        loginTimer.Stop();
                        LoginBtn.Enabled = true;
                        UserIDtxtbox.Enabled = true;
                        Passwordtxtbox.Enabled = true;
                        LoginCloseBttn.Enabled = true;
                        Timerlbl.Visible = false;
                        Timelbl.Visible = false;
                        MessageBox.Show("You may now login again.", "Login Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string _username = "", _fullname = "", _role = "";
                if (string.IsNullOrWhiteSpace(UserIDtxtbox.Text) || string.IsNullOrWhiteSpace(Passwordtxtbox.Text))
                {
                    loginAttempt += 1;
                    MessageBox.Show("Fields can not be null. Login attempts: " + loginAttempt.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UserIDtxtbox.Clear();
                    Passwordtxtbox.Clear();
                    if (loginAttempt == 5)
                    {
                        UserIDtxtbox.Enabled = false;
                        Passwordtxtbox.Enabled = false;
                        LoginBtn.Enabled = false;
                        LoginCloseBttn.Enabled = false;
                        Timerlbl.Visible = true;
                        Timelbl.Visible = true;
                        loginTimer.Tag = 0;
                        loginTimer.Start();
                        MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (loginAttempt == 8)
                    {
                        UserIDtxtbox.Enabled = false;
                        Passwordtxtbox.Enabled = false;
                        LoginBtn.Enabled = false;
                        LoginCloseBttn.Enabled = false;
                        Timerlbl.Visible = true;
                        Timelbl.Visible = true;
                        loginTimer.Tag = 0;
                        loginTimer.Start();
                        MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (loginAttempt == 10)
                    {
                        UserIDtxtbox.Enabled = false;
                        Passwordtxtbox.Enabled = false;
                        LoginBtn.Enabled = false;
                        LoginCloseBttn.Enabled = false;
                        Timerlbl.Visible = true;
                        Timelbl.Visible = true;
                        loginTimer.Tag = 0;
                        loginTimer.Start();
                        MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (loginAttempt == 15)
                    {
                        UserIDtxtbox.Enabled = false;
                        Passwordtxtbox.Enabled = false;
                        LoginBtn.Enabled = false;
                        LoginCloseBttn.Enabled = false;
                        Timerlbl.Visible = true;
                        Timelbl.Visible = true;
                        loginTimer.Tag = 0;
                        loginTimer.Start();
                        MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (loginAttempt >= 16)
                    {
                        UserIDtxtbox.Enabled = false;
                        Passwordtxtbox.Enabled = false;
                        LoginBtn.Enabled = false;
                        LoginCloseBttn.Enabled = false;
                        Timerlbl.Visible = true;
                        Timelbl.Visible = true;
                        loginTimer.Tag = 0;
                        loginTimer.Start();
                        MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        cn.Close();
                        return;
                    }
                }
                if (!string.IsNullOrEmpty(_username))
                {
                    StocksUI stocksForm = new StocksUI(_username);
                    stocksForm.ShowDialog();
                }
                using (SqlCommand command = new SqlCommand("SELECT * From tbUser WHERE username = @username", cn))
                {
                    command.Parameters.AddWithValue("@username", UserIDtxtbox.Text);
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            _encryptedPassword = dr["encryptedPassword"].ToString();
                            _decryptedPassword = AESHelper.Decrypt(_encryptedPassword);
                            if (_decryptedPassword == Passwordtxtbox.Text)
                            {
                                if (dr.HasRows)
                                {
                                    if (!String.Equals(dr["username"].ToString(), UserIDtxtbox.Text, StringComparison.Ordinal))
                                    {
                                        loginAttempt += 1;
                                        MessageBox.Show("Invalid credentials! Login attempts: " + loginAttempt.ToString(), "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        UserIDtxtbox.Clear();
                                        Passwordtxtbox.Clear();
                                        dr.Close();
                                        cn.Close();
                                        if (loginAttempt == 5)
                                        {
                                            UserIDtxtbox.Enabled = false;
                                            Passwordtxtbox.Enabled = false;
                                            LoginBtn.Enabled = false;
                                            LoginCloseBttn.Enabled = false;
                                            Timerlbl.Visible = true;
                                            Timelbl.Visible = true;
                                            loginTimer.Tag = 0;
                                            loginTimer.Start();
                                            MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                        else if (loginAttempt == 8)
                                        {
                                            UserIDtxtbox.Enabled = false;
                                            Passwordtxtbox.Enabled = false;
                                            LoginBtn.Enabled = false;
                                            LoginCloseBttn.Enabled = false;
                                            Timerlbl.Visible = true;
                                            Timelbl.Visible = true;
                                            loginTimer.Tag = 0;
                                            loginTimer.Start();
                                            MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                        else if (loginAttempt == 10)
                                        {
                                            UserIDtxtbox.Enabled = false;
                                            Passwordtxtbox.Enabled = false;
                                            LoginBtn.Enabled = false;
                                            LoginCloseBttn.Enabled = false;
                                            Timerlbl.Visible = true;
                                            Timelbl.Visible = true;
                                            loginTimer.Tag = 0;
                                            loginTimer.Start();
                                            MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                        else if (loginAttempt == 15)
                                        {
                                            UserIDtxtbox.Enabled = false;
                                            Passwordtxtbox.Enabled = false;
                                            LoginBtn.Enabled = false;
                                            LoginCloseBttn.Enabled = false;
                                            Timerlbl.Visible = true;
                                            Timelbl.Visible = true;
                                            loginTimer.Tag = 0;
                                            loginTimer.Start();
                                            MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                        else if (loginAttempt >= 16)
                                        {
                                            UserIDtxtbox.Enabled = false;
                                            Passwordtxtbox.Enabled = false;
                                            LoginBtn.Enabled = false;
                                            LoginCloseBttn.Enabled = false;
                                            Timerlbl.Visible = true;
                                            Timelbl.Visible = true;
                                            loginTimer.Tag = 0;
                                            loginTimer.Start();
                                            MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        }
                                        else
                                        {
                                            cn.Close();
                                            return;
                                        }
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
                                loginAttempt += 1;
                                MessageBox.Show("Invalid credentials! Login attempts: " + loginAttempt.ToString(), "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                UserIDtxtbox.Clear();
                                Passwordtxtbox.Clear();
                                dr.Close();
                                cn.Close();
                                if (loginAttempt == 5)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt == 8)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt == 10)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt == 15)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt >= 16)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {
                                    cn.Close();
                                    return;
                                }
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
                                    loginAttempt = 0; // RESET LOCK UP COUNT
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
                                if (_role == "Administrator" || _role == "Super Administrator")
                                {
                                    cn.Open();
                                    if (cn.State == ConnectionState.Open)
                                    {
                                        LogDao log = new LogDao(cn);
                                        string logAction = "LOGIN";
                                        string logType = "ACCOUNTS";
                                        string logDescription = _role + " logged in";
                                        log.AddLogs(logAction, logType, logDescription, _username);
                                        Console.WriteLine("Log added successfully. Connection is Open");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Connection is Closed. Cannot add log.");
                                    }
                                    MessageBox.Show("Welcome " + _fullname + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loginAttempt = 0; // RESET LOCK UP COUNT
                                    UserIDtxtbox.Clear();
                                    Passwordtxtbox.Clear();
                                    dr.Close();
                                    cn.Close();
                                    this.Hide();
                                    InvUI main = new InvUI(_username, _role);
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
                                loginAttempt += 1;
                                MessageBox.Show("Invalid credentials! Login attempts: " + loginAttempt.ToString(), "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                UserIDtxtbox.Clear();
                                Passwordtxtbox.Clear();
                                dr.Close();
                                cn.Close();
                                if (loginAttempt == 5)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt == 8)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt == 10)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt == 15)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt >= 16)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {
                                    cn.Close();
                                    return;
                                }
                            }
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(UserIDtxtbox.Text) || string.IsNullOrWhiteSpace(Passwordtxtbox.Text))
                            {
                                dr.Close();
                                cn.Close();
                                return;
                            }
                            else
                            {
                                loginAttempt += 1;
                                MessageBox.Show("Invalid credentials! Login attempts: " + loginAttempt.ToString(), "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                UserIDtxtbox.Clear();
                                Passwordtxtbox.Clear();
                                dr.Close();
                                cn.Close();
                                if (loginAttempt == 5)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt == 8)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt == 10)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt == 15)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else if (loginAttempt >= 16)
                                {
                                    UserIDtxtbox.Enabled = false;
                                    Passwordtxtbox.Enabled = false;
                                    LoginBtn.Enabled = false;
                                    LoginCloseBttn.Enabled = false;
                                    Timerlbl.Visible = true;
                                    Timelbl.Visible = true;
                                    loginTimer.Tag = 0;
                                    loginTimer.Start();
                                    MessageBox.Show("You have succeeded the maximum number of attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {
                                    cn.Close();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Invalid credentials!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserIDtxtbox.Clear();
                Passwordtxtbox.Clear();
            }
            finally
            {
                cn.Close();
            }
        }

        public void NPEyeBtn_MouseDown(object sender, EventArgs e)
        {
            Passwordtxtbox.PasswordChar = '\0';
            Passwordtxtbox.UseSystemPasswordChar = false;
        }

        private void LoginCloseBttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeBttn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void NPEyeBtn_MouseUp(object sender, EventArgs e)
        {
            Passwordtxtbox.PasswordChar = '●';
            Passwordtxtbox.UseSystemPasswordChar = true;
        }
    }
}
