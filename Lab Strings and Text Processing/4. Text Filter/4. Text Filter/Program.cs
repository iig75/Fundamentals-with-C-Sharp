using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> banList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string str = Console.ReadLine();

            foreach(var val in banList)
            {
                while (str.Contains(val))
                {
                    str = str.Replace(val, new string('*', val.Length));
                }
            }

            Console.WriteLine($"{str}");
        }
    }
}
