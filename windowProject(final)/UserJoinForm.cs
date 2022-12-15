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
    public partial class UserJoinForm : Form
    {

        MainForm mainForm1 = new MainForm();

        public UserJoinForm()
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

            Upload upd2 = new Upload()
            {
                name = NameBox.Text,
                id = IdBox.Text,
                pw = PwChBox.Text
            };
            var send = client.Set("가입자 명단/" + IdBox.Text, upd2);
            this.Hide();
            MainForm mainform = new MainForm();
            

            String username = NameBox.Text;
            String userID = IdBox.Text;
            String userPW = PwChBox.Text;
            String userPWCK = PwBox.Text;

            if(userPW == userPWCK)
            {
                MessageBox.Show("회원가입 완료!");
                mainform.Show();
            }
            else
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다. 비밀번호를 다시 입력해주세요.");
                this.Show();
            }
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

            else if(PwBox.Text != PwChBox.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다. 비밀번호를 다시 입력해주세요.");
                this.Show();
            }
            else
            {
                this.Close();
                MessageBox.Show("회원가입이 완료되었습니다. 로그인 후 이용해주세요.");
                mainForm1.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            mainForm1.Show();
        }
        
    }
}
