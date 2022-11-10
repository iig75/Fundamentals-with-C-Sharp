using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .ToList();

            string str1 = input[0];
            string str2 = input[1];

            int sum = 0;

            if (str1.Length > str2.Length)
            {
                int dif = str1.Length - str2.Length;

                for (int i = 0; i < dif; i++)
                {
                    str2 += '!'.ToString();
                }
            }

            if (str1.Length < str2.Length)
            {
                int dif = str2.Length - str1.Length;

                for (int i = 0; i < dif; i++)
                {
                    str1 += '!'.ToString();
                }
            }

            sum = calculateSum(str1, str2);

            Console.WriteLine($"{sum}");
        }



        private static int calculateSum(string str1, string str2)
        {
            int sum=0;

            for (int i = 0; i < str1.Length; i++)
            {
                if (((int)str1[i] != 33) && ((int)str2[i] != 33))
                    sum += (int)str1[i] * (int)str2[i];

                if (((int)str1[i] == 33) && ((int)str2[i] != 33))
                    sum += 1 * (int)str2[i];

                if (((int)str1[i] != 33) && ((int)str2[i] == 33))
                    sum += (int)str1[i] * 1;
            }

            return sum;
        }
    }
}
