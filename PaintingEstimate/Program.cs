// Does the program compile with no syntax errors? Yes.
// Does the program implement all of the requirements stated in the exercise directions? Yes.
// Does the program work correctly according to the exercise requirements? Yes.


using System;

namespace PaintingEstimate
{
    class Program
    {
        static int Cost(int Length, int Width)
        {
            int Wall1 = Length * 9; //9 feet tall times Length for walls 1 and 3.
            int Wall2 = Width * 9; //9 feet tall times Width for walls 2 and 4.
            int WallTotal = (Wall1 * 2) + (Wall2 * 2);
            int WallCost = 6 * WallTotal;
            return WallCost;
        }
        static void Main(string[] args)
        {
            int Length;
            string StringLength;

            int Width;
            string StringWidth;

            int TotalCost;

            Console.Write("Enter the Length of the room: ");
            StringLength = Console.ReadLine();
            Length = Int32.Parse(StringLength);

            Console.Write("Enter the Width of the room: ");
            StringWidth = Console.ReadLine();
            Width = Int32.Parse(StringWidth);

            TotalCost = Cost(Length, Width);
            Console.Write("Cost to paint room at $6 per sq foot: $" + TotalCost + ".");

         }
    }
}
