using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            int changed = 0;

            while(true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    if(changed == 1)
                        Console.WriteLine(String.Join(" ", nums));
                    break;
                }
                else
                {
                    string[] str = command.Split();

                    switch(str[0])
                    {
                        case "Add":
                            add(nums, int.Parse(str[1]));
                            changed = 1;
                            break;

                        case "Remove":
                            remove(nums, int.Parse(str[1]));
                            changed = 1;
                            break;

                        case "RemoveAt":
                            removeat(nums, int.Parse(str[1]));
                            changed = 1;
                            break;

                        case "Insert":
                            insert(nums, int.Parse(str[1]), int.Parse(str[2]));
                            changed = 1;
                            break;

                        case "Contains":
                            Contains(nums, int.Parse(str[1]));
                            break;

                        case "PrintEven":
                            PrintEven(nums);
                            break;

                        case "PrintOdd":
                            PrintOdd(nums);
                            break;

                        case "GetSum":
                            GetSum(nums);
                            break;

                        case "Filter":
                            Filter(nums, str[1], int.Parse(str[2]));
                            break;
                    }
                }
            }
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



        static void Contains(List<int> z, int x)
        {
            if (z.Contains(x))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }



        static void PrintEven(List<int> z)
        {
            for (int i = 0; i < z.Count; i++)
            {
                if (z[i] % 2 == 0)
                {
                    Console.Write($"{z[i]} ");
                }
            }
            Console.WriteLine();
        }



        static void PrintOdd(List<int> z)
        {
            for (int i = 0; i < z.Count; i++)
            {
                if (z[i] % 2 != 0)
                {
                    Console.Write($"{z[i]} ");
                }
            }
            Console.WriteLine();
        }



        static void GetSum(List<int> z)
        {
            Console.WriteLine(z.Sum()); 
        }



        static void Filter(List<int> z, string x, int y)
        {
            switch (x)
            {
                case ">":
                    {
                        for (int i = 0; i < z.Count; i++)
                        {
                            if (z[i] > y)
                                Console.Write($"{z[i]} ");
                        }
                        Console.WriteLine();
                        break;
                    }
                    

                case ">=":
                    {
                        for (int i = 0; i < z.Count; i++)
                        {
                            if (z[i] >= y)
                                Console.Write($"{z[i]} ");
                        }
                        Console.WriteLine();
                        break;
                    }

                case "<":
                    {
                        for (int i = 0; i < z.Count; i++)
                        {
                            if (z[i] < y)
                                Console.Write($"{z[i]} ");
                        }
                        Console.WriteLine();
                        break;
                    }

                case "<=":
                    {
                        for (int i = 0; i < z.Count; i++)
                        {
                            if (z[i] <= y)
                                Console.Write($"{z[i]} ");
                        }
                        Console.WriteLine();
                        break;
                    }
            }
        }



    }
}
