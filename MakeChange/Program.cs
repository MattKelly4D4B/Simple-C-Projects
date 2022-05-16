using System;

namespace MakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter $: ");
            String StrMoney = Console.ReadLine();
            double Money = double.Parse(StrMoney);

            double Hundred = 100;
            double Fifty = 50;
            double Twenty = 20;
            double Ten = 10;
            double Five = 5;
            double One = 1;
            double Quarter = .25;
            double Dime = .10;
            double Nickel = .05;
            double Penny = .01;

            double NumHundred = (int)(Money / Hundred);
            double NumFifty = (int)(( Money % Hundred) / Fifty);
            double NumTwenty = (int)(((Money % Hundred) % Fifty) / Twenty);
            double NumTen = (int)((((Money % Hundred) % Fifty) % Twenty) / Ten );
            double NumFive = (int)(((((Money % Hundred) % Fifty) % Twenty) % Ten) / Five);
            double NumOne = (int)((((((Money % Hundred) % Fifty) % Twenty) % Ten) % Five) / One);
            double NumQuarter = (int)(((((((Money % Hundred) % Fifty) % Twenty) % Ten) % Five) % One) / Quarter);
            double NumDime = (int)((((((((Money % Hundred) % Fifty) % Twenty) % Ten) % Five) % One) % Quarter) / Dime);
            double NumNickel = (int)(((((((((Money % Hundred) % Fifty) % Twenty) % Ten) % Five) % One) % Quarter) % Dime) / Nickel);
            double NumPenny = (int)((((((((((Money % Hundred) % Fifty) % Twenty) % Ten) % Five) % One) % Quarter) % Dime) % Nickel) / Penny);

            Console.WriteLine("Number of Hundreds: " + NumHundred.ToString());
            Console.WriteLine("Number of Fiftys: " + NumFifty.ToString());
            Console.WriteLine("Number of Twentys: " + NumTwenty.ToString());
            Console.WriteLine("Number of Tens: " + NumTen.ToString());
            Console.WriteLine("Number of Fives: " + NumFive.ToString());
            Console.WriteLine("Number of Ones: " + NumOne.ToString());
            Console.WriteLine("Number of Quarters: " + NumQuarter.ToString());
            Console.WriteLine("Number of Dimes: " + NumDime.ToString());
            Console.WriteLine("Number of Nickels: " + NumNickel.ToString());
            Console.WriteLine("Number of Pennies: " + NumPenny.ToString());

        }
    }
}
