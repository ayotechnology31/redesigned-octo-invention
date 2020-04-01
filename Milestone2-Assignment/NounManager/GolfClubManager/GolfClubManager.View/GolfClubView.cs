using System;
using System.Collections.Generic;
using System.Text;
using GolfClubManager.Models;

namespace GolfClubManager.View
{
	public class GolfClubView
	{
		public int GetMenuChoice()
		{
			while (true)
			{
				Console.WriteLine("GolfClubManager");
				Console.WriteLine("---------------------");
				Console.WriteLine("1. Create");
				Console.WriteLine("2. List All");
				Console.WriteLine("3. Find By ID");
				Console.WriteLine("4. Edit");
				Console.WriteLine("5. Remove");

				Console.WriteLine("\nQ to quit");
				Console.WriteLine("Enter selection: ");

				string userInput = Console.ReadLine();

				switch (userInput)
				{
					case "1":
						return 1;
					case "2":
						return 2;
					case "3":
						return 3;
					case "4":
						return 4;
					case "5":
						return 5;
					case "Q":
						return 0;
				}
			}
		}

		public GolfClub GetNewGolfClubInfo()
		{

			///example of isolation 
			GolfClub gcv = new GolfClub();

			int id, year;
			string name;
			float rating;
			Console.WriteLine("Enter Golf Club Id (5 digits): ");
			id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(id);
			Console.WriteLine("Enter Golf Club Name: ");
			name = Console.ReadLine();
			Console.WriteLine("Enter Golf Club Year: ");
			year = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Golf Club Rating (1-5 stars): ");
			rating = float.Parse(Console.ReadLine());

			gcv.Id = id;
			gcv.Name = name;
			gcv.Year = year;
			gcv.Rating = rating;

			return gcv;
		}

		public void DisplayAllGolfClubs(GolfClub gc)
		{
			// give context to user 
			Console.WriteLine("Here's a list of all the golf clubs: ");
		}

		public GolfClub EditGolfClub(GolfClub gc)
		{
			int id, year;
			string name;
			float rating;

			return null;
		}

		public int SearchGolfClub()
		{
			return 0;
		}

		public int ConfirmRemoveGolfClub(GolfClub gc)
		{
			int id;
			Console.WriteLine("Enter Golf Club ID you want to remove.");
			id = Convert.ToInt32(Console.ReadLine());

			return id;
		}
	}
}
