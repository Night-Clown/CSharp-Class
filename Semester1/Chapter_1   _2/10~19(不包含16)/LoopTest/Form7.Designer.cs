﻿namespace _0dao9shuchu
{
    partial class Form7
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
            this.txtshuchu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtshuchu
            // 
            this.txtshuchu.Location = new System.Drawing.Point(92, 88);
            this.txtshuchu.Multiline = true;
            this.txtshuchu.Name = "txtshuchu";
            this.txtshuchu.Size = new System.Drawing.Size(100, 85);
            this.txtshuchu.TabIndex = 3;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtshuchu);
            this.Name = "Form7";
            this.Text = "数组中奇数与偶数的个数";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtshuchu;
    }
}