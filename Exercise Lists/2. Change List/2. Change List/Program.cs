using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            while (true)
            {
                List<string> command = Console.ReadLine()
                                              .Split()
                                              .ToList();

                if (command[0] == "end")
                    break;

                if(command[0] == "Delete")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i]==int.Parse(command[1]))
                        {
                            nums.Remove(int.Parse(command[1]));
                            i--;
                        }
                    }
                }

                if(command[0] == "Insert")
                {
                    nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
