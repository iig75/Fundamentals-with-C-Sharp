using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<string> names = new List<string> { };

            for (int i=1; i<=num; i++)
            {
                List<string> command = Console.ReadLine()
                                              .Split()
                                              .ToList();

                if (command[2] == "going!")
                { 
                    if(names.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(command[0]);
                    }
                }

                if(command[2]=="not")
                {
                    if (names.Contains(command[0]))
                    {
                        names.Remove(command[0]); 
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}
