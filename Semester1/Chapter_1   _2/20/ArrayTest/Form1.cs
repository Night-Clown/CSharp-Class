using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayTest
{
    public partial class Form1 : Form
    {
        public int[] arr = new int[6] { 1, 5, 6, -1, 9, 44 };
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*for(int i = 0; i < 3; i++)
            {
                txtArray.Text += a[i] + "\r\n";
            }*/
            txtOutput.Text = "";
            foreach (int _ in arr)
            {
                txtInput.Text += _ + ",";
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            txtOutput.Text = "";
            foreach (int _ in arr)
            {
                txtOutput.Text += _ + ",";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(arr, 0, arr.Length);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            Array.Reverse(arr);
            txtOutput.Text = "";
            foreach (int _ in arr)
            {
                txtOutput.Text += _ + ",";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
            txtInput.Focus();
        }
    }
}
