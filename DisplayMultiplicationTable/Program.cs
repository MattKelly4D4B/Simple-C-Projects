using System;

namespace DisplayMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            for (x = 0; x <= 10; x++)
            {
                for (y = 0;  y <= 10; y++)
                {
                    Console.Write(x * y +", ");                    
                }

                Console.WriteLine("");
            }
        }
    }
}
