using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_FinallyHW
{
    public partial class Frm_HW008 : Form
    {
        public Frm_HW008()
        {
            InitializeComponent();
        }

        
        public void SetImageFiles(string[] imageFiles)
        {
            //// 在这里处理图片文件路径，可以将其加载到 PictureBox 控件中显示，或者使用其他方式进行展示
            //// 示例：假设你的表单上有一个名为 pictureBox1 的 PictureBox 控件
            //foreach (string imagePath in imageFiles)
            //{
            //    PictureBox pictureBox = new PictureBox();
            //    pictureBox.Image = Image.FromFile(imagePath);
             
            //    // 在这里设置 PictureBox 的位置、大小等属性
            //    this.Controls.Add(pictureBox); // 添加到表单上显示


               
            }

        private void Frm_HW008_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmP001 form2 = new FrmP001();
            //form2.TopLevel = false;
            //form2.Parent = this.splitContainer1.Panel1;
            form2.Show();
            //this.BackgroundImage = new Bitmap(@"C:\Users\User\Desktop\C#\P\600px-075Graveler.png");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmP002 form2 = new FrmP002();
            form2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmP003 form2 = new FrmP003();
            form2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmP004 form2 = new FrmP004();
            form2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmP005 form2 = new FrmP005();
            form2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmP006 form2 = new FrmP006();
            form2.Show();
        }
    }
}

