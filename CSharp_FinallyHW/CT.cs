using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_FinallyHW
{
    
    public partial class CT : Form
    {
        public Form currentChildForm;
        public CT()
        {
            InitializeComponent();
        }
        public void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            currentChildForm = null; // 当子窗口关闭时，将当前子窗口设置为 null
        }
        public void CloseCurrentChildForm()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // 关闭当前子窗口
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();

            Frm_HW001 form1 = new Frm_HW001();
            form1.TopLevel = false;
            form1.Parent = this.splitContainer1.Panel2;
            form1.FormClosed += ChildFormClosed;
            form1.Show();
            currentChildForm = form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();
            Frm_HW002 form2 = new Frm_HW002();
            form2.TopLevel = false;
            form2.Parent = this.splitContainer1.Panel2;
            form2.FormClosed += ChildFormClosed;
            form2.Show();
            currentChildForm = form2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();
            Frm_HW003 form3 = new Frm_HW003();
            form3.TopLevel = false;
            form3.Parent = this.splitContainer1.Panel2;
            form3.FormClosed += ChildFormClosed;
            form3.Show();
            currentChildForm = form3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();
            Frm_HW004 form4 = new Frm_HW004();
            form4.TopLevel = false;
            form4.Parent = this.splitContainer1.Panel2;
            form4.FormClosed += ChildFormClosed;
            form4.Show();
            currentChildForm = form4;
        }

        private void CT_Load(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();
            Frm_HW005 form5 = new Frm_HW005();
            form5.TopLevel = false;
            form5.Parent = this.splitContainer1.Panel2;
            form5.FormClosed += ChildFormClosed;
            form5.Show();
            currentChildForm = form5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();
            Frm_HW006 form6 = new Frm_HW006();
            form6.TopLevel = false;
            form6.Parent = this.splitContainer1.Panel2;
            form6.FormClosed += ChildFormClosed;
            form6.Show();
            currentChildForm = form6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_HW007 form7 = new Frm_HW007();
            form7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CloseCurrentChildForm();
            Frm_HW008 form8 = new Frm_HW008();
            form8.TopLevel = false;
            form8.Parent = this.splitContainer1.Panel2;
            form8.FormClosed += ChildFormClosed;
            form8.Show();
            currentChildForm = form8;
        }
    }
}
