using System;
using System.Numerics;

namespace _8._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine(mathPower(n1, n2));
        }

        private static double mathPower(double n1, double n2)
        {
            double res = 1;

            res = Math.Pow(n1, n2);

            return res;
        }
    }
}
