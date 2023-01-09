using System;
using System.Windows.Forms;

namespace HFCSTalkerEx
{
    internal class Talker
    {
        public static int SayThis(string thingToSay, int noOfTimes)
        {
            string finalString = "";
            for (int count = 1; count <= noOfTimes; count ++)
            {
                finalString += finalString + thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
