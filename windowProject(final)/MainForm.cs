using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowProject_final_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void INOUT_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInoutForm UserInoutPage = new UserInoutForm();
            UserInoutPage.Show();
        }

        private void PURCHASE_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseForm PurchasePage = new PurchaseForm();
            PurchasePage.Show();
        }
    }
}
