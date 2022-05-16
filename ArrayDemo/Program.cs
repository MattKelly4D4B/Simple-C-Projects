using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string StringInput;
            int Input = 1;
            int[] ArrayNumber = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 19 };
            string StringArrayPosition;
            int ArrayPosition;
            int ArrayValue;
            string StringArrayValue;
            //for (n = 0; n <= 10; n++)
            //{
            //    i = (n * 5) / 2; //equation that calculates values to be stored in array.
            //    ArrayNumber = new int[] { i };
            //    i++; //Step i to make even more strange int value for array, why not?
            //}

            while (Input == 1 || Input == 2 || Input == 3)
            {
                Console.WriteLine("Enter a value to see the array:");
                Console.WriteLine("1) View the array from first to last position.");
                Console.WriteLine("2) View the array from last to first position.");
                Console.WriteLine("3) View a certain position of the array.");
                Console.WriteLine("4) Quit Application.");
                Console.Write("Number: ");
                StringInput = Console.ReadLine();
                Input = Int32.Parse(StringInput);

                if (Input == 1)
                {
                    Console.WriteLine("First to Last:");
                    foreach (var Num in ArrayNumber)
                    {
                        Console.WriteLine(Num.ToString());
                    }
                }

                else if (Input == 2)
                {
                    Array.Reverse(ArrayNumber);
                    Console.WriteLine("Last to First:");
                    foreach (var Num in ArrayNumber)
                    {
                        Console.WriteLine(Num.ToString());
                    }
                }

                else if (Input == 3)
                {
                    Console.Write("Pick a number from 1-10 to view: ");
                    StringArrayPosition = Console.ReadLine();
                    ArrayPosition = Int32.Parse(StringArrayPosition);

                    ArrayValue = ArrayNumber[ArrayPosition - 1];
                    StringArrayValue = ArrayValue.ToString();
                    Console.WriteLine("Item number " + ArrayPosition.ToString() + " is: " + StringArrayValue + ".");


                }
            }
            if (Input == 4)
            {
                Console.WriteLine("Goodbye!");
            }
        }
        
        }
    }



