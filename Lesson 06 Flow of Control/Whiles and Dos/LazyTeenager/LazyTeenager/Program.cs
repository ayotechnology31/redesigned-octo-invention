using System;

namespace LazyTeenager
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int clean = 0;
			Random chance = new Random();
			clean = chance.Next(15);

			do
			{
				clean = 1;
				break;
			} while (clean);


			Console.WriteLine("Clean your room!! That's IT, I'm doing it!!! YOU'RE GROUNDED AND I'M TAKING YOUR XBOX!");
		}
	}
}
