namespace jiafa
{
    partial class frmjiafa
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
            this.lbljia = new System.Windows.Forms.Label();
            this.btnjisuan = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.txtadd1 = new System.Windows.Forms.TextBox();
            this.txtadd2 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtjieguo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbljia
            // 
            this.lbljia.AutoSize = true;
            this.lbljia.Location = new System.Drawing.Point(199, 101);
            this.lbljia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbljia.Name = "lbljia";
            this.lbljia.Size = new System.Drawing.Size(15, 15);
            this.lbljia.TabIndex = 0;
            this.lbljia.Text = "+";
            // 
            // btnjisuan
            // 
            this.btnjisuan.Location = new System.Drawing.Point(143, 272);
            this.btnjisuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnjisuan.Name = "btnjisuan";
            this.btnjisuan.Size = new System.Drawing.Size(100, 29);
            this.btnjisuan.TabIndex = 1;
            this.btnjisuan.Text = "计算";
            this.btnjisuan.UseVisualStyleBackColor = true;
            this.btnjisuan.Click += new System.EventHandler(this.btnjisuan_Click);
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(363, 272);
            this.btncancle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(100, 29);
            this.btncancle.TabIndex = 2;
            this.btncancle.Text = "取消";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // txtadd1
            // 
            this.txtadd1.Location = new System.Drawing.Point(48, 98);
            this.txtadd1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtadd1.Name = "txtadd1";
            this.txtadd1.Size = new System.Drawing.Size(132, 25);
            this.txtadd1.TabIndex = 3;
            // 
            // txtadd2
            // 
            this.txtadd2.Location = new System.Drawing.Point(241, 96);
            this.txtadd2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtadd2.Name = "txtadd2";
            this.txtadd2.Size = new System.Drawing.Size(132, 25);
            this.txtadd2.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(407, 101);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(15, 15);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "=";
            // 
            // txtjieguo
            // 
            this.txtjieguo.Location = new System.Drawing.Point(463, 98);
            this.txtjieguo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtjieguo.Name = "txtjieguo";
            this.txtjieguo.Size = new System.Drawing.Size(132, 25);
            this.txtjieguo.TabIndex = 6;
            // 
            // frmjiafa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 434);
            this.Controls.Add(this.txtjieguo);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtadd2);
            this.Controls.Add(this.txtadd1);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnjisuan);
            this.Controls.Add(this.lbljia);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmjiafa";
            this.Text = "加法器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbljia;
        private System.Windows.Forms.Button btnjisuan;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.TextBox txtadd1;
        private System.Windows.Forms.TextBox txtadd2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtjieguo;
    }
}

