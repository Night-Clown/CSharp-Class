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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            int i = 1, sum=1,num=0;
            for (i = 1; i <= 10; i++)
            {
                sum *= i;
                num += sum;
            }
            txtshuchu.Text = num.ToString();
        }
    }
}
