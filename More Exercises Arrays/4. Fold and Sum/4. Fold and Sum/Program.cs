using System;
using System.Linq;

namespace _4._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int quota = nums.Length / 4;

            int[] nums1 = new int[nums.Length / 2];
            int[] nums2 = new int[nums.Length / 2];

            for(int i=0; i<quota; i++)
            {
                nums1[i] = nums[quota-1-i];
            }

            for (int i = 0; i < quota; i++)
            {
                nums1[quota+i] = nums[nums.Length - 1 - i];
            }

            for (int i = quota; i < nums.Length - quota; i++)
            {
                nums2[i - quota] = nums[i];
            }

            for(int i = 0; i<nums2.Length; i++)
            {
                Console.Write($"{nums1[i] + nums2[i]} ");
            }
        }
    }
}
