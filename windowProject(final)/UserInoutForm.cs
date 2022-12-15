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
    public partial class UserInoutForm : Form
    {
        public UserInoutForm()
        {
            InitializeComponent();
        }

        

        private void seat1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked=true;
            bool IsSelected = new bool();
            IsSelected = false;

            //이미 좌석이 선택된 경우
            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("1번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("1번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;
                    
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("2번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("2번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("3번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("3번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat4_Click_1(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("4번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("4번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat5_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("5번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("5번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat6_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("6번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("6번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat7_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("7번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("7번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void seat8_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
            bool IsSelected = new bool();
            IsSelected = false;

            if (IsSelected == true)
            {
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("8번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }
            }

            //비어있던 좌석을 선택한 경우
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    MessageBox.Show("8번 좌석에 입실 처리 되었습니다.");
                    seat1.BackColor = Color.LightGray;
                    IsSelected = true;

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void seat9_Click(object sender, EventArgs e)
        {
            radioButton9.Checked = true;
            seat9.BackColor = Color.LightGray;
        }
    }
}
