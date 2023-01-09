using System;
using System.Windows.Forms;

namespace HFCSGuysEx
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            } else
            {
                MessageBox.Show("I don't have enough for that.");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            } else
            {
                MessageBox.Show(amount + " isn't an amount I'll take, " + Name + " says.");
                return 0;
            }
        }
    }
}
