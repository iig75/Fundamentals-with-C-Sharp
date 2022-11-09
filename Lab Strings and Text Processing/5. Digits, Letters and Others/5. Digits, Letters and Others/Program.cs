using System;

namespace _5._Digits__Letters_and_Others
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string digits = String.Empty;
            string letters = String.Empty;
            string symbols = String.Empty;

            for (int i = 0; i < str.Length; i++)
            {

                if (Char.IsDigit(str[i]))
                {
                    digits += str[i];
                }
                else if (Char.IsLetter(str[i]))
                {
                    letters += str[i];
                }
                else
                {
                    symbols += str[i];
                }
            }

            Console.WriteLine($"{digits}");
            Console.WriteLine($"{letters}");
            Console.WriteLine($"{symbols}");
        }
    }
}
