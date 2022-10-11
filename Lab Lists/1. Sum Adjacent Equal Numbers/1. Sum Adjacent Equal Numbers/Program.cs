using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine()
                                    .Split(" ")
                                    .Select(double.Parse)
                                    .ToList();

            int flag = 0;

            while (true)
            {
                flag = 0;

                for (int i = 0; i < nums.Count - 1; i++)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        nums[i] += nums[i + 1];
                        nums.RemoveAt(i + 1);
                        flag = 1;
                    }
                }

                if (flag == 0)
                {
                    break;
                }
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}