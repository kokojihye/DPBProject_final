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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductInfo.Text = comboBox1.SelectedItem.ToString();
            //comboBox2.SelectedIndex = -1;
            //comboBox3.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductInfo.Text = comboBox2.SelectedItem.ToString();
            //comboBox1.SelectedIndex = -1;
            //comboBox3.SelectedIndex = -1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductInfo.Text = comboBox3.SelectedItem.ToString();
            //comboBox1.SelectedIndex = -1;
            //comboBox2.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ProductInfo.Text + "을 결제하시겠습니까?","결제확인", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                MainForm mainform = new MainForm();
                mainform.Show();

                MessageBox.Show("결제가 완료되었습니다.");
            }
        }
    }
}
