using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string a1 = "", a2 = "", a3 = "", a4 = "";
            
            if(rbtnA1.Checked) a1 = rbtnA1.Text;
            else if(rbtnA2.Checked) a1 = rbtnA2.Text;
            else if(rbtnA3.Checked) a1 = rbtnA3.Text;
            else if(rbtnA4.Checked) a1 = rbtnA4.Text;
            
            if (chkA1.Checked) a2 = chkA1.Text + " ";
            if (chkA2.Checked) a2 += chkA2.Text + " ";
            if (chkA3.Checked) a2 += chkA3.Text + " ";
            if (chkA4.Checked) a2 += chkA4.Text;

            a3 = lstA.SelectedItem.ToString();

            a4 = cboA.Text;

            lstResult.Items.Add("第一个问题答案:" + a1);
            lstResult.Items.Add("第二个问题答案:" + a2);
            lstResult.Items.Add("第三个问题答案:" + a3);
            lstResult.Items.Add("第四个问题答案:" + a4);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
        }
    }
}
