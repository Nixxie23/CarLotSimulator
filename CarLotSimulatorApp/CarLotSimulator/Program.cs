using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCarLot = new CarLot();
            var coolCar = new Car();
            coolCar.Make = "Chevrolet";
            coolCar.Model = "Impala";
            coolCar.Year = 1967;
            coolCar.IsDriveable = true;
            coolCar.EngineNoise = "vrrrROOOOOmmmmm";
            coolCar.HonkNoise = "hooooooooonk";

            firstCarLot.CarList = new List<Car>();
            firstCarLot.CarList.Add(coolCar);
            
            
            var mysteryMachine = new Car() { IsDriveable = true, EngineNoise = "rumblerumble", HonkNoise = "BEEP BEEP", Make = "Ford", Model = "Econoline", Year = 1978 };

            firstCarLot.CarList.Add(mysteryMachine);
            
            var tardis = new Car()
            {
                IsDriveable = true,
                EngineNoise = "reEEEeee, reEEEEeee, reeEEEEeee,",
                HonkNoise = "SCREECH",
                Make = "Time Lords Auto",
                Model = "Blue Police Box",
                Year = 0

            };
            firstCarLot.CarList.Add(tardis);

            coolCar.MakeEngineNoise(coolCar.EngineNoise);
            mysteryMachine.MakeEngineNoise(tardis.EngineNoise);
            tardis.MakeEngineNoise(mysteryMachine.EngineNoise);
            coolCar.MakeHonkNoise(coolCar.HonkNoise);
            mysteryMachine.MakeHonkNoise(mysteryMachine.HonkNoise);
            tardis.MakeHonkNoise(tardis.HonkNoise);

            foreach (var car in firstCarLot.CarList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}.");
            }

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
