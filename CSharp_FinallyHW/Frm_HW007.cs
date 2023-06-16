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
    public partial class Frm_HW007 : Form
    {
        public Frm_HW007()
        {
            InitializeComponent();
        }

        private void Frm_HW007_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lab007.Text = DateTime.Now.ToString();
            Lab007.Left -= 5;
            //Lab007.Top -= 5;
            if (Lab007.Right < 0)
            {
                Lab007.Left = this.ClientSize.Width;
            }
            PB007.Left -= 15;
            if (PB007.Right < 0)
            {
                PB007.Left = this.ClientSize.Width;
            }
            PB008.Left -= 30;
            if (PB008.Right < 0)
            {
                PB008.Left = this.ClientSize.Width;
            }
            PB009.Left -= 60;
            if (PB009.Right < 0)
            {
                PB009.Left = this.ClientSize.Width;
            }




        }
    }
}
