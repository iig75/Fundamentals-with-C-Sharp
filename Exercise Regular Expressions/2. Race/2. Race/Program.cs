using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            Dictionary<string, int> scoreList = new Dictionary<string, int>();

            foreach(var val in names)
            {
                scoreList.Add(val, 0);
            }

            string pattern1 = @"[A-Za-z]+";
            string pattern2 = @"[0-9]+";

            Regex regexName = new Regex(pattern1);
            Regex regexMiles = new Regex(pattern2);

            while (true)
            {
                string name = String.Empty;
                string distance = String.Empty;
                int miles = 0;

                string str = Console.ReadLine();

                if (str == "end of race")
                    break;

                if (regexName.IsMatch(pattern1))
                {
                    foreach (Match val in regexName.Matches(str))
                    {
                        name += val.Value;
                    }
                }

                if (regexMiles.IsMatch(pattern2))
                {
                    foreach (Match val in regexMiles.Matches(str))
                    {
                        distance += val.Value;
                    }
                }


                for (int i = 0; i < distance.Length; i++)
                {
                    miles += int.Parse(distance[i].ToString());
                }


                if (scoreList.ContainsKey(name))
                {
                    scoreList[name] += miles;
                }
            }


            int x = 1;
            foreach(var val in scoreList.OrderByDescending(x=>x.Value))
            {
                if (x > 3)
                    break;

                switch(x)
                {
                    case 1:
                        Console.WriteLine($"1st place: {val.Key}");
                        break;

                    case 2:
                        Console.WriteLine($"2nd place: {val.Key}");
                        break;

                    case 3:
                        Console.WriteLine($"3rd place: {val.Key}");
                        break;
                }

                x++;
            }

        }
    }
}
