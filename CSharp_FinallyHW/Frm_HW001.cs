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
    public partial class Frm_HW001 : Form
    {
        public Frm_HW001()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string Name = txtHomeWorkName.Text;
            string Zodiac = txtZZZ.Text;
            string Constellation = txtHomeWorkConstellation.Text;
            string Weight = txtHomeWorkweight.Text;

            MessageBox.Show("早安~~~"+ "\n" +"在下"+ Name+"\n"+"生肖是"+Zodiac+"神獸"+"\n"+
                "黃道十二宮是"+Constellation+"\n"+"我的可愛有"+Weight+"公噸");
        }
    }
}
