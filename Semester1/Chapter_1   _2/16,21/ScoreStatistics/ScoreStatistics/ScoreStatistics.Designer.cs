namespace ScoreStatistics
{
    partial class ScoreStatistics
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblAve = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtAve = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(79, 43);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(101, 12);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "请输入学生的成绩";
            // 
            // lblAve
            // 
            this.lblAve.AutoSize = true;
            this.lblAve.Location = new System.Drawing.Point(79, 114);
            this.lblAve.Name = "lblAve";
            this.lblAve.Size = new System.Drawing.Size(77, 12);
            this.lblAve.TabIndex = 1;
            this.lblAve.Text = "学生平均成绩";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(79, 157);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(113, 12);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "高于平均成绩的人数";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(203, 40);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 21);
            this.txtInput.TabIndex = 3;
            // 
            // txtAve
            // 
            this.txtAve.Location = new System.Drawing.Point(203, 111);
            this.txtAve.Name = "txtAve";
            this.txtAve.Size = new System.Drawing.Size(100, 21);
            this.txtAve.TabIndex = 4;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(117, 71);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "确认输入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(203, 154);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 21);
            this.txtOutput.TabIndex = 6;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(117, 210);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(75, 23);
            this.btnStatistic.TabIndex = 7;
            this.btnStatistic.Text = "统计";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(228, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 296);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtAve);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblAve);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblAve;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtAve;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnCancel;
    }
}

