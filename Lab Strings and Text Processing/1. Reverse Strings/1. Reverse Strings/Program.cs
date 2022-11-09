using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            List<string> revWords = new List<string>();

            while (true)
            {
                string str = Console.ReadLine();
                string revStr = String.Empty;

                if (str == "end")
                    break;

                words.Add(str);

                for(int i=str.Length; i>0; i--)
                {
                    revStr += str[i-1];
                }

                revWords.Add(revStr);
            }

            for(int i=0; i<words.Count; i++)
            {
                Console.WriteLine($"{words[i]} = {revWords[i]}");
            }

        }
    }
}
