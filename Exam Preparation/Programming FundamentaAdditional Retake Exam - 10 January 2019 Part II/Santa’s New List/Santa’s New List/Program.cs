using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_New_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Names = new Dictionary<string, int>();
            Dictionary<string, int> Toys = new Dictionary<string, int>();

            while(true)
            {

                List<string> command = Console.ReadLine()
                                              .Split("->", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                if (command[0] == "END")
                    break;



                if(command[0] == "Remove")
                {
                    if (Names.ContainsKey(command[1]))
                    {
                        Names.Remove(command[1]);
                    }
                }
                


                if((command[0]!="END") && (command[0]!="Remove"))
                {
                    if(Names.ContainsKey(command[0]))
                    {
                        Names[command[0]] += int.Parse(command[2]);

                        if(Toys.ContainsKey(command[1]))
                        {
                            Toys[command[1]] += int.Parse(command[2]);
                        }
                        else
                        {
                            Toys.Add(command[1], int.Parse(command[2]));
                        }
                    }
                    else
                    {
                        Names.Add(command[0], int.Parse(command[2]));

                        if (Toys.ContainsKey(command[1]))
                        {
                            Toys[command[1]] += int.Parse(command[2]);
                        }
                        else
                        {
                            Toys.Add(command[1], int.Parse(command[2]));
                        }
                    }

                }

            }



            Console.WriteLine("Children:");

            foreach(var val in Names.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{val.Key} -> {val.Value}");
            }



            Console.WriteLine("Presents:");

            foreach (var val in Toys)
            {
                Console.WriteLine($"{val.Key} -> {val.Value}");
            }



        }
    }
}
