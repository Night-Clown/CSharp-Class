namespace _09_yhh_StudentScore
{
    partial class frmManageScore
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblSname = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lblSid = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.lblCid = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.gbxCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.btnDel);
            this.gbxCourse.Controls.Add(this.btnEdit);
            this.gbxCourse.Controls.Add(this.btnSearch);
            this.gbxCourse.Controls.Add(this.txtSname);
            this.gbxCourse.Controls.Add(this.lblSname);
            this.gbxCourse.Controls.Add(this.txtSid);
            this.gbxCourse.Controls.Add(this.lblSid);
            this.gbxCourse.Controls.Add(this.txtClass);
            this.gbxCourse.Controls.Add(this.lblClass);
            this.gbxCourse.Controls.Add(this.txtCid);
            this.gbxCourse.Controls.Add(this.lblCid);
            this.gbxCourse.Location = new System.Drawing.Point(39, 30);
            this.gbxCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCourse.Size = new System.Drawing.Size(493, 160);
            this.gbxCourse.TabIndex = 2;
            this.gbxCourse.TabStop = false;
            this.gbxCourse.Text = "课程信息";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(200, 118);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(56, 18);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(364, 118);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 18);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(35, 118);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 18);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseMnemonic = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(82, 73);
            this.txtSname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSname.MaxLength = 10;
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(91, 21);
            this.txtSname.TabIndex = 9;
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(33, 75);
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
            this.lblSid.Location = new System.Drawing.Point(33, 32);
            this.lblSid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(29, 12);
            this.lblSid.TabIndex = 6;
            this.lblSid.Text = "学号";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(330, 73);
            this.txtClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClass.MaxLength = 30;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(92, 21);
            this.txtClass.TabIndex = 5;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(275, 75);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(29, 12);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "班级";
            // 
            // txtCid
            // 
            this.txtCid.Location = new System.Drawing.Point(331, 30);
            this.txtCid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCid.MaxLength = 10;
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(91, 21);
            this.txtCid.TabIndex = 2;
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(275, 32);
            this.lblCid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(53, 12);
            this.lblCid.TabIndex = 0;
            this.lblCid.Text = "课程编号";
            // 
            // dgvInfo
            // 
            this.dgvInfo.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(39, 204);
            this.dgvInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowHeadersWidth = 51;
            this.dgvInfo.RowTemplate.Height = 27;
            this.dgvInfo.Size = new System.Drawing.Size(493, 177);
            this.dgvInfo.TabIndex = 3;
            // 
            // frmManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 404);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.gbxCourse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmManageScore";
            this.Text = "管理成绩信息";
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvInfo;
    }
}