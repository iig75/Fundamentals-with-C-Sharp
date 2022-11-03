using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>(); 

            for(int i=1; i<=n; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                if(command[0]== "register")
                {
                    if(!parking.ContainsKey(command[1]))
                    {
                        parking.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                    }
                }

                if(command[0]== "unregister")
                {
                    if (parking.ContainsKey(command[1]))
                    {
                        parking.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }

            foreach(var val in parking)
            {
                Console.WriteLine($"{val.Key} => {val.Value}");
            }
        }
    }
}
