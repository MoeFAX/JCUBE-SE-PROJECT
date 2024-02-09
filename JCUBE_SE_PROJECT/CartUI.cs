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
    public partial class CartUI : Form
    {
        public CartUI()
        {
            InitializeComponent();
        }
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Discount moduleForm = new Discount();
            moduleForm.ShowDialog();
        }
    }
}
