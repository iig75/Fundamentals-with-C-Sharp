using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToList();

            List<int> nums2 = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToList();

            List<int> nums = new List<int>(nums1.Count+nums2.Count);

            int j = 0;
            int k = 1;

            if (nums1.Count > nums2.Count)
            {
                for (int i = 0; i < nums2.Count; i++)
                {
                    nums.Insert(j, nums1[i]);
                    nums.Insert(k, nums2[i]);
                    j += 2;
                    k += 2;
                }

                for (int i = nums2.Count * 2; i < nums1.Count + nums2.Count; i++)
                {
                    nums.Insert(i, nums1[i - nums2.Count]);
                }
            }
            else
            {
                for (int i = 0; i < nums1.Count; i++)
                {
                    nums.Insert(j, nums1[i]);
                    nums.Insert(k, nums2[i]);
                    j += 2;
                    k += 2;
                }

                for (int i = nums1.Count * 2; i < nums2.Count + nums1.Count; i++)
                {
                    nums.Insert(i, nums2[i - nums1.Count]);
                }
            }

            Console.Write(String.Join(" ", nums));
        }
    }
}
