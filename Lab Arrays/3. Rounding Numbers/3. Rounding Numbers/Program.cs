using System;

namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            double[] numbers = Array.ConvertAll(str.Split(), Double.Parse);

            foreach (double v in numbers)
                Console.WriteLine($"{v} => {(int)Math.Round(v, MidpointRounding.AwayFromZero)}");
        }
    }
}
