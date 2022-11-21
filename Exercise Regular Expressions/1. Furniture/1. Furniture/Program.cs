using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<furniturePrice>\d+(.\d+)?)!(?<furnitureQuantity>\d+)(.\d+)?$";
            Regex regex = new Regex(pattern);

            List<string> furnitureName = new List<string>();

            double total = 0;

            while(true)
            {
                string str = Console.ReadLine();

                if (str == "Purchase")
                    break;

                if(regex.IsMatch(str))
                {
                    var data = regex.Match(str);
                    furnitureName.Add(data.Groups["furnitureName"].Value);
                    total += (double.Parse(data.Groups["furniturePrice"].Value) * int.Parse(data.Groups["furnitureQuantity"].Value));
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach(var val in furnitureName)
            {
                Console.WriteLine($"{val}");
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
