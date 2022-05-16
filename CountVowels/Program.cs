using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 0;
            int Length = 0;
            int Vowels = 0;

            Console.WriteLine("Vowel Counter!");
            Console.Write("Enter a word in lowercase: ");
            string String = Console.ReadLine();

            Length = String.Length;

            while (I < Length)
            {
                Char Letter = String[I];
                string LetterString = Letter.ToString();

                if (LetterString == "a" || LetterString == "A")
                {
                    Vowels = Vowels + 1;
                }
                else if (LetterString == "e" || LetterString == "E")
               {
                    Vowels = Vowels + 1;
                }
                else if (LetterString == "i" || LetterString == "I")
                {
                    Vowels = Vowels + 1;
                }
                else if (LetterString == "o" || LetterString == "O")
                {
                    Vowels = Vowels + 1;
                }
                else if (LetterString == "u" || LetterString == "U")
                {
                    Vowels = Vowels + 1;
                }

                I++;
            }

            Console.WriteLine("Vowels: " + Vowels);

        }
    }
}
