using System;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Eggs.");

            Console.WriteLine("1st Chicken: "); //Prompt for first chickens eggs, read as str, parse to int, and repeat for all 4 chickens.
            string StrCh1 = Console.ReadLine();
            int Ch1 = Int32.Parse(StrCh1);

            Console.WriteLine("2nd Chicken: ");
            string StrCh2 = Console.ReadLine();
            int Ch2 = Int32.Parse(StrCh2);

            Console.WriteLine("3rd Chicken: ");
            string StrCh3 = Console.ReadLine();
            int Ch3 = Int32.Parse(StrCh3);

            Console.WriteLine("4th Chicken: ");
            string StrCh4 = Console.ReadLine();
            int Ch4 = Int32.Parse(StrCh4);

            int EggSum = Ch1 + Ch2 + Ch3 + Ch4; //Compute total Eggs
            int Dozens = EggSum / 12;           // Compute Dozens of eggs.
            int Remainder = (EggSum % 12);      // Computer remainder.

            Console.WriteLine("Total Number of Eggs: " + EggSum.ToString()); //Print Total Eggs
            Console.WriteLine("You have: " + Dozens.ToString() + " Dozen, and " + Remainder.ToString() + " Eggs."); //Print in units of dozens.


        }
    }
}
