using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFCSMileReimburseEx
{
    public partial class Form1 : Form
    {
        public const decimal MileValue = 0.39M;
        public int StartMilesVal;
        public int EndMilesVal;
        public int TotalMilesVal;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (StartMilesVal > EndMilesVal)
            {
                MessageBox.Show("Invalid Input; end must be greater than start");
            } else
            {
                TotalMilesVal = EndMilesVal - StartMilesVal;
                AmountOwedLabel.Text = (TotalMilesVal * MileValue).ToString();
            }
        }

        private void StartMilesCounter_ValueChanged(object sender, EventArgs e)
        {
            StartMilesVal = (int)StartMilesCounter.Value;
        }

        private void EndMilesCounter_ValueChanged(object sender, EventArgs e)
        {
            EndMilesVal = (int)EndMilesCounter.Value;
        }
    }
}
