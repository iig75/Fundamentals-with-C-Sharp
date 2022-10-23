using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine()
                                          .Split()
                                          .ToList();

            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {

                List<string> command = Console.ReadLine()
                                              .Split()
                                              .ToList();

                if(command[0] == "Include")
                {
                    coffees.Add(command[1]);
                }



                if (command[0] == "Remove")
                {
                    if (int.Parse(command[2]) <= coffees.Count)
                    {
                        if (command[1] == "first")
                        {
                            for (int j = 0; j < int.Parse(command[2]); j++)
                            {
                                coffees.RemoveAt(0);
                            }
                        }

                        if (command[1] == "last")
                        {
                            for (int j = 0; j < int.Parse(command[2]); j++)
                            {
                                coffees.RemoveAt(coffees.Count-1);
                            }
                        }
                    }
                }



                if (command[0] == "Prefer")
                {
                    if((int.Parse(command[1])>=0)&&(int.Parse(command[1])<=coffees.Count)&& (int.Parse(command[2]) >= 0) && (int.Parse(command[2]) <= coffees.Count))
                    {
                        string str = String.Empty;

                        str = coffees[int.Parse(command[1])];
                        coffees[int.Parse(command[1])] = coffees[int.Parse(command[2])];
                        coffees[int.Parse(command[2])] = str;
                    }
                }



                if (command[0] == "Reverse")
                {
                    coffees.Reverse();
                }



            }



            Console.WriteLine("Coffees:");
            Console.WriteLine(String.Join(" ", coffees));



        }
    }
}
