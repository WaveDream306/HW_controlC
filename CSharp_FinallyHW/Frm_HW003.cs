using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_FinallyHW
{
    public partial class Frm_HW003 : Form
    {
        public Frm_HW003()
        {
            InitializeComponent();
        }
       
        int TotalPrice = 0;
        
        string TotalBuy = "桂花凍胭脂紅 x"+" "+ "\n"
           + "茉香綠茶 x" + "\n"
           + "椪柑綠茶 x" + "\n"
           + "葡萄柚綠 x";
        int P70Count = 0;
        int P70Total = 0;
        int P30Count = 0;
        int P30Total = 0;
        int P50Count = 0;
        int P50Total = 0;
        int P90Count = 0;
        int P90Total = 0;
        private void button1_Click(object sender, EventArgs e)
        {        
            TotalPrice += 70;
            LabTotal.Text = "NT$" + TotalPrice.ToString();
            LabList.Text = TotalBuy;


            P70Count += 1;
            P70Total += 70;
            LabP70.Text = P70Count.ToString() + ",NT$" + P70Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TotalPrice += 30;
            LabTotal.Text = "NT$" + TotalPrice.ToString();
            LabList.Text = TotalBuy;

            P30Count += 1;
            P30Total += 30;
            LabP30.Text = P30Count.ToString() + ",NT$" + P30Total.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TotalPrice += 50;
            LabTotal.Text = "NT$" + TotalPrice.ToString();
            LabList.Text = TotalBuy;

            P50Count += 1;
            P50Total += 50;
            LabP50.Text = P50Count.ToString() + ",NT$" + P50Total.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TotalPrice += 90;
            LabTotal.Text = "NT$" + TotalPrice.ToString();
            LabList.Text = TotalBuy;

            P90Count += 1;
            P90Total += 90;
            LabP90.Text = P90Count.ToString() + ",NT$" + P90Total.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總共消費:"+ TotalPrice + "元");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("折價後總共消費:" + TotalPrice*0.9+"元");
        }
    }
}
