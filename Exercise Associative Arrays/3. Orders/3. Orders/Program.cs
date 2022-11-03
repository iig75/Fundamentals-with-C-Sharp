using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> orders = new Dictionary<string, string>();

            while(true)
            {
                List<string> command = Console.ReadLine()
                                              .Split()
                                              .ToList();

                if (command[0] == "buy")
                    break;

                if(!orders.ContainsKey(command[0]))
                {
                    orders.Add(command[0], $"{command[1]}:{command[2]}");
                }
                else
                {
                    List<string> A = orders[command[0]].Split(":").ToList();

                    A[1] = (int.Parse(A[1]) + int.Parse(command[2])).ToString();

                    if (double.Parse(A[1]) > double.Parse(command[1]))
                        A[0] = command[1];

                    orders[command[0]] = $"{A[0]}:{A[1]}";
                }
            }

            foreach (var val in orders)
            {
                List<string> B = val.Value.Split(":").ToList();

                Console.WriteLine($"{val.Key} -> {(double.Parse(B[0])*int.Parse(B[1])):f2}");
            }
        }
    }
}