using System;

namespace CheckDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Account Number: ");
            string StrNum = Console.ReadLine();
            int Num = int.Parse(StrNum);

            if (((Num / 10) % 7) == (Num % 10))
            {
                Console.WriteLine("Valid");
            }

            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
