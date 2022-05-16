using System;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 3;      //Used help from https://www.w3resource.com/cpp-exercises/numbers/cpp-numbers-exercise-5.php
            int U = 1;
            int Sum = 0;
            int Ctr = 0;

            while (I <= 10000)      
            {
                while (U <= 10000)
                {
                    if (U < I)
                    {
                        if (I % U == 0)
                            Sum = Sum + U;
                    }
                    U++;
                }
                if (Sum == I)
                {
                    Ctr++;
                    Console.WriteLine(I + ", ");
                }
                I++;
                U = 1; Sum = 0;
            }
        }
    }
}