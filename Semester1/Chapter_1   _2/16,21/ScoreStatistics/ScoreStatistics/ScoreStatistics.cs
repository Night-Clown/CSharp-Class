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
    public partial class ScoreStatistics : Form
    {
        double[] arr = new double[999];
        int n = 0;
        public ScoreStatistics()
        {
            InitializeComponent();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            int num = 0;
            double sum=0,ave;
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            ave = sum / n;
            txtAve.Text = ave.ToString();

            foreach(int a in arr){
                if (a > ave) num++;
            }
            txtOutput.Text = num.ToString();

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            arr[n++] = Double.Parse(txtInput.Text);
            txtInput.Text = "";
            txtInput.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Array.Clear(arr, 0, arr.Length);
            n = 0;
            txtAve.Text = "";
            txtInput.Text = "";
            txtOutput.Text = "";
            txtInput.Focus();
        }
    }
}
