namespace _0dao9shuchu
{
    partial class Form8
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
            this.lblnum = new System.Windows.Forms.Label();
            this.lblpd = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtpd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(50, 67);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(77, 12);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "请输入一个数";
            // 
            // lblpd
            // 
            this.lblpd.AutoSize = true;
            this.lblpd.Location = new System.Drawing.Point(50, 134);
            this.lblpd.Name = "lblpd";
            this.lblpd.Size = new System.Drawing.Size(65, 12);
            this.lblpd.TabIndex = 1;
            this.lblpd.Text = "是否为素数";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(52, 203);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 2;
            this.btnsubmit.Text = "判断";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(160, 202);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(75, 23);
            this.btncancle.TabIndex = 3;
            this.btncancle.Text = "取消";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(143, 57);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 21);
            this.txtnum.TabIndex = 4;
            // 
            // txtpd
            // 
            this.txtpd.Location = new System.Drawing.Point(143, 124);
            this.txtpd.Name = "txtpd";
            this.txtpd.Size = new System.Drawing.Size(100, 21);
            this.txtpd.TabIndex = 5;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtpd);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.lblpd);
            this.Controls.Add(this.lblnum);
            this.Name = "Form8";
            this.Text = "素数判断";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblpd;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtpd;
    }
}