using System;

namespace _2._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            string randomString = Console.ReadLine();

            int start = Math.Min(input1, input2);
            int stop = Math.Max(input1, input2);

            int sum = 0;

            for (int i=0; i<randomString.Length; i++)
            {
                if(((int)randomString[i] > start) && ((int)randomString[i] < stop))
                {
                    sum += (int)randomString[i];
                }
            }

            Console.WriteLine($"{sum}");
        }
    }
}
