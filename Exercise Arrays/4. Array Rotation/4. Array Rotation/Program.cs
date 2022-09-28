using System;
using System.Linq;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oldArray = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            int n = int.Parse(Console.ReadLine());

            int[] newArray = new int[oldArray.Length];

            int[] x = new int[n];

            if (n > oldArray.Length)
                n = n - oldArray.Length;

            for (int i = 0; i <= n - 1; i++)
                x[i] = oldArray[i];

            Array.Copy(oldArray, n, newArray, 0, oldArray.Length - n);

            int j = 0;

            for (int i = oldArray.Length - n; i <= oldArray.Length - 1; i++)
            {
                newArray[i] = x[j];
                j++;
            }

            foreach (int f in newArray)
                Console.Write($"{f} ");
        }
    }
}
