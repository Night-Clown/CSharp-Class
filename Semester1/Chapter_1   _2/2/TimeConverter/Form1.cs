using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class frmtime : Form
    {
        public frmtime()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            int z, xs, f, s;
            z = Convert.ToInt32(textBox1.Text);
            xs = z / 3600;
            f = z % 3600 / 60;
            s = z % 3600 % 60;
            textBox2.Text = xs.ToString();
            textBox3.Text = f.ToString();
            textBox4.Text = s.ToString();
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
