using System;
using System.Text.RegularExpressions;

namespace Problem_2___Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||\#)(?<food>[A-Za-z ]+)(\1)(?<date>[0-9]{2}(\/)[0-9]{2}(\/)[0-9]{2})(\1)(?<cal>[0-9]+)(\1)";

            string input = Console.ReadLine();

            int calories = 0;

            MatchCollection mathes = Regex.Matches(input, pattern);

            foreach (Match m in mathes)
            {
                calories += int.Parse(m.Groups["cal"].Value);
            }

            Console.WriteLine($"You have food to last you for: {calories / 2000} days!");
            
            foreach (Match m in mathes)
            {
                Console.WriteLine($"Item: {m.Groups["food"].Value}, Best before: {m.Groups["date"].Value}, Nutrition: {m.Groups["cal"].Value}");
            }
        }
    }
}
