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
    public partial class Frm_HW002 : Form
    {
        public Frm_HW002()
        {
            InitializeComponent();
        }

        public void btnplan1_Click(object sender, EventArgs e)
        {
            float money = float.Parse(txtmoney.Text);
            float year = float.Parse(txtyear.Text);
            float rate = float.Parse(txtrate.Text);
            float Fmoney = float.Parse(txtFmoney.Text);
            //試算公式：
            //每月應付本息金額之平均攤還率 ＝{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            //(公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年期 ｘ 12)
            //每月應攤還本金與利息試算：
            //平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 
            //＝每月應還本金金額＋每月應付利息金額
            //每月應付利息金額＝本金餘額×月利率
            //每月應還本金金額＝平均每月應攤付本息金額－每月應付利息金額
            //[(1＋月利率)^月數] 設定為AAA 這樣公式 = (AAA×月利率)/(AAA-1)
            float monthrate = rate / 1200;
            float months = year * 12;
            //Math.Pow(1 + monthrate, months)
            double AAA = Math.Pow((1 + monthrate), months);
            Double F = (money - Fmoney) * (AAA * monthrate) / (AAA - 1);
            Double FFF = Math.Round(F);
            string Result001 = ("NT "+FFF+"元").ToString();
            txtMonth.Text = Result001;
            MessageBox.Show(Result001);
        }

        public void btnAllMoney_Click(object sender, EventArgs e)
        {
            float money = float.Parse(txtmoney.Text);
            float year = float.Parse(txtyear.Text);
            float rate = float.Parse(txtrate.Text);
            float Fmoney = float.Parse(txtFmoney.Text);

            float monthrate = rate / 1200;
            float months = year * 12;
            //Math.Pow(1 + monthrate, months)
            double AAA = Math.Pow((1 + monthrate), months);
            Double F = ((money - Fmoney) * (AAA * monthrate) / (AAA - 1))* months;
            Double FFFFF = Math.Round(F);
            string Result002 = ("NT "+FFFFF+"元").ToString();
            txtTotal.Text = Result002;
            MessageBox.Show(Result002);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Frm_HW002_001 f001 = new Frm_HW002_001
                (txtmoney.Text, txtyear.Text, txtrate.Text,
                txtFmoney.Text,txtMonth.Text,txtTotal.Text);


            f001.ShowDialog();

        }
    }
}
