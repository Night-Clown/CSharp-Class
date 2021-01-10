using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_yhh_StudentScore
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_FormClosing(Object sender,FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tsmiStudentAdd_Click(object sender, EventArgs e)
        {
            frmAddStu Addstu = new frmAddStu();
            Addstu.MdiParent = this;
            Addstu.Show();
        }

        private void tsmiStudentUpdate_Click(object sender, EventArgs e)
        {
            frmManageStu manageStu = new frmManageStu();
            manageStu.MdiParent = this;
            manageStu.Show();
        }

        private void tsmiStudentSearch_Click(object sender, EventArgs e)
        {
            frmManageStu manageStu = new frmManageStu();
            manageStu.MdiParent = this;
            manageStu.Show();
        }

        private void tsmiStudentDelete_Click(object sender, EventArgs e)
        {
            frmManageStu manageStu = new frmManageStu();
            manageStu.MdiParent = this;
            manageStu.Show();
        }

        private void tsmiCourseSearch_Click(object sender, EventArgs e)
        {
            frmManageCourse manageCourse = new frmManageCourse();
            manageCourse.MdiParent = this;
            manageCourse.Show();
        }

        private void tsmiCourseAdd_Click(object sender, EventArgs e)
        {
            frmAddCourse addCourse = new frmAddCourse();
            addCourse.MdiParent = this;
            addCourse.Show();
        }

        private void tsmiCourseUpdate_Click(object sender, EventArgs e)
        {
            frmManageCourse manageCourse = new frmManageCourse();
            manageCourse.MdiParent = this;
            manageCourse.Show();
        }

        private void tsmiCourseDelete_Click(object sender, EventArgs e)
        {
            frmManageCourse manageCourse = new frmManageCourse();
            manageCourse.MdiParent = this;
            manageCourse.Show();
        }

        private void tsmiScoreSearch_Click(object sender, EventArgs e)
        {
            frmManageScore manageScore = new frmManageScore();
            manageScore.MdiParent = this;
            manageScore.Show();
        }

        private void tsmiScoreAdd_Click(object sender, EventArgs e)
        {
            frmAddScore addScore = new frmAddScore();
            addScore.MdiParent = this;
            addScore.Show();
        }

        private void tsmiScoreUpdate_Click(object sender, EventArgs e)
        {
            frmManageScore manageScore = new frmManageScore();
            manageScore.MdiParent = this;
            manageScore.Show();
        }

        private void tsmiScoreDelete_Click(object sender, EventArgs e)
        {
            frmManageScore manageScore = new frmManageScore();
            manageScore.MdiParent = this;
            manageScore.Show();
        }

        private void tsmiVersion_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.MdiParent = this;
            about.Show();
        }

        private void tsbtnStudent_Click(object sender, EventArgs e)
        {
            frmManageStu manageStu = new frmManageStu();
            manageStu.MdiParent = this;
            manageStu.Show();
        }

        private void tsbtnCourse_Click(object sender, EventArgs e)
        {
            frmManageCourse manageCourse = new frmManageCourse();
            manageCourse.MdiParent = this;
            manageCourse.Show();
        }

        private void tsbtnScore_Click(object sender, EventArgs e)
        {
            frmManageScore manageScore = new frmManageScore();
            manageScore.MdiParent = this;
            manageScore.Show();
        }
    }
}
