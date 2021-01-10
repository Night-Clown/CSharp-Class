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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    txtshuchu.Text = txtshuchu.Text + i.ToString() + " ";
                }
            }

        }
    }
}
