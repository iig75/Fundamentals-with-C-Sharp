using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1___World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {

                List<string> command = Console.ReadLine()
                                              .Split(":", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                if (command[0] == "Travel")
                    break;



                if (command[0] == "Add Stop")
                {
                    if ((int.Parse(command[1]) >= 0) && (int.Parse(command[1]) <= input.Length-1))
                    {
                        input = input.Insert(int.Parse(command[1]), command[2]);
                    }

                    Console.WriteLine(input);
                }



                if (command[0] == "Remove Stop")
                {
                    if (((int.Parse(command[1]) >= 0) && (int.Parse(command[1]) <= input.Length-1)) &&
                        ((int.Parse(command[2]) >= 0) && (int.Parse(command[2]) <= input.Length-1)) &&
                        (int.Parse(command[1]) <= int.Parse(command[2])))
                    {
                        input = input.Remove(int.Parse(command[1]), int.Parse(command[2]) - int.Parse(command[1]) + 1);
                    }

                    Console.WriteLine(input);
                }



                if (command[0] == "Switch")
                {
                    if ((input.Contains(command[1])) && (command[1] != command[2]))
                    {
                        input = input.Replace(command[1], command[2]);
                    }

                    Console.WriteLine(input);
                }

            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
