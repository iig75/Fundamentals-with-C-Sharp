using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            
            while (true)
            {
                List<string> command = Console.ReadLine().Split(" : ").ToList();

                if (command[0] == "end")
                    break;

                if(!courses.ContainsKey(command[0]))
                {
                    courses.Add(command[0], new List<string>());
                    courses[command[0]].Add(command[1]);
                }
                else
                {
                    courses[command[0]].Add(command[1]);
                }
            }


            foreach(var val in courses)
            {
                Console.WriteLine($"{val.Key}: {val.Value.Count}");

                foreach(var name in val.Value)
                    Console.WriteLine($"-- {name}");
            }
        }
    }
}
