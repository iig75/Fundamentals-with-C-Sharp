using System;

namespace _5._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            PosNeg(nums);

        }

        private static void PosNeg(int[] nums)
        {
            int count = 0;
            int zero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                    count++;

                if (nums[i] == 0)
                {
                    zero = 1;
                    break;
                }
                    
            }

            if ((count % 2 == 0) && (zero == 0))
            {
                Console.WriteLine("positive");
            }

            if ((count % 2 != 0) && (zero == 0))
            {
                Console.WriteLine("negative");
            }

            if (zero == 1)
            {
                Console.WriteLine("zero");
            }
        }
    }
}
