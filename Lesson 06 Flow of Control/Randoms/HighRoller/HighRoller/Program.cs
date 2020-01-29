using System;

namespace HighRoller
{
	class Program
	{
		static void Main(string[] args)
		{
			//Random diceRoller = new Random();

			//int rollResult = diceRoller.Next(6) + 1;

			//Console.WriteLine("TIME TO ROOOOOOLL THE DICE!");
			//Console.WriteLine("I rolled a " + rollResult);

			//if (rollResult == 1)
			//{
			//	Console.WriteLine("You rolled a critical failure!");
			//}

			Random diceRoller = new Random();

			int rollResult = diceRoller.Next(6) + 1;

			int input;

			Console.WriteLine("TIME TO ROOOOOOLL THE DICE!");
			Console.WriteLine("How many number of sides does the dice have?");
			
			input = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("I rolled a " + rollResult);

			if (rollResult == 1)
			{
				Console.WriteLine("You rolled a critical failure! Ouch");
			}
			else
			{
				Console.WriteLine("You rolled a critical! Nice Job!");
			}
		}
	}
}
