using System;
using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex reg = new Regex(pattern);

            if (reg.IsMatch(str))
            {
                foreach(Match match in reg.Matches(str))
                {
                    Console.Write($"{match.Value} ");
                }
            }
        }
    }
}
