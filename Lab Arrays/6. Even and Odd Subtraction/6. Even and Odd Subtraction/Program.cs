using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int sumOdd = 0;
            int sumEven = 0;

            for(int i=0; i<=numbers.Length-1; i++)
            {
                if (numbers[i] % 2 == 0)
                    sumEven += numbers[i];
                else
                    sumOdd += numbers[i];
            }

            Console.WriteLine($"{sumEven-sumOdd}");
        }
    }
}
