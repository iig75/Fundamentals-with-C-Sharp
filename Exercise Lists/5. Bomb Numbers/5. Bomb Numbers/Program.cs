using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bomb = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            List<int> command = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            int start = 0;
            int count = 0;
            int x = 0;

            for (int i = 0; i < bomb.Count; i++)
            {
                if ((bomb[i] == Math.Abs(command[0])))
                {
                    if (i - Math.Abs(command[1]) <= 0)
                    {
                        start = 0;
                        x = i - command[1];
                    }
                    else
                    {
                        start = i - Math.Abs(command[1]);
                    }

                    if (i + Math.Abs(command[1]) >= bomb.Count)
                    {
                        count = bomb.Count-start;
                    }
                    else
                    {
                        if(x ==0)
                           count = 2 * Math.Abs(command[1]) + 1;
                        else
                           count = 2 * Math.Abs(command[1]) + 1 + x;
                    }

                    bomb.RemoveRange(start, count);
                    i--;
                }
            }

            Console.WriteLine(bomb.Sum());
        }
    }
}
