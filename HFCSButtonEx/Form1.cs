using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFCSButtonEx
{
    public partial class Form1 : Form
    {
        int clickCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Bob";
            int x = 3;
            double d = Math.PI / 2;

            MessageBox.Show("Name is " + name 
                            + "\nx is " + x*3 
                            + "\nd is " + d);
            clickCount += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clickCount.ToString());
            clickCount += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string boxMessage = "This line runs no matter what";

            if (clickCount >= 5)
            {
                boxMessage += "\nThis means click count is 5 or more";
            }
            
            MessageBox.Show(boxMessage);
            clickCount += 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int messageCount = 0;

            while (messageCount < 5)
            {
                MessageBox.Show("Pound");
                messageCount += 1;
            }
        }
    }
}
