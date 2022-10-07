using System;

namespace _4._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int strLen = 0;
            int digitSum = 0;
            int alphaDigit = 0;

            strLen = method1(str);

            alphaDigit = method2(str);

            digitSum = method3(str);

            if ((strLen == 1) && (digitSum >= 2) && (str.Length == alphaDigit))
            {
                Console.WriteLine($"Password is valid");
            }

        }

        private static int method3(string str)
        {
            int digitSum = 0;

            foreach (char ch in str)
            {
                if (Char.IsDigit(ch))
                {
                    digitSum++;
                }
            }

            if (digitSum < 2)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }

            return digitSum;
        }

        private static int method2(string str)
        {
            int alphaDigit = 0;

            foreach (char ch in str)
            {
                if ((Char.IsDigit(ch)) || (Char.IsLetter(ch)))
                {
                    alphaDigit++;
                }
            }

            if (str.Length != alphaDigit)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }

            return alphaDigit;
        }

        private static int method1(string str)
        {
            int strLen = 0;

            if ((str.Length >= 6) && (str.Length <= 10))
            {
                strLen = 1;
            }
            else
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }

            return strLen;
        }
    }
}
