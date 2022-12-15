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

        private void btnjoin_Click(object sender, EventArgs e)
        {

            String username = NameBox.Text;
            String userID = PhoneNumBox.Text;
            String userPW = PwBox.Text;
            String userPWCK = PwChBox.Text;
            if (String.IsNullOrEmpty(NameBox.Text))
            {
                MessageBox.Show("이름을 입력해주세요");
                NameBox.Focus();
            }
            else if (String.IsNullOrEmpty(PhoneNumBox.Text))
            {
                MessageBox.Show("휴대폰번호를 입력해주세요");
                PhoneNumBox.Focus();
            }
            else if (String.IsNullOrEmpty(PwBox.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요");
                PwBox.Focus();
            }
            else if (String.IsNullOrEmpty(PwChBox.Text))
            {
                MessageBox.Show("비밀번호를 다시 입력해주세요");
                PwChBox.Focus();
            }

            else if (PwBox.Text != PwChBox.Text)
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

        private void btnmain_Click(object sender, EventArgs e)
        {

        }
    }
}
