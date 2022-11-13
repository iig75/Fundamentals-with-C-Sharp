using System;

namespace _5._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();

            string str2 = Console.ReadLine();

            if((int.Parse(str2)==0) || (str1=="0"))
            {
                Console.WriteLine("0");
                return;
            }

            string a = "0";
            string b = "0";
            string result = String.Empty;

            for(int i=str1.Length-1; i>=0; i--)
            {

                a = (int.Parse(str1[i].ToString()) * (int.Parse(str2)) + int.Parse(b)).ToString();

                b = (int.Parse(a) / 10).ToString();
                a = (int.Parse(a) % 10).ToString();

                result = result.Insert(0, a);
            }

            if (int.Parse(b) > 0)
                result = result.Insert(0, b);

            Console.WriteLine(result = result.TrimStart('0'));
        }
    }
}
