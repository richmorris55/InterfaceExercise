using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
        public string EngineType { get; set; }

        public string Color { get; set; }

        public bool IsFourWheelDrive { get; set; }

        public string Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
       

        public void EngineNoise()
        {

            Console.WriteLine("Engine sounds good");

        }





    }


}


