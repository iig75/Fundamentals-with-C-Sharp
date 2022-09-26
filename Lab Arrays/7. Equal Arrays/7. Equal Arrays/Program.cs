using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            int[] nums2 = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            int sum = 0;
            int err = -1;

            for (int i = 0; i <= nums1.Length - 1; i++)
            {
                if (nums1[i] == nums2[i])
                    sum += nums1[i];
                else
                {
                    err = i;
                    break;
                }                    
            }

            if(err<0)
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            else
                Console.WriteLine($"Arrays are not identical. Found difference at {err} index");
        }
    }
}
