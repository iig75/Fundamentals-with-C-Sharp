using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for(int x=1; x<=n; x++)
            {
                bigInt(x);
            }
            

        }

        private static void bigInt(int z)
        {
            string str = z.ToString();

            int sum = 0;
            int flag = 0;

            for (int i = 0; i <= str.Length - 1; i++)
            {
                sum += str[i];

                if (str[i] % 2 != 0)
                {
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                sum = 0;
            }
            else
            {
                if (sum % 8 == 0)
                {
                    Console.WriteLine($"{str}");
                }
            }
        }
    }
}
