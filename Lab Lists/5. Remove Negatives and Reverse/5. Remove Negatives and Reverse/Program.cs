using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            int flag = 0;

            while(true)
            {
                flag = 0;

                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] < 0)
                    {
                        nums.RemoveAt(i);
                        flag = 1;
                    }
                }

                if (flag == 0)
                    break;
            }

            nums.Reverse();

            if (nums.Count == 0)
                Console.WriteLine("empty");
            else
                Console.Write(String.Join(" ", nums));
        }
    }
}
