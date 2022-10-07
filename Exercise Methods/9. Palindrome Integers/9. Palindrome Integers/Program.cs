using System;

namespace _9._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                string x = Console.ReadLine();

                if (x == "END")
                {
                    break;
                }
                else
                {
                    palindrome(x);
                }
            }
        }

        private static void palindrome(string str)
        {
            string str1 = "";
            string str2 = "";

            if ((str.Length) % 2 == 0)
            {
                for (int i = 0; i <= (str.Length / 2) - 1; i++)
                {
                    str1 += str[i];
                }

                for (int i = str.Length - 1; i >= str.Length / 2; i--)
                {
                    str2 += str[i];
                }

                int i1 = int.Parse(str1);
                int i2 = int.Parse(str2);

                if (i1 == i2)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                if (str.Length > 2)
                {
                    for (int i = 0; i <= (str.Length / 2) - 1; i++)
                    {
                        str1 += str[i];
                    }

                    for (int i = str.Length - 1; i >= (str.Length / 2) + 1; i--)
                    {
                        str2 += str[i];
                    }

                    int i1 = int.Parse(str1);
                    int i2 = int.Parse(str2);

                    if (i1 == i2)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                else
                {
                    Console.WriteLine("true");
                }

            }
        }
    }
}
