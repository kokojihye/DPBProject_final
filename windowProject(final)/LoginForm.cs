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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (IDtext.Text == "kojihye" && PWtext.Text == "000429")
            {
                StartForm startForm1 = new StartForm();
                MessageBox.Show("관리자 계정으로 로그인 되었습니다. 감사합니다!");
                this.Hide(); 
                startForm1.Show();
                

            }
            else if (String.IsNullOrEmpty(IDtext.Text))
            {
                MessageBox.Show("관리자 아이디를 입력해주세요");
                IDtext.Focus();
            }
            else if (String.IsNullOrEmpty(PWtext.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요");
                PWtext.Focus();
            }

            else
                MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.");
        }
    }
}
