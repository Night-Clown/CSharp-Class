namespace xueshengchengji
{
    partial class ScoreEvaluator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblsc = new System.Windows.Forms.Label();
            this.lbljg = new System.Windows.Forms.Label();
            this.txtsc = new System.Windows.Forms.TextBox();
            this.txtjg = new System.Windows.Forms.TextBox();
            this.btnpd = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsc
            // 
            this.lblsc.AutoSize = true;
            this.lblsc.Location = new System.Drawing.Point(44, 73);
            this.lblsc.Name = "lblsc";
            this.lblsc.Size = new System.Drawing.Size(65, 12);
            this.lblsc.TabIndex = 0;
            this.lblsc.Text = "请输入成绩";
            // 
            // lbljg
            // 
            this.lbljg.AutoSize = true;
            this.lbljg.Location = new System.Drawing.Point(46, 129);
            this.lbljg.Name = "lbljg";
            this.lbljg.Size = new System.Drawing.Size(53, 12);
            this.lbljg.TabIndex = 1;
            this.lbljg.Text = "评定结果";
            // 
            // txtsc
            // 
            this.txtsc.Location = new System.Drawing.Point(172, 63);
            this.txtsc.Name = "txtsc";
            this.txtsc.Size = new System.Drawing.Size(100, 21);
            this.txtsc.TabIndex = 2;
            // 
            // txtjg
            // 
            this.txtjg.Location = new System.Drawing.Point(172, 119);
            this.txtjg.Name = "txtjg";
            this.txtjg.Size = new System.Drawing.Size(100, 21);
            this.txtjg.TabIndex = 3;
            // 
            // btnpd
            // 
            this.btnpd.Location = new System.Drawing.Point(48, 205);
            this.btnpd.Name = "btnpd";
            this.btnpd.Size = new System.Drawing.Size(75, 23);
            this.btnpd.TabIndex = 4;
            this.btnpd.Text = "评定";
            this.btnpd.UseVisualStyleBackColor = true;
            this.btnpd.Click += new System.EventHandler(this.btnpd_Click);
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(172, 204);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(75, 23);
            this.btncancle.TabIndex = 5;
            this.btncancle.Text = "取消";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnpd);
            this.Controls.Add(this.txtjg);
            this.Controls.Add(this.txtsc);
            this.Controls.Add(this.lbljg);
            this.Controls.Add(this.lblsc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsc;
        private System.Windows.Forms.Label lbljg;
        private System.Windows.Forms.TextBox txtsc;
        private System.Windows.Forms.TextBox txtjg;
        private System.Windows.Forms.Button btnpd;
        private System.Windows.Forms.Button btncancle;
    }
}

