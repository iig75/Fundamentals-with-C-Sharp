using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine()  /*A12b s17G*/
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            double sum = 0;

            foreach(var val in input)
            {
                sum += calcLetters(val);
            }

            Console.WriteLine($"{sum:f2}");

        }


        private static double calcLetters(string str)
        {
            string concat = str.Substring(1, str.Length-2);

            double digit = double.Parse(concat);

            double sum1 = 0;
            double sum2 = 0;

            if (char.IsUpper(str[0]))
            {
                sum1 = digit / ((double)char.ToUpper(str[0]) - 64);
            }
            else
            {
                sum1 = digit * ((double)char.ToUpper(str[0]) - 64);
            }

            if (char.IsUpper(str[str.Length-1]))
            {
                sum2 = sum1 - ((double)char.ToUpper(str[str.Length-1]) - 64);
            }
            else
            {
                sum2 = sum1 + ((double)char.ToUpper(str[str.Length-1]) - 64);
            }

            return sum2;
        }
    }
}
