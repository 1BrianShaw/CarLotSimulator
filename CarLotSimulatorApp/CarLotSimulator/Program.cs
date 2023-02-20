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

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            //Standard Member Initialization
            CarLot lot = new CarLot();
            
            Car bmw = new Car();
            lot.Carlist.Add(bmw);

            bmw.Year = 2018;
            bmw.Make = "BMW";
            bmw.Model = "328i";
            bmw.EngineNoise = "Vroom";
            bmw.HonkNoise = "Beep Beep";
            bmw.IsDriveable= true;

            //bmw.MakeEngineNoise();
            //bmw.MakeHonkNoise();
            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");

            //Object initializer syntax
            Car celica = new Car() { Year = 1996, Make = "Toyota", Model = "Celica", EngineNoise = "putter", HonkNoise = "HAWNK", IsDriveable= true };
            lot.Carlist.Add(celica);
            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");

            //celica.MakeEngineNoise();
            //celica.MakeHonkNoise();

            //Constructor initialization
            Car sonata = new Car(2022, "Hyundai", "Sonata", "vroom vroom", "beep beep", true);
            lot.Carlist.Add(sonata);
            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");

            //sonata.MakeEngineNoise();
            //sonata.MakeHonkNoise();

            Console.WriteLine("-------------");

            foreach(var car in lot.Carlist)
            {
                Console.WriteLine();
                Console.WriteLine($"Year:{car.Year} Make: {car.Make} Model: {car.Model}");
            }

            Console.WriteLine($"The number of cars in the lot is: {CarLot.numberOfCars}");





        }
    }
}
