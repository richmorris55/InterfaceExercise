using System;
namespace InterfaceExercise
{
	public class SUV : ICompany, IVehicle
	{
		public bool HasThirdRowSeating { get; set; }

		public bool PowerFoldingSeats { get; set; }
        public string Logo { get ; set ; }
        public bool HasGoodReviews { get ; set ; }
        public int AverageCost { get ; set ; }
        public string EngineType { get ; set ; }
        public string Color { get ; set ; }
        public bool IsFourWheelDrive { get ; set ; }
        public string Year { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
    }
}

