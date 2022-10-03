using System;
using System.Linq;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine()
                              .Split()
                              .Select(int.Parse)
                              .ToArray();

            int count = 1;
            int max = 0;
            int n = 0;

            for (int i = 0; i <= nums.Length - 2; i++)
            {

                if (i < nums.Length - 1)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        count += 1;

                        if (count > max)
                        {
                            max = count;
                            n = nums[i];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }

                if (i == nums.Length - 1)
                {
                    if (nums[i - 1] == nums[i])
                    {
                        count += 1;

                        if (count > max)
                        {
                            max = count;
                            n = nums[i];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }

            }

            for (int i = 0; i < max; i++)
                Console.Write($"{n} ");

        }
    }
}
