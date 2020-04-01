using GolfClubManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GolfClubManager.Data
{
	public class GolfClubRepository : GolfClub
	{
		//everything is interacting with line 10
		List<GolfClub> golfClubs = new List<GolfClub>();
		public void Create(GolfClub gcr)
		{
			golfClubs.Add(gcr);
		}

		public List<GolfClub> ReadAll(GolfClub gcc) 
		{
			//how do i read from my list


			return null;
		}

		public GolfClub ReadById()
		{
			return null;
		}
		
		public void Update(int id, GolfClub gc)
		{

		}
		
		public void Delete(int id)
		{
			List<GolfClub> golfClubsCopy = new List<GolfClub>();
			foreach(GolfClub gc in golfClubs)
			{
				if(gc.Id == id) 
				{
					continue;
				}
				golfClubsCopy.Add(gc);
			}
			golfClubs = golfClubsCopy;
		}

	}
}
