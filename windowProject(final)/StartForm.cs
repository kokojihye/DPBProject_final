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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void JOIN_button_Click(object sender, EventArgs e)
        {
            this.Dispose();

            UserJoinForm UserLoginPage = new UserJoinForm();
            UserLoginPage.Show();
        }

        private void LOGIN_button_Click(object sender, EventArgs e)
        {
            this.Dispose();

            UserLoginForm UserLoginPage = new UserLoginForm();
            UserLoginPage.Show();
        }
    }
}
