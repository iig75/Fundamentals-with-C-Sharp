using System;

namespace _4._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string res = String.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                res += ((char)((int)str[i] + 3)).ToString();
            }

            Console.WriteLine($"{res}");
        }
    }
}
