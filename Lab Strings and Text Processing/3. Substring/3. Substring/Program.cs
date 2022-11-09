using System;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string ptr = Console.ReadLine();

            string inputStr = Console.ReadLine();
            
            while(inputStr.Contains(ptr))
            {
                int startIndex = inputStr.IndexOf(ptr);

                inputStr = inputStr.Remove(startIndex, ptr.Length);
            }

            Console.WriteLine($"{inputStr}");
        }
    }
}
