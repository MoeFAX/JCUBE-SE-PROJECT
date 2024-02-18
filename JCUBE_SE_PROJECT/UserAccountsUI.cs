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
    public partial class UserAccountsUI : Form
    {
        public UserAccountsUI()
        {
            InitializeComponent();
        }

        private void CABttn_Click(object sender, EventArgs e)
        {
            CreateAccount moduleForm = new CreateAccount();
            moduleForm.ShowDialog();
        }

        private void ResetPasswordBttn_Click(object sender, EventArgs e)
        {
            ResetPassword moduleForm = new ResetPassword();
            moduleForm.ShowDialog();
        }

        private void CPBttn_Click(object sender, EventArgs e)
        {
            UAChangePassword moduleForm = new UAChangePassword();
            moduleForm.ShowDialog();
        }
    }
}
