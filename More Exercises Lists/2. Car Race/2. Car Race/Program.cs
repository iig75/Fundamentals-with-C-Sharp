using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            double LSum = 0;
            double RSum = 0;

            for (int i = 0; i < nums.Count / 2; i++)
            {
                LSum += nums[i];

                if(nums[i]==0)
                {
                    LSum -= LSum * 0.2;
                }
            }

            for (int i = nums.Count-1; i > nums.Count / 2; i--)
            {
                RSum += nums[i];

                if (nums[i] == 0)
                {
                    RSum -= RSum * 0.2;
                }
            }

            if(LSum<RSum)
                Console.WriteLine($"The winner is left with total time: {LSum}");
            else
                Console.WriteLine($"The winner is right with total time: {RSum}");

        }
    }
}
