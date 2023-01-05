using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFCSColorChangeEx
{
    public partial class Form1 : Form
    {
        int checkBox = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox == 0)
            {
                MessageBox.Show("Box is not checked.");
            } else if (label1.BackColor == Color.Red)
            {
                label1.BackColor = Color.Green;
            } else
            {
                label1.BackColor = Color.Red;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox = 1;
            }
        }
    }
}
