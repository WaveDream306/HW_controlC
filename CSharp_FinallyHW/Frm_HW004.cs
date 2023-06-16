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
    public partial class Frm_HW004 : Form
    {
        public Frm_HW004()
        {
            InitializeComponent();
        }
        string StudentResult = "學生\n------------------\n";
        int StuMax;
        int StuMin;
        Student stu = new Student();
        private void button1_Click(object sender, EventArgs e)
        {
            
            stu.Name=txtName.Text;
            stu.ChScore = int.Parse(txtCh.Text);
            stu.MaScore = int.Parse(txtMa.Text);
            stu.SoScore = int.Parse(txtSo.Text);
            StudentResult = "姓名:" + stu.Name + "\n"
                + "國文:" + stu.ChScore + "\n"
                + "數學:" + stu.MaScore + "\n"
                + "社會:" + stu.SoScore + "\n";
            if (stu.ChScore > stu.MaScore && stu.ChScore > stu.SoScore)
            {
                StuMax = stu.ChScore;
                if(stu.MaScore > stu.SoScore)
                {
                    StuMin= stu.SoScore;
                }
                else
                {
                    StuMin = stu.MaScore;
                }
            }
            else if (stu.MaScore > stu.SoScore)
            {
                StuMax= stu.MaScore;
                if(stu.SoScore > stu.ChScore)
                {
                    StuMin = stu.ChScore;
                }
                else
                {
                    StuMin = stu.SoScore;
                }
            }
            else if (stu.SoScore > stu.MaScore)
            {
                StuMax = stu.SoScore;
                if (stu.MaScore > stu.ChScore)
                {
                    StuMin = stu.ChScore;
                }
                else
                {
                    StuMin = stu.MaScore;
                }
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            LabShow.Text = StudentResult;
        }
        private void btnMm_Click(object sender, EventArgs e)
        {
            if (StuMax == stu.ChScore && StuMin == stu.SoScore)
            {
                LabMaxandmin.Text = "國文最高:" + StuMax.ToString()+"分" + "\n" +
                 "社會較低:" + StuMin.ToString()+"分";
            }
            if (StuMax == stu.ChScore && StuMin == stu.MaScore)
            {
                LabMaxandmin.Text = "國文最高:" + StuMax.ToString() + "分" + "\n" +
                 "數學較低:" + StuMin.ToString() + "分";
            }
            if (StuMax == stu.SoScore && StuMin == stu.ChScore)
            {
                LabMaxandmin.Text = "社會最高:" + StuMax.ToString() + "分" + "\n" +
                 "國文較低:" + StuMin.ToString() + "分";
            }
            if (StuMax == stu.SoScore && StuMin == stu.MaScore)
            {
                LabMaxandmin.Text = "社會最高:" + StuMax.ToString() + "分" + "\n" +
                 "數學較低:" + StuMin.ToString() + "分";
            }
            if (StuMax == stu.MaScore && StuMin == stu.ChScore)
            {
                LabMaxandmin.Text = "數學最高:" + StuMax.ToString() + "分" + "\n" +
                 "國文較低:" + StuMin.ToString() + "分";
            }
            if (StuMax == stu.MaScore && StuMin == stu.SoScore)
            {
                LabMaxandmin.Text = "數學最高:" + StuMax.ToString() + "分" + "\n" +
                 "社會較低:" + StuMin.ToString() + "分";
            }

            //LabMaxandmin.Text = "最高科目成績為:"+StuMax.ToString() +"\n"+
            //     "最低科目成績為:" + StuMin.ToString();
        }
    }
}
