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
    public partial class Frm_HW005 : Form
    {
        public Frm_HW005()
        {
            InitializeComponent();
        }

        private void btn加法_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(textBox1.Text);
            decimal num2 = decimal.Parse(textBox2.Text);
            decimal result = num1 + num2;
            LabShow.Text=result.ToString();
            Lab_001.Text = ("輕輕鬆鬆");
        }

        private void btn減法_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(textBox1.Text);
            decimal num2 = decimal.Parse(textBox2.Text);
            decimal result = num1 - num2;
            LabShow.Text = result.ToString();
            Lab_002.Text = ("小菜一疊");
        }

        private void btn乘法_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(textBox1.Text);
            decimal num2 = decimal.Parse(textBox2.Text);
            decimal result = num1 * num2;
            LabShow.Text = result.ToString();
            Lab_003.Text = ("雕蟲小技");
        }

        private void 除法_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(textBox1.Text);
            decimal num2 = decimal.Parse(textBox2.Text);
            
            if (num2==0)
            {
                LabShow.Text = "無限";
            }
            else
            {
                decimal result = (num1 / num2);
                LabShow.Text = result.ToString("#.##");
                Lab_004.Text = ("略懂略懂");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
