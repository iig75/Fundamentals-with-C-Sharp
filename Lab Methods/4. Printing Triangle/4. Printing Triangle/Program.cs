using System;

namespace _4._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                triangle(i);
            }

            for (int i = n-1; i >= 1; i--)
            {
                triangle(i);
            }
        }

        private static void triangle(int b)
        {
            for (int i = 1; i <= b; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

    }
}
