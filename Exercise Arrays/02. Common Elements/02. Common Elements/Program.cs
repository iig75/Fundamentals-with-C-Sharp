using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine()
                                   .Split()
                                   .ToArray();

            string[] str2 = Console.ReadLine()
                                   .Split()
                                   .ToArray();

            foreach(string s in str2)
                foreach(string s1 in str1)
                    if(s==s1)
                        Console.Write($"{s} ");
        }
    }
}
