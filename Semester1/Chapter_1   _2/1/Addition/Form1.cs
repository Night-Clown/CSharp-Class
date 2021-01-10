using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jiafa
{
    public partial class frmjiafa : Form
    {
        public frmjiafa()
        {
            InitializeComponent();
        }

        private void btnjisuan_Click(object sender, EventArgs e)
        {
            int add1, add2, result;
            add1 = Convert.ToInt32(txtadd1.Text);
            add2 = Convert.ToInt32(txtadd2.Text);
            result = add1 + add2;
            txtjieguo.Text = result.ToString();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            txtadd1.Text = "";
            txtadd2.Text = "";
            txtjieguo.Text = "";
            txtadd1.Focus();
        }
    }
}
