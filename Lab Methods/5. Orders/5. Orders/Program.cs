using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            int q = int.Parse(Console.ReadLine());

            Console.WriteLine($"{calc(product, q):f2}");
        }

        private static double calc(string product, int q)
        {
            double sum = 0;

            switch (product)
            {
                case "coffee":
                    sum = 1.5 * q;
                    break;

                case "water":
                    sum = 1.00 * q;
                    break;

                case "coke":
                    sum = 1.40 * q;
                    break;

                case "snacks":
                    sum = 2.00 * q;
                    break;
            }

            return sum;
        }
    }
}
