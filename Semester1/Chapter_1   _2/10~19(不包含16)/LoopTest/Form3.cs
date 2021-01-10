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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int i = 0,sum=0;
            for (i = 0; i <= 100; i++)
            {
                sum += i;
            }
            txtshuchu.Text = sum.ToString();
        }
    }
}
