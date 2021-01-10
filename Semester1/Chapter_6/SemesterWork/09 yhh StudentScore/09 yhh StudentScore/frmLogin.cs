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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string strSql = "";
            DataSet ds;
            if (txtName.Text.Trim() != "" && txtPwd.Text.Trim() != "")
            {
                strSql = "select * from Userinfo where Userid='" + txtName.Text + "' and Userpwd='" + txtPwd.Text + "'";
                DataAccess data = new DataAccess();
                data.dataCon();
                ds = data.getDataSet(strSql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    frmMain fMain = new frmMain();
                    fMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密错误!", "登录失败");
                }
            }
            else
            {
                MessageBox.Show("用户名或密码为空,请输入信息", "提示");
            }
        }
        private void frmLogin_Activited(Object sender,EventArgs e)
        {
            txtName.Focus();
        }
    }
}
