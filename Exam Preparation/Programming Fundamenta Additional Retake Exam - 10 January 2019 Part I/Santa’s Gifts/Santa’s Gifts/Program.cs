using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> input = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            int step = 0;

            for(int i=1; i<=n; i++)
            {
                List<string> command = Console.ReadLine()
                                              .Split()
                                              .ToList();

                if(command[0]== "Forward")
                {
                    if ((int.Parse(command[1]) >= 0) && (int.Parse(command[1])<input.Count) && (step + int.Parse(command[1]) < input.Count))
                    {
                        step += int.Parse(command[1]);
                        input.RemoveAt(step);
                    }
                }



                if (command[0] == "Back")
                {
                    if ((int.Parse(command[1]) >= 0) && (int.Parse(command[1]) < input.Count) && (step-int.Parse(command[1])>=0))
                    {
                        step -= int.Parse(command[1]);
                        input.RemoveAt(step);
                    }
                }



                if (command[0] == "Gift")
                {
                    if (((int.Parse(command[1]) >= 0) && (int.Parse(command[1]) < input.Count)))
                    {
                        step = int.Parse(command[1]);
                        input.Insert(step, int.Parse(command[2]));
                    }
                }



                if (command[0] == "Swap")
                {
                    int index1 = input.IndexOf(int.Parse(command[1]));
                    int index2 = input.IndexOf(int.Parse(command[2]));

                    if ((index1 > -1) && (index2 > -1))
                    {
                        input.RemoveAt(index1);
                        input.Insert(index1, int.Parse(command[2]));

                        input.RemoveAt(index2);
                        input.Insert(index2, int.Parse(command[1]));
                    }
                }



            }

            Console.WriteLine($"Position: {step}");

            Console.WriteLine(String.Join(", ", input));
        }
    }
}
