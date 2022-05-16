// Does the program compile with no syntax errors? YES
// Does the program implement all of the requirements stated in the exercise directions? YES
// Does the program work correctly according to the exercise requirements? YES

using System;

namespace DriverLicenseFormat
{
    class Program
    {
        static string Soundex(string StringNumber)
        {
            string SoundexString; //Soundex Variables
            string Letter;
            string Num1;
            string Num2;
            string Num3;
            string Phrase1;
            string Phrase2;
            string Phrase3;
            string SoundexFinalPhrase;

            SoundexString = StringNumber.Substring(0, 4);
            Letter = StringNumber.Substring(0, 1);
            Num1 = StringNumber.Substring(1, 1);
            Num2 = StringNumber.Substring(2, 1);
            Num3 = StringNumber.Substring(3, 1);

            if (Num1 == "1")
            {
                Phrase1 = "The first consanant is: B, F, V, or P. \n";
            }
            else if (Num1 == "2")
            {
                Phrase1 = "The first consanant is: C, G, J, K, Q, S, X, or Z. \n";
            }
            else if (Num1 == "3")
            {
                Phrase1 = "The first consanant is: D, or T. \n";
            }
            else if (Num1 == "4")
            {
                Phrase1 = "The first consanant is: L. \n";
            }
            else if (Num1 == "5")
            {
                Phrase1 = "The first consanant is: M, or N. \n";
            }
            else if (Num1 == "6")
            {
                Phrase1 = "The first consanant is: R. \n";
            }
            else
            {
                Phrase1 = "There is no letter for the 2nd place, 0 is a placeholder. \n";
            }

            if (Num2 == "1")
            {
                Phrase2 = "The next consanant is: B, F, V, or P. \n";
            }
            else if (Num2 == "2")
            {
                Phrase2 = "The next consanant is: C, G, J, K, Q, S, X, or Z. \n";
            }
            else if (Num2 == "3")
            {
                Phrase2 = "The next consanant is: D, or T. \n";
            }
            else if (Num2 == "4")
            {
                Phrase2 = "The next consanant is: L. \n";
            }
            else if (Num2 == "5")
            {
                Phrase2 = "The next consanant is: M, or N. \n";
            }
            else if (Num2 == "6")
            {
                Phrase2 = "The next consanant is: R. \n";
            }
            else
            {
                Phrase2 = "There is no letter for the 3rd place, 0 is a placeholder. \n";
            }

            if (Num3 == "1")
            {
                Phrase3 = "The last consanant is: B, F, V, or P.\n";
            }
            else if (Num3 == "2")
            {
                Phrase3 = "The last consanant is: C, G, J, K, Q, S, X, or Z.\n";
            }
            else if (Num3 == "3")
            {
                Phrase3 = "The last consanant is: D, or T.\n";
            }
            else if (Num3 == "4")
            {
                Phrase3 = "The last consanant is: L.\n";
            }
            else if (Num3 == "5")
            {
                Phrase3 = "The last consanant is: M, or N.\n";
            }
            else if (Num3 == "6")
            {
                Phrase3 = "The last consanant is: R.\n";
            }
            else
            {
                Phrase3 = "There is no letter for the 4th place, 0 is a placeholder.\n";
            }

            SoundexFinalPhrase = "Your Soundex code is: " + Letter + Num1 + Num2 + Num3+ ".\n" + "The first letter is: " + Letter + ".\n" + Phrase1 + Phrase2 + Phrase3;

            return SoundexFinalPhrase;
        }



        static void PrintSoundex(string SoundexFinalString) // Prints Soundex info.
        {
            Console.WriteLine(SoundexFinalString);
            Console.WriteLine("");
        }

        static void PrintNameCodeInfo(string StringNumber) //Prints Name Code Info. No Calculations used.
        {
            string Name;
            Name = StringNumber.Substring(5, 3);
            Console.WriteLine("Your encoded name is: " + Name);
            Console.WriteLine("The second field is a numerical code based on your first name and middle initial. If your name is not on a preset list of names, you can calculate the number with your first and middle initial.");
            Console.WriteLine("");
        }

        static void PrintBirthYear(string StringNumber) // Prints Birth Year, No calculations used.
        {
            string Year; //Birth Year Variables
            string WholeYear;
            Year = StringNumber.Substring(9, 2);
            WholeYear = "19" + Year;
            Console.WriteLine("Birth Year: " + WholeYear + ".");
        }

