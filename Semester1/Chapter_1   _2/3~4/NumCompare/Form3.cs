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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox4.Text);
            if (a > b)
            {
                if (b > c)
                {
                    textBox3.Text = c.ToString() + "," + b.ToString() + "," + a.ToString(); 
                }
                else if (c > a)
                {
                    textBox3.Text = b.ToString() + "," + a.ToString() + "," + c.ToString();
                }
                else
                {
                    textBox3.Text = b.ToString() + "," + c.ToString() + "," + a.ToString();
                }
            }
            else
            {
                if (a > c)
                {
                    textBox3.Text = c.ToString() + "," + a.ToString() + "," + b.ToString();
                }
                else if (c > b)
                {
                    textBox3.Text = a.ToString() + "," + b.ToString() + "," + c.ToString();
                }
                else
                {
                    textBox3.Text = a.ToString() + "," +c.ToString() + "," + b.ToString();
                }
            }
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
