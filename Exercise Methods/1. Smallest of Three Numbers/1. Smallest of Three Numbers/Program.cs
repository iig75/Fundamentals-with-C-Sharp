using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(smallNumber(n1, n2, n3));
        }

        private static int smallNumber(int n1, int n2, int n3)
        {
            int small = 0;

            if (n1 < n2)
            {
                if (n1 < n3)
                {
                    small = n1;
                }
                else
                {
                    small = n3;
                }

            }
            else
            {
                if (n2 < n3)
                {
                    small = n2;
                }
                else
                {
                    small = n3;
                }
            }

            return small;
        }
    }
}
