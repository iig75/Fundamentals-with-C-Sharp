using System;
using System.Text.RegularExpressions;

namespace Problem_2___Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\=|\/)([A-Z][A-Za-z]{2,})(\1)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            string output = String.Empty;

            int len = 0;

            foreach(Match m in matches)
            {
                output += m.Value +", ";
                len += m.Value.Length - 2;
            }

            if(output.Length>0)
            {
                output = output.Remove(output.Length - 2, 1);
                output = output.Replace("=", "");
                output = output.Replace("/", "");
            }

            Console.WriteLine($"Destinations: {output}");
            Console.WriteLine($"Travel Points: {len}");
        }
    }
}
