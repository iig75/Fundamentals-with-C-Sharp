using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\|\$\%\.]*?\%(?<name>[A-Z][a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<quantity>\d+)\|[^\|\$\%\.]*?(?<price>\d+(.\d+)?)\$[^\|\$\%\.]*?$";

            string str = String.Empty;

            double totalIncome = 0;

            Regex regex = new Regex(pattern);

            while(true)
            {
                str = Console.ReadLine();

                if (str == "end of shift")
                    break;

                if(regex.IsMatch(str))
                {
                    foreach(Match match in regex.Matches(str))
                    {
                        Console.WriteLine($"{match.Groups["name"].Value}: {match.Groups["product"].Value} - {(double.Parse(match.Groups["quantity"].Value) * double.Parse(match.Groups["price"].Value)):f2}");

                        totalIncome += (double.Parse(match.Groups["quantity"].Value) * double.Parse(match.Groups["price"].Value));
                    }
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
