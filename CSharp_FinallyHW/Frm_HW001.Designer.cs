namespace CSharp_FinallyHW
{
    partial class Frm_HW001
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.txtHomeWorkweight = new System.Windows.Forms.TextBox();
            this.txtHomeWorkConstellation = new System.Windows.Forms.TextBox();
            this.txtZZZ = new System.Windows.Forms.TextBox();
            this.txtHomeWorkName = new System.Windows.Forms.TextBox();
            this.HomeWorkweight = new System.Windows.Forms.Label();
            this.HomeWorkChinese_Zodiac = new System.Windows.Forms.Label();
            this.HomeWorkConstellation = new System.Windows.Forms.Label();
            this.HomeWorkName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSharp_FinallyHW.Properties.Resources.f_18269218_1;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(644, 280);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(92, 33);
            this.btnHello.TabIndex = 19;
            this.btnHello.Text = "早安";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // txtHomeWorkweight
            // 
            this.txtHomeWorkweight.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHomeWorkweight.Location = new System.Drawing.Point(644, 221);
            this.txtHomeWorkweight.Name = "txtHomeWorkweight";
            this.txtHomeWorkweight.Size = new System.Drawing.Size(92, 33);
            this.txtHomeWorkweight.TabIndex = 18;
            // 
            // txtHomeWorkConstellation
            // 
            this.txtHomeWorkConstellation.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHomeWorkConstellation.Location = new System.Drawing.Point(644, 157);
            this.txtHomeWorkConstellation.Name = "txtHomeWorkConstellation";
            this.txtHomeWorkConstellation.Size = new System.Drawing.Size(92, 33);
            this.txtHomeWorkConstellation.TabIndex = 17;
            // 
            // txtZZZ
            // 
            this.txtZZZ.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtZZZ.Location = new System.Drawing.Point(644, 93);
            this.txtZZZ.Name = "txtZZZ";
            this.txtZZZ.Size = new System.Drawing.Size(92, 33);
            this.txtZZZ.TabIndex = 16;
            // 
            // txtHomeWorkName
            // 
            this.txtHomeWorkName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHomeWorkName.Location = new System.Drawing.Point(644, 29);
            this.txtHomeWorkName.Name = "txtHomeWorkName";
            this.txtHomeWorkName.Size = new System.Drawing.Size(92, 33);
            this.txtHomeWorkName.TabIndex = 15;
            // 
            // HomeWorkweight
            // 
            this.HomeWorkweight.AutoSize = true;
            this.HomeWorkweight.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HomeWorkweight.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.HomeWorkweight.Location = new System.Drawing.Point(528, 222);
            this.HomeWorkweight.Name = "HomeWorkweight";
            this.HomeWorkweight.Size = new System.Drawing.Size(110, 32);
            this.HomeWorkweight.TabIndex = 14;
            this.HomeWorkweight.Text = "體重：";
            // 
            // HomeWorkChinese_Zodiac
            // 
            this.HomeWorkChinese_Zodiac.AutoSize = true;
            this.HomeWorkChinese_Zodiac.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HomeWorkChinese_Zodiac.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.HomeWorkChinese_Zodiac.Location = new System.Drawing.Point(528, 94);
            this.HomeWorkChinese_Zodiac.Name = "HomeWorkChinese_Zodiac";
            this.HomeWorkChinese_Zodiac.Size = new System.Drawing.Size(110, 32);
            this.HomeWorkChinese_Zodiac.TabIndex = 13;
            this.HomeWorkChinese_Zodiac.Text = "生肖：";
            // 
            // HomeWorkConstellation
            // 
            this.HomeWorkConstellation.AutoSize = true;
            this.HomeWorkConstellation.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HomeWorkConstellation.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.HomeWorkConstellation.Location = new System.Drawing.Point(528, 158);
            this.HomeWorkConstellation.Name = "HomeWorkConstellation";
            this.HomeWorkConstellation.Size = new System.Drawing.Size(110, 32);
            this.HomeWorkConstellation.TabIndex = 12;
            this.HomeWorkConstellation.Text = "星座：";
            // 
            // HomeWorkName
            // 
            this.HomeWorkName.AutoSize = true;
            this.HomeWorkName.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HomeWorkName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.HomeWorkName.Location = new System.Drawing.Point(528, 30);
            this.HomeWorkName.Name = "HomeWorkName";
            this.HomeWorkName.Size = new System.Drawing.Size(110, 32);
            this.HomeWorkName.TabIndex = 11;
            this.HomeWorkName.Text = "姓名：";
            // 
            // Frm_HW001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtHomeWorkweight);
            this.Controls.Add(this.txtHomeWorkConstellation);
            this.Controls.Add(this.txtZZZ);
            this.Controls.Add(this.txtHomeWorkName);
            this.Controls.Add(this.HomeWorkweight);
            this.Controls.Add(this.HomeWorkChinese_Zodiac);
            this.Controls.Add(this.HomeWorkConstellation);
            this.Controls.Add(this.HomeWorkName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_HW001";
            this.Text = "Frm_HW001";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox txtHomeWorkweight;
        private System.Windows.Forms.TextBox txtHomeWorkConstellation;
        private System.Windows.Forms.TextBox txtZZZ;
        private System.Windows.Forms.TextBox txtHomeWorkName;
        private System.Windows.Forms.Label HomeWorkweight;
        private System.Windows.Forms.Label HomeWorkChinese_Zodiac;
        private System.Windows.Forms.Label HomeWorkConstellation;
        private System.Windows.Forms.Label HomeWorkName;
    }
}