        static int BirthMonth(string StringNumber) //Birth Month and Birth Day are aquire using the same function just returning different things each time.
        {                                          //I wrote it thinking you can pass back multiple variables to main, but figured out i can do it this way.
                                                   //I have a test number for both male and female and loop through each day of the year to find the day that produces the number on the drivers license.

            string StrNum;
            int Number;
            int TestNumberM = 0;
            int TestNumberF = 0;
            int Month = 1;
            int MonthNum = 1;
            string[] MonthArray = { "Zero", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }; //zero is inserted as first month to line up array and month.
            int Day = 0;
            int DayNum = 1;
            int Female = 500;
            int Male = 0;

            StrNum = StringNumber.Substring(12, 3);
            Number = Int32.Parse(StrNum);

            while (Month <= 12 && TestNumberM != Number && TestNumberF != Number)
            {
                Day = 0;

                while (Day <= 30 && TestNumberM != Number && TestNumberF != Number)
                {
                    Day++;
                    TestNumberM = ((Month - 1) * 40) + Day + Male;
                    TestNumberF = ((Month - 1) * 40) + Day + Female;
                    if (TestNumberM == Number || TestNumberF == Number)
                    {
                        MonthNum = Month;
                        DayNum = Day;
                    }

                }
                if (TestNumberF != Number || TestNumberM != Number)
                    Month++;
            }

            return MonthNum;

        }

        static int BirthDay(string StringNumber) //Same method as BirthMonth just returns the day instead of the month.
        {
            string StrNum;
            int Number;
            int TestNumberM = 0;
            int TestNumberF = 0;
            int Month = 1;
            int MonthNum = 1;
            int Day = 0;
            int DayNum = 1;
            int Female = 500;
            int Male = 0;

            StrNum = StringNumber.Substring(12, 3);
            Number = Int32.Parse(StrNum);

            while (Month <= 12 && TestNumberM != Number && TestNumberF != Number)
            {
                Day = 0;

                while (Day <= 30 && TestNumberM != Number && TestNumberF != Number)
                {
                    Day++;
                    TestNumberM = ((Month - 1) * 40) + Day + Male;
                    TestNumberF = ((Month - 1) * 40) + Day + Female;
                    if (TestNumberM == Number || TestNumberF == Number)
                    {
                        MonthNum = Month;
                        DayNum = Day;
                    }

                }
                if (TestNumberF != Number || TestNumberM != Number)
                    Month++;
            }

            return DayNum;
        }

        static void PrintBirthDay(int MonthNum, int DayNum) // changes month number into actual name of the month and prints day as well.
        {
            string MonthName;
            string[] MonthArray = { "Zero", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" }; //zero is inserted as first month to line up array and month.
            MonthName = MonthArray[MonthNum];
            Console.WriteLine("Birth Month: " + MonthName + ".");
            Console.WriteLine("Birth Day: " + DayNum + ".");
            Console.WriteLine("");
        }

        static void PrintOverflow(string StringNumber)// gets and prints overflow number.
        {
            string OverflowNumber;
            OverflowNumber = StringNumber.Substring(16);
            Console.WriteLine("The Overflow number is: " + OverflowNumber + ".");
            Console.WriteLine("This number exists to tell if your license number is the same as someone elses.");
            Console.WriteLine("This is what's used to tell them apart.");

        }

            static void Main(string[] args)
        {
            int MonthNum;
            int DayNum;
            string SoundexFinalString;

            Console.Write("Enter your drivers license number w/ dashes: "); // prompt for input
            string StringNumber = Console.ReadLine(); // reads input

            SoundexFinalString = Soundex(StringNumber);//Calculate soundex info.
            PrintSoundex(SoundexFinalString);//Print Soundex info.

            PrintNameCodeInfo(StringNumber);// Prints encoded name info.

            PrintBirthYear(StringNumber);// prints birth year

            MonthNum = BirthMonth(StringNumber);// calculates month.
            DayNum = BirthDay(StringNumber);// calculates day.
            PrintBirthDay(MonthNum, DayNum);// prints whole birthday.

            PrintOverflow(StringNumber);//Prints Overflow information.
        }
    }
}
