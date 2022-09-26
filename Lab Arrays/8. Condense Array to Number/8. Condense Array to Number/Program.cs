using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            while(true)
            {
                if (nums.Length == 1)
                    break;

                for (int i = 0; i <= nums.Length - 2; i++)
                    nums[i] = nums[i] + nums[i + 1];

                nums = nums.Take(nums.Count() - 1).ToArray();
            }

            for (int i = 0; i <= nums.Length - 1; i++)
                Console.Write($"{nums[i]} ");
        }
    }
}
