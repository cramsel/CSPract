using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFCSElephantEx
{
    public partial class Form1 : Form
    {
        Elephant Lloyd;
        Elephant Lucina;

        public Form1()
        {
            InitializeComponent();
            Lloyd = new Elephant() 
                { Name = "Lloyd", EarSize = 33};
            Lucina = new Elephant() 
                { Name = "Lucina", EarSize = 40};
        }

        private void LloydButton_Click(object sender, EventArgs e)
        {
            Lloyd.WhoAmI();
        }

        private void LuciaButton_Click(object sender, EventArgs e)
        {
            Lucina.WhoAmI();
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            Elephant Holder;
            Holder = Lloyd;
            Lloyd = Lucina;
            Lucina = Holder;

            MessageBox.Show("Objects swapped");
        }
    }
}
