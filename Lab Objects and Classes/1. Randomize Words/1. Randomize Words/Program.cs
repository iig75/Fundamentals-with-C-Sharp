using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            Random rnd1 = new Random();
            Random rnd2 = new Random();

            for(int i=0; i<words.Count; i++)
            {
                int n1 = rnd1.Next(0, words.Count);
                int n2 = rnd2.Next(0, words.Count);

                string str = words[n1];
                words[n1] = words[n2];
                words[n2] = str;
            }

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
