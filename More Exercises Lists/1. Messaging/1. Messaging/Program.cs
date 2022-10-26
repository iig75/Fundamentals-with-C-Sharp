using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine()
                                    .Split()
                                    .ToList();

            string str = Console.ReadLine();
            string result = String.Empty;

            int sum = 0;

            foreach(string n in nums)
            {
                sum = 0;

                for(int i=0; i<n.Length; i++)
                {
                    sum += int.Parse(n[i].ToString());
                }

                if ((sum < str.Length) && (str.Length>0))
                {
                    result += str[sum].ToString();
                    str = str.Remove(sum, 1);
                }

                if ((sum > str.Length) && (str.Length > 0))
                {
                    sum = sum - (str.Length*(sum/str.Length));
                    result += str[sum].ToString();
                    str = str.Remove(sum, 1);

                }
            }

            Console.WriteLine(result);
        }
    }
}
