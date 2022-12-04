using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {

            string magic = Console.ReadLine();


            while(true)
            {
                List<string> command = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                if (command[0] == "Abracadabra")
                    break;



                if(command[0] == "Abjuration")
                {
                    magic = magic.ToUpper();

                    Console.WriteLine(magic);
                }



                if (command[0] == "Necromancy")
                {
                    magic = magic.ToLower();

                    Console.WriteLine(magic);
                }



                if (command[0] == "Illusion")
                {
                    if((int.Parse(command[1])<0) || (int.Parse(command[1])>=magic.Length))
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                    else
                    {
                        magic = magic.Remove(int.Parse(command[1]), 1);
                        magic = magic.Insert(int.Parse(command[1]), command[2]);

                        Console.WriteLine("Done!");
                    }
                }



                if (command[0] == "Divination")
                {
                    if (magic.Contains(command[1]))
                    {
                        magic = magic.Replace(command[1], command[2]);
                      
                        Console.WriteLine(magic);
                    }
                }



                if (command[0] == "Alteration")
                {
                    if (magic.Contains(command[1]))
                    {
                        int index = magic.IndexOf(command[1]);
                       
                        magic = magic.Remove(index, command[1].Length);

                        Console.WriteLine(magic);
                    }
                }



                if ((command[0] != "Abjuration") && (command[0] != "Necromancy") && (command[0] != "Illusion") && (command[0] != "Divination") && (command[0] != "Alteration"))
                {
                    Console.WriteLine("The spell did not work!");
                }


            }



        }
    }
}
