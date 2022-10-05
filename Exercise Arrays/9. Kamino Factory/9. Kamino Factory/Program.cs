using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] maxArr = new int[n];

            int count = 0;
            int max = 0;
            int index = 0;
            int sum = 0;

            int max1 = 0;
            int index1 = 0;
            int sum1 = 0;
            int sample1 = 1;
            int z = 0;

            while (true)
            {
                string str = Console.ReadLine();

                if (str == "Clone them!")
                    break;
                else
                {
                    int[] nums = str.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    for (int i = 0; i <= nums.Length - 1; i++)
                    {
                        if (nums[i] == 1)
                        {
                            count++;
                            sum++;
                        }
                        else
                        {
                            count = 0;
                        }

                        if (count > max)
                        {
                            max = count;
                            index = i + 1 - max;
                        }
                    }

                    z++;

                    if ((max == max1) && (index == index1) && (sum > sum1))
                    {
                        max1 = max;
                        sum1 = sum;
                        index1 = index;
                        sample1 = z;

                        for (int j = 0; j <= nums.Length - 1; j++)
                            maxArr[j] = nums[j];
                    }

                    if ((max == max1) && (index < index1))
                    {
                        max1 = max;
                        sum1 = sum;
                        index1 = index;
                        sample1 = z;

                        for (int j = 0; j <= nums.Length - 1; j++)
                            maxArr[j] = nums[j];
                    }

                    if (max > max1)
                    {
                        max1 = max;
                        sum1 = sum;
                        index1 = index;
                        sample1 = z;

                        for (int j = 0; j <= nums.Length - 1; j++)
                            maxArr[j] = nums[j];
                    }

                    sum = 0;
                    max = 0;
                    index = 0;
                    count = 0;

                }

            }

            Console.WriteLine($"Best DNA sample {sample1} with sum: {sum1}.");

            for (int h = 0; h <= maxArr.Length - 1; h++)
                Console.Write($"{maxArr[h]} ");
        }
    }
}
