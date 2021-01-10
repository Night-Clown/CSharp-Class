using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1_1 : Form
    {
        int flag;
        int num1;
        int results;

        public Form1_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num_Click(Object sender,EventArgs s)
        {
            Button btnNum = (Button)sender;
            txtOutput.Text = txtOutput.Text + btnNum.Text;
        }

        private void operator_Click(Object sender, EventArgs s)
        {
            Button btnOperator = (Button)sender;
            if (btnOperator.Text == "+")
            {
                num1 = int.Parse(txtOutput.Text);
                txtOutput.Text = "";
                flag = 0;
            }
            else if(btnOperator.Text == "-")
            {
                num1 = int.Parse(txtOutput.Text);
                txtOutput.Text = "";
                flag = 1;
            }
            else if (btnOperator.Text == "*")
            {
                num1 = int.Parse(txtOutput.Text);
                txtOutput.Text = "";
                flag = 2;
            }
            else if (btnOperator.Text == "/")
            {
                num1 = int.Parse(txtOutput.Text);
                txtOutput.Text = "";
                flag = 3;
            }
            else if (btnOperator.Text == "C")
            {
                num1 = 0;
                txtOutput.Text = "";
                txtOutput.Focus();
            }
            else if (btnOperator.Text == "=")
            {
                switch (flag)
                {
                    case 0:
                        results = num1 + int.Parse(txtOutput.Text);
                        break;
                    case 1:
                        results = num1 - int.Parse(txtOutput.Text);
                        break;
                    case 2:
                        results = num1 * int.Parse(txtOutput.Text);
                        break;
                    case 3:
                        results = num1 / int.Parse(txtOutput.Text);
                        break;
                }
                txtOutput.Text=results.ToString();
            }
        }
    }
}
