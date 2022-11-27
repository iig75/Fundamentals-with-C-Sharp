using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1___Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());

            string str = input;


            while (true)
            {
                List<string> command = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();                

                if (command[0] == "Done")
                    break;



                if (command[0] == "TakeOdd")
                {
                    string oddPass = String.Empty;

                    for (int i=1; i<str.Length; i+=2)
                    {
                        oddPass += str[i];
                    }

                    str = oddPass;
                    Console.WriteLine(str);
                }



                if (command[0] == "Cut")
                {
                    str = str.Remove(int.Parse(command[1]), int.Parse(command[2]));

                    Console.WriteLine(str);                    
                }



                if (command[0] == "Substitute")
                {

                    if (str.Contains(command[1]))
                    {
                        str = str.Replace(command[1], command[2]);
                        Console.WriteLine(str);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                }
            }



            Console.WriteLine($"Your password is: {str}");
        }
    }
}
