using System;

namespace _6._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            strMethod(str);
        }

        private static void strMethod(string str)
        {
            if ((str.Length) % 2 == 0)
            {
                Console.Write($"{str[str.Length / 2-1]}{str[str.Length / 2]}");
            }
            else
            {
                Console.Write($"{str[str.Length / 2]}");
            }
        }
    }
}
