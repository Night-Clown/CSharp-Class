namespace xueshengchengji
{
    partial class frm2
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
            this.btncancle = new System.Windows.Forms.Button();
            this.btnpd = new System.Windows.Forms.Button();
            this.txtjg = new System.Windows.Forms.TextBox();
            this.txtsc = new System.Windows.Forms.TextBox();
            this.lbljg = new System.Windows.Forms.Label();
            this.lblsc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(208, 236);
            this.btncancle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(100, 29);
            this.btncancle.TabIndex = 11;
            this.btncancle.Text = "取消";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnpd
            // 
            this.btnpd.Location = new System.Drawing.Point(43, 238);
            this.btnpd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpd.Name = "btnpd";
            this.btnpd.Size = new System.Drawing.Size(100, 29);
            this.btnpd.TabIndex = 10;
            this.btnpd.Text = "计算";
            this.btnpd.UseVisualStyleBackColor = true;
            this.btnpd.Click += new System.EventHandler(this.btnpd_Click);
            // 
            // txtjg
            // 
            this.txtjg.Location = new System.Drawing.Point(208, 130);
            this.txtjg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtjg.Name = "txtjg";
            this.txtjg.Size = new System.Drawing.Size(132, 25);
            this.txtjg.TabIndex = 9;
            this.txtjg.TextChanged += new System.EventHandler(this.txtjg_TextChanged);
            // 
            // txtsc
            // 
            this.txtsc.Location = new System.Drawing.Point(208, 60);
            this.txtsc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsc.Name = "txtsc";
            this.txtsc.Size = new System.Drawing.Size(132, 25);
            this.txtsc.TabIndex = 8;
            this.txtsc.TextChanged += new System.EventHandler(this.txtsc_TextChanged);
            // 
            // lbljg
            // 
            this.lbljg.AutoSize = true;
            this.lbljg.Location = new System.Drawing.Point(40, 142);
            this.lbljg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbljg.Name = "lbljg";
            this.lbljg.Size = new System.Drawing.Size(0, 15);
            this.lbljg.TabIndex = 7;
            this.lbljg.Click += new System.EventHandler(this.lbljg_Click);
            // 
            // lblsc
            // 
            this.lblsc.AutoSize = true;
            this.lblsc.Location = new System.Drawing.Point(37, 72);
            this.lblsc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsc.Name = "lblsc";
            this.lblsc.Size = new System.Drawing.Size(82, 15);
            this.lblsc.TabIndex = 6;
            this.lblsc.Text = "请输入数字";
            this.lblsc.Click += new System.EventHandler(this.lblsc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "结果";
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnpd);
            this.Controls.Add(this.txtjg);
            this.Controls.Add(this.txtsc);
            this.Controls.Add(this.lbljg);
            this.Controls.Add(this.lblsc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm2";
            this.Text = "星期转换器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnpd;
        private System.Windows.Forms.TextBox txtjg;
        private System.Windows.Forms.TextBox txtsc;
        private System.Windows.Forms.Label lbljg;
        private System.Windows.Forms.Label lblsc;
        private System.Windows.Forms.Label label1;
    }
}