using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int x = 0;

            for (int i=0; i<= nums.Length-1; i++)
            {
                for(int j=i+1; j<=nums.Length-1; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        x = 1;
                    }
                    else
                    {
                        x = 0;
                        break;
                    }
                }

                if (x == 1)
                {
                    x = 0;
                    Console.Write($"{nums[i]} ");                    
                }
            }

            Console.Write($"{nums[nums.Length - 1]} ");
        }
    }
}
