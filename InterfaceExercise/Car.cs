using System;
namespace InterfaceExercise
{
	public class Car : ICompany, IVehicle
	{
		
		public string FuelMileage { get; set; }

		public bool HasTrunk { get; set; }

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

