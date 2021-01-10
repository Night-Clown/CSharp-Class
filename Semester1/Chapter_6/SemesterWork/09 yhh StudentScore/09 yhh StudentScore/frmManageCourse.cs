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
    public partial class frmManageCourse : Form
    {
        public frmManageCourse()
        {
            InitializeComponent();
        }
        private static string cid;
        public static string Cid { get => cid; set => cid = value; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtCid.Text != "") condition += "and Cid='" + txtCid.Text + "'";
            if (txtCname.Text != "") condition += "and Sname='" + txtCname.Text + "'";
            sql = "SELECT Cid AS 课程编号,Cname AS 课程名称,Credit AS 学分 " +
                "FROM Studentinfo WHERE 1=1" + condition;
            data.dataCon();
            ds = data.getDataSet(sql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmManageCourse.cid = dgvInfo.CurrentRow.Cells[0].Value.ToString();
            new frmEditCourse().Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql;
            DataAccess data = new DataAccess();
            sql = "DELETE FROM Course WHERE Cid='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
            data.dataCon();
            if (data.sqlExec(sql))
            {
                MessageBox.Show("删除成功!");
            }
            else
            {
                MessageBox.Show("删除失败!");
            }
        }
    }
}
