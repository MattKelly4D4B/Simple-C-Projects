using System;

namespace RockPaperScissors
{
	class Program
	{
		static void Main(string[] args)
		{
			Random ranNumGen = new Random(); //1 is scissors, 2 is paper, and 3 is rock.



				int Opponent = ranNumGen.Next(1, 4);
				Console.WriteLine(Opponent);
				Console.WriteLine("Enter a Letter to play Rock Paper Scissors");
				Console.Write("S for Scissors, P for Paper, or R for Rock: ");
				String Player = Console.ReadLine();
				

				if (Player == "S" && Opponent == 1)
				{
					Console.WriteLine("Its a Draw.");
				}

				else if ((Player == "S" && Opponent == 2))
				{
					Console.WriteLine("You Win!");
				}

				else if ((Player == "S" && Opponent == 3))
				{
					Console.WriteLine("Sorry, you Lose.");
				}

				else if (Player == "P" && Opponent == 1)
				{
					Console.WriteLine("Sorry, you Lose.");
				}

				else if ((Player == "P" && Opponent == 2))
				{
					Console.WriteLine("Its a Draw.");
				}

				else if ((Player == "P" && Opponent == 3))
				{
					Console.WriteLine("You Win!");

				}

				else if (Player == "R" && Opponent == 1)
				{
					Console.WriteLine("You Win!");
				}

				else if ((Player == "R" && Opponent == 2))
				{
					Console.WriteLine("Sorry, You Lose.");
				}

				else if ((Player == "R" && Opponent == 3))
				{
					Console.WriteLine("Its a Draw!");
				}

			}
		}
	}



