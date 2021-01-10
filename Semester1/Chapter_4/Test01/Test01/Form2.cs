using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01
{
    public partial class Form2 : Form
    {
        bool selectFootball = false;
        bool selectBasketball = false;
        bool selectBadminton = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void chkBall_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox habit = (CheckBox)sender;
            if (habit.Checked)
            {
                if (habit.Text == "篮球") selectBasketball = true;
                else if (habit.Text == "足球") selectFootball = true;
                else if (habit.Text == "羽毛球") selectBadminton = true;
            }
            else
            {
                if (habit.Text == "篮球") selectBasketball = false;
                else if (habit.Text == "足球") selectFootball = false;
                else if (habit.Text == "羽毛球") selectBadminton = false;
            }
            string result = "";
            if (selectBasketball) result += "篮球 ";
            if (selectFootball) result += "足球 ";
            if (selectBadminton) result += "羽毛球";
            txtOutput.Text = result;
        }
    }
}
