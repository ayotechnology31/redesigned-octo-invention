using System;

namespace GuessMeFinally
{
	class Program
	{
		static void Main(string[] args)
		{
			Random yourGuess = new Random();
			int rightAnswer = yourGuess.Next(-10, 10);
			string input;
			int guess;
			int numberLoops = 1;

			while (true)
			{
				Console.Write("I've chosen a number between -10 and 10. Betcha can't guess it! ");
				input = Console.ReadLine();
				Console.WriteLine("Your guess: " + input);

				///changing from one type to another
				if (int.TryParse(input, out guess))
				{
					numberLoops++;
					if (rightAnswer == guess && numberLoops == 1)
					{
						Console.WriteLine("Wow, nice guess! That was it!");
						break;
					}
					else if (rightAnswer > guess)
					{
						Console.WriteLine("Ha, nice try -too low! Try again!");
						continue;
					}

					//compare right answer and users guess
					else if (rightAnswer < guess)
					{
						Console.WriteLine("Too bad, way too high. Try again!");
						continue;
					}

					if (rightAnswer == guess)
					{
						Console.WriteLine("Finally, it's about time you got it!");
						break;
					}
				}
			}
		}
	}
}
