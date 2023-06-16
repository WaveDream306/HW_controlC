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
    public partial class Frm_HW002_001 : Form
    {
        public Frm_HW002_001()
        {
            InitializeComponent();
        }

        

        public Frm_HW002_001(string str001, string str002, 
            string str003,string str004,string str005,string str006)
        {
            InitializeComponent();
            txtmoney002.Text = str001;
            txtyear002.Text = str002;
            txtrate002.Text = str003;
            txtFmoney002.Text = str004;
            txtMonth002.Text = str005;
            txtTotal002.Text = str006;


        }

        private void Frm_HW002_001_Load(object sender, EventArgs e)
        {
            //Frm_HW002 f1 = new Frm_HW002();
            //textBox2.Text = f1.str; 
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("準備配送至您的信箱，預計2050年送達");//惡搞可再進階
        }
    }
}
