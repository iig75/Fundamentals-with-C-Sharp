using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> plants = new List<Plant>();

            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                List<string> input = Console.ReadLine()
                                            .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();

                bool exist = false;

                foreach(Plant p in plants)
                {
                    if (p.PlantName==input[0])
                    {
                        p.Rarity = int.Parse(input[1]);
                        exist = true;
                        break;
                    }
                }

                if(!exist)
                {
                    Plant plant = new Plant(input[0], int.Parse(input[1]), 0, 0);
                    plants.Add(plant);
                }

            }



            while(true)
            {

                List<string> command = Console.ReadLine()
                                              .Replace(" - ", ": ")
                                              .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();



                if (command[0] == "Exhibition")
                    break;



                bool exitst = false;

                foreach (Plant p in plants)
                {
                    if (p.PlantName == command[1])
                    {
                        exitst = true;
                        break;
                    }
                }

                if(!exitst)
                {
                    Console.WriteLine("error");
                }



                if (command[0] == "Rate")
                {
                    foreach (Plant p in plants)
                    {
                        if (p.PlantName == command[1])
                        {
                            p.Rating += double.Parse(command[2]);
                            p.Count++;
                            break;
                        }
                    }
                }



                if (command[0] == "Update")
                {
                    foreach (Plant p in plants)
                    {
                        if (p.PlantName == command[1])
                        {
                            p.Rarity = int.Parse(command[2]);
                            break;
                        }
                    }
                }



                if (command[0] == "Reset")
                {
                    foreach (Plant p in plants)
                    {
                        if (p.PlantName == command[1])
                        {
                            p.Rating = 0;
                            p.Count = 0;
                            break;
                        }
                    }
                }

            }



            Console.WriteLine("Plants for the exhibition:");

            foreach (Plant p in plants)
            {
                double rating = 0;
                
                if((p.Rating!=0) && (p.Count!=0))
                {
                    rating = double.Parse(p.Rating.ToString()) / int.Parse(p.Count.ToString());
                }

                Console.WriteLine($"- {p.PlantName}; Rarity: {p.Rarity}; Rating: {rating:f2}");
            }

        }
    }



    class Plant
    {
        public Plant(string plantName, int rarity, double rating, int count)
        {
            PlantName = plantName;
            Rarity = rarity;
            Rating = rating;
            Count = count;
        }

        public string PlantName { get; set; }

        public int Rarity { get; set; }

        public double Rating { get; set; }

        public int Count { get; set; }
    }
}
