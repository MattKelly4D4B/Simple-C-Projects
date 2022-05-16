using System;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Initial = null;

            double DTotal = 0;
            double ETotal = 0;
            double FTotal = 0;

            double TotalSales = 0;


            while (Initial != "Z" && Initial != "z")
            {

                Console.Write("Enter first initial or press Z for totals: ");
                Initial = Console.ReadLine();

                if (Initial == "D" || Initial == "d")
                {
                    Console.WriteLine("Hello: Danielle.");
                    Console.Write("Enter sale amount: ");
                    string StringTotal = Console.ReadLine();
                    double doubleTotal = double.Parse(StringTotal);
                    DTotal = DTotal + doubleTotal;
                    TotalSales = TotalSales + DTotal;
                }

                else if (Initial == "E" || Initial == "e")
                {
                    Console.WriteLine("Hello: Edward.");
                    Console.Write("Enter sale amount: ");
                    string StringTotal = Console.ReadLine();
                    double doubleTotal = double.Parse(StringTotal);
                    ETotal = ETotal + doubleTotal;
                    TotalSales = TotalSales + ETotal;
                }

                else if (Initial == "F" || Initial == "f")
                {
                    Console.WriteLine("Hello: Francis.");
                    Console.Write("Enter sale amount: ");
                    string StringTotal = Console.ReadLine();
                    double doubleTotal = double.Parse(StringTotal);
                    FTotal = FTotal + doubleTotal;
                    TotalSales = TotalSales + FTotal;
                }

                else if (Initial == "Z" || Initial == "z")
                { 
                    
                }
                else
                {
                    Console.WriteLine("You did not enter a correct initial");
                }

            }

             
            Console.WriteLine("Sale Summary:");
            
            Console.WriteLine("Danielle's Total: " + DTotal.ToString());
            Console.WriteLine("Edward's Total: " + ETotal.ToString());
            Console.WriteLine("Francis's Total: " + FTotal.ToString());

            Console.WriteLine("Total Sales: " + TotalSales.ToString());

            if (DTotal > ETotal && DTotal > FTotal)
            {
                Console.WriteLine("The person with the highest total is: Danielle!");
            }

            else if (ETotal > DTotal && ETotal > FTotal)
            {
                Console.WriteLine("The person with the highest total is: Edward!");
            }

            else if (FTotal > DTotal && FTotal > ETotal)
            {
                Console.WriteLine("The person with the highest total is: Francis!");
            }
            else
            {
                Console.WriteLine("It's a Tie!");
            }
        }

    }
}
