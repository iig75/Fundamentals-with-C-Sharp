using System;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Console.WriteLine(check(str));
        }

        private static int check(string str)
        {
            int sum = 0;

            for (int j = 0; j <= str.Length - 1; j++)
            {
                if ((str[j] == 'A') || (str[j] == 'a') || (str[j] == 'E') || (str[j] == 'e') || (str[j] == 'I') || (str[j] == 'i') || (str[j] == 'O') || (str[j] == 'o') || (str[j] == 'U') || (str[j] == 'u'))
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}
