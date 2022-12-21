using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var lot = new CarLot();

            var ford = new Car();
            ford.Year = 2010;
            ford.Make = "Ford";
            ford.Model = "Focus";
            ford.IsDriveable = false;
            ford.EngineNoise = "Pffft";
            ford.HonkNoise = "Beep";
            lot.Stock.Add(ford);

            var chevy = new Car();
            chevy.Year = 2001;
            chevy.Make = "Chevy";
            chevy.Model = "Equinox";
            chevy.IsDriveable = true;
            chevy.EngineNoise = "Vroom-Vroom";
            chevy.HonkNoise = "Beep-Beep";
            lot.Stock.Add(chevy);

            var chevy2 = new Car();
            chevy2.Year = 2020;
            chevy2.Make = "Chevy";
            chevy2.Model = "Malibu";
            chevy2.IsDriveable = true;
            chevy2.EngineNoise = "Vrmmm";
            chevy2.HonkNoise = "Beep";
            lot.Stock.Add(chevy2);


            Console.WriteLine("---------------");

            foreach (var vehicle in lot.Stock)
            {
                vehicle.MakeEngineNoise(vehicle.EngineNoise);
                vehicle.MakeHonkNoise(vehicle.HonkNoise);
            }
            Console.WriteLine("---------------");
            Console.WriteLine("BONUS");
            Console.WriteLine("---------------");
            foreach (var vehicle in lot.Stock)
            {
                Console.WriteLine("Make: " + vehicle.Make);
                Console.WriteLine("Year: " + vehicle.Year);
                Console.WriteLine("Model: " + vehicle.Model);
            }

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
