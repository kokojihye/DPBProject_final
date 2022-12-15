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

        private void JOIN_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            UserJoinForm UserLoginPage = new UserJoinForm();
            UserLoginPage.Show();
        }

        private void LOGIN_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            UserLoginForm UserLoginPage = new UserLoginForm();
            UserLoginPage.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
