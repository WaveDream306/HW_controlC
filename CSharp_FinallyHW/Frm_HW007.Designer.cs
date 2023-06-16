namespace CSharp_FinallyHW
{
    partial class Frm_HW007
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lab007 = new System.Windows.Forms.Label();
            this.PB007 = new System.Windows.Forms.PictureBox();
            this.PB008 = new System.Windows.Forms.PictureBox();
            this.PB009 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB007)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB008)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB009)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lab007
            // 
            this.Lab007.AutoSize = true;
            this.Lab007.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lab007.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lab007.Location = new System.Drawing.Point(945, 9);
            this.Lab007.Name = "Lab007";
            this.Lab007.Size = new System.Drawing.Size(0, 48);
            this.Lab007.TabIndex = 0;
            // 
            // PB007
            // 
            this.PB007.Image = global::CSharp_FinallyHW.Properties.Resources._634e1c205ab72071fe941043f816a9e2f31db3ae;
            this.PB007.Location = new System.Drawing.Point(419, 366);
            this.PB007.Name = "PB007";
            this.PB007.Size = new System.Drawing.Size(360, 360);
            this.PB007.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB007.TabIndex = 1;
            this.PB007.TabStop = false;
            // 
            // PB008
            // 
            this.PB008.Image = global::CSharp_FinallyHW.Properties.Resources._600px_070Weepinbell;
            this.PB008.Location = new System.Drawing.Point(815, 724);
            this.PB008.Name = "PB008";
            this.PB008.Size = new System.Drawing.Size(353, 297);
            this.PB008.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB008.TabIndex = 2;
            this.PB008.TabStop = false;
            // 
            // PB009
            // 
            this.PB009.Image = global::CSharp_FinallyHW.Properties.Resources._600px_075Graveler;
            this.PB009.Location = new System.Drawing.Point(953, 71);
            this.PB009.Name = "PB009";
            this.PB009.Size = new System.Drawing.Size(399, 289);
            this.PB009.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB009.TabIndex = 3;
            this.PB009.TabStop = false;
            // 
            // Frm_HW007
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1634, 867);
            this.Controls.Add(this.PB009);
            this.Controls.Add(this.PB008);
            this.Controls.Add(this.PB007);
            this.Controls.Add(this.Lab007);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_HW007";
            this.Text = "Frm_HW007";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Frm_HW007_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PB007)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB008)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB009)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lab007;
        private System.Windows.Forms.PictureBox PB007;
        private System.Windows.Forms.PictureBox PB008;
        private System.Windows.Forms.PictureBox PB009;
    }
}