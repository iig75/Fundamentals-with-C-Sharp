using System;

namespace _1._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(checkNumber(n));

        }

        private static string checkNumber(int n)
        {
            string str="";

            if (n > 0)
            {
                str = $"The number {n} is positive.";
            }

            if (n < 0)
            {
                str = $"The number {n} is negative.";
            }

            if (n == 0)
            {
                str = $"The number {n} is zero.";
            }

            return str;
        }
    }
}
