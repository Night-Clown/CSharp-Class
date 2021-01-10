using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0dao9shuchu
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int i,flag=0;
            i = int.Parse(txtnum.Text);
            if (i == 2 || i == 3)
            {
                txtpd.Text = "yes";
            }
            else if (i == 0 || i == 1)
            {
                txtpd.Text = "no";
            }
            else
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        txtpd.Text = "no";
                        break;
                    }

                }
                if (flag == 0)
                {
                    txtpd.Text = "yes";
                }
            }
            
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            txtnum.Text = "";
            txtpd.Text = "";
            txtnum.Focus();
        }
    }
}
