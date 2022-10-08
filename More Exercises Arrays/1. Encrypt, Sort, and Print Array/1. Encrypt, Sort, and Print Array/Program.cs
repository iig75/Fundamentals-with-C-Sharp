using System;

namespace _1._Encrypt__Sort__and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] str = new string[n];

            for (int i = 0; i <= n - 1; i++)
            {
                str[i] = Console.ReadLine();
            }

            string word = "";
            char letter = '0';

            int sum = 0;

            int[] output = new int[n];
 
            for (int i = 0; i <= n - 1; i++)
            {
                word = str[i];

                for (int j = 0; j < word.Length; j++)
                {
                    if ((word[j] == 'A') || (word[j] == 'a') || (word[j] == 'E') || (word[j] == 'e') || (word[j] == 'I') || (word[j] == 'i') || (word[j] == 'O') || (word[j] == 'o') || (word[j] == 'U') || (word[j] == 'u'))
                    {
                        sum += (int)word[j] * word.Length;
                    }
                    else
                    {
                        sum += (int)word[j] / word.Length;
                    }
                }
                output[i] = sum;
                sum = 0;
            }

            Array.Sort(output);

            foreach (int i in output)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
