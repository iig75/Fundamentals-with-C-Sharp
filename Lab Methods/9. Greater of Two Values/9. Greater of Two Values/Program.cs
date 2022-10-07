using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if (str == "int")
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"{GetMax(n1, n2)}");
            }

            if (str == "char")
            {
                char ch1 = char.Parse(Console.ReadLine());
                char ch2 = char.Parse(Console.ReadLine());

                Console.WriteLine($"{GetMax(ch1, ch2)}");
            }

            if (str == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();

                Console.WriteLine($"{GetMax(str1, str2)}");
            }
        }

        static int GetMax(int n1, int n2)
        {
            int res = 0;

            if (n1 > n2)
            {
                res = n1;
            }
            else
            {
                res = n2;
            }

            return res;
        }

        static char GetMax(char n1, char n2)
        {
            char res = '-';

            if ((int)n1 > (int)n2)
            {
                res = n1;
            }
            else
            {
                res = n2;
            }

            return res;
        }

        static string GetMax(string n1, string n2)
        {
            string res = string.Empty;

            int comp = n1.CompareTo(n2);
            if (comp > 0)
            {
                res = n1;
            }
            else
            {
                res = n2;
            }

            return res;
        }
    }
}
