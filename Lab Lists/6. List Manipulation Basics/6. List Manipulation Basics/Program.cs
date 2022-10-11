using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                    break;

                string[] str = new string[3];

                str = command.Split();

                if (str[0] == "Add")
                    add(nums, int.Parse(str[1]));


                if (str[0] == "Remove")
                    remove(nums, int.Parse(str[1]));

                if (str[0] == "RemoveAt")
                    removeat(nums, int.Parse(str[1]));

                if (str[0] == "Insert")
                    insert(nums, int.Parse(str[1]), int.Parse(str[2]));

            }

            Console.Write(String.Join(" ", nums));
        }



        static void add(List<int> z, int x)
        {
            z.Add(x);
        }



        static void remove(List<int> z, int x)
        {
            z.Remove(x);
        }



        static void removeat(List<int> z, int x)
        {
            z.RemoveAt(x);
        }



        static void insert(List<int> z, int x, int y)
        {
            z.Insert(y, x);
        }



    }
}
