using System;
namespace InterfaceExercise
{
	public interface ICompany
	{

		public string Logo { get; set; }

		public bool HasGoodReviews { get; set; }

		public int AverageCost { get; set; }

		public void ThemeSong ()
		{


			Console.WriteLine("Ford is the best in Texas!");


		}
	}
}

