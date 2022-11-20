using System;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string pattern = @"\+\b359( |-)2\1[0-9]{3}\1[0-9]{4}\b";

            Regex regex = new Regex(pattern);

            string result = String.Empty;

            if(regex.IsMatch(str))
            {
                foreach(Match match in regex.Matches(str))
                {
                    result += $"{match.Value}, ";
                }

                result = result.Remove(result.Length - 2, 2);

                Console.WriteLine(result);
            }
        }
    }
}
