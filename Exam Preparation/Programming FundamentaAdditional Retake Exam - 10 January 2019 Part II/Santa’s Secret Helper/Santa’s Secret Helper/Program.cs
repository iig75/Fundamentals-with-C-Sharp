using System;
using System.Text.RegularExpressions;

namespace Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"@(?<name>[A-Za-z]+)([^@\-!:>]*!)(?<pos>[G])(!)";

            while (true)
            {
                string str = Console.ReadLine();
                string str1 = String.Empty;

                if (str == "end")
                    break;

                for (int h = 0; h < str.Length; h++)
                {
                     str1 += ((char)((int)str[h] - n)).ToString();
                }

                Regex regex = new Regex(pattern);

                if(regex.IsMatch(str1))
                {
                    Console.WriteLine($"{regex.Match(str1).Groups["name"].Value}");
                }
            }
        }
    }
}
