using System;

namespace _11._Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Math(n1, str, n2)}");
        }


        static double Math(int x, string a, int y)
        {
            double res = 0;

            switch (a)
            {
                case "*":
                    res = x * y;
                    break;

                case "/":
                    res = x / y;
                    break;

                case "+":
                    res = x + y;
                    break;

                case "-":
                    res = x - y;
                    break;
            }

            return res;
        }
    }
}
