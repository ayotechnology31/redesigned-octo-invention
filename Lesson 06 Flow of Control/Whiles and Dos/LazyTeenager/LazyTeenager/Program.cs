using System;

namespace LazyTeenager
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Random chance = new Random();
			int clean = chance.Next(15);

			Console.Write("Did you clean your room?");
			bool cleaned;
			
			if(Console.ReadLine().Equals("y"))
			{
				cleaned = true;
			}
			else
			{
				cleaned = false;
			}

			bool x = false;
			do
			{
				x = true;
				break;
			} while (cleaned);

			if(clean*5 != cleaned)
			{
				Console.WriteLine("Clean your room!!");
			}
			else
			{
				Console.WriteLine("Clean your room!! That's IT, I'm doing it!!! YOU'RE GROUNDED AND I'M TAKING YOUR XBOX!");
			}
		}
	}
}
