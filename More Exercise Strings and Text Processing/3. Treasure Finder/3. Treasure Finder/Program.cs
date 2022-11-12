using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str1 = new List<string>();

            List<string> str2 = new List<string>();

            int[] keys = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            string line1 = String.Empty;
            string line2 = String.Empty;

            while(true)
            {
                line1 = Console.ReadLine();

                if (line1 == "find")
                    break;

                str1.Add(line1);
            }

            int x = 0;

            line1 = String.Empty;

            for(int h=0; h<str1.Count; h++)
            {
                line1 = str1[h];
                line2 = String.Empty;

                for (int i = 0; i < line1.Length; i++)
                {
                    line2 += ((char)((int)line1[i] - (int)keys[x])).ToString();

                    x++;

                    if (x == keys.Length)
                        x = 0;
                }

                x = 0;
                str2.Add(line2);
            }

            string name = String.Empty;
            string coor = String.Empty;

            for(int i=0; i<str2.Count; i++)
            {
                name = str2[i].Substring(str2[i].IndexOf('&')+1, str2[i].LastIndexOf('&')- str2[i].IndexOf('&')-1);
                coor = str2[i].Substring(str2[i].IndexOf('<')+1, str2[i].LastIndexOf('>') - str2[i].IndexOf('<')-1);

                Console.WriteLine($"Found {name} at {coor}");
            }
            
        }
    }
}
