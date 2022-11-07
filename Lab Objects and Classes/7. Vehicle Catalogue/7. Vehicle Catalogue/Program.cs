using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {

            CatalogVehicle catalog = new CatalogVehicle();

            while (true)
            {

                List<string> commands = Console.ReadLine()
                                               .Split("/", StringSplitOptions.RemoveEmptyEntries)
                                               .ToList();

                if (commands[0] == "end")
                    break;

                string vehickleType = commands[0];
                string vehickleBrand = commands[1];
                string vehickleModel = commands[2];
                string vehickleHPW = commands[3];

                if(vehickleType=="Car")
                {
                    Car car = new Car(vehickleType, vehickleBrand, vehickleModel, vehickleHPW);

                    catalog.Cars.Add(car);
                }

                if (vehickleType == "Truck")
                {
                    Truck truck = new Truck(vehickleType, vehickleBrand, vehickleModel, vehickleHPW);

                    catalog.Trucks.Add(truck);
                }

            }



            if(catalog.Cars.Count>0)
            {
                Console.WriteLine("Cars:");
                
                foreach (var val in catalog.Cars.OrderBy(x=>x.CarBrand))
                {
                    Console.WriteLine($"{val.CarBrand}: {val.CarModel} - {val.CarHP}hp");
                }
            }



            if(catalog.Trucks.Count>0)
            {
                Console.WriteLine("Trucks:");

                foreach(var val in catalog.Trucks.OrderBy(x=>x.TruckBrand))
                {
                    Console.WriteLine($"{val.TruckBrand}: {val.TruckModel} - {val.TruckW}kg");
                }
            }



        }
    }



    public class CatalogVehicle
    {
        public CatalogVehicle()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }



    public class Car
    {
        public Car(string carType, string carBrand, string carModel, string carHP)
        {
            CarType = carType;
            CarBrand = carBrand;
            CarModel = carModel;
            CarHP = carHP;
        }

        public string CarType { get; set; }

        public string CarBrand { get; set; }

        public string CarModel { get; set; }

        public string CarHP { get; set; }
    }



    public class Truck
    {
        public Truck(string truckType, string truckBrand, string truckModel, string truckW)
        {
            TruckType = truckType;
            TruckBrand = truckBrand;
            TruckModel = truckModel;
            TruckW = truckW;
        }

        public string TruckType { get; set; }

        public string TruckBrand { get; set; }

        public string TruckModel { get; set; }

        public string TruckW { get; set; }
    }

}
