using System;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            string str = Console.ReadLine();

            for(int i=0; i<str.Length; i++)
            {
                if (str[i] != (char)32)
                {
                    if (count.ContainsKey(str[i]))
                    {
                        count[str[i]]++;
                    }
                    else
                    {
                        count.Add(str[i], 1);
                    }
                }
            }

            foreach(var val in count)
            {
                Console.WriteLine($"{val.Key} -> {val.Value}");
            }
        }
    }
}
