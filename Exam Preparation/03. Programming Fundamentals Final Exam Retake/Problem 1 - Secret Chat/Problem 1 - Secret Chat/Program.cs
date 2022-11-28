using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_1___Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while(true)
            {
                List<string> command = Console.ReadLine()
                                              .Split(":|:", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                if (command[0] == "Reveal")
                    break;

                if (command[0] == "InsertSpace")
                {
                    message = message.Insert(int.Parse(command[1]), " ");

                    Console.WriteLine(message);
                }

                if (command[0] == "Reverse")
                {
                    if(message.Contains(command[1]))
                    {
                        string reverse = String.Empty;

                        var regex = new Regex(Regex.Escape(command[1]));
                        message = regex.Replace(message, "", 1);

                        for (int i = command[1].Length - 1; i >= 0; i--)
                            reverse += command[1][i].ToString();

                        message = message + reverse;

                        Console.WriteLine(message);
                    }
                    else
                        Console.WriteLine("error");
                }

                if (command[0] == "ChangeAll")
                {
                    message = message.Replace(command[1], command[2]);

                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
