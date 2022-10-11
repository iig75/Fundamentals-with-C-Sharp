using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            for (int i = 0; i < nums.Count / 2; i++)
            {


                Console.Write($"{nums[i]+nums[nums.Count-1-i]} ");

            }

            if((nums.Count) % 2 != 0)
            {
                Console.Write($"{nums[nums.Count / 2]} ");
            }
        }
    }
}
