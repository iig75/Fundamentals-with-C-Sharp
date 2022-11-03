using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> res = new Dictionary<string, int>();

            int i = 0;
            
            string key = String.Empty;

            while (true)
            {
                i++;

                string str = Console.ReadLine();

                if (str == "stop")
                    break;

                if (i % 2 != 0)
                {
                    key = str;

                    if (!res.ContainsKey(str))
                    {
                        res.Add(str, 0);                        
                    }
                }
                else
                {
                    res[key] += int.Parse(str);
                }
            }

            foreach (var val in res)
            {
                Console.WriteLine($"{val.Key} -> {val.Value}");
            }
        }
    }
}
