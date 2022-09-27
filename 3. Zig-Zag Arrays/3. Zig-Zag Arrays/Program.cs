using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];
            int[] nums1 = new int[n];
            int[] nums2 = new int[n];

            int j = 0;

            foreach(int z in nums)
            {                
                nums = Console.ReadLine()
                              .Split()
                              .Select(int.Parse)
                              .ToArray();

                if (j % 2 != 0)
                {
                    nums1[j] = nums[z+1];
                    nums2[j] = nums[z];
                }
                else
                {
                    nums1[j] = nums[z];
                    nums2[j] = nums[z+1];
                }

                j++;
            }
            
            foreach(int x in nums1)
               Console.Write($"{x} ");

            Console.WriteLine();

            foreach (int x in nums2)
                Console.Write($"{x} ");
        }
    }
}
