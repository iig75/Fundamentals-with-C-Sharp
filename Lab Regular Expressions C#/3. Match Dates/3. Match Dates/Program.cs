using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string pattern = @"(?<day>\d{2})(/|.|-)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            Regex regex = new Regex(pattern);

            if(regex.IsMatch(str))
            {
                foreach (Match date in regex.Matches(str))
                {
                    string day = date.Groups["day"].Value;
                    string month = date.Groups["month"].Value;
                    string year = date.Groups["year"].Value;

                    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
                }
            }
        }
    }
}
