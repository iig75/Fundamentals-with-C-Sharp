using System;

namespace _6._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = String.Empty;

            str2 += str1[0];
            int h = 0;

            for (int i = 1; i < str1.Length; i++)
            {
                if (str1[i] != str2[h])
                {
                    str2 += str1[i];
                    h++;
                }
            }

            Console.WriteLine($"{str2}");
        }
    }
}