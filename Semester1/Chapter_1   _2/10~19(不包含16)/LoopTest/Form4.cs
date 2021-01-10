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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int i = 0, sum = 0;
            for (i = 0; i <= 100; i += 2)
            {
                sum += i;
            }
            txtshuchu.Text = sum.ToString();
        }
    }
}
