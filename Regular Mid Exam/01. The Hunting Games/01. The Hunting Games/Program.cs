using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        { 
            int N = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            decimal groupsEnergy = decimal.Parse(Console.ReadLine());
            decimal waterPerDay = decimal.Parse(Console.ReadLine());
            decimal foodPerDay = decimal.Parse(Console.ReadLine());

            decimal totalWater = N * numberOfPlayers * waterPerDay;
            decimal totalFood = N * numberOfPlayers * foodPerDay;
            decimal totalEnergy = groupsEnergy;

            for(int i=1; i<=N; i++)
            {
                decimal energyLost = decimal.Parse(Console.ReadLine());

                totalEnergy -= energyLost;

                if (totalEnergy <= 0.00m)
                    break;


                if (i % 2 == 0)
                {
                    totalWater -= totalWater * 0.3m;
                    totalEnergy += totalEnergy * 0.05m;
                }

                if (i % 3 == 0)
                {
                    totalFood -= totalFood / numberOfPlayers;
                    totalEnergy += totalEnergy * 0.1m;
                }

            }

            if (totalEnergy>0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {totalEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
            }

        }
    }
}
