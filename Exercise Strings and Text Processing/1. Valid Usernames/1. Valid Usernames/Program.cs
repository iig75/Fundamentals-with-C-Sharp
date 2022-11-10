using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine()
                                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();

            foreach (var val in usernames)
            {
                bool err = false;

                for(int i=0; i<val.Length; i++)
                {
                    if ((!Char.IsLetter(val[i])) && (!Char.IsDigit(val[i])) && (val[i]!='_') && (val[i]!='-'))
                    {
                        err = true;
                    }
                }

                if((val.Length < 3) || (val.Length>16))
                {
                    err = true;
                }

                if(!err)
                {
                    Console.WriteLine($"{val}");
                }
            }
        }
    }
}
