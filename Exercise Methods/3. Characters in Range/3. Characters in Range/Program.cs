using System;

namespace _3._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {

            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());

            ascii(ch1, ch2);

        }

        private static void ascii(char ch1, char ch2)
        {
            if ((int)ch1 <= (int)ch2)
            {
                for (int i = (int)ch1 + 1; i <= (int)ch2 - 1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = (int)ch2 + 1; i <= (int)ch1 - 1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
