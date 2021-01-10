using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreStatistics
{
    public partial class BipartiteStatistics : Form
    {
        int[] arr = new int[999];
        int n = 0;
        public BipartiteStatistics()
        {
            InitializeComponent();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            int oddNum = 0, evenNum = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenNum++;
                }
                else
                {
                    oddNum++;
                }
            }
            txtOdd.Text = oddNum.ToString();
            txtEven.Text = evenNum.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            n = 0;
            Array.Clear(arr, 0, arr.Length);
            txtInput.Text = "";
            txtOdd.Text = "";
            txtEven.Text = "";
            txtInput.Focus();
        }

        private void btnInput_Click_1(object sender, EventArgs e)
        {
            arr[n++] = Int32.Parse(txtInput.Text);
            txtInput.Text = "";
            txtInput.Focus();
        }
    }
}
