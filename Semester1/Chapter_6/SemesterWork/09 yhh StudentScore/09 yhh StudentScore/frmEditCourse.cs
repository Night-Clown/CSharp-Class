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
    public partial class frmEditCourse : Form
    {
        public frmEditCourse()
        {
            InitializeComponent();
        }

        private void frmEditCourse_Load(object sender, EventArgs e)
        {
            txtCid.Text = frmManageCourse.sid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (txtCid.Text != "" && txtCname.Text != "" && txtCredit.Text != "")
            {
                sql = "UPDATE Courseinfo set Cname='" + txtCname.Text + "',Credit='" + txtCredit.Text +
                    "' where Cid='" + frmManageCourse.Cid + "'";
                DataAccess data = new DataAccess();
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
            else
            {
                MessageBox.Show("输入未完全!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
