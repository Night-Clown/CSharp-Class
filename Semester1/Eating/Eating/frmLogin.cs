using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eating
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool isNullInput()
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("用户名为空");
                return true;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("密码为空");
                return true;
            }
            if (cboCharacter.Text == "")
            {
                MessageBox.Show("角色未选择");
                return true;
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //判断输入是否为空
            if (!isNullInput())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string sql1 = "";
                string sql2 = "";
                switch (cboCharacter.Text)
                {
                    //根据不同的角色选择 在不同的表中判断账号存在与否和密码的正确
                    case "用户":
                        sql1 = "select * from [User] where username='" + username + "'";
                        sql2 = "select * from [User] where username='" + username + "'" + " and password='" + password + "'";
                        break;
                    case "窗口管理员":
                        sql1 = "select * from Window where wUsername='" + username + "'";
                        sql2 = "select * from Window where wUsername='" + username + "'" + " and wPassword='" + password + "'";
                        break;
                    case "食堂管理员":
                        sql1 = "select * from Canteen where cUsername='" + username + "'";
                        sql2 = "select * from Canteen where cUsername='" + username + "'" + " and cPassword='" + password + "'";
                        break;
                }
                string message = DataLoginAccess.judgeUser(sql1, sql2);
                if (message == null)
                {
                    MessageBox.Show("登陆成功");
                }
                else MessageBox.Show(message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
