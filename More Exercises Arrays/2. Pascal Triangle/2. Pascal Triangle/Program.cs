using System;

namespace _2._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                for(int j=0; j<=i; j++)
                {

                    if ((i==j) || (j == 0) || (j == arr1.Length-1))
                    {
                        arr2[j] = 1;
                        arr1[j] = 1;
                    }
                    else
                    {
                        arr2[j] = arr1[j-1] + arr1[j];
                    }

                    Console.Write($"{arr2[j]} ");
                }

                for (int h = 0; h < arr1.Length; h++)
                {
                    arr1[h] = arr2[h];
                    arr2[h] = 0;
                }

                Console.WriteLine();
            }
        }
    }
}
