using System;
using System.Linq;

namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            int sum1 = 0;
            int sum2 = 0;
            int endResult = -99;

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                sum1 = 0;
                sum2 = 0;

                for (int k1 = 0; k1 < i; k1++)
                {
                    if (i == 0)
                        sum1 = 0;
                    else
                        sum1 += nums[k1];
                }

                for (int k2 = i + 1; k2 <= nums.Length - 1; k2++)
                {
                    if (i == nums.Length)
                        sum2 = 0;
                    else
                        sum2 += nums[k2];
                }

                if (sum1 == sum2)
                {
                    endResult = i;
                    break;
                }

            }

            if (endResult != -99)
                Console.WriteLine($"{endResult}");

            if (endResult == -99)
                Console.WriteLine($"no");
            
        }
    }
}
