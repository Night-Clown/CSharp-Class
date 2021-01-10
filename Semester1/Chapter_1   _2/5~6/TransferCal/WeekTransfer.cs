using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xueshengchengji
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void lblsc_Click(object sender, EventArgs e)
        {

        }

        private void btnpd_Click(object sender, EventArgs e)
        {

            int c;
            c = Convert.ToInt32(txtsc.Text);
            if (c > 7 || c <= 0)
            {
                txtjg.Text = "请重新输入";
            }
            else
            {
                switch (c)
                {
                    case 1:
                        txtjg.Text = "星期一";
                        break;
                    case 2:
                        txtjg.Text = "星期二";
                        break;
                    case 3:
                        txtjg.Text = "星期三";
                        break;
                    case 4:
                        txtjg.Text = "星期四";
                        break;
                    case 5:
                        txtjg.Text = "星期五";
                        break;
                    case 6:
                        txtjg.Text = "星期六";
                        break;
                    case 7:
                        txtjg.Text = "星期七";
                        break;
                    default:
                        
                        break;
                }
            }
        }

        private void txtjg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbljg_Click(object sender, EventArgs e)
        {

        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            txtsc.Text = "";
            txtjg.Text = "";
            txtsc.Focus();
        }
    }
}
