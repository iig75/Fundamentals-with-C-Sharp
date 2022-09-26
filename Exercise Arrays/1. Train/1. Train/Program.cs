using System;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];

            for(int i=0; i<=n-1; i++)
                wagons[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n - 1; i++)
                Console.Write($"{wagons[i]} ");

            Console.WriteLine();
            
            Console.WriteLine(wagons.Sum());
        }
    }
}
