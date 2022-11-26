using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cityes = new List<City>();



            while (true)
            {
                List<string> input = Console.ReadLine()
                                              .Split("||", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                if (input[0] == "Sail")
                    break;

                if(cityes.Count>0)
                {
                    bool exist = false;

                    foreach (City c in cityes)
                    {                        
                        if (c.CityName == input[0])
                        {
                            exist = true;
                            break;
                        }
                    }

                    if(!exist)
                    {
                        City city = new City(input[0], int.Parse(input[1]), int.Parse(input[2]));
                        cityes.Add(city);
                    }
                    else
                    {
                        foreach (City c in cityes)
                        {
                            if (c.CityName == input[0])
                            {
                                c.CityPeople += int.Parse(input[1]);
                                c.CityGold += int.Parse(input[2]);
                            }
                        }
                    }
                }
                else
                {
                    City city = new City(input[0], int.Parse(input[1]), int.Parse(input[2]));
                    cityes.Add(city);
                }
            }



            while(true)
            {
                List<string> command = Console.ReadLine()
                                              .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                if (command[0] == "End")
                    break;



                if(command[0] == "Plunder")
                {
                    foreach(City c in cityes)
                    {
                        if(c.CityName==command[1])
                        {
                            Console.WriteLine($"{c.CityName} plundered! {command[3]} gold stolen, {command[2]} citizens killed.");

                            c.CityPeople -= int.Parse(command[2]);
                            c.CityGold -= int.Parse(command[3]);

                            if ((c.CityPeople <= 0) || (c.CityGold <= 0))
                            {
                                Console.WriteLine($"{c.CityName} has been wiped off the map!");
                                cityes.Remove(c);
                                break;
                            }
                        }
                    }
                }



                if(command[0] == "Prosper")
                {
                    foreach (City c in cityes)
                    {
                        if (c.CityName == command[1])
                        {
                            if(int.Parse(command[2]) < 0)
                            {
                                Console.WriteLine($"Gold added cannot be a negative number!");
                            }
                            else
                            {
                                c.CityGold += int.Parse(command[2]);
                                Console.WriteLine($"{command[2]} gold added to the city treasury. {c.CityName} now has {c.CityGold} gold.");
                            }
                        }
                    }
                }
            }



            if(cityes.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityes.Count} wealthy settlements to go to:");

                foreach (City c in cityes)
                {
                    Console.WriteLine($"{c.CityName} -> Population: {c.CityPeople} citizens, Gold: {c.CityGold} kg");
                }
             
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }            
        }
    }



    class City
    {
        public City(string cityName, int cityPeople, int cityGold)
        {
            CityName = cityName;
            CityPeople = cityPeople;
            CityGold = cityGold;
        }

        public string CityName { get; set; }

        public int CityPeople { get; set; }

        public int CityGold { get; set; }
    }
}
