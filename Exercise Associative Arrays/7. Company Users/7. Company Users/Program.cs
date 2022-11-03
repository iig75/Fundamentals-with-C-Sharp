using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while(true)
            {
                List<string> command = Console.ReadLine().Split(" -> ").ToList();

                if (command[0] == "End")
                    break;

                if(!companies.ContainsKey(command[0]))
                {
                    companies.Add(command[0], new List<string>());
                    companies[command[0]].Add(command[1]);
                }
                else
                {
                    if(!companies[command[0]].Contains(command[1]))
                    {
                        companies[command[0]].Add(command[1]);
                    }
                }
            }

            foreach(var val in companies)
            {
                Console.WriteLine($"{val.Key}");

                foreach(var val1 in val.Value)
                {
                    Console.WriteLine($"-- {val1}");
                }
            }
        }
    }
}
