using System;

namespace ForTimesFor
{
	class Program
	{
		static void Main(string[] args)
		{
			string input;
			int guess;
			int total = 0;

			Console.WriteLine("Which times table shall I recite? 5");
			for (int x = 1; x < 16; x++)
			{
				Console.WriteLine("What is " + x + " * 5 is: ");
				input = Console.ReadLine();
				if (int.TryParse(input, out guess))
				{
					if (guess == x * 5)
					{
						Console.WriteLine("Correct!");
						total++;
					}
					else
					{
						Console.WriteLine("Sorry no, the answer is: {0}", x * 5);
					}
				}
				//Console.WriteLine(x + "  * 5 is: {0}", x * 5);
			}
			Console.WriteLine("You got " + total + " correct.");
		}
	}
}
