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
    public partial class ScoreEvaluator : Form
    {
        public ScoreEvaluator()
        {
            InitializeComponent();
        }

        private void btnpd_Click(object sender, EventArgs e)
        {
            int sc,c;
            sc = Convert.ToInt32(txtsc.Text);
            c = sc / 10;
            if (sc > 100 || c < 0)
            {
                txtjg.Text = "请重新输入";
            }
            else
            {
                switch (c)
                {
                    case 10:
                        txtjg.Text = "优秀";
                        break;
                    case 9:
                        txtjg.Text = "优秀";
                        break;
                    case 8:
                        txtjg.Text = "良好";
                        break;
                    case 7:
                        txtjg.Text = "中等";
                        break;
                    case 6:
                        txtjg.Text = "及格";
                        break;
                    default:
                        txtjg.Text = "不及格";
                        break;
                }
            }
            
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            txtsc.Text = "";
            txtjg.Text = "";
            txtsc.Focus();
        }
    }
}
