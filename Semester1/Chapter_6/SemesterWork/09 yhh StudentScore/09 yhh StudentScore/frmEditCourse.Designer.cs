namespace _09_yhh_StudentScore
{
    partial class frmEditCourse
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxCourse = new System.Windows.Forms.GroupBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.lblCname = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.gbxCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 241);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 18);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 241);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 18);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.txtCname);
            this.gbxCourse.Controls.Add(this.lblCname);
            this.gbxCourse.Controls.Add(this.txtCredit);
            this.gbxCourse.Controls.Add(this.txtCid);
            this.gbxCourse.Controls.Add(this.lblCredit);
            this.gbxCourse.Controls.Add(this.lblCid);
            this.gbxCourse.Location = new System.Drawing.Point(38, 65);
            this.gbxCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCourse.Size = new System.Drawing.Size(366, 130);
            this.gbxCourse.TabIndex = 3;
            this.gbxCourse.TabStop = false;
            this.gbxCourse.Text = "课程信息";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(81, 69);
            this.txtCname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCname.MaxLength = 30;
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(248, 21);
            this.txtCname.TabIndex = 5;
            // 
            // lblCname
            // 
            this.lblCname.AutoSize = true;
            this.lblCname.Location = new System.Drawing.Point(26, 71);
            this.lblCname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCname.Name = "lblCname";
            this.lblCname.Size = new System.Drawing.Size(53, 12);
            this.lblCname.TabIndex = 4;
            this.lblCname.Text = "课程名称";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(239, 27);
            this.txtCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCredit.MaxLength = 10;
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(91, 21);
            this.txtCredit.TabIndex = 3;
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(82, 27);
            this.txtCid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCid.MaxLength = 10;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(91, 21);
            this.txtCid.TabIndex = 2;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(194, 30);
            this.lblCredit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(29, 12);
            this.lblCredit.TabIndex = 1;
            this.lblCredit.Text = "学分";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(26, 30);
            this.lblCid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(53, 12);
            this.lblCid.TabIndex = 0;
            this.lblCid.Text = "课程编号";
            // 
            // frmEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxCourse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEditCourse";
            this.Text = "frmEditCourse";
            this.Load += new System.EventHandler(this.frmEditCourse_Load);
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label lblCname;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblCid;
    }
}