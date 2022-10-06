using System;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(strMethod(str, n));
        }

        private static string strMethod(string str, int n)
        {
            string newStr = "";

            for (int i = 1; i <= n; i++)
            {
                newStr = string.Concat(newStr, str);
            }

            return newStr;
        }
    }
}
