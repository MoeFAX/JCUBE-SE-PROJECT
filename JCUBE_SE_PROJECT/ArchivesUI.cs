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
    public partial class ArchivesUI : Form
    {
        private string loggedInUsername;
        SqlConnection cn = new SqlConnection();
        DBConnect dbcon = new DBConnect();

        public ArchivesUI(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
            cn = new SqlConnection(dbcon.myConnection());

            AccountDeletion AccountAge = new AccountDeletion();
            AccountAge.AccountAge(cn);
            AccountDeletion ExpiredAccounts = new AccountDeletion();
            ExpiredAccounts.ExpiredAccounts(cn);
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            StocksArchive moduleForm = new StocksArchive(loggedInUsername);
            moduleForm.ShowDialog();
        }
        private void btnItemList_Click(object sender, EventArgs e)
        {
            ItemListArchives moduleForm = new ItemListArchives(loggedInUsername);
            moduleForm.ShowDialog();
        }
    }
}
