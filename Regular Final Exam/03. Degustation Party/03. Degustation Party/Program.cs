using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Degustation_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guestBook = new Dictionary<string, List<string>>();

            int unlikeedCount = 0;

            while (true)
            {
                List<string> command = Console.ReadLine()
                                              .Split("-")
                                              .ToList();



                if (command[0] == "Stop")
                    break;
                


                if(command[0] == "Like")
                {
                    if (!guestBook.ContainsKey(command[1]))
                    {
                        guestBook.Add(command[1], new List<string>());
                        guestBook[command[1]].Add(command[2]);
                    }
                    else
                    {
                        if (!guestBook[command[1]].Contains(command[2]))
                        {
                            guestBook[command[1]].Add(command[2]);
                        }
                    }
                }



                if(command[0] == "Dislike")
                {
                    if(guestBook.ContainsKey(command[1]))
                    {
                        if (guestBook[command[1]].Contains(command[2]))
                        {
                            guestBook[command[1]].Remove(command[2]);
                            unlikeedCount++;
                            Console.WriteLine($"{command[1]} doesn't like the {command[2]}.");
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} doesn't have the {command[2]} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{command[1]} is not at the party.");
                    }

                }



            }



            foreach (var val in guestBook)
            {
                Console.Write($"{val.Key}: ");

                string output = String.Empty;

                foreach (var val1 in val.Value)
                {
                    output += String.Join(", ", val1+", ");
                }
                
                if(output.Length>0)
                {
                    output = output.Remove(output.Length - 2, 1);
                    Console.Write(output);
                }

                Console.WriteLine("");
            }

            Console.WriteLine($"Unliked meals: {unlikeedCount}");
            
        }
    }
}