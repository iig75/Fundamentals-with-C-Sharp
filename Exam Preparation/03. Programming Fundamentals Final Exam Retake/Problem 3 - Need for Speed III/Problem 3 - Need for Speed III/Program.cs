using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                List<string> data = Console.ReadLine()
                                           .Split("|", StringSplitOptions.RemoveEmptyEntries)
                                           .ToList();

                Car car = new Car(data[0], int.Parse(data[1]), int.Parse(data[2]));

                cars.Add(car);
            }



            while(true)
            {
                List<string> commands = Console.ReadLine()
                                               .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                                               .ToList();

                if (commands[0] == "Stop")
                    break;



                if (commands[0] == "Drive")
                {
                    foreach (Car c in cars)
                    {
                        if (c.CarName == commands[1])
                        {
                            if (c.Fuel >= int.Parse(commands[3]))
                            {
                                c.Fuel -= int.Parse(commands[3]);
                                c.Mileage += int.Parse(commands[2]);
                                Console.WriteLine($"{c.CarName} driven for {commands[2]} kilometers. {commands[3]} liters of fuel consumed.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough fuel to make that ride");
                            }

                            if(c.Mileage>=100000)
                            {
                                Console.WriteLine($"Time to sell the {c.CarName}!");
                                cars.Remove(c);
                                break;
                            }
                        }

                    }
                }



                if (commands[0] == "Refuel")
                {
                    foreach(Car c in cars)
                    {
                        if(c.CarName == commands[1])
                        {
                            if (c.Fuel+int.Parse(commands[2]) >= 75)
                            {
                                Console.WriteLine($"{c.CarName} refueled with {75 - c.Fuel} liters");
                                c.Fuel = 75;                                
                            }
                            else
                            {
                                c.Fuel += int.Parse(commands[2]);
                                Console.WriteLine($"{c.CarName} refueled with {commands[2]} liters");
                            }
                        }

                    }
                }



                if (commands[0] == "Revert")
                {
                    foreach (Car c in cars)
                    {
                        if (c.CarName == commands[1])
                        {
                            if (c.Mileage - int.Parse(commands[2]) < 10000)
                            {
                                c.Mileage = 10000;
                            }
                            else
                            {
                                c.Mileage -= int.Parse(commands[2]);
                                Console.WriteLine($"{c.CarName} mileage decreased by {commands[2]} kilometers");
                            }
                        }
                    }
                }
            }

            foreach(Car c in cars)
            {
                Console.WriteLine($"{c.CarName} -> Mileage: {c.Mileage} kms, Fuel in the tank: {c.Fuel} lt.");
            }

        }
    }



    class Car
    {
        public Car(string carName, int mileage, int fuel)
        {
            CarName = carName;
            Mileage = mileage;
            Fuel = fuel;
        }

        public string CarName { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }
}
