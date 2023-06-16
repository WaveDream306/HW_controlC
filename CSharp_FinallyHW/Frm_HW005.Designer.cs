namespace CSharp_FinallyHW
{
    partial class Frm_HW005
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HW005));
            this.Lab001 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn加法 = new System.Windows.Forms.Button();
            this.btn減法 = new System.Windows.Forms.Button();
            this.btn乘法 = new System.Windows.Forms.Button();
            this.除法 = new System.Windows.Forms.Button();
            this.LabShow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lab_001 = new System.Windows.Forms.Label();
            this.Lab_002 = new System.Windows.Forms.Label();
            this.Lab_003 = new System.Windows.Forms.Label();
            this.Lab_004 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab001
            // 
            this.Lab001.AutoSize = true;
            this.Lab001.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab001.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Lab001.Location = new System.Drawing.Point(464, 196);
            this.Lab001.Name = "Lab001";
            this.Lab001.Size = new System.Drawing.Size(126, 32);
            this.Lab001.TabIndex = 0;
            this.Lab001.Text = "數字1：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(464, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "數字2：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(464, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "計算結果：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(464, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "===================";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(596, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 36);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(596, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 36);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn加法
            // 
            this.btn加法.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加法.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn加法.Location = new System.Drawing.Point(470, 294);
            this.btn加法.Name = "btn加法";
            this.btn加法.Size = new System.Drawing.Size(50, 50);
            this.btn加法.TabIndex = 7;
            this.btn加法.Text = "+";
            this.btn加法.UseVisualStyleBackColor = true;
            this.btn加法.Click += new System.EventHandler(this.btn加法_Click);
            // 
            // btn減法
            // 
            this.btn減法.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn減法.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn減法.Location = new System.Drawing.Point(540, 294);
            this.btn減法.Name = "btn減法";
            this.btn減法.Size = new System.Drawing.Size(50, 50);
            this.btn減法.TabIndex = 8;
            this.btn減法.Text = "-";
            this.btn減法.UseVisualStyleBackColor = true;
            this.btn減法.Click += new System.EventHandler(this.btn減法_Click);
            // 
            // btn乘法
            // 
            this.btn乘法.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn乘法.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn乘法.Location = new System.Drawing.Point(614, 294);
            this.btn乘法.Name = "btn乘法";
            this.btn乘法.Size = new System.Drawing.Size(50, 50);
            this.btn乘法.TabIndex = 9;
            this.btn乘法.Text = "*";
            this.btn乘法.UseVisualStyleBackColor = true;
            this.btn乘法.Click += new System.EventHandler(this.btn乘法_Click);
            // 
            // 除法
            // 
            this.除法.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.除法.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.除法.Location = new System.Drawing.Point(694, 294);
            this.除法.Name = "除法";
            this.除法.Size = new System.Drawing.Size(50, 50);
            this.除法.TabIndex = 10;
            this.除法.Text = "/";
            this.除法.UseVisualStyleBackColor = true;
            this.除法.Click += new System.EventHandler(this.除法_Click);
            // 
            // LabShow
            // 
            this.LabShow.AutoSize = true;
            this.LabShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabShow.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabShow.ForeColor = System.Drawing.Color.Gold;
            this.LabShow.Location = new System.Drawing.Point(682, 394);
            this.LabShow.MinimumSize = new System.Drawing.Size(100, 20);
            this.LabShow.Name = "LabShow";
            this.LabShow.Size = new System.Drawing.Size(100, 32);
            this.LabShow.TabIndex = 11;
            this.LabShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-53, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lab_001
            // 
            this.Lab_001.AutoSize = true;
            this.Lab_001.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_001.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Lab_001.Location = new System.Drawing.Point(291, 31);
            this.Lab_001.Name = "Lab_001";
            this.Lab_001.Size = new System.Drawing.Size(0, 32);
            this.Lab_001.TabIndex = 13;
            // 
            // Lab_002
            // 
            this.Lab_002.AutoSize = true;
            this.Lab_002.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_002.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Lab_002.Location = new System.Drawing.Point(390, 63);
            this.Lab_002.Name = "Lab_002";
            this.Lab_002.Size = new System.Drawing.Size(0, 32);
            this.Lab_002.TabIndex = 14;
            // 
            // Lab_003
            // 
            this.Lab_003.AutoSize = true;
            this.Lab_003.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_003.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Lab_003.Location = new System.Drawing.Point(486, 95);
            this.Lab_003.Name = "Lab_003";
            this.Lab_003.Size = new System.Drawing.Size(0, 32);
            this.Lab_003.TabIndex = 15;
            // 
            // Lab_004
            // 
            this.Lab_004.AutoSize = true;
            this.Lab_004.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab_004.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Lab_004.Location = new System.Drawing.Point(584, 127);
            this.Lab_004.Name = "Lab_004";
            this.Lab_004.Size = new System.Drawing.Size(0, 32);
            this.Lab_004.TabIndex = 16;
            // 
            // Frm_HW005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lab_004);
            this.Controls.Add(this.Lab_003);
            this.Controls.Add(this.Lab_002);
            this.Controls.Add(this.Lab_001);
            this.Controls.Add(this.LabShow);
            this.Controls.Add(this.除法);
            this.Controls.Add(this.btn乘法);
            this.Controls.Add(this.btn減法);
            this.Controls.Add(this.btn加法);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lab001);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_HW005";
            this.Text = "Frm_HW005";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab001;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn加法;
        private System.Windows.Forms.Button btn減法;
        private System.Windows.Forms.Button btn乘法;
        private System.Windows.Forms.Button 除法;
        private System.Windows.Forms.Label LabShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lab_001;
        private System.Windows.Forms.Label Lab_002;
        private System.Windows.Forms.Label Lab_003;
        private System.Windows.Forms.Label Lab_004;
    }
}