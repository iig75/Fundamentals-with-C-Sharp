using System;
using System.Collections.Generic;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordToLowerCase = word.ToLower();

                if(counts.ContainsKey(wordToLowerCase))
                {
                    counts[wordToLowerCase]++;
                }
                else
                {
                    counts.Add(wordToLowerCase, 1);
                }
            }

            foreach(var val in counts)
            {
                if(val.Value % 2 != 0)
                {
                    Console.Write(val.Key +" ");
                }
            }
        }
    }
}
