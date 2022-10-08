using System;

namespace _3._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double line1 = 0;
            double line2 = 0;

            line1 = GetLineLength(x1, y1, x2, y2);
            line2 = GetLineLength(x3, y3, x4, y4);

            if(line1>line2)
            {
                double point1 = GetDistanse(x1, y1);
                double point2 = GetDistanse(x2, y2);

                if(point1 <= point2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }

            }
            else
            {
                double point3 = GetDistanse(x3, y3);
                double point4 = GetDistanse(x4, y4);

                if (point3 <= point4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }



        static double GetLineLength(double a1, double b1, double a2, double b2)
        {
            double res = 0;

            res = Math.Sqrt(Math.Pow(a2-a1, 2) + Math.Pow(b2 - b1, 2));

            return res;
        }



        static double GetDistanse(double a1, double b1)
        {
            double res = 0;

            res = Math.Sqrt(Math.Pow((a1), 2) + Math.Pow((b1), 2));

            return res;
        }

    }
}
