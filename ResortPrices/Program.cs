using System;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            string StringDays;
            int Days;
            int Price = 0;
            int TotalPrice = 0; 

            Console.Write("Enter number of days you will be staying: ");
            StringDays = Console.ReadLine();
            Days = Int32.Parse(StringDays);

            if (Days < 3)
            {
                Price = 200;
            }
            
            else if (Days >= 3 && Days < 5)
            {
                Price = 180;
            }
            
            else if (Days >= 5 && Days < 8)
            {
                Price = 160;
            }
            
            else if (Days >= 8)
            {
                Price = 140;
            }

            TotalPrice = Days * Price;
            Console.WriteLine("Your total price will be: " + TotalPrice.ToString() + ".");
        }
    }
}
