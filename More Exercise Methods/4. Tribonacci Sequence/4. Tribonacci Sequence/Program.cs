using System;

namespace _4._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            tribonachi(n);
        }

        private static void tribonachi(int n)
        {
            int[] nums = new int[n];

            if (nums.Length >= 1)
            {
                nums[0] = 1;
            }

            if (nums.Length >= 2)
            {
                nums[0] = 1;
                nums[1] = 1;
            }

            if (nums.Length >= 3)
            {
                nums[0] = 1;
                nums[1] = 1;
                nums[2] = 2;
            }

            if (nums.Length >= 4)
            {
                for (int i = 3; i < nums.Length; i++)
                {
                    nums[i] = nums[i - 3] + nums[i - 2] + nums[i - 1];
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
