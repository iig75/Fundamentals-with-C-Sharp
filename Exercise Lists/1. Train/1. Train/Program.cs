using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            int count = int.Parse(Console.ReadLine());

            while(true)
            {
                List<string> command = Console.ReadLine()
                                              .Split()
                                              .ToList();

                if (command[0] == "end")
                    break;

                if (command[0] == "Add")
                {
                    nums.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] + int.Parse(command[0]) <= count)
                        {
                            nums[i] += int.Parse(command[0]);
                            break;
                        }                            
                    }
                }

            }





       
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
