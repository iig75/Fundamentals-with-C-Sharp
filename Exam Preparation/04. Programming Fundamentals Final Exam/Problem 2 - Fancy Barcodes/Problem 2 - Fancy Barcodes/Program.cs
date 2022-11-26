using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_2___Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"\@\#+([A-Z])([A-Za-z0-9]{4,})([A-Z])\@\#+";

            for(int i=1; i<=n; i++)
            {
                string str = Console.ReadLine();

                Regex regex = new Regex(pattern);
                
                if(regex.IsMatch(str))
                {
                    string group = String.Empty;

                    for (int h = 0; h < str.Length; h++)
                    {
                        if (Char.IsDigit(str[h]))
                        {
                            group += str[h].ToString();
                        }
                    }

                    if (group == "")
                        group = "00";

                    Console.WriteLine($"Product group: {group}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
