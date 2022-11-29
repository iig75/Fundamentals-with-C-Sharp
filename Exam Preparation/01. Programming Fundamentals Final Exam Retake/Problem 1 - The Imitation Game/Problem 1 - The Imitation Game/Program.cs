using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1___The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while(true)
            {
                List<string> command = Console.ReadLine()
                                              .Split("|", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                if (command[0] == "Decode")
                    break;



                if (command[0] == "Move")
                {
                    if ((int.Parse(command[1]) >= 0) && (int.Parse(command[1]) < input.Length))
                    {
                        string substr = input.Substring(0, int.Parse(command[1]));
                        input = input.Remove(0, substr.Length);
                        input = input + substr;                        
                    }
                }



                if (command[0] == "Insert")
                {
                    if ((int.Parse(command[1]) >= 0) && (int.Parse(command[1]) < input.Length))
                    {
                        input = input.Insert(int.Parse(command[1]), command[2]);
                    }
                    else
                    {
                        input = input + command[2];
                    }
                }



                if (command[0] == "ChangeAll")
                {
                    if((input.Contains(command[1])) && (command[1] != command[2]))
                    {
                        input = input.Replace(command[1], command[2]);
                    }
                }

            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
