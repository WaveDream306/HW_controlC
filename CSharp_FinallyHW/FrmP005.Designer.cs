﻿namespace CSharp_FinallyHW
{
    partial class FrmP005
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
            this.pictureBox001 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox001)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox001
            // 
            this.pictureBox001.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox001.Image = global::CSharp_FinallyHW.Properties.Resources.螢幕擷取畫面__882_;
            this.pictureBox001.Location = new System.Drawing.Point(0, 0);
            this.pictureBox001.Name = "pictureBox001";
            this.pictureBox001.Size = new System.Drawing.Size(800, 450);
            this.pictureBox001.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox001.TabIndex = 2;
            this.pictureBox001.TabStop = false;
            // 
            // FrmP005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox001);
            this.Name = "FrmP005";
            this.Text = "FrmP005";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox001)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox001;
    }
}