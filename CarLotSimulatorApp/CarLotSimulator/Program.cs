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
            
            Car carOne = new Car();
            Car carTwo = new Car();
            Car carThree = new Car();
            
            carOne.Year = 2000;
            carOne.Make = "Make 1";
            carOne.Model = "Model 1";
            carOne.EngineNoise = "EN 1";
            carOne.HonkNoise = "HN 1";
            carOne.IsDriveable = true;
            
            carTwo.Year = 2001;
            carTwo.Make = "Make 2";
            carTwo.Model = "Model 2";
            carTwo.EngineNoise = "EN 2";
            carTwo.HonkNoise = "HN 2";
            carTwo.IsDriveable = true;
            
            carThree.Year = 2002;
            carThree.Make = "Make 3";
            carThree.Model = "Model 3";
            carThree.EngineNoise = "EN 3";
            carThree.HonkNoise =  "HN 3";
            carThree.IsDriveable = false;
            
            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHonkNoise(carOne.HonkNoise);
            
            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carTwo.MakeHonkNoise(carTwo.HonkNoise);
            
            carThree.MakeEngineNoise(carThree.EngineNoise);
            carThree.MakeHonkNoise(carThree.HonkNoise);
        }
    }
}
