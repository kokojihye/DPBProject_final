using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace windowProject_final_
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
