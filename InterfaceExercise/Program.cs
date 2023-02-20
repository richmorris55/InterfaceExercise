using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

          

            Car car1 = new Car();
            car1.Year = "2021";
            car1.Make = "Subaru";
            car1.Model = "Wrx";
            car1.EngineType = "4 cyl, 2.0 L, Automatic (AV-S8)";
            car1.FuelMileage = "23 mpg combined";
           

            
            SUV suv1 = new SUV();
            suv1.Year = "2023";
            suv1.Make = "Cadillac";
            suv1.Model = "Escalade";
            suv1.EngineType = "8 cyl, 6.2 L, Automatic";
            suv1.HasThirdRowSeating = true;
            


            Truck truck1 = new Truck();
            truck1.Year = "2022";
            truck1.Make = "Ford";
            truck1.Model = "F-350 Super Duty";
            truck1.EngineType = "8 cyl, 6.7 L, Automatic";
            truck1.PayloadCapacity = 4713;


            List<IVehicle> vehicleList = new List<IVehicle>() { car1, suv1, truck1 };



            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"Vehicle Year: {vehicle.Year}");
                Console.WriteLine($"Vehicle Make: {vehicle.Make}" );
                Console.WriteLine($"Vehicle Model: {vehicle.Model}");
                Console.WriteLine($"Engine Type: {vehicle.EngineType}");
                
            }
            



        }
    }
}
