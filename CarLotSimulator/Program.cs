﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Now that the Car class is created we can instanciate 3 new cars

            //Standard member initialization ---------- one type
            var Car1 = new Car();
            Car1.Year = 2017;
            Car1.Make = "Honda";
            Car1.Model = "Civic";
            Car1.EngineNoise = "RRRHUMMMM";
            Car1.HonkNoise = "Beep, Bong";
            Car1.IsDriveable = "true";

            var Car2 = new Car();
            Car2.Year = 2015;
            Car2.Make = "Dogde";
            Car2.Model = "Ram";
            Car2.EngineNoise = "GGGRRRRRUUUU";
            Car2.HonkNoise = "Honk, Honnnnnk";
            Car2.IsDriveable = "true";

            var Car3 = new Car();
            Car3.Year = 2015;
            Car3.Make = "Ford";
            Car3.Model = "Fusion";
            Car3.EngineNoise = "Hmmmmm";
            Car3.HonkNoise = "Beep, Beep, Ding";
            Car3.IsDriveable = "flase";

            //Set the properties for each of the cars
            //Call each of the methods for each car

            Console.WriteLine("----------");

            Car1.MakeEngineNoise();
            Car1.MakeHonkNoise();

            Console.WriteLine("----------");

            Car2.MakeEngineNoise();
            Car2.MakeHonkNoise();

            Console.WriteLine("----------");

            Car3.MakeEngineNoise();
            Car3.MakeHonkNoise();



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            //Object initializer syntax --------- two type

            Car celica = new Car() {
                Year = 2000,
                Make = "Toyota",
                Model = "Celica",
                EngineNoise = "Nothing",
                HonkNoise = "Help" };

            Console.WriteLine("----------");
            celica.MakeEngineNoise();
            celica.MakeHonkNoise();

            //Constructor initialization -------------third type

            Car someOtherCar = new Car(
                3000, "Mars Inc.",
                "Alpha ++", "Space Noises",
                "Does a space ship Honk?",
                "true");

            Console.WriteLine("----------");
            someOtherCar.MakeEngineNoise();
            someOtherCar.MakeHonkNoise();


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"---------------");
            Console.WriteLine($"Number of New Cars added: {CarLot.nubmerOfCars}");





        }


    }
}
