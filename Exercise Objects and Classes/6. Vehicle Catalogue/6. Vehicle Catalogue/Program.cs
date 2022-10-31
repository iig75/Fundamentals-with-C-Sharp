using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            while(true)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                if (input[0] == "End")
                    break;

                string str = input[0];

                Vehicle vehicle = new Vehicle((char.ToUpper(str[0]) + str.Substring(1)), input[1], input[2], int.Parse(input[3]));

                vehicles.Add(vehicle);
            }



            while(true)
            {
                string command = Console.ReadLine();

                if (command == "Close the Catalogue")
                    break;

                for(int i=0; i<vehicles.Count; i++)
                {
                    Vehicle currentVehicle = vehicles[i];

                    if(currentVehicle.Model==command)
                    {
                        Console.WriteLine($"Type: {currentVehicle.Type}");
                        Console.WriteLine($"Model: {currentVehicle.Model}");
                        Console.WriteLine($"Color: {currentVehicle.Color}");
                        Console.WriteLine($"Horsepower: {currentVehicle.HorsePower}");
                    }
                }
            }



            double carPower = 0;
            double truckPower = 0;

            int carCount = 0;
            int truckCount = 0;

            for (int i = 0; i < vehicles.Count; i++)
            {
                Vehicle currentVehicle = vehicles[i];

                if (currentVehicle.Type == "Car")
                {
                    carPower += currentVehicle.HorsePower;
                    carCount++;
                }

                if (currentVehicle.Type == "Truck")
                {
                    truckPower += currentVehicle.HorsePower;
                    truckCount++;
                }
            }

            if (carCount == 0)
                carCount++;

            if (truckCount == 0)
                truckCount++;

            Console.WriteLine($"Cars have average horsepower of: {(carPower/carCount):f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {(truckPower/truckCount):f2}.");
        }
    }



    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }

}
