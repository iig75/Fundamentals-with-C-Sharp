using System;
using System.Linq;

namespace _4._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                    .Split()
                                    .Where(x => x.Length % 2 == 0)
                                    .ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
