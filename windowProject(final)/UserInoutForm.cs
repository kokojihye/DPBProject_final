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
                MessageBox.Show("퇴실하시겠습니까?", "퇴실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    MessageBox.Show(Convert.ToString(seatnum),"번 좌석 퇴실 처리 되었습니다.\n이용해주셔서 감사합니다,");
                    IsSelected = false;
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    UserJoinForm UserJoinPage = new UserJoinForm();
                    UserJoinPage.Show();
                }

                //return IsSelected;
            }

            //비어있던 좌석을 선택한 경우(입실)
            else if (IsSelected == false)
            {
                MessageBox.Show("입실하시겠습니까?", "입실 확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.OK)
                {
                    this.Hide();
                    MessageBox.Show("번 좌석에 입실 처리 되었습니다.");
                    IsSelected = true;
                    MainForm mainform = new MainForm();
                    mainform.Show();

                }
                else if (DialogResult == DialogResult.Cancel)
                {
                    this.Hide();
                    //UserJoinForm UserJoinPage = new UserJoinForm();
                    //UserJoinPage.Show();
                }
                //return IsSelected;
            }
            return IsSelected;
        }

        private void SetColor(bool IsSelected)
        {
            if (IsSelected == false) //좌석이 선택되지 않은 상태
            {
                this.BackColor = Color.PeachPuff;
                MessageBox.Show("좌석이 선택되지 않았습니다.");
            }
            else if (IsSelected == true) //좌석이 선택된 상태
            {
                this.BackColor = Color.LightGray;
                MessageBox.Show("좌석이 선택되었습니다.");

            }
        }


        private void seat1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            IsSelected = ClickEvent(1,IsSelected);
            SetColor(IsSelected);           
        }

        private void seat2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
