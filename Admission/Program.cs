using System;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Admissions Application:");
            Console.Write("Please enter your GPA: ");
            string StrGPA = Console.ReadLine();
            double GPA = double.Parse(StrGPA);

            Console.Write("Please enter your Admission Test Score: ");
            string StrScore = Console.ReadLine();
            double Score = double.Parse(StrScore);

            if (GPA >= 3.0 && Score >= 60)
            {
                Console.WriteLine("Accept!");
            }

            else if (GPA < 3.0 && Score >= 80)
            {
                Console.WriteLine("Accept!");
            }

            else
            {
                Console.WriteLine("Reject.");
            }
        }
    }
}
