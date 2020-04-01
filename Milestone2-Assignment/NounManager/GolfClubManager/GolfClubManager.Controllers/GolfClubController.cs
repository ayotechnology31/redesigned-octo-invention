using System;
using System.Collections.Generic;
using System.Text;
using GolfClubManager.Models;
using GolfClubManager.View;
using GolfClubManager.Data;

namespace GolfClubManager.Controllers
{
	public class GolfClubController
	{
		GolfClubManager.View.GolfClubView gv = new GolfClubView();
		GolfClubRepository gr = new GolfClubRepository();

		public void Run()
		{
			int t = 0;

			while(true)
			{

				t = gv.GetMenuChoice();
				if(t == 1)
				{
					CreateGolfClub();
				}
				else if (t == 2)
				{
					ListAllGolfClub();
				}
				else if (t== 3)
				{
					FindByIDGolfClub();
				}
				else if (t == 4)
				{
					EditGolfClub();
				}
				else if (t == 5)
				{
					RemoveGolfClub();
				}
				else if (t == 0)
				{
					Environment.Exit(0);
				}
			}
		}
		
		private void CreateGolfClub()
		{
			GolfClub gcc = gv.GetNewGolfClubInfo();
			gr.Create(gcc);
		}
		private void ListAllGolfClubs()
		{
			
		}

		private void FindByIDGolfClub()
		{

		}

		private void EditGolfClub()
		{

		}

		private void RemoveGolfClub()
		{
			int id = gv.ConfirmRemoveGolfClub(null);
			gr.Delete(id);
		}
	}
}
