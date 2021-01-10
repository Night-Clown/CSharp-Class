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
    public partial class frmManageScore : Form
    {
        public frmManageScore()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            string condition="";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtSid.Text != "") condition += " and Studentinfo.Sid='" + txtSid.Text + "'";
            if (txtSname.Text != "") condition += " and Class='" + txtClass.Text + "'";
            if (txtCid.Text != "") condition += " and Cid='" + txtCid.Text + "'";
            sql = "Select Courseinfo.Cid AS 课程号,Courseinfo.Cname AS 课程名称,Studentinfo.Sname AS 姓名,Studentinfo.Class AS 班级," +
                "Studentinfo.Sid AS 学号,Scoreinfo.Score AS 成绩 FROM Studentinfo,Courseinfo,Scoreinfo WHERE Courseinfo.Cid=Scoreinfo.Cid AND " +
                "Studentinfo.Sid=Socreinfo.Sid" + condition;
            data.dataCon();
            ds = data.getDataSet(sql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql;
            DataAccess data = new DataAccess();
            sql = "UPDATE Scoreinfo SET Score='" + dgvInfo.CurrentRow.Cells[5].Value.ToString() + "' WHERE Sid='" + dgvInfo.CurrentRow.Cells[4].Value.ToString() +
                "' AND Cid='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
            data.dataCon();
            if (data.sqlExec(sql))
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql;
            DataAccess data = new DataAccess();
            sql = "DELETE FROM Scoreinfo WHERE Cid='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "' AND Sid='" + dgvInfo.CurrentRow.Cells[4].Value.ToString() + "'";
            if (data.sqlExec(sql))
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
