using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bijiaodaxiao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int a, b, c,d;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox4.Text);
            if (a > b)
            {
                if (a > c)
                {
                    d = a;
                }
                else
                {
                    d = c;
                }
            }
            else
            {
                if (b > c)
                {
                    d = b;
                }
                else
                {
                    d = c;
                }
            }
            textBox3.Text = d.ToString();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();

        }
    }
}
