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
        FirebaseConfig fbc = new FirebaseConfig()
        {
            AuthSecret = "74wa4lLLYMdKI7R22dI3xOYNnY5UFpznf9zb0htV",
            BasePath = "https://windowprogramming-final-work-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void LOGIN_button_Click(object sender, EventArgs e)
        {
            var result = client.Get("가입자 명단/" + IdBox.Text);
            Upload upd = result.ResultAs<Upload>();

            if (upd == null)
            {
                MessageBox.Show("아이디를 잘못 입력하였습니다. 입력하신 내용을 확인해주세요.");
            }
            
            else if (PwBox.Text == upd.pw)
            {
                MessageBox.Show("로그인 되었습니다.");
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();

            }
            else
            {
                MessageBox.Show("비밀번호를 잘못 입력하였습니다. 입력하신 내용을 확인해주세요.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fbc);
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
