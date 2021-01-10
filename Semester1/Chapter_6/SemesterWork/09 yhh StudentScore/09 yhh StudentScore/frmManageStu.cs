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
    public partial class frmManageStu : Form
    {
        public frmManageStu()
        {
            InitializeComponent();
        }
        private static string sid;

        public static string Sid { get => sid; set => sid = value; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            string condition = "";
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txtSid.Text != "") condition += "and Sid='" + txtSid.Text + "'";
            if (txtName.Text != "") condition += "and Sname='" + txtName.Text + "'";
            if (txtClass.Text != "") condition += "and Class='" + txtClass.Text + "'";
            if (cboSex.Text != "") condition += "and Sex='" + cboSex.Text + "'";
            sql = "SELECT Sid AS 学号,Sname AS 姓名,Sex AS 性别,Birthday AS 出生日期,Class AS 班级,Tel AS 电话,Adress AS 家庭住址 " +
                "FROM Studentinfo WHERE 1=1" + condition;
            data.dataCon();
            ds = data.getDataSet(sql);
            dgvInfo.DataSource = ds.Tables[0];
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string sql;
            DataAccess data = new DataAccess();
            sql = "DELETE FROM Studentinfo WHERE Sid='" + dgvInfo.CurrentRow.Cells[0].Value.ToString() + "'";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmManageStu.sid = dgvInfo.CurrentRow.Cells[0].Value.ToString();
            frmEditStu frmEditStu = new frmEditStu();
            frmEditStu.Show();
        }
    }
}
