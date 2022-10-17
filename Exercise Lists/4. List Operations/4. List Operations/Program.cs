using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            while(true)
            {
                List<string> command = Console.ReadLine()
                                              .Split()
                                              .ToList();

                if (command[0] == "End")
                    break;

                switch (command[0])
                {
                    case "Add":
                        add(nums, int.Parse(command[1]));
                        break;

                    case "Insert":
                        insert(nums, int.Parse(command[1]), int.Parse(command[2]));
                        break;

                    case "Remove":
                        remove(nums, int.Parse(command[1]));
                        break;

                    case "Shift":
                        shift(nums, command[1], int.Parse(command[2]));
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", nums));
        }



        static void shift(List<int> a, string b, int c)
        {
            int z = 0;

            if(b == "left")
            {
                for(int i=1; i<=c; i++)
                {
                    z = a[0];
                    a.RemoveAt(0);
                    a.Add(z);
                }
            }

            if (b == "right")
            {
                for (int i = 1; i <= c; i++)
                {
                    z = a[a.Count-1];
                    a.RemoveAt(a.Count-1);
                    a.Insert(0, z);
                }
            }
        }



        static void add(List<int> a, int b)
        {
            a.Add(b);
        }



        static void insert(List<int> a, int b, int c)
        {
            if((c >= a.Count) || (c < 0))
                Console.WriteLine("Invalid index");
            else
                a.Insert(c, b);
        }



        static void remove(List<int> a, int b)
        {
            if ((b >= a.Count) || (b < 0))
                Console.WriteLine("Invalid index");
            else
                a.RemoveAt(b);
        }
    }
}
