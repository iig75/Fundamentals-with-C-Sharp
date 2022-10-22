using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> BigList = Console.ReadLine()
                                          .Split("|")
                                          .Reverse()
                                          .ToList();

            List<string> SmallList = new List<string>();

            for (int i = 0; i < BigList.Count; i++)
            {
                SmallList = BigList[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .ToList();

                for (int j = 0; j < SmallList.Count; j++)
                {
                    Console.Write($"{SmallList[j]} ");
                }
            }
        }
    }
}
