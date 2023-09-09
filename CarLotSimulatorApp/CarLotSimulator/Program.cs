using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //instanciate Carlot at the beggining of the program
            //and as you create a car add the car to the list.
            var lot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            //Set the properties for each of the cars
            //Call each of the methods for each car

            var felixCar = new Car();
            felixCar.Make = "Dodge";
            felixCar.Model = "challenger";
            felixCar.Year = 2023;
            felixCar.EngineNoise = "vroom";
            felixCar.HonkNoise = "weep";
            felixCar.IsDrivable = true;

            lot.Cars.Add(felixCar);

            var joeysCar = new Car()
            {
                Year = 2006,
                Make = "Nissan",
                Model = "370z",
                EngineNoise = "BopBopBop",
                HonkNoise = "plop",
                IsDrivable = false
            };

            lot.Cars.Add(joeysCar);

            var chachysCar = new Car(2012, "Toyota", "Yaris", "pewwww","boopboop", true);

            lot.Cars.Add(chachysCar);

            //Call methods

            joeysCar.MakeEngineNoise();
            chachysCar.MakeEngineNoise();
            felixCar.MakeEngineNoise();


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Numbers of cars created: { CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }


    }
}
