using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1___Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder(Console.ReadLine()); 

            while(true)
            {
                List<string> command = Console.ReadLine()
                                              .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                if (command[0] == "Generate")
                    break;

                if (command[0] == "Contains")
                {
                    if(sb.ToString().Contains(command[1]))
                    {
                        Console.WriteLine($"{sb} contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                if(command[0]== "Flip")
                {
                    string subStr = sb.ToString().Substring(int.Parse(command[2]), int.Parse(command[3]) - int.Parse(command[2]));

                    if (command[1] == "Upper")
                    {
                        subStr = subStr.ToUpper();
                    }
                    else
                    {
                        subStr = subStr.ToLower();
                    }

                    sb.Remove(int.Parse(command[2]), int.Parse(command[3]) - int.Parse(command[2]));
                    sb.Insert(int.Parse(command[2]), subStr);

                    Console.WriteLine(sb);
                }

                if(command[0]== "Slice")
                {
                    sb.Remove(int.Parse(command[1]), int.Parse(command[2]) - int.Parse(command[1]));

                    Console.WriteLine(sb);
                }
            }

            Console.WriteLine($"Your activation key is: {sb}");

        }
    }
}
