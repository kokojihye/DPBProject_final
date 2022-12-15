using Oracle.DataAccess.Client;
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
        private int intID; //ID 필드 설정
        private string strCommand;
        bool IsSelected = false;


        //데이터 삭제, 추가, 업데이트 인지를 설정할 문자열 필드
        private OracleConnection odpConn = new OracleConnection();
        public int getintID
        { get { return intID; } }
        public string getstrCommand
        { get { return strCommand; } }
        private void showDataGridView() //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = "User Id=kim1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";


                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("SELECT * from users", odpConn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();
                DBGrid.DataSource = dt;
                DBGrid.AutoResizeColumns();
                DBGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DBGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DBGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }
        public UserInoutForm()
        {
            InitializeComponent();
        }

        private Boolean ClickEvent(int seatnum, bool IsSelected)
        {
            //이미 선택된 좌석을 클릭한 경우(퇴실)
            if (IsSelected == true)
            {
                DialogResult dialogResult = MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //퇴실 확인
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show(Convert.ToString(seatnum)+"번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    IsSelected = false;

                }
                //퇴실 취소
                else if (dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("선택을 취소하였습니다.");
                    this.Show();
                }
            }

            //비어있던 좌석을 선택한 경우(입실)
            else if (IsSelected == false)
            {
                DialogResult dialogResult = MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //입실 확인
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show(Convert.ToString(seatnum)+"번 좌석에 입실 처리 되었습니다.");
                    IsSelected = true;
                    this.Show();

                }
                //입실 취소
                else if (dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("선택을 취소하였습니다.");
                    this.Show();
                }
            }
            return IsSelected;
        }

        private Color SetColor(bool IsSelected)
        {
            Color selectedColor = Color.LightGray;
            if (IsSelected == false)
            {
                selectedColor = Color.PeachPuff;
                //MessageBox.Show("좌석이 선택되지 않았습니다.");
            }
            else if (IsSelected == true)
            {
                selectedColor = Color.LightGray;
                //MessageBox.Show("좌석이 선택되었습니다.");
            }
            return selectedColor;
        }


        private void seat1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            bool IsSelected1 = ClickEvent(1,IsSelected); //clickevent함수로 입실/퇴실 선택
            seat1.BackColor = SetColor(IsSelected1); //입실퇴실에 따라 좌석 색상 변경
            IsSelected = IsSelected1;
        }

        private void seat2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            bool IsSelected2 = ClickEvent(2, IsSelected);
            seat2.BackColor = SetColor(IsSelected2);
            IsSelected = IsSelected2;
        }

        private void seat3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            bool IsSelected3 = ClickEvent(3, IsSelected);
            seat3.BackColor = SetColor(IsSelected3);
            IsSelected = IsSelected3;
        }

        private void seat4_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            bool IsSelected4 = ClickEvent(4, IsSelected);
            seat4.BackColor = SetColor(IsSelected4);
            IsSelected = IsSelected4;
        }

        private void seat5_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
            bool IsSelected5 = ClickEvent(5, IsSelected);
            seat5.BackColor = SetColor(IsSelected5);
            IsSelected = IsSelected5;
        }

        private void seat6_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true;
            bool IsSelected6 = ClickEvent(6, IsSelected);
            seat6.BackColor = SetColor(IsSelected6);
            IsSelected = IsSelected6;
        }

        private void seat7_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            bool IsSelected7 = ClickEvent(7, IsSelected);
            seat7.BackColor = SetColor(IsSelected7);
            IsSelected = IsSelected7;
        }

        private void seat8_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
            bool IsSelected8 = ClickEvent(8, IsSelected);
            seat8.BackColor = SetColor(IsSelected8);
            IsSelected = IsSelected8;
        }

        private void seat9_Click(object sender, EventArgs e)
        {
            radioButton9.Checked = true;
            bool IsSelected9 = ClickEvent(9, IsSelected);
            seat9.BackColor = SetColor(IsSelected9);
            IsSelected = IsSelected9;
        }

        private void seat10_Click(object sender, EventArgs e)
        {
            radioButton10.Checked = true;
            bool IsSelected10 = ClickEvent(10, IsSelected);
            seat10.BackColor = SetColor(IsSelected10);
            IsSelected = IsSelected10;
        }
        private void seat11_Click(object sender, EventArgs e)
        {
            radioButton11.Checked = true;
            bool IsSelected11 = ClickEvent(11, IsSelected);
            seat11.BackColor = SetColor(IsSelected11);
            IsSelected = IsSelected11;
        }

        private void seat12_Click(object sender, EventArgs e)
        {
            radioButton12.Checked = true;
            bool IsSelected12 = ClickEvent(12, IsSelected);
            seat12.BackColor = SetColor(IsSelected12);
            IsSelected = IsSelected12;
        }

        private void seat13_Click(object sender, EventArgs e)
        {
            radioButton13.Checked = true;
            bool IsSelected13 = ClickEvent(13, IsSelected);
            seat13.BackColor = SetColor(IsSelected13);
            IsSelected = IsSelected13;
        }

        private void gotomainBtn_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void selectbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
