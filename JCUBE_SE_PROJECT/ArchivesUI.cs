using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public ArchivesUI()
        {
            InitializeComponent();
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            ItemListArchives moduleForm = new ItemListArchives();
            moduleForm.ShowDialog();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            StocksArchive moduleForm = new StocksArchive(loggedInUsername);
            moduleForm.ShowDialog();
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            DailySalesArchive moduleForm = new DailySalesArchive();
            moduleForm.ShowDialog();
        }
    }
}
