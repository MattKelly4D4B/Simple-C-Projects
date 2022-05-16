using System;

namespace MoveEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of hours: ");
            String StrHours = Console.ReadLine();
            double Hours = double.Parse(StrHours);

            Console.WriteLine("Enter number of miles: ");
            string StrMiles = Console.ReadLine();
            double Miles = double.Parse(StrMiles);


            double TotalPrice = 200 + (150 * Hours) + (2 * Miles);
            String StrPrice = TotalPrice.ToString();

            Console.WriteLine("Total Hours: " + StrHours);
            Console.WriteLine("Total Miles: " + StrMiles);
            Console.WriteLine("Total Price is: $" + TotalPrice);
        }
    }
}
