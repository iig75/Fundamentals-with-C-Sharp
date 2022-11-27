using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_2___Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@|\#)([A-Za-z]{3,})(\1)(\1)([A-Za-z]{3,})(\1)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            string reverse = String.Empty;
            string endStr = String.Empty;

            foreach (Match m in matches)
            {
                string pattern2 = @"[A-Za-z]+";
                MatchCollection matches2 = Regex.Matches(m.Value, pattern2);


                for(int h=0; h<matches2.Count; h+=2)
                {
                    reverse = String.Empty;

                    for (int z = matches2[h].Length - 1; z >= 0; z--)
                    {
                        reverse += matches2[h].Value[z];
                    }

                    if(reverse == matches2[h+1].Value)
                    {
                        endStr += $"{matches2[h].Value} <=> {matches2[h+1].Value}, ";
                    }
                }


            }

            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");                
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }


            if (endStr.Length > 0)
            {
                Console.WriteLine("The mirror words are:");
                endStr = endStr.Remove(endStr.Length - 2, 1);
            }
            else
            {
                endStr = "No mirror words!";
            }

            Console.WriteLine($"{endStr}");
        }
    }
}
