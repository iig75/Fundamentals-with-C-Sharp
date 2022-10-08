using System;

namespace _2._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{CenterPoint(n1, n2, n3, n4)}");
        }

        static string CenterPoint(double x1, double x2, double x3, double x4)
        {
            string res = string.Empty;

            double max1 = 0;
            double max2 = 0;

            max1 = Math.Pow(x1, 2) + Math.Pow(x2, 2);
            max2 = Math.Pow(x3, 2) + Math.Pow(x4, 2);

            if (max1 <= max2)
            { 
                res= $"({x1}, {x2})";
            }
            else
            {
                res = $"({x3}, {x4})";
            }

            return res;
        }
    }
}
