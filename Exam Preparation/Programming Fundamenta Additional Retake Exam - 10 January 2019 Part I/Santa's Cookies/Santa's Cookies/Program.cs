using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalBoxes = 0;

            for(int i=1; i<=n; i++)
            {
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());

                int flourCups = flour / 140;
                int sugarSpoons = sugar / 20;
                int cocoaSpoons = cocoa / 10;
               
                int min2 = Math.Min(flourCups, sugarSpoons);
                int min = Math.Min(min2, cocoaSpoons);

                double boxes = 0;

                boxes = (((140 + 20 + 10) * min) / 25);

                if (boxes > 0)
                {
                    Console.WriteLine($"Boxes of cookies: {Math.Floor(boxes / 5)}");
                }
                else
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }

                totalBoxes += (int)Math.Floor(boxes / 5);
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }


}
