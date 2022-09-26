using System;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] items = str.Split();
            Array.Reverse(items);

            foreach (string s in items)
                Console.Write($"{s} ");
        }
    }
}
