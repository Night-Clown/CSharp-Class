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
    public partial class frmAddStu : Form
    {
        public frmAddStu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql;
            DataAccess data = new DataAccess();
            sql="insert into Studentinfo(Sid,Sname,Sex,Birthday,Class,Tel,Address) " +
                "values('"+txtSid.Text+ "','" + txtName.Text + "','" + cboSex.Text + 
                "','" + txtBirthday.Text + "','" + txtClass.Text + "','" + txtTel.Text + "','"
                +txtAddress.Text+"')";
            data.dataCon();
            if (data.sqlExec(sql))
            {
                MessageBox.Show("添加成功!!");
            }
            else
            {
                MessageBox.Show("添加失败!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
