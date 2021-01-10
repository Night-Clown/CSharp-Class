namespace ScoreStatistics
{
    partial class BipartiteStatistics
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.txtEven = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtOdd = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblEve = new System.Windows.Forms.Label();
            this.lblOdd = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(68, 204);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(75, 23);
            this.btnStatistic.TabIndex = 16;
            this.btnStatistic.Text = "统计";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // txtEven
            // 
            this.txtEven.Location = new System.Drawing.Point(154, 148);
            this.txtEven.Name = "txtEven";
            this.txtEven.Size = new System.Drawing.Size(100, 21);
            this.txtEven.TabIndex = 15;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(68, 65);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 14;
            this.btnInput.Text = "确认输入";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click_1);
            // 
            // txtOdd
            // 
            this.txtOdd.Location = new System.Drawing.Point(154, 105);
            this.txtOdd.Name = "txtOdd";
            this.txtOdd.Size = new System.Drawing.Size(100, 21);
            this.txtOdd.TabIndex = 13;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(154, 34);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 21);
            this.txtInput.TabIndex = 12;
            // 
            // lblEve
            // 
            this.lblEve.AutoSize = true;
            this.lblEve.Location = new System.Drawing.Point(30, 151);
            this.lblEve.Name = "lblEve";
            this.lblEve.Size = new System.Drawing.Size(65, 12);
            this.lblEve.TabIndex = 11;
            this.lblEve.Text = "偶数的个数";
            // 
            // lblOdd
            // 
            this.lblOdd.AutoSize = true;
            this.lblOdd.Location = new System.Drawing.Point(30, 108);
            this.lblOdd.Name = "lblOdd";
            this.lblOdd.Size = new System.Drawing.Size(65, 12);
            this.lblOdd.TabIndex = 10;
            this.lblOdd.Text = "基数的个数";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(30, 37);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(77, 12);
            this.lblInput.TabIndex = 9;
            this.lblInput.Text = "请输入一个数";
            // 
            // BipartiteStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.txtEven);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtOdd);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblEve);
            this.Controls.Add(this.lblOdd);
            this.Controls.Add(this.lblInput);
            this.Name = "BipartiteStatistics";
            this.Text = "BipartiteStatistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.TextBox txtEven;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtOdd;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblEve;
        private System.Windows.Forms.Label lblOdd;
        private System.Windows.Forms.Label lblInput;
    }
}