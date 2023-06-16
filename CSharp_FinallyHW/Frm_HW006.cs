using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_FinallyHW
{
    public partial class Frm_HW006 : Form
    {
        public Frm_HW006()
        {
            InitializeComponent();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(txtNumber.Text, out int result);

            if (isNum /*txtNumber.Text != ""*/ /*&& txtNumber.Text != string*/)
            {
                int i = int.Parse(txtNumber.Text);
                if (i % 2 == 0)
                {
                    LabResult.Text = i.ToString() + "是偶數哦";
                }
                else
                {
                    LabResult.Text = i.ToString() + "是奇數餒";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字!");
                txtNumber.Clear();
                txtNumber.Focus();
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LabResult.Text = "結果";
            txtNumber.Clear() ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(txtNumber.Text, out int result);
            if (isNum)
            {
                int i = int.Parse(txtNumber.Text);
                if (i % 2 == 0 && i % 3 == 0)
                {
                    LabResult.Text = i.ToString() + "是6的倍數";
                }
                else
                {
                    LabResult.Text = i.ToString() + "不是6的倍數哦 QQ";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字!");
                txtNumber.Clear();
                txtNumber.Focus();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(txtNumber.Text, out int result);
            if (isNum)
            {
                int pn = int.Parse(txtNumber.Text);
                int sum = 0;
                for (int i = 1; i <= pn; i++)
                {
                    if (pn % i == 0)
                    {
                        sum += 1;
                    }
                }
                if (sum == 2)
                {
                    LabResult.Text = "質數";
                }
                else
                {
                    LabResult.Text = "NO NO NO";
                }

            }
            else
            {
                MessageBox.Show("請輸入數字!");
                txtNumber.Clear();
                txtNumber.Focus();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //產生六個號碼
            int ball_1 = 0;
            int ball_2 = 0;
            int ball_3 = 0;
            int ball_4 = 0;
            int ball_5 = 0;
            int ball_6 = 0;
            int[] randomBall = new int[6];
            //產生亂數初始值
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                //隨機產生1~49
                randomBall[i] = rnd.Next(1, 50);

                for (int j = 0; j < i; j++)
                {
                    //檢查號碼是否重複
                    while (randomBall[j] == randomBall[i])
                    {
                        j = 0;
                        //重新產生，存回陣列，亂數產生的範圍是1~49
                        randomBall[i] = rnd.Next(1, 50);
                    }
                }
                ball_1 = randomBall[0];
                ball_2 = randomBall[1];
                ball_3 = randomBall[2];
                ball_4 = randomBall[3];
                ball_5 = randomBall[4];
                ball_6 = randomBall[5];
            }
            LabResult.Text = ball_1.ToString()+","+ ball_2.ToString() + "," + ball_3.ToString() + "," +
                ball_4.ToString() + "," + ball_5.ToString() + "," + ball_6.ToString();
  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(txtNumber.Text, out int re);
            if (isNum)
            {
                int i = int.Parse(txtNumber.Text);
                int result = i * i;
                LabResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字!");
                txtNumber.Clear();
                txtNumber.Focus();
            }


        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(txtNumber.Text, out int re);
            if (isNum)
            {
                decimal infinite = decimal.Parse(txtNumber.Text);
                decimal result = infinite * infinite;
                txtNumber.Text = result.ToString();
                LabResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字!");
                txtNumber.Clear();
                txtNumber.Focus();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LabResult.Text = "2,3,5,7,11\n13,17,19,23,29\n31,37,41,43,47";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LabResult.Text = "1,1,2,3,5,8,\n13,21,34,55,89";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LabResult.Text = "53,59,61,67,71,\n73,79,83,89,97";
        }
    }
}
