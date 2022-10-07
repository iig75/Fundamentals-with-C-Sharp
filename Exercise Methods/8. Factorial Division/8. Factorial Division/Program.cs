using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            double res1 = factorial(n1);
            double res2 = factorial(n2);

            Console.WriteLine($"{(res1 / res2):f2}");
        }

        private static double factorial(int n1)
        {
            double res = 1;

            for (int i = n1 - 1; i >= 1; i--)
            {
                res += res * i;
            }

            return res;
        }
    }
}








