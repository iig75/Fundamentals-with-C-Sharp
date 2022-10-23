using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Phone_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine()
                                         .Split(", ")
                                         .ToList();

            while(true)
            {
                List<string> command = Console.ReadLine()
                                              .Split(" - ")
                                              .ToList();

                if (command[0] == "End")
                    break;



                if(command[0] == "Add")
                {
                    if(!phones.Contains(command[1]))
                    {
                        phones.Add(command[1]);
                    }
                }



                if (command[0] == "Remove")
                {
                    if (phones.Contains(command[1]))
                    {
                        phones.Remove(command[1]);
                    }
                }



                if (command[0] == "Bonus phone")
                {
                    List<string> oldnew = command[1].Split(":").ToList();

                    if (phones.Contains(oldnew[0]))
                    {
                        int i = 0;

                        for (i = 0; i < phones.Count; i++)
                        {
                            if(phones[i]==oldnew[0])
                            {
                                break;
                            }
                        }

                        if (i == phones.Count-1)
                            phones.Add(oldnew[1]);
                        else
                            phones.Insert(i+1, oldnew[1]);
                    }
                }



                if (command[0] == "Last")
                {
                    if(phones.Contains(command[1]))
                    {
                        int i = 0;
                        string str = String.Empty;

                        for (i = 0; i < phones.Count; i++)
                        {
                            if (phones[i] == command[1])
                            {
                                break;
                            }
                        }

                        str = phones[i];
                        phones.Remove(command[1]);
                        phones.Add(str);
                    }
                }



            }

            Console.WriteLine(String.Join(", ", phones));
        }
    }
}
