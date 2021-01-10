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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    txtshuchu.Text = txtshuchu.Text + j.ToString() + "*" + i.ToString() + "=" + (j * i).ToString() + "\t";
                }
                txtshuchu.Text = txtshuchu.Text + "\r\n";
            }
        }
    }
}
