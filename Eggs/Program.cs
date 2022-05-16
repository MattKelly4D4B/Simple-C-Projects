using System;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ch1 = 5;
            int Ch2 = 4;
            int Ch3 = 7;
            int Ch4 = 4;

            int EggSum = Ch1 + Ch2 + Ch3 + Ch4;
            int Dozens = EggSum / 12;
            int Remainder = (EggSum % 12);

            Console.WriteLine("Total Number of Eggs: " + EggSum.ToString());
            Console.WriteLine("You have: " + Dozens.ToString() + " Dozen, and " + Remainder.ToString() + " Eggs.");


        }
    }
}
