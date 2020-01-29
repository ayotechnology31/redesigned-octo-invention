using System;

namespace LovesMe
{
	class Program
	{
		static void Main(string[] args)
		{
			int pedals = 34;
			int noPedals = 0;

			Console.WriteLine("Well here goes nothing...");

			while (pedals > noPedals)
			{
				if(pedals % 2 == 0)
				{
					Console.WriteLine("It loves me NOT!");
				}
				else
				{
					Console.WriteLine("It loves me!");
				}
				pedals--;
			}
			Console.WriteLine("I knew it! It LOVES ME!");
		}
	}
}
