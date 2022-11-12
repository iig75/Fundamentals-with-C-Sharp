using System;

namespace _7._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();   // abv>1>1>2>2asdasd

            string res = String.Empty;

            int bomb = 0;

            for(int i=0; i<str.Length; i++)
            {
                if(str[i]=='>')
                {
                    bomb += int.Parse(str[i+1].ToString());
                }

                if ((bomb > 0) && (str[i] != '>'))
                {
                    str = str.Remove(i, 1);
                    bomb--;
                    i--;
                }
            }

            Console.WriteLine(str);
        }
    }
}
