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
    public partial class Form2_2 : Form
    {
        int flag;
        double num1 = 0;
        double results;
        double tem;
        bool isFirstOperator = true;

        public Form2_2()
        {
            InitializeComponent();
        }

        private void Form2_2_Load(object sender, EventArgs e)
        {

        }

        private void num_Click(Object sender, EventArgs s)
        {
            Button btnNum = (Button)sender;
            txtOutput.Text = txtOutput.Text + btnNum.Text;
        }

        private void temNum()
        {
            switch (flag)
            {
                case 0:
                    results = tem + num1;
                    tem = results;
                    break;
                case 1:
                    results = tem - num1;
                    tem = results;
                    break;
                case 2:
                    results = tem * num1;
                    tem = results;
                    break;
                case 3:
                    results = tem / num1;
                    tem = results;
                    break;
            }


        }

        private void setOperator(Button btnOperator)
        {
            if (btnOperator.Text == "+")
            {
                num1 = double.Parse(txtOutput.Text);
                if (!isFirstOperator) temNum();
                txtOutput.Text = "";
                flag = 0;
            }
            else if (btnOperator.Text == "-")
            {
                num1 = double.Parse(txtOutput.Text);
                if (!isFirstOperator) temNum();
                txtOutput.Text = "";
                flag = 1;
            }
            else if (btnOperator.Text == "*")
            {
                num1 = double.Parse(txtOutput.Text);
                if (!isFirstOperator) temNum();
                txtOutput.Text = "";
                flag = 2;
            }
            else if (btnOperator.Text == "/")
            {
                num1 = double.Parse(txtOutput.Text);
                if (!isFirstOperator) temNum();
                txtOutput.Text = "";
                flag = 3;
            }
            else if (btnOperator.Text == "C")
            {
                num1 = 0;
                tem = 0;
                results = 0;
                txtOutput.Text = "";
                isFirstOperator = true;
                txtOutput.Focus();
            }
            else if (btnOperator.Text == "=")
            {
                num1 = double.Parse(txtOutput.Text);
                if (!isFirstOperator) temNum();
                isFirstOperator = true;
                txtOutput.Text = results.ToString();
            }


            if (isFirstOperator) tem = num1;
        }

        private void operator_Click(Object sender, EventArgs s)
        {
            Button btnOperator = (Button)sender;
            if (isFirstOperator)
            {
                setOperator(btnOperator);
                isFirstOperator = false;
            }
            else
            {
                setOperator(btnOperator);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "")
            {
                txtOutput.Text = "0.";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + ".";
            }
        }
    }
}
