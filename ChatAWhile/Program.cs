using System;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zip = { 262, 414, 608, 715, 815, 920 };
            double[] rate = { .07, .10, .05, .16, .24, .14 };
            string StringZipInput;
            int ZipInput;
            string StringMinutes;
            double Minutes;
            int ArrayIndex;
            double TotalCost;

            Console.Write("Enter a Zip code: "); //prompt user to enter zip code and convert to int.
            StringZipInput = Console.ReadLine();
            ZipInput = Int32.Parse(StringZipInput);
            
            Console.WriteLine(""); // Blank space

            ArrayIndex = Array.IndexOf(zip, ZipInput); //find array Index of given zipcode.

            Console.Write("Enter Number of Minutes: ");
            StringMinutes = Console.ReadLine();
            Minutes = double.Parse(StringMinutes);

            TotalCost = rate[ArrayIndex] * Minutes;

            Console.WriteLine("Total Cost is: " + TotalCost + ".");

            

        }
    }
}
