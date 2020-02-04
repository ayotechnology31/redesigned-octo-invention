using System;

namespace LazyTeenager
{
	class Program
	{
		static void Main(string[] args)
		{

			bool cleaned = false;
			int cleaningChance = 0;
			int numberOfTimes = 0;
			//int acceptableChance = 60;
			Random chance = new Random();
			int acceptableChance = chance.Next(70,80);

			do
			{
				Console.Write(cleaningChance + "%" + " ");
				Console.WriteLine("Clean your room!!");
				cleaningChance = cleaningChance + 5;
				numberOfTimes++;
				if(numberOfTimes == 15)
				{
					Console.WriteLine("Clean your room!! That's IT, I'm doing it!!! YOU'RE GROUNDED AND I'M TAKING YOUR XBOX!");
					break;
				}
				if(cleaningChance >= acceptableChance)
				{
					Console.WriteLine("FINE! I'LL CLEAN MY ROOM. BUT I REFUSE TO EAT MY PEAS");
					cleaned = true;
				}

			}
			while (cleaned == false);



			//Random chance = new Random();
			//int clean = chance.Next(15);

			//Console.Write("Did you clean your room?");
			//bool cleaned;
			
			//if(Console.ReadLine().Equals("y"))
			//{
			//	cleaned = true;
			//}
			//else
			//{
			//	cleaned = false;
			//}

			//bool x = false;
			//do
			//{
			//	x = true;
			//	break;
			//} while (cleaned);

			//if(clean*5 != cleaned)
			//{
			//	Console.WriteLine("Clean your room!!");
			//}
			//else
			//{
			//	Console.WriteLine("Clean your room!! That's IT, I'm doing it!!! YOU'RE GROUNDED AND I'M TAKING YOUR XBOX!");
			//}
		}
	}
}
