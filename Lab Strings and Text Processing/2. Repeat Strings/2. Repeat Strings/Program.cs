using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string str = String.Empty;

            foreach(var val in words)
            {
                for (int i = 0; i < val.Length; i++)
                {
                    str += val;
                }
            }

            Console.WriteLine($"{str}");
        }
    }
}
