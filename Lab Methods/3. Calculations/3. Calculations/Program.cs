using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int k = int.Parse(Console.ReadLine());

            int l = int.Parse(Console.ReadLine());

            switch (str)
            {
                case "add":
                    add(k, l);
                    break;

                case "multiply":
                    multiply(k, l);
                    break;

                case "subtract":
                    subtract(k, l);
                    break;

                case "divide":
                    divide(k, l);
                    break;
            }

        }

        private static void add(int k, int l)
        {
            int result = k + l;
            Console.WriteLine(result);
        }

        private static void multiply(int k, int l)
        {
            int result = k * l;
            Console.WriteLine(result);
        }

        private static void subtract(int k, int l)
        {
            int result = k - l;
            Console.WriteLine(result);
        }

        private static void divide(int k, int l)
        {
            int result = k / l;
            Console.WriteLine(result);
        }



    }
}
