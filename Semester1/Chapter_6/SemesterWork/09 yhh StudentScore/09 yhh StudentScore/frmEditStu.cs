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
    public partial class frmEditStu : Form
    {
        public frmEditStu()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql;
            DataAccess data = new DataAccess();
            sql = "update Studentinfo(set SName='"+txtName.Text+ "',Sex='" + cboSex.Text + "'," +
                "Birthday='" + txtBirthday.Text + "',Class='" + txtClass.Text + "', Tel='" + txtTel.Text + "'," +
                "Address='" + txtAddress.Text + "' where Sid='"+frmManageStu.Sid+"'";
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

        private void frmEditStu_Load(object sender, EventArgs e)
        {
            txtSid.Text = frmManageStu.Sid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
