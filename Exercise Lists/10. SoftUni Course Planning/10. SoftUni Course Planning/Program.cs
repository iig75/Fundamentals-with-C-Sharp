using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lessons = Console.ReadLine()
                                          .Split(", ")
                                          .ToList();

            while(true)
            {

                List<string> command = Console.ReadLine()
                                              .Split(":")
                                              .ToList();

                if (command[0] == "course start")
                    break;

                //Add
                if (command[0] == "Add")
                {
                    if (!lessons.Contains(command[1]))
                    {
                        lessons.Add(command[1]);
                    }
                }

                //Remove
                if (command[0] == "Remove")
                {
                    if (lessons.Contains(command[1]))
                    {
                        lessons.Remove(command[1]);
                    }

                    if (lessons.Contains(command[1] + "-Exercise"))
                    {
                        lessons.Remove(command[1] + "-Exercise");
                    }
                }

                //Insert
                if (command[0] == "Insert")
                {
                    if (!lessons.Contains(command[1]))
                    {
                        lessons.Insert(int.Parse(command[2]), command[1]);
                    }
                }

                //Swap
                if (command[0] == "Swap")
                {
                    if ((lessons.Contains(command[1])) && (lessons.Contains(command[2])))
                    {
                        string swap = String.Empty;
                        int i = 0;
                        int j = 0;
                        int k = 0;

                        for (i = 0; i < lessons.Count; i++)
                        {
                            if (lessons[i] == command[1])
                            {
                                break;
                            }
                        }

                        for (j = 0; j < lessons.Count; j++)
                        {
                            if (lessons[j] == command[2])
                            {
                                break;
                            }
                        }

                        swap = lessons[i];
                        lessons[i] = lessons[j];
                        lessons[j] = swap;

                        if (lessons.Contains(command[1] + "-Exercise"))
                        {
                            for (k = 0; k < lessons.Count; k++)
                            {
                                if (lessons[k] == command[1] + "-Exercise")
                                {
                                    break;
                                }
                            }

                            lessons.RemoveAt(k);

                            if(j+1>lessons.Count)
                                lessons.Add(command[1] + "-Exercise");
                            else
                                lessons.Insert(j+1, command[1] + "-Exercise");
                            
                        }

                        if (lessons.Contains(command[2] + "-Exercise"))
                        {
                            for (k = 0; k < lessons.Count; k++)
                            {
                                if (lessons[k] == command[2] + "-Exercise")
                                {
                                    break;
                                }
                            }

                            lessons.RemoveAt(k);
                            lessons.Insert(i+1, command[2] + "-Exercise");
                            
                        }

                    }
                }

                //Exercise
                if (command[0] == "Exercise")
                {
                    if((!lessons.Contains(command[1])) && (!lessons.Contains(command[1]+ "-Exercise")))
                    {
                        lessons.Add(command[1]);
                        lessons.Add(command[1]+"-Exercise");
                    }

                    if ((lessons.Contains(command[1])) && (!lessons.Contains(command[1] + "-Exercise")))
                    {
                        int i = 0;

                        for (i=0; i<lessons.Count; i++)
                        {
                            if (lessons[i] == command[1])
                            {
                                break;
                            }
                        }

                        lessons.Insert(i+1, command[1] + "-Exercise");
                    }

                }
            }



            for(int i=0; i<lessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessons[i]}");
            }



        }
    }
}
