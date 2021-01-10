namespace WindowsFormsApplication4
{
    partial class frmtime
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
            this.lblzong = new System.Windows.Forms.Label();
            this.lblxiaoshi = new System.Windows.Forms.Label();
            this.lblfen = new System.Windows.Forms.Label();
            this.lblmiao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblzong
            // 
            this.lblzong.AutoSize = true;
            this.lblzong.Location = new System.Drawing.Point(34, 25);
            this.lblzong.Name = "lblzong";
            this.lblzong.Size = new System.Drawing.Size(77, 12);
            this.lblzong.TabIndex = 0;
            this.lblzong.Text = "请输入总秒数";
            // 
            // lblxiaoshi
            // 
            this.lblxiaoshi.AutoSize = true;
            this.lblxiaoshi.Location = new System.Drawing.Point(36, 85);
            this.lblxiaoshi.Name = "lblxiaoshi";
            this.lblxiaoshi.Size = new System.Drawing.Size(29, 12);
            this.lblxiaoshi.TabIndex = 1;
            this.lblxiaoshi.Text = "小时";
            // 
            // lblfen
            // 
            this.lblfen.AutoSize = true;
            this.lblfen.Location = new System.Drawing.Point(36, 127);
            this.lblfen.Name = "lblfen";
            this.lblfen.Size = new System.Drawing.Size(29, 12);
            this.lblfen.TabIndex = 2;
            this.lblfen.Text = "分钟";
            // 
            // lblmiao
            // 
            this.lblmiao.AutoSize = true;
            this.lblmiao.Location = new System.Drawing.Point(36, 166);
            this.lblmiao.Name = "lblmiao";
            this.lblmiao.Size = new System.Drawing.Size(17, 12);
            this.lblmiao.TabIndex = 3;
            this.lblmiao.Text = "秒";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 7;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(47, 221);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 12;
            this.btnsubmit.Text = "转换";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(178, 220);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(75, 23);
            this.btncancle.TabIndex = 13;
            this.btncancle.Text = "取消";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // frmtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblmiao);
            this.Controls.Add(this.lblfen);
            this.Controls.Add(this.lblxiaoshi);
            this.Controls.Add(this.lblzong);
            this.Name = "frmtime";
            this.Text = "时间转换器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblzong;
        private System.Windows.Forms.Label lblxiaoshi;
        private System.Windows.Forms.Label lblfen;
        private System.Windows.Forms.Label lblmiao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btncancle;
    }
}

