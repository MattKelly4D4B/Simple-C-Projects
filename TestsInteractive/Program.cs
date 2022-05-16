using System;

namespace TestsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Test Scores.");
            Console.Write("Test 1: "); //Prompt for, read, and convert test scores to double.
            String StrTest1 = Console.ReadLine();
            Double Test1 = Double.Parse(StrTest1);

            Console.Write("Test 2: ");
            String StrTest2 = Console.ReadLine();
            Double Test2 = Double.Parse(StrTest2);

            Console.Write("Test 3: ");
            String StrTest3 = Console.ReadLine();
            Double Test3 = Double.Parse(StrTest3);

            Console.Write("Test 4: ");
            String StrTest4 = Console.ReadLine();
            Double Test4 = Double.Parse(StrTest4);

            Console.Write("Test 5: ");
            String StrTest5 = Console.ReadLine();
            Double Test5 = Double.Parse(StrTest5);

            Console.Write("Test 6: ");
            String StrTest6 = Console.ReadLine();
            Double Test6 = Double.Parse(StrTest6);

            Console.Write("Test 7: ");
            String StrTest7 = Console.ReadLine();
            Double Test7 = Double.Parse(StrTest7);

            Console.Write("Test 8: ");
            String StrTest8 = Console.ReadLine();
            Double Test8 = Double.Parse(StrTest8);

            Double Avg = (Test1 + Test2 + Test3 + Test4 + Test5 + Test6 + Test7 + Test8) / 8; //Compute Average

            Console.WriteLine("The average score is: " + Avg.ToString()); //Print Result

        }
    }
}
