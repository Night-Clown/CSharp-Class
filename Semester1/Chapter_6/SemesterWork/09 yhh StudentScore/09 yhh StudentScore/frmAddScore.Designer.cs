namespace _09_yhh_StudentScore
{
    partial class frmAddScore
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
            this.gbxCourse = new System.Windows.Forms.GroupBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblSname = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lblSid = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.lblCname = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lblCid = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.txtScore);
            this.gbxCourse.Controls.Add(this.lblScore);
            this.gbxCourse.Controls.Add(this.txtSname);
            this.gbxCourse.Controls.Add(this.lblSname);
            this.gbxCourse.Controls.Add(this.txtSid);
            this.gbxCourse.Controls.Add(this.lblSid);
            this.gbxCourse.Controls.Add(this.txtCname);
            this.gbxCourse.Controls.Add(this.lblCname);
            this.gbxCourse.Controls.Add(this.txtCid);
            this.gbxCourse.Controls.Add(this.lblCid);
            this.gbxCourse.Location = new System.Drawing.Point(35, 61);
            this.gbxCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCourse.Size = new System.Drawing.Size(364, 169);
            this.gbxCourse.TabIndex = 1;
            this.gbxCourse.TabStop = false;
            this.gbxCourse.Text = "课程信息";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(82, 116);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScore.MaxLength = 10;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(91, 21);
            this.txtScore.TabIndex = 11;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(26, 118);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(29, 12);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "成绩";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(240, 30);
            this.txtSname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSname.MaxLength = 10;
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(91, 21);
            this.txtSname.TabIndex = 9;
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(185, 32);
            this.lblSname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(29, 12);
            this.lblSname.TabIndex = 8;
            this.lblSname.Text = "姓名";
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(82, 30);
            this.txtSid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSid.MaxLength = 10;
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(91, 21);
            this.txtSid.TabIndex = 7;
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Location = new System.Drawing.Point(26, 32);
            this.lblSid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(29, 12);
            this.lblSid.TabIndex = 6;
            this.lblSid.Text = "学号";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(240, 73);
            this.txtCname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCname.MaxLength = 30;
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(92, 21);
            this.txtCname.TabIndex = 5;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Location = new System.Drawing.Point(185, 75);
            this.lblCname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(53, 12);
            this.lblCname.TabIndex = 4;
            this.lblCname.Text = "课程名称";
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(82, 73);
            this.txtCid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCid.MaxLength = 10;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(91, 21);
            this.txtCid.TabIndex = 2;
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(26, 75);
            this.lblCid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(53, 12);
            this.lblCid.TabIndex = 0;
            this.lblCid.Text = "课程编号";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 265);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 18);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 265);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 18);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxCourse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddScore";
            this.Text = "添加成绩信息";
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}