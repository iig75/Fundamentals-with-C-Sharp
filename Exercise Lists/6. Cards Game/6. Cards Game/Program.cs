using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cards1 = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            List<int> cards2 = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            int i = 0;

            while(true)
            {
                if(cards1[i]>cards2[i])
                {
                    cards1.Add(cards1[i]);
                    cards1.Add(cards2[i]);
                }

                if (cards2[i] > cards1[i])
                {
                    cards2.Add(cards2[i]);
                    cards2.Add(cards1[i]);
                }

                cards1[i] = 0;
                cards2[i] = 0;

                if ((cards1.Sum() == 0) || (cards2.Sum() == 0))
                {
                    break;
                }

                i++;
            }

            if (cards1.Sum() == 0)
                Console.WriteLine($"Second player wins! Sum: {cards2.Sum()}");
            else
                Console.WriteLine($"First player wins! Sum: {cards1.Sum()}");
        }
    }
}