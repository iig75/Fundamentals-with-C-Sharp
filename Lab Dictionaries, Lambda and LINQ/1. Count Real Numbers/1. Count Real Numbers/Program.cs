using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            for(int i=0; i<nums.Length; i++)
            {
                if (counts.ContainsKey(nums[i]))
                {
                    counts[nums[i]]++;
                }
                else
                {
                    counts.Add(nums[i], 1);
                }
            }

            foreach(var num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }            
        }
    }
}
