namespace Test01
{
    partial class Form2
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
            this.chkBasketball = new System.Windows.Forms.CheckBox();
            this.chkFootball = new System.Windows.Forms.CheckBox();
            this.chkBadminton = new System.Windows.Forms.CheckBox();
            this.lblhabits = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkBasketball
            // 
            this.chkBasketball.AutoSize = true;
            this.chkBasketball.Location = new System.Drawing.Point(51, 96);
            this.chkBasketball.Name = "chkBasketball";
            this.chkBasketball.Size = new System.Drawing.Size(48, 16);
            this.chkBasketball.TabIndex = 0;
            this.chkBasketball.Text = "篮球";
            this.chkBasketball.UseVisualStyleBackColor = true;
            this.chkBasketball.CheckedChanged += new System.EventHandler(this.chkBall_CheckedChanged);
            // 
            // chkFootball
            // 
            this.chkFootball.AutoSize = true;
            this.chkFootball.Location = new System.Drawing.Point(51, 148);
            this.chkFootball.Name = "chkFootball";
            this.chkFootball.Size = new System.Drawing.Size(48, 16);
            this.chkFootball.TabIndex = 1;
            this.chkFootball.Text = "足球";
            this.chkFootball.UseVisualStyleBackColor = true;
            this.chkFootball.CheckedChanged += new System.EventHandler(this.chkBall_CheckedChanged);
            // 
            // chkBadminton
            // 
            this.chkBadminton.AutoSize = true;
            this.chkBadminton.BackColor = System.Drawing.SystemColors.Control;
            this.chkBadminton.Location = new System.Drawing.Point(51, 203);
            this.chkBadminton.Name = "chkBadminton";
            this.chkBadminton.Size = new System.Drawing.Size(60, 16);
            this.chkBadminton.TabIndex = 2;
            this.chkBadminton.Text = "羽毛球";
            this.chkBadminton.UseVisualStyleBackColor = false;
            this.chkBadminton.CheckedChanged += new System.EventHandler(this.chkBall_CheckedChanged);
            // 
            // lblhabits
            // 
            this.lblhabits.AutoSize = true;
            this.lblhabits.Location = new System.Drawing.Point(208, 100);
            this.lblhabits.Name = "lblhabits";
            this.lblhabits.Size = new System.Drawing.Size(29, 12);
            this.lblhabits.TabIndex = 3;
            this.lblhabits.Text = "爱好";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(210, 128);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(139, 91);
            this.txtOutput.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 402);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblhabits);
            this.Controls.Add(this.chkBadminton);
            this.Controls.Add(this.chkFootball);
            this.Controls.Add(this.chkBasketball);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBasketball;
        private System.Windows.Forms.CheckBox chkFootball;
        private System.Windows.Forms.CheckBox chkBadminton;
        private System.Windows.Forms.Label lblhabits;
        private System.Windows.Forms.TextBox txtOutput;
    }
}