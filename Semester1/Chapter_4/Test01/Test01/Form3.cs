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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int index = lstInput.SelectedIndex;
            while (index != -1)
            {
                lstOutput.Items.Add(lstInput.Items[index]);
                lstInput.Items.RemoveAt(index);
                index = lstInput.SelectedIndex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstOutput.Items.AddRange(lstInput.Items);
            lstInput.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = lstOutput.SelectedIndex;
            while (index != -1)
            {
                lstInput.Items.Add(lstOutput.Items[index]);
                lstOutput.Items.RemoveAt(index);
                index = lstOutput.SelectedIndex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstInput.Items.AddRange(lstOutput.Items);
            lstOutput.Items.Clear();
        }
    }
}